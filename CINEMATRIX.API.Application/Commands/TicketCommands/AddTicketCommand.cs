using AutoMapper;
using CINEMATRIX.API.Application.Commands.Abstractions;
using CINEMATRIX.API.Contracts.IncomingOutgoing;
using CINEMATRIX.Data.Domain.Models;
using CINEMATRIX.Data.Services;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace CINEMATRIX.API.Application.Commands.TicketCommands
{
    public class AddTicketCommand : CommandBase<long, TicketDTO>
    {
        public AddTicketCommand(TicketDTO ticket) : base(ticket) { }
    }

    public class AddTicketCommandHandler : IRequestHandler<AddTicketCommand, long>
    {
        private readonly ITicketService _ticketService;
        private readonly IMapper _mapper;

        public AddTicketCommandHandler(ITicketService ticketService, IMapper mapper)
        {
            _ticketService = ticketService;
            _mapper = mapper;
        }

        public async Task<long> Handle(AddTicketCommand request, CancellationToken cancellationToken)
        {
            var ticket = _mapper.Map<Ticket>(request.Entity);

            var insertedTicket = await _ticketService.InsertAsync(ticket);

            return insertedTicket.Id;
        }
    }
}
