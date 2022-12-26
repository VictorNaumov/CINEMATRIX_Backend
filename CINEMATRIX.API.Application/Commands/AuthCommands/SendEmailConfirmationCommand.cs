using CINEMATRIX.API.Application.Commands.Abstractions;
using CINEMATRIX.Data.Services;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace CINEMATRIX.API.Application.Commands.AuthCommands
{
    public class SendEmailConfirmationCommand : CommandBase<bool, string>
    {
        public SendEmailConfirmationCommand(string userName) : base(userName) { }
    }

    public class SendEmailConfirmationCommandHandler : IRequestHandler<SendEmailConfirmationCommand, bool>
    {
        private readonly IUserService _userService;

        public SendEmailConfirmationCommandHandler(IUserService userService)
        {
            _userService = userService;
        }

        public async Task<bool> Handle(SendEmailConfirmationCommand request, CancellationToken cancellationToken)
        {
            var user = await _userService.GetByUserNameAsync(request.Entity);

            var subject = "Confirmation of the email address";
            var message = "Please follow the link to confirm your email address: <a href='{0}'>confirm</a>";

            var isSended = await _userService.TrySendEmailAsync(user, subject, message);

            return isSended;
        }
    }
}
