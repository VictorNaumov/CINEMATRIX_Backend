using System.Threading;
using System.Threading.Tasks;
using CINEMATRIX.API.Application.Commands.SessionCommands;
using CINEMATRIX.Data.Services;
using FluentValidation;

namespace CINEMATRIX.API.Application.Validation.Session
{
    public class DeleteSessionValidator : AbstractValidator<DeleteSessionCommand>
    {
        private readonly ISessionService _sessionService;

        public DeleteSessionValidator(ISessionService sessionService)
        {
            _sessionService = sessionService;

            CreateRules();
        }

        private void CreateRules()
        {
            RuleFor(cmd => cmd.Id)
                .MustAsync(Exist)
                .WithMessage(cmd => string.Format(Resources.Resources.SessionNotFound, cmd.Id));
        }

        private async Task<bool> Exist(long id, CancellationToken cancellationToken) 
            => await _sessionService.ExistsAsync(id, cancellationToken);
    }
}
