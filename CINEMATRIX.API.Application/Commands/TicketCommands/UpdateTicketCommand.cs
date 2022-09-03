using AutoMapper;
using CINEMATRIX.API.Application.Commands.Abstractions;
using CINEMATRIX.API.Contracts.IncomingOutgoing;
using CINEMATRIX.API.Contracts.Outgoing.Abstractions;
using CINEMATRIX.Data.Domain.Models;
using CINEMATRIX.Data.Services;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace CINEMATRIX.API.Application.Commands.TicketCommands
{
    public class UpdateTicketCommand : CommandBase<Response, TicketDTO>
    {
        public UpdateTicketCommand(long id, TicketDTO update) : base(id, update) { }
    }

    public class UpdateTicketCommandHandler : IRequestHandler<UpdateTicketCommand, Response>
    {
        private readonly ITicketService _ticketService;
        private readonly IMapper _mapper;

        public UpdateTicketCommandHandler(ITicketService ticketService, IMapper mapper)
        {
            _ticketService = ticketService;
            _mapper = mapper;
        }

        public async Task<Response> Handle(UpdateTicketCommand request, CancellationToken cancellationToken)
        {
            var ticket = await _ticketService.GetByIdAsync(request.Id, cancellationToken);

            if (ticket == null)
            {
                return Response.Error;
            }

            var ticketToUpdate = _mapper.Map<Ticket>(ticket);

            var updatedTicket = await _ticketService.UpdateAsync(ticketToUpdate);

            if (updatedTicket == null)
            {
                return Response.Error;
            }

            return Response.Successful;
        }
    }
}
