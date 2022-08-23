using CINEMATRIX.Data.Services;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace CINEMATRIX.API.Application.Commands.TicketCommands  
{
    public class DeleteTicketCommand : IRequest
    {
        public long Id { get; }

        public DeleteTicketCommand(long id)
        {
            Id = id;
        }
    }

    public class DeleteTicketCommandHandler : IRequestHandler<DeleteTicketCommand>
    {
        private readonly ITicketService _ticketService;

        public DeleteTicketCommandHandler(ITicketService ticketService)
        {
            _ticketService = ticketService;
        }

        public async Task<Unit> Handle(DeleteTicketCommand request, CancellationToken cancellationToken)
        {
            await _ticketService.DeleteAsync(request.Id, cancellationToken);

            return Unit.Value;
        }
    }
}
