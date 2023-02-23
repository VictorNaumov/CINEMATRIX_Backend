using CINEMATRIX.API.Application.Commands.FavoriteMovieCommands;
using CINEMATRIX.Data.Services;
using FluentValidation;
using System.Threading;
using System.Threading.Tasks;

namespace CINEMATRIX.API.Application.Validation.FavoriteMovie
{
    public class DeleteFavoriteMovieValidator : AbstractValidator<DeleteFavoriteMovieCommand>
    {
        private readonly IFavoriteMovieService _favoriteMovieService;

        public DeleteFavoriteMovieValidator(IFavoriteMovieService favoriteMovieService)
        {
            _favoriteMovieService = favoriteMovieService;

            CreateRules();
        }

        private void CreateRules()
        {
            RuleFor(query => query.Id)
                .MustAsync(Exist)
                .WithMessage(query => string.Format(Resources.Resources.FavoriteMovieNotFound, query.Id));
        }

        private async Task<bool> Exist(long id, CancellationToken cancellationToken)
            => await _favoriteMovieService.ExistAsync(id, cancellationToken);
    }
}
