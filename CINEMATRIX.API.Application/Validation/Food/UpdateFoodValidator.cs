using System.Threading;
using System.Threading.Tasks;
using CINEMATRIX.API.Application.Commands.FoodCommands;
using CINEMATRIX.API.Application.Validation.Abstractions;
using CINEMATRIX.API.Contracts.Outgoing.Abstractions;
using CINEMATRIX.Data.Services;
using FluentValidation;

namespace CINEMATRIX.API.Application.Validation.Food

{
    public class UpdateFoodValidator : FoodValidatorBase<UpdateFoodCommand, Response>
    {
        private readonly IFoodService _foodService;

        public UpdateFoodValidator(IFoodService foodService) : base()
        {
            _foodService = foodService;

            CreateRules();
        }

        private void CreateRules()
        {
            RuleFor(cmd => cmd.Id)
               .NotNull()
               .WithMessage(cmd => string.Format(Resources.Resources.ValueRequired, nameof(cmd.Id)));

            RuleFor(cmd => cmd.Id)
                .MustAsync(Exist)
                .WithMessage(cmd => string.Format(Resources.Resources.FoodNotFound, cmd.Id));
        }

        private async Task<bool> Exist(long id, CancellationToken cancellationToken)
            => await _foodService.ExistsAsync(id, cancellationToken);
    }
}
