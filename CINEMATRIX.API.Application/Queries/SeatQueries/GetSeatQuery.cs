using AutoMapper;
using CINEMATRIX.API.Contracts.IncomingOutgoing;
using CINEMATRIX.Data.Services;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace CINEMATRIX.API.Application.Queries.SeatQueries
{
    public class GetSeatQuery : IRequest<HallDTO>
    {
        public long Id { get; }

        public GetSeatQuery(long id)
        {
            Id = id;
        }
    }

    public class GetProductQueryHandler : IRequestHandler<GetSeatQuery, HallDTO>
    {
        private readonly IHallService _hallService;
        private readonly IMapper _mapper;

        public GetProductQueryHandler(IHallService hallService, IMapper mapper)
        {
            _hallService = hallService;
            _mapper = mapper;
        }

        public async Task<HallDTO> Handle(GetSeatQuery request, CancellationToken cancellationToken)
        {
            var hall = await _hallService.GetAsync(request.Id, cancellationToken);

            if (hall == null)
            {
                return null;
            }

            var mappedHall = _mapper.Map<HallDTO>(hall);

            return mappedHall;
        }
    }
}
