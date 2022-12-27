using CINEMATRIX.API.Application.Commands.Abstractions;
using CINEMATRIX.API.Contracts.IncomingOutgoing;
using CINEMATRIX.Data.Services;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace CINEMATRIX.API.Application.Queries.AuthQueries
{
    public class ConfirmEmailQuery : CommandBase<string, ConfirmEmailDTO>
    {
        public ConfirmEmailQuery(ConfirmEmailDTO user) : base(user) { }
    }

    public class ConfirmEmailCommandHandler : IRequestHandler<ConfirmEmailQuery, string>
    {
        private readonly IUserService _userService;

        public ConfirmEmailCommandHandler(IUserService userService)
        {
            _userService = userService;
        }

        public async Task<string> Handle(ConfirmEmailQuery request, CancellationToken cancellationToken)
        {
            var isSuccesful = await _userService.ConfirmEmailAsync(request.Entity);

            return isSuccesful
                ? "Email was successfully confirmed, thank you!"
                : "The token is incorrect or the expiration date has expired!";
        }
    }
}
