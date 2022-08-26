using CINEMATRIX.API.Application.Commands.SessionCommands;
using CINEMATRIX.API.Application.Validation.Abstractions;
using CINEMATRIX.API.Contracts.Outgoing.Abstractions;
using CINEMATRIX.Data.Services;
using FluentValidation;
using System.Threading;
using System.Threading.Tasks;

namespace CINEMATRIX.API.Application.Validation.Session
{
    public class UpdateSessionValidator : SessionValidatorBase<UpdateSessionCommand, Response>
    {
        private readonly ISessionService _sessionService;

        public UpdateSessionValidator(ISessionService sessionService, IHallService _hallService) : base(_hallService)
        {
            _sessionService = sessionService;

            CreateRules();
        }

        private void CreateRules()
        {
            RuleFor(cmd => cmd.Id)
               .NotNull()
               .WithMessage(cmd => string.Format(Resources.Resources.ValueRequired, nameof(cmd.Id)))
               .MustAsync(Exist)
               .WithMessage(cmd => string.Format(Resources.Resources.SessionNotFound, cmd.Id));
        }

        private async Task<bool> Exist(long id, CancellationToken cancellationToken)
            => await _sessionService.ExistsAsync(id, cancellationToken);
    }
}
