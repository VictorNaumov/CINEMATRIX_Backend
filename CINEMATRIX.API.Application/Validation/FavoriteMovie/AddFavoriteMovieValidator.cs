using CINEMATRIX.API.Application.Commands.FavoriteMovieCommands;
using CINEMATRIX.API.Application.Validation.Abstractions;
using CINEMATRIX.Data.Services;

namespace CINEMATRIX.API.Application.Validation.FavoriteMovie
{
    public class AddFavoriteMovieValidator : FavoriteMovieValidatorBase<AddFavoriteMovieCommand, long>
    {
        public AddFavoriteMovieValidator(IProfileService profileService, IFavoriteMovieService favoriteMovieService) : base(profileService, favoriteMovieService) { }
    }
}
