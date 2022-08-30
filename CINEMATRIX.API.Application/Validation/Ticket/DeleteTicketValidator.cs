using System.Threading;
using System.Threading.Tasks;
using CINEMATRIX.API.Application.Commands.TicketCommands;
using CINEMATRIX.Data.Services;
using FluentValidation;

namespace CINEMATRIX.API.Application.Validation.Ticket
{
    public class DeleteTicketValidator : AbstractValidator<DeleteTicketCommand>
    {
        private readonly ITicketService _ticketService;

        public DeleteTicketValidator(ITicketService ticketService)
        {
            _ticketService = ticketService;

            CreateRules();
        }

        private void CreateRules()
        {
            RuleFor(cmd => cmd.Id)
                .MustAsync(Exist)
                .WithMessage(cmd => string.Format(Resources.Resources.TicketNotFound, cmd.Id));
        }

        private async Task<bool> Exist(long id, CancellationToken cancellationToken) 
            => await _ticketService.ExistsAsync(id, cancellationToken);
    }
}
