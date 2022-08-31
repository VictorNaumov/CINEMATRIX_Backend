using CINEMATRIX.API.Application.Commands.Abstractions;
using CINEMATRIX.API.Application.Validation.Utilities;
using CINEMATRIX.API.Contracts.IncomingOutgoing;
using FluentValidation;
using System;

namespace CINEMATRIX.API.Application.Validation.Abstractions
{
    public class HallValidatorBase<TCommand, TResponse> : AbstractValidator<TCommand>
        where TCommand : CommandBase<TResponse, HallDTO>
    {
        public HallValidatorBase()
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

            RuleFor(cmd => cmd.Entity.SoundSystem)
                .Must(ValidationRuleUtility.InNotNullOrWhitespace)
                .WithMessage(cmd => string.Format(Resources.Resources.ValueRequired, nameof(cmd.Entity.SoundSystem)));

            RuleFor(cmd => cmd.Entity.Projector)
                .Must(ValidationRuleUtility.InNotNullOrWhitespace)
                .WithMessage(cmd => string.Format(Resources.Resources.ValueRequired, nameof(cmd.Entity.Projector)));
            
            RuleFor(cmd => cmd.Entity.Screen)
                .Must(ValidationRuleUtility.InNotNullOrWhitespace)
                .WithMessage(cmd => string.Format(Resources.Resources.ValueRequired, nameof(cmd.Entity.Screen)));
            
            RuleFor(cmd => cmd.Entity.ScreenResolution)
                .Must(ValidationRuleUtility.InNotNullOrWhitespace)
                .WithMessage(cmd => string.Format(Resources.Resources.ValueRequired, nameof(cmd.Entity.ScreenResolution)));
        }
    }
}

