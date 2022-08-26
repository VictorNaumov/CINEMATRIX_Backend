using CINEMATRIX.API.Application.Commands.Abstractions;
using CINEMATRIX.API.Application.Validation.Utilities;
using CINEMATRIX.API.Contracts.IncomingOutgoing;
using CINEMATRIX.Data.Services;
using FluentValidation;
using System.Threading;
using System.Threading.Tasks;

namespace CINEMATRIX.API.Application.Validation.Abstractions
{
    public class TicketValidatorBase<TCommand, TResponse> : AbstractValidator<TCommand>
        where TCommand : CommandBase<TResponse, TicketDTO>
    {
        private readonly ISessionService _sessionService;
        private readonly ISeatService _seatService;

        public TicketValidatorBase(ISessionService sessionService, ISeatService seatService)
        {
            _sessionService = sessionService;
            _seatService = seatService;

            CreateRules();
        }

        private void CreateRules()
        {
            RuleFor(cmd => cmd.Entity)
                .NotNull()
                .WithMessage(cmd => string.Format(Resources.Resources.ValueRequired, nameof(cmd.Entity)));

            RuleFor(cmd => cmd.Entity.SeatId)
                .NotNull()
                .WithMessage(cmd => string.Format(Resources.Resources.ValueRequired, nameof(cmd.Entity.SeatId)))
                .MustAsync(SeatExist)
                .WithMessage(cmd => string.Format(Resources.Resources.HallNotFound, cmd.Entity.SeatId));

            RuleFor(cmd => cmd.Entity.SessionId)
                .NotNull()
                .WithMessage(cmd => string.Format(Resources.Resources.ValueRequired, nameof(cmd.Entity.SessionId)))
                .MustAsync(SessionExist)
                .WithMessage(cmd => string.Format(Resources.Resources.HallNotFound, cmd.Entity.SessionId));
        }

        private async Task<bool> SeatExist(long id, CancellationToken cancellationToken)
            => await _seatService.ExistsAsync(id, cancellationToken);
        private async Task<bool> SessionExist(long id, CancellationToken cancellationToken)
            => await _sessionService.ExistsAsync(id, cancellationToken);
    }
}