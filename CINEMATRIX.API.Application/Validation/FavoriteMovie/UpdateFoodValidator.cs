using CINEMATRIX.API.Application.Commands.FavoriteMovieCommands;
using CINEMATRIX.API.Application.Validation.Abstractions;
using CINEMATRIX.API.Contracts.Outgoing.Abstractions;
using CINEMATRIX.Data.Services;
using FluentValidation;
using System.Threading;
using System.Threading.Tasks;

namespace CINEMATRIX.API.Application.Validation.FavoriteMovie
{
    public class UpdateFavoriteMovieValidator : FavoriteMovieValidatorBase<UpdateFavoriteMovieCommand, Response>
    {
        private readonly IFavoriteMovieService _favoriteMovieService;

        public UpdateFavoriteMovieValidator(IProfileService profileService, IFavoriteMovieService favoriteMovieService) : base(profileService, favoriteMovieService)
        {
            _favoriteMovieService = favoriteMovieService;

            CreateRules();
        }

        private void CreateRules()
        {
            RuleFor(cmd => cmd.Id)
               .NotNull()
               .WithMessage(cmd => string.Format(Resources.Resources.ValueRequired, nameof(cmd.Id)))
               .MustAsync(Exist)
               .WithMessage(cmd => string.Format(Resources.Resources.FavoriteMovieNotFound, cmd.Id));
        }

        private async Task<bool> Exist(long id, CancellationToken cancellationToken)
            => await _favoriteMovieService.ExistAsync(id, cancellationToken);
    }
}
