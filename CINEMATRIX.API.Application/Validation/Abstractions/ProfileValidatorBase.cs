using CINEMATRIX.API.Application.Commands.Abstractions;
using CINEMATRIX.API.Application.Validation.Utilities;
using CINEMATRIX.API.Contracts.IncomingOutgoing;
using FluentValidation;
using System;

namespace CINEMATRIX.API.Application.Validation.Abstractions
{
    public class ProfileValidatorBase<TCommand, TResponse> : AbstractValidator<TCommand>
        where TCommand : CommandBase<TResponse, ProfileDTO>
    {
        public ProfileValidatorBase()
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

            RuleFor(cmd => cmd.Entity.SecondName)
                .Must(ValidationUtility.InNotNullOrWhitespace)
                .WithMessage(cmd => string.Format(Resources.Resources.ValueRequired, nameof(cmd.Entity.SecondName)));


            RuleFor(cmd => cmd.Entity.PhoneNumber)
                .Must(ValidationUtility.InNotNullOrWhitespace)
                .WithMessage(cmd => string.Format(Resources.Resources.ValueRequired, nameof(cmd.Entity.PhoneNumber)));

            RuleFor(cmd => cmd.Entity.DateOfBirth)
                .Must(ValidationUtility.IsValidDateTime)
                .WithMessage(query => string.Format(Resources.Resources.ProfileDateOfBirthMustBeInRange, DateTime.Now.AddYears(-100).ToShortDateString(), DateTime.Now.ToShortDateString()));
        }
    }
}