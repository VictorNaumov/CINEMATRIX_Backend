using AutoMapper;
using CINEMATRIX.API.Contracts.IncomingOutgoing;
using CINEMATRIX.Data.Services;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace CINEMATRIX.API.Application.Queries.TicketQueries
{
    public class GetTicketQuery : IRequest<TicketDTO>
    {
        public long Id { get; }

        public GetTicketQuery(long id)
        {
            Id = id;
        }
    }

    public class GetTicketQueryHandler : IRequestHandler<GetTicketQuery, TicketDTO>
    {
        private readonly ITicketService _ticketService;
        private readonly IMapper _mapper;

        public GetTicketQueryHandler(ITicketService ticketService, IMapper mapper)
        {
            _ticketService = ticketService;
            _mapper = mapper;
        }

        public async Task<TicketDTO> Handle(GetTicketQuery request, CancellationToken cancellationToken)
        {
            var ticket = await _ticketService.GetAsync(request.Id, cancellationToken);

            if (ticket == null)
            {
                return null;
            }

            var mappedTicket = _mapper.Map<TicketDTO>(ticket);

            return mappedTicket;
        }
    }
}
