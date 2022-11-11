using AutoMapper;
using CINEMATRIX.API.Contracts.IncomingOutgoing;
using CINEMATRIX.Data.Services;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace CINEMATRIX.API.Application.Queries.CinemaQueries
{
    public class GetCinemaQuery : IRequest<CinemaDTO>
    {
        public long Id { get; }

        public GetCinemaQuery(long id)
        {
            Id = id;
        }
    }

    public class GetCinemaQueryHandler : IRequestHandler<GetCinemaQuery, CinemaDTO>
    {
        private readonly ICinemaService _cinemaService;
        private readonly IMapper _mapper;

        public GetCinemaQueryHandler(ICinemaService cinemaService, IMapper mapper)
        {
            _cinemaService = cinemaService;
            _mapper = mapper;
        }

        public async Task<CinemaDTO> Handle(GetCinemaQuery request, CancellationToken cancellationToken)
        {
            var cinema = await _cinemaService.GetByIdAsync(request.Id, cancellationToken);

            if (cinema == null)
            {
                return null;
            }

            var mappedCinema = _mapper.Map<CinemaDTO>(cinema);

            return mappedCinema;
        }
    }
}
