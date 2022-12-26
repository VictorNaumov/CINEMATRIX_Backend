using CINEMATRIX.API.Contracts.IncomingOutgoing;
using CINEMATRIX.Data.Domain.Models;
using CINEMATRIX.Data.EF.SQL;
using CINEMATRIX.Data.Services.Abstraction;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace CINEMATRIX.Data.Services
{
    public interface IUserService : IBaseService<User>
    {
        Task<bool> ExistAsync(UserDTO userDTO);
        Task<User> LoginAsync(LoginDTO loginDTO);
        Task<User> GetByUserNameAsync(string userName);
        Task<bool> TrySendEmailAsync(User user, string subject, string message);
        Task<bool> ConfirmEmailAsync(ConfirmEmailDTO confirmEmailDTO);
        Task<bool> IsValidEmailConfirmationToken(ConfirmEmailDTO confirmEmailDTO);
        string CreateToken(User user, string role);
    }

    public class UserService : BaseService<User>, IUserService
    {
        private readonly IConfiguration _configuration;
        private readonly IMailService _mailService;

        public UserService(ApplicationDbContext dbContext, IConfiguration configuration, IMailService mailService) : base(dbContext)
        {
            _configuration = configuration;
            _mailService = mailService;
        }

        public async Task<bool> ExistAsync(UserDTO user)
        {
            return await _dbContext.Users.AnyAsync(entity => entity.Email == user.Email);
        }

        public async Task<User> LoginAsync(LoginDTO loginDTO)
        {
            if (!await _dbContext.Users.AnyAsync(entity => entity.Email == loginDTO.Email))
            {
                return null;
            }

            var user = await _dbContext.Users.Where(entity => entity.Email == loginDTO.Email).FirstOrDefaultAsync();

            if (user.Password != loginDTO.Password)
            {
                return null;
            }

            return user;
        }

        public async Task<bool> TrySendEmailAsync(User user, string subject, string message)
        {
            try
            {
                var confirmationToken = await GenerateEmailConfirmationTokenAsync(user);
                var callbackUrl = $@"https://localhost:5001/api/v1/auth/confirmEmail?userId={user.Id}&token={confirmationToken}";

                var mailRequest = new MailRequest()
                {
                    ToEmail = user.Email,
                    Subject = subject,
                    Body = string.Format(message, callbackUrl),
                };

                await _mailService.SendEmailAsync(mailRequest);

                return true;
            }
            catch
            {
                return false;
            }
        }

        public async Task<bool> ConfirmEmailAsync(ConfirmEmailDTO confirmEmailDTO)
        {
            var isValidToken = await IsValidEmailConfirmationToken(confirmEmailDTO);
            if (isValidToken)
            {
                var user = await GetByIdAsync(confirmEmailDTO.UserId);

                if (user != null)
                {
                    user.IsEmailConfirmed = true;
                    await _dbContext.SaveChangesAsync();

                    return true;
                }
            }

            return false;
        }

        public async Task<bool> IsValidEmailConfirmationToken(ConfirmEmailDTO confirmEmailDTO)
            => await _dbContext.EmailConfirmationTokens.AnyAsync(ect =>
                        ect.Token == confirmEmailDTO.Token
                        && ect.UserId == confirmEmailDTO.UserId
                        && ect.ExpiresAt >= DateTime.Now);

        public async Task<User> GetByUserNameAsync(string userName)
            => await _dbContext.Users
                .Include(x => x.Profile)
                .FirstOrDefaultAsync(entity => entity.UserName == userName);

        public string CreateToken(User user, string role)
        {
            var signingCredentials = GetSigningCredentials();
            var Claims = GetClaims(user, role);
            var tokenOptions = GenerateTokenOptions(signingCredentials, Claims);

            return new JwtSecurityTokenHandler().WriteToken(tokenOptions);
        }

        private SigningCredentials GetSigningCredentials()
        {
            var key = _configuration.GetSection("JwtSettings").GetSection("key").Value;
            var secret = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(key + key));

            return new SigningCredentials(secret, SecurityAlgorithms.HmacSha256);
        }

        private List<Claim> GetClaims(User user, string role)
        {
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, user.UserName)
            };

            var binaryRole = ToBinary(ConvertToByteArray(role, Encoding.ASCII));

            claims.Add(new Claim(ClaimTypes.Role, binaryRole));

            return claims;
        }
        private JwtSecurityToken GenerateTokenOptions(SigningCredentials signingCredentials, List<Claim> claims)
        {
            var jwtSettings = _configuration.GetSection("jwtSettings");
            var tokenOptions = new JwtSecurityToken
            (
                issuer: jwtSettings.GetSection("validIssuer").Value,
                audience: jwtSettings.GetSection("validAudience").Value,
                claims: claims,
                expires: DateTime.Now.AddMinutes(Convert.ToDouble(jwtSettings.GetSection("minutesExpires").Value)),
                signingCredentials: signingCredentials
            );

            return tokenOptions;
        }

        private static byte[] ConvertToByteArray(string str, Encoding encoding)
            => encoding.GetBytes(str);

        private static string ToBinary(byte[] data)
            => string.Join(" ", data.Select(b => Convert.ToString(b, 2).PadLeft(8, '0')));

        private async Task<string> GenerateEmailConfirmationTokenAsync(User user)
        {
            string token = Guid.NewGuid().ToString();

            var tokenEntity = new EmailConfirmationToken
            {
                Token = token,
                UserId = user.Id,
                ExpiresAt = DateTime.UtcNow.AddDays(1)
            };

            _dbContext.EmailConfirmationTokens.Add(tokenEntity);
            await _dbContext.SaveChangesAsync();

            return token;
        }
    }
}
