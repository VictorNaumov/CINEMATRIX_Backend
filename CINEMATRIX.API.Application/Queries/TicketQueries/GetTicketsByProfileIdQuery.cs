using AutoMapper;
using CINEMATRIX.API.Contracts.IncomingOutgoing;
using CINEMATRIX.API.Contracts.Outgoing;
using CINEMATRIX.Data.Services;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace CINEMATRIX.API.Application.Queries.TicketQueries
{
    public class GetTicketsByProfileIdQuery : IRequest<List<FoundTicketDTO>>
    {
        public long ProfileId { get; }

        public GetTicketsByProfileIdQuery(long profileId)
        {
            ProfileId = profileId;
        }
    }

    public class GetTicketsByProfileIdQueryQueryHandler : IRequestHandler<GetTicketsByProfileIdQuery, List<FoundTicketDTO>>
    {
        private readonly ITicketService _ticketService;
        private readonly IMapper _mapper;

        public GetTicketsByProfileIdQueryQueryHandler(ITicketService ticketService, IMapper mapper)
        {
            _ticketService = ticketService;
            _mapper = mapper;
        }

        public async Task<List<FoundTicketDTO>> Handle(GetTicketsByProfileIdQuery request, CancellationToken cancellationToken)
        {
            var tickets = await _ticketService.GetTicketsByProfileId(request.ProfileId, cancellationToken);

            if (tickets == null)
            {
                return null;
            }

            foreach(var ticket in tickets)
            {
                ticket.Session.Tickets = null;
            }

            var mappedTickets = _mapper.Map<List<FoundTicketDTO>>(tickets);

            return mappedTickets;
        }
    }
}
