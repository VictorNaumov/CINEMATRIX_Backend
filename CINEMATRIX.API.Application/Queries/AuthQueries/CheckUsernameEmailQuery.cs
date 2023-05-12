using CINEMATRIX.Data.Services;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace CINEMATRIX.API.Application.Queries.AuthQueries
{
    public class CheckExistUsernameQuery : IRequest<bool>
    {
        public string Username { get; set; }
        public CheckExistUsernameQuery(string username) : base()
        {
            Username = username;
        }
    }

    public class CheckExistUsernameQueryHandler : IRequestHandler<CheckExistUsernameQuery, bool>
    {
        private readonly IUserService _userService;

        public CheckExistUsernameQueryHandler(IUserService userService)
        {
            _userService = userService;
        }

        public async Task<bool> Handle(CheckExistUsernameQuery request, CancellationToken cancellationToken)
        {
            return await _userService.ExistUsernameAsync(request.Username, cancellationToken);
        }
    }
}
