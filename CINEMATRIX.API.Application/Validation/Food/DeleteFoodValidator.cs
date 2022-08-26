using System.Threading;
using System.Threading.Tasks;
using CINEMATRIX.API.Application.Commands.FoodCommands;
using CINEMATRIX.Data.Services;
using FluentValidation;

namespace CINEMATRIX.API.Application.Validation.Food
{
    public class DeleteFoodValidator : AbstractValidator<DeleteFoodCommand>
    {
        private IFoodService _foodService;

        public DeleteFoodValidator(IFoodService foodService)
        {
            _foodService = foodService;

            CreateRules();
        }

        private void CreateRules()
        {
            RuleFor(query => query.Id)
                .MustAsync(Exist)
                .WithMessage(query => string.Format(Resources.Resources.FoodNotFound, query.Id));
        }

        private async Task<bool> Exist(long id, CancellationToken cancellationToken) 
            => await _foodService.ExistsAsync(id, cancellationToken);
    }
}
