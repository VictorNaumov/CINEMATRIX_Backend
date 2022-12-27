using AutoMapper;
using CINEMATRIX.API.Contracts.Outgoing;
using CINEMATRIX.Data.Services;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace CINEMATRIX.API.Application.Queries.MovieCommentQueries
{
    public class GetMovieCommentsByProfileIdQuery : IRequest<List<FoundMovieCommentDTO>>
    {
        public long ProfileId { get; }

        public GetMovieCommentsByProfileIdQuery(long profileId)
        {
            ProfileId = profileId;
        }
    }

    public class GetMovieCommentsByProfileIdQueryHandler : IRequestHandler<GetMovieCommentsByProfileIdQuery, List<FoundMovieCommentDTO>>
    {
        private readonly IMovieCommentService _movieCommentService;
        private readonly IMapper _mapper;

        public GetMovieCommentsByProfileIdQueryHandler(IMovieCommentService movieCommentService, IMapper mapper)
        {
            _movieCommentService = movieCommentService;
            _mapper = mapper;
        }

        public async Task<List<FoundMovieCommentDTO>> Handle(GetMovieCommentsByProfileIdQuery request, CancellationToken cancellationToken)
        {
            var movieComments = await _movieCommentService.GetByProfileIdAsync(request.ProfileId, cancellationToken);

            var mappedMovieComments = _mapper.Map<List<FoundMovieCommentDTO>>(movieComments);

            return mappedMovieComments;
        }
    }
}
