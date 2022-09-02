using AutoMapper;
using CINEMATRIX.API.Contracts.Outgoing.TMDB;
using CINEMATRIX.Data.Services;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace CINEMATRIX.API.Application.Queries.MovieQueries
{
    public class GetMovieQuery : IRequest<FoundMovieDTO>
    {
        public long Id { get; }

        public GetMovieQuery(long id)
        {
            Id = id;
        }
    }

    public class GetGenreQueryHandler : IRequestHandler<GetMovieQuery, FoundMovieDTO>
    {
        private readonly IMovieService _genreService;
        private readonly IMapper _mapper;

        public GetGenreQueryHandler(IMovieService genreService, IMapper mapper)
        {
            _genreService = genreService;
            _mapper = mapper;
        }

        public async Task<FoundMovieDTO> Handle(GetMovieQuery request, CancellationToken cancellationToken)
        {
            var genre = await _genreService.GetAsync(request.Id, cancellationToken);

            if (genre == null)
            {
                return null;
            }

            var mappedMovie = _mapper.Map<FoundMovieDTO>(genre);

            return mappedMovie;
        }
    }
}
