using AutoMapper;
using CINEMATRIX.API.Contracts.Outgoing;
using CINEMATRIX.Data.Services;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace CINEMATRIX.API.Application.Queries.MovieQueries
{
    public class GetMovieDetailsQuery : IRequest<FoundMovieDTO>
    {
        public long Id { get; }

        public GetMovieDetailsQuery(long id)
        {
            Id = id;
        }
    }

    public class GetMovieDetailsQueryHandler : IRequestHandler<GetMovieDetailsQuery, FoundMovieDTO>
    {
        private readonly IMovieService _movieService;
        private readonly IMapper _mapper;

        public GetMovieDetailsQueryHandler(IMovieService movieService, IMapper mapper)
        {
            _movieService = movieService;
            _mapper = mapper;
        }

        public async Task<FoundMovieDTO> Handle(GetMovieDetailsQuery request, CancellationToken cancellationToken)
        {
            var apiResponse = await _movieService.GetByIdWithRelationsAsync(request.Id, cancellationToken);

            var movie = _mapper.Map<FoundMovieDTO>(apiResponse);

            return movie;
        }
    }
}
