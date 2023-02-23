using CINEMATRIX.API.Application.Commands.Abstractions;
using CINEMATRIX.API.Application.Validation.Utilities;
using CINEMATRIX.API.Contracts.IncomingOutgoing;
using CINEMATRIX.Data.Services;
using FluentValidation;
using System.Threading;
using System.Threading.Tasks;

namespace CINEMATRIX.API.Application.Validation.Abstractions
{
    public class FavoriteMovieValidatorBase<TCommand, TResponse> : AbstractValidator<TCommand>
        where TCommand : CommandBase<TResponse, FavoriteMovieDTO>
    {

        private readonly IProfileService _profileService;
        private readonly IFavoriteMovieService _favoriteMovieService;

        public FavoriteMovieValidatorBase(IProfileService profileService, IFavoriteMovieService favoriteMovieService)
        {
            _profileService = profileService;
            _favoriteMovieService = favoriteMovieService;

            CreateRules();
        }


        private void CreateRules()
        {
            RuleFor(cmd => cmd.Entity)
                .NotNull()
                .WithMessage(cmd => string.Format(Resources.Resources.ValueRequired, nameof(cmd.Entity)));

            RuleFor(cmd => cmd.Entity.MovieId)
                .Must(ValidationRuleUtility.IsPositiveNumber)
                .WithMessage(cmd => string.Format(Resources.Resources.ValueRequired, nameof(cmd.Entity.MovieId)));

            RuleFor(cmd => cmd.Entity.ProfileId)
                .NotNull()
                .WithMessage(cmd => string.Format(Resources.Resources.ValueRequired, nameof(cmd.Entity.ProfileId)))
                .MustAsync(ProfileExist)
                .WithMessage(cmd => string.Format(Resources.Resources.HallNotFound, cmd.Entity.ProfileId));

            RuleFor(cmd => cmd.Entity)
                .MustAsync(FavoriteMovieNotExist)
                .WithMessage(cmd => string.Format(Resources.Resources.ValueRequired, nameof(cmd.Entity)));

            RuleFor(cmd => cmd.Entity.Rating)
                .Must(ValidationRuleUtility.IsPositiveNumber)
                .WithMessage(cmd => string.Format(Resources.Resources.ValueRequired, nameof(cmd.Entity.Rating)));
        }

        private async Task<bool> ProfileExist(long id, CancellationToken cancellationToken)
            => await _profileService.ExistAsync(id, cancellationToken);

        private async Task<bool> FavoriteMovieNotExist(FavoriteMovieDTO entity, CancellationToken cancellationToken)
            => !(await _favoriteMovieService.ExistAsync(entity.ProfileId, entity.MovieId, cancellationToken));
    }
}