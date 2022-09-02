using AutoMapper;
using CINEMATRIX.API.Contracts.IncomingOutgoing;
using CINEMATRIX.Data.Services;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace CINEMATRIX.API.Application.Queries.SeatTypeQueries
{
    public class GetSeatTypeQuery : IRequest<SeatTypeDTO>
    {
        public long Id { get; }

        public GetSeatTypeQuery(long id)
        {
            Id = id;
        }
    }

    public class GetSeatTypeQueryHandler : IRequestHandler<GetSeatTypeQuery, SeatTypeDTO>
    {
        private readonly ISeatTypeService _seatTypeService;
        private readonly IMapper _mapper;

        public GetSeatTypeQueryHandler(ISeatTypeService seatTypeService, IMapper mapper)
        {
            _seatTypeService = seatTypeService;
            _mapper = mapper;
        }

        public async Task<SeatTypeDTO> Handle(GetSeatTypeQuery request, CancellationToken cancellationToken)
        {
            var seatType = await _seatTypeService.GetAsync(request.Id, cancellationToken);

            if (seatType == null)
            {
                return null;
            }

            var mappedSeatType = _mapper.Map<SeatTypeDTO>(seatType);

            return mappedSeatType;
        }
    }
}
