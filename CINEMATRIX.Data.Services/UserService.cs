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
        string CreateToken(User user, string role);
    }

    public class UserService : BaseService<User>, IUserService
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly IConfiguration _configuration;

        public UserService(ApplicationDbContext dbContext, IConfiguration configuration) : base(dbContext)
        {
            _dbContext = dbContext;
            _configuration = configuration;
        }

        public async Task<bool> ExistAsync(UserDTO userDTO)
        {
            return await _dbContext.Users.AnyAsync(entity => entity.Email == userDTO.Email);
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
        {
            return encoding.GetBytes(str);
        }

        private static string ToBinary(byte[] data)
        {
            return string.Join(" ", data.Select(byt => Convert.ToString(byt, 2).PadLeft(8, '0')));
        }
    }
}
