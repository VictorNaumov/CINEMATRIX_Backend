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
    public class GetTicketsBySessionIdQuery : IRequest<List<FoundTicketDTO>>
    {
        public long SessionId { get; }

        public GetTicketsBySessionIdQuery(long sessionId)
        {
            SessionId = sessionId;
        }
    }

    public class GetTicketsBySessionIdQueryHandler : IRequestHandler<GetTicketsBySessionIdQuery, List<FoundTicketDTO>>
    {
        private readonly ITicketService _ticketService;
        private readonly IMapper _mapper;

        public GetTicketsBySessionIdQueryHandler(ITicketService ticketService, IMapper mapper)
        {
            _ticketService = ticketService;
            _mapper = mapper;
        }

        public async Task<List<FoundTicketDTO>> Handle(GetTicketsBySessionIdQuery request, CancellationToken cancellationToken)
        {
            var tickets = await _ticketService.GetTicketsBySessionId(request.SessionId, cancellationToken);

            if (tickets == null)
            {
                return null;
            }

            var mappedTickets = _mapper.Map<List<FoundTicketDTO>>(tickets);

            return mappedTickets;
        }
    }
}
