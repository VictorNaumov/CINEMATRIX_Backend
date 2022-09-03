using CINEMATRIX.API.Application.Commands.Abstractions;
using CINEMATRIX.API.Contracts.IncomingOutgoing;
using CINEMATRIX.API.Contracts.Outgoing;
using CINEMATRIX.Data.Services;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace ComputerTechnicianBackend.API.Application.Queries.AuthQueries
{
    public class LoginUserQuery : CommandBase<LoginUserDTO, LoginDTO>
    {
        public LoginUserQuery(LoginDTO user) : base(user) { }
    }

    public class LoginUserQueryHandler : IRequestHandler<LoginUserQuery, LoginUserDTO>
    {
        private readonly IUserService userService;
        private readonly IRoleService roleService;

        public LoginUserQueryHandler(IUserService userService, IRoleService roleService)
        {
            this.userService = userService;
            this.roleService = roleService;
        }

        public async Task<LoginUserDTO> Handle(LoginUserQuery request, CancellationToken cancellationToken)
        {
            var user = await userService.LoginAsync(request.Entity);

            if (user == null)
            {
                return null;
            }

            var role = await roleService.GetByIdAsync(user.RoleId);

            if (role == null)
            {
                return null;
            }

            var token = userService.CreateToken(user, role.Name);

            return new LoginUserDTO { Role = role.Name, Token = token };
        }

    }
}
