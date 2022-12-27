using CINEMATRIX.Data.Services;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace CINEMATRIX.API.Application.Commands.FavoriteMovieCommands
{
    public class DeleteFavoriteMovieCommand : IRequest
    {
        public long Id { get; }

        public DeleteFavoriteMovieCommand(long id)
        {
            Id = id;
        }
    }

    public class DeleteFavoriteMovieCommandHandler : IRequestHandler<DeleteFavoriteMovieCommand>
    {
        private readonly IFavoriteMovieService _favoriteMovieService;

        public DeleteFavoriteMovieCommandHandler(IFavoriteMovieService FavoriteMovieService)
        {
            _favoriteMovieService = FavoriteMovieService;
        }

        public async Task<Unit> Handle(DeleteFavoriteMovieCommand request, CancellationToken cancellationToken)
        {
            await _favoriteMovieService.DeleteAsync(request.Id, cancellationToken);

            return Unit.Value;
        }
    }
}
