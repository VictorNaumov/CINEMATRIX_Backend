using AutoMapper;
using CINEMATRIX.API.Contracts.Outgoing;
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

    public class GetMovieQueryHandler : IRequestHandler<GetMovieQuery, FoundMovieDTO>
    {
        private readonly IMovieService _movieService;
        private readonly IMapper _mapper;

        public GetMovieQueryHandler(IMovieService movieService, IMapper mapper)
        {
            _movieService = movieService;
            _mapper = mapper;
        }

        public async Task<FoundMovieDTO> Handle(GetMovieQuery request, CancellationToken cancellationToken)
        {
            var apiResponse = await _movieService.GetMovieByIdAsync(request.Id, cancellationToken);
    
            var movie = _mapper.Map<FoundMovieDTO>(apiResponse);

            return movie;
        }
    }
}
