using CINEMATRIX.Data.Services;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace CINEMATRIX.API.Application.Queries.AuthQueries
{
    public class CheckExistEmailQuery : IRequest<bool>
    {
        public string Email { get; set; }
        public CheckExistEmailQuery(string email) : base()
        {
            Email = email;
        }
    }

    public class CheckExistEmailQueryHandler : IRequestHandler<CheckExistEmailQuery, bool>
    {
        private readonly IUserService _userService;

        public CheckExistEmailQueryHandler(IUserService userService)
        {
            _userService = userService;
        }

        public async Task<bool> Handle(CheckExistEmailQuery request, CancellationToken cancellationToken)
        {
            return await _userService.ExistUsernameAsync(request.Email, cancellationToken);
        }
    }
}
