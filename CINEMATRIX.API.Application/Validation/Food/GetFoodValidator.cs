using CINEMATRIX.API.Application.Queries.FoodQueries;
using CINEMATRIX.Data.Services;
using FluentValidation;
using System.Threading;
using System.Threading.Tasks;

namespace CINEMATRIX.API.Application.Validation.Food
{
    public class GetFoodValidator : AbstractValidator<GetFoodQuery>
    {
        private readonly IFoodService _foodService;

        public GetFoodValidator(IFoodService foodService)
        {
            _foodService = foodService;

            CreateRules();
        }

        private void CreateRules()
        {
            RuleFor(cmd => cmd.Id)
                .NotNull()
                .WithMessage(cmd => string.Format(Resources.Resources.ValueRequired, nameof(cmd.Id)))
                .MustAsync(Exist)
                .WithMessage(cmd => string.Format(Resources.Resources.FoodNotFound, cmd.Id));
        }

        private async Task<bool> Exist(long id, CancellationToken cancellationToken)
            => await _foodService.ExistsAsync(id, cancellationToken);
    }
}
