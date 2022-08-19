using CINEMATRIX.API.Application.Commands.Abstractions;
using CINEMATRIX.API.Contracts.IncomingOutgoing;
using CINEMATRIX.Data.Domain.Enums;
using CINEMATRIX.Data.Domain.Models;
using CINEMATRIX.Data.Services;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace CINEMATRIX.API.Application.Commands.AuthCommands
{
    public class RegisterUserCommand : CommandBase<bool, UserDTO>
    {
        public RegisterUserCommand(UserDTO user) : base(user) { }
    }

    public class RegisterUserCommandHandler : IRequestHandler<RegisterUserCommand, bool>
    {

        private readonly IUserService _userService;

        public RegisterUserCommandHandler(IUserService userService)
        {
            _userService = userService;
        }
        public async Task<bool> Handle(RegisterUserCommand request, CancellationToken cancellationToken)
        {
            var isExist = await _userService.ExistAsync(request.Entity);

            if (!isExist)
            {
                return false;
            }

            var role = (long)RoleEnums.User;
            var newUser = MapToUser(request.Entity, role);
            var insertedUser = await _userService.InsertAsync(newUser);

            if (insertedUser == null)
            {
                return false;
            }

            return true;
        }

        private User MapToUser(UserDTO user, long roleId)
        {
            return new User
            {
                Email = user.Email,
                UserName = user.UserName,
                Password = user.Password,
                RoleId = roleId
            };
        }
    }
}
