using AutoMapper;
using CINEMATRIX.API.Contracts.Outgoing;
using CINEMATRIX.Data.Services;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace CINEMATRIX.API.Application.Queries.MovieCommentQueries
{
    public class GetMovieCommentsByMovieIdQuery : IRequest<List<FoundMovieCommentDTO>>
    {
        public long MovieId { get; }

        public GetMovieCommentsByMovieIdQuery(long movieId)
        {
            MovieId = movieId;
        }
    }

    public class GetMovieCommentsByMovieIdQueryHandler : IRequestHandler<GetMovieCommentsByMovieIdQuery, List<FoundMovieCommentDTO>>
    {
        private readonly IMovieCommentService _movieCommentService;
        private readonly IMapper _mapper;

        public GetMovieCommentsByMovieIdQueryHandler(IMovieCommentService movieCommentService, IMapper mapper)
        {
            _movieCommentService = movieCommentService;
            _mapper = mapper;
        }

        public async Task<List<FoundMovieCommentDTO>> Handle(GetMovieCommentsByMovieIdQuery request, CancellationToken cancellationToken)
        {
            var movieComments = await _movieCommentService.GetByMovieIdAsync(request.MovieId, cancellationToken);

            var mappedMovieComments = _mapper.Map<List<FoundMovieCommentDTO>>(movieComments);

            return mappedMovieComments;
        }
    }
}
