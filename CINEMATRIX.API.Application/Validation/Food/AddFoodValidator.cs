using CINEMATRIX.API.Application.Commands.FoodCommands;
using CINEMATRIX.API.Application.Validation.Abstractions;

namespace CINEMATRIX.API.Application.Validation.Food
{
    public class AddFavoriteMovieValidator : FoodValidatorBase<AddFoodCommand, long>
    {
        public AddFavoriteMovieValidator() : base() { }
    }
}
