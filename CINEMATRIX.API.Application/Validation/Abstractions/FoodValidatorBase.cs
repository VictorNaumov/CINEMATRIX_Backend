using CINEMATRIX.API.Application.Commands.Abstractions;
using CINEMATRIX.API.Application.Validation.Utilities;
using CINEMATRIX.API.Contracts.IncomingOutgoing;
using FluentValidation;

namespace CINEMATRIX.API.Application.Validation.Abstractions
{
    public class FoodValidatorBase<TCommand, TResponse> : AbstractValidator<TCommand>
        where TCommand : CommandBase<TResponse, FoodDTO>
    {
        public FoodValidatorBase()
        {
            CreateRules();
        }

        private void CreateRules()
        {
            RuleFor(cmd => cmd.Entity)
                .NotNull()
                .WithMessage(cmd => string.Format(Resources.Resources.ValueRequired, nameof(cmd.Entity)));

            RuleFor(cmd => cmd.Entity.Name)
                .Must(ValidationRuleUtility.InNotNullOrWhitespace)
                .WithMessage(cmd => string.Format(Resources.Resources.ValueRequired, nameof(cmd.Entity.Name)));

            RuleFor(cmd => cmd.Entity.Description)
                .Must(ValidationRuleUtility.InNotNullOrWhitespace)
                .WithMessage(cmd => string.Format(Resources.Resources.ValueRequired, nameof(cmd.Entity.Description)));

            RuleFor(cmd => cmd.Entity.Price)
                .Must(ValidationRuleUtility.IsPositiveNumber)
                .WithMessage(Resources.Resources.FoodPriceCanNotBeLessThanNull);
        }
    }
}