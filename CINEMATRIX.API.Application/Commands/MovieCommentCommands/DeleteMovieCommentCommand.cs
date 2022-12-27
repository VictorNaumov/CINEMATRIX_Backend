using CINEMATRIX.Data.Services;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace CINEMATRIX.API.Application.Commands.MovieCommentCommands
{
    public class DeleteMovieCommentCommand : IRequest
    {
        public long Id { get; }

        public DeleteMovieCommentCommand(long id)
        {
            Id = id;
        }
    }

    public class DeleteMovieCommentCommandHandler : IRequestHandler<DeleteMovieCommentCommand>
    {
        private readonly IMovieCommentService _movieCommentService;

        public DeleteMovieCommentCommandHandler(IMovieCommentService MovieCommentService)
        {
            _movieCommentService = MovieCommentService;
        }

        public async Task<Unit> Handle(DeleteMovieCommentCommand request, CancellationToken cancellationToken)
        {
            await _movieCommentService.DeleteAsync(request.Id, cancellationToken);

            return Unit.Value;
        }
    }
}
