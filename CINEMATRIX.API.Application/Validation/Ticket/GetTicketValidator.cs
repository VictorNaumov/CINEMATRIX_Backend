using CINEMATRIX.API.Application.Queries.TicketQueries;
using CINEMATRIX.Data.Services;
using FluentValidation;
using System.Threading;
using System.Threading.Tasks;

namespace CINEMATRIX.API.Application.Validation.Ticket
{
    public class GetTicketValidator : AbstractValidator<GetTicketQuery>
    {
        private readonly ITicketService _ticketService;

        public GetTicketValidator(ITicketService ticketService)
        {
            _ticketService = ticketService;

            CreateRules();
        }

        private void CreateRules()
        {
            RuleFor(query => query.Id)
                .NotNull()
                .WithMessage(query => string.Format(Resources.Resources.ValueRequired, nameof(query.Id)))
                .MustAsync(Exist)
                .WithMessage(cmd => string.Format(Resources.Resources.TicketNotFound, cmd.Id));
        }

        private async Task<bool> Exist(long id, CancellationToken cancellationToken)
            => await _ticketService.ExistsAsync(id, cancellationToken);
    }
}
