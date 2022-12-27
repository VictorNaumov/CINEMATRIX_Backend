using AutoMapper;
using CINEMATRIX.API.Contracts.IncomingOutgoing;
using CINEMATRIX.Data.Services;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace CINEMATRIX.API.Application.Queries.MovieCommentQueries
{
    public class GetMovieCommentQuery : IRequest<MovieCommentDTO>
    {
        public long Id { get; }

        public GetMovieCommentQuery(long id)
        {
            Id = id;
        }
    }

    public class GetMovieCommentQueryHandler : IRequestHandler<GetMovieCommentQuery, MovieCommentDTO>
    {
        private readonly IMovieCommentService _movieCommentService;
        private readonly IMapper _mapper;

        public GetMovieCommentQueryHandler(IMovieCommentService movieCommentService, IMapper mapper)
        {
            _movieCommentService = movieCommentService;
            _mapper = mapper;
        }

        public async Task<MovieCommentDTO> Handle(GetMovieCommentQuery request, CancellationToken cancellationToken)
        {
            var movieComment = await _movieCommentService.GetByIdAsync(request.Id, cancellationToken);

            if (movieComment == null)
            {
                return null;
            }

            var mappedMovieComment = _mapper.Map<MovieCommentDTO>(movieComment);

            return mappedMovieComment;
        }
    }
}
