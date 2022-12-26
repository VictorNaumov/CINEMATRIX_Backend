using AutoMapper;
using CINEMATRIX.API.Contracts.Outgoing;
using CINEMATRIX.Data.Services;
using MediatR;
using System.Collections.Generic;
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
        private readonly IMovieCommentService _movieCommentService;
        private readonly IMapper _mapper;

        public GetMovieDetailsQueryHandler(IMovieService movieService, IMapper mapper, IMovieCommentService movieCommentService)
        {
            _movieService = movieService;
            _movieCommentService = movieCommentService;
            _mapper = mapper;
        }

        public async Task<FoundMovieDTO> Handle(GetMovieDetailsQuery request, CancellationToken cancellationToken)
        {
            var apiResponse = await _movieService.GetByIdWithRelationsAsync(request.Id, cancellationToken);

            var movie = _mapper.Map<FoundMovieDTO>(apiResponse);
            var movieComments = await _movieCommentService.GetByMovieIdAsync(request.Id, cancellationToken);
            
            movie.MovieComments = _mapper.Map<List<FoundMovieCommentDTO>>(movieComments);

            return movie;
        }
    }
}
