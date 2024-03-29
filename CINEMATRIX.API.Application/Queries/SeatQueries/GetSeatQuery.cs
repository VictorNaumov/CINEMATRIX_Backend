﻿using AutoMapper;
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

    public class GetSeatQueryHandler : IRequestHandler<GetSeatQuery, HallDTO>
    {
        private readonly IHallService _hallService;
        private readonly IMapper _mapper;

        public GetSeatQueryHandler(IHallService hallService, IMapper mapper)
        {
            _hallService = hallService;
            _mapper = mapper;
        }

        public async Task<HallDTO> Handle(GetSeatQuery request, CancellationToken cancellationToken)
        {
            var hall = await _hallService.GetByIdAsync(request.Id, cancellationToken);

            if (hall == null)
            {
                return null;
            }

            var mappedHall = _mapper.Map<HallDTO>(hall);

            return mappedHall;
        }
    }
}
