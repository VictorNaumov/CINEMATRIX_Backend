using AutoMapper;
using CINEMATRIX.API.Application.Commands.Abstractions;
using CINEMATRIX.API.Contracts.IncomingOutgoing;
using CINEMATRIX.API.Contracts.Outgoing;
using CINEMATRIX.Data.Domain.Enums;
using CINEMATRIX.Data.Domain.Models;
using CINEMATRIX.Data.Services;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace CINEMATRIX.API.Application.Commands.AuthCommands
{
    public class RegisterUserCommand : CommandBase<LoginUserDTO, UserDTO>
    {
        public RegisterUserCommand(UserDTO user) : base(user) { }
    }

    public class RegisterUserCommandHandler : IRequestHandler<RegisterUserCommand, LoginUserDTO>
    {
        private readonly IUserService _userService;
        private readonly IRoleService _roleService;
        private readonly IMapper _mapper;

        public RegisterUserCommandHandler(IUserService userService, IRoleService roleService, IMapper mapper)
        {
            _userService = userService;
            _roleService = roleService;
            _mapper = mapper;
        }
        public async Task<LoginUserDTO> Handle(RegisterUserCommand request, CancellationToken cancellationToken)
        {
            var isExist = await _userService.ExistAsync(request.Entity);

            if (isExist)
            {
                return null;
            }

            var role = await _roleService.GetByIdAsync(request.Entity.RoleId ?? (int)RoleEnum.User, cancellationToken);
            var newUser = _mapper.Map<User>(request.Entity);
            newUser.RoleId = role.Id;

            var insertedUser = await _userService.InsertAsync(newUser);

            if (insertedUser == null)
            {
                return null;
            }

            var token = _userService.CreateToken(insertedUser, insertedUser.Role.Name);

            return new LoginUserDTO { Role = role.Name, Token = token };
        }
    }
}
