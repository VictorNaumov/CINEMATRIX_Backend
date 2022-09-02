using CINEMATRIX.API.Application.Commands.TicketCommands;
using CINEMATRIX.API.Application.Validation.Abstractions;
using CINEMATRIX.API.Contracts.Outgoing.Abstractions;
using CINEMATRIX.Data.Services;
using FluentValidation;
using System.Threading;
using System.Threading.Tasks;

namespace CINEMATRIX.API.Application.Validation.Ticket
{
    public class UpdateTicketValidator : TicketValidatorBase<UpdateTicketCommand, Response>
    {
        private readonly ITicketService _ticketService;

        public UpdateTicketValidator(ITicketService ticketService, ISessionService sessionService, ISeatService seatService)
            : base(sessionService, seatService)
        {
            _ticketService = ticketService;

            CreateRules();
        }

        private void CreateRules()
        {
            RuleFor(cmd => cmd.Id)
               .NotNull()
               .WithMessage(cmd => string.Format(Resources.Resources.ValueRequired, nameof(cmd.Id)))
               .MustAsync(Exist)
               .WithMessage(cmd => string.Format(Resources.Resources.TicketNotFound, cmd.Id));
        }

        private async Task<bool> Exist(long id, CancellationToken cancellationToken)
            => await _ticketService.ExistsAsync(id, cancellationToken);
    }
}
