using CINEMATRIX.API.Application.Commands.Abstractions;
using CINEMATRIX.API.Contracts.IncomingOutgoing;
using CINEMATRIX.Data.Services;
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
                .Must(NotBeNullOrWhitespace)
                .WithMessage(Resources.Resources.FoodNameRequired);

            RuleFor(cmd => cmd.Entity.Description)
                .Must(NotBeNullOrWhitespace)
                .WithMessage(Resources.Resources.FoodDescriptionRequired);

            RuleFor(cmd => cmd.Entity.Price)
                .Must(NotBeLessThanNull)
                .WithMessage(Resources.Resources.FoodPriceCanNotBeLessThanNull);

            RuleFor(cmd => cmd.Entity.Price)
                .Must(NotBeLessThanNull)
                .WithMessage(query => string.Format(Resources.Resources.ValueRequired, nameof(query.Id)));

        }

        private bool NotBeNullOrWhitespace(string value) 
            => !string.IsNullOrWhiteSpace(value);
        
        private bool NotBeLessThanNull(decimal value) 
            => value > 0;

    }
}