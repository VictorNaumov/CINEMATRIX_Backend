using CINEMATRIX.API.Application.Commands.Abstractions;
using CINEMATRIX.API.Application.Validation.Utilities;
using CINEMATRIX.API.Contracts.IncomingOutgoing;
using FluentValidation;

namespace CINEMATRIX.API.Application.Validation.Abstractions
{
    public class SeatTypeValidatorBase<TCommand, TResponse> : AbstractValidator<TCommand>
        where TCommand : CommandBase<TResponse, SeatTypeDTO>
    {
        public SeatTypeValidatorBase()
        {
            CreateRules();
        }

        private void CreateRules()
        {
            RuleFor(cmd => cmd.Entity)
                .NotNull()
                .WithMessage(cmd => string.Format(Resources.Resources.ValueRequired, nameof(cmd.Entity)));

            RuleFor(cmd => cmd.Entity.Name)
                .Must(ValidationUtility.InNotNullOrWhitespace)
                .WithMessage(cmd => string.Format(Resources.Resources.ValueRequired, nameof(cmd.Entity.Name)));

            RuleFor(cmd => cmd.Entity.Price)
                .Must(ValidationUtility.IsPositiveNumber)
                .WithMessage(cmd => string.Format(Resources.Resources.ValueRequired, nameof(cmd.Entity.Price)));
        }
    }
}