using CINEMATRIX.API.Application.Commands.Abstractions;
using CINEMATRIX.API.Contracts.IncomingOutgoing;
using CINEMATRIX.Data.Services;
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
                .Must(NotBeNullOrWhitespace)
                .WithMessage(Resources.Resources.ProfileNameRequired);

            RuleFor(cmd => cmd.Entity.SecondName)
                .Must(NotBeNullOrWhitespace)
                .WithMessage(Resources.Resources.ProfileSecondNameRequired);

            RuleFor(cmd => cmd.Entity.DateOfBirth)
                .Must(IsValidDateTime)
                .WithMessage(query => string.Format(Resources.Resources.ProfileDateOfBirthMustBeInRange, DateTime.Now.AddYears(-130), DateTime.Now.AddYears(5)));

            RuleFor(cmd => cmd.Entity.PhoneNumber)
                .Must(NotBeNullOrWhitespace)
                .WithMessage(Resources.Resources.ProfilePhoneNumberRequired);
        }

        private bool NotBeNullOrWhitespace(string value) 
            => !string.IsNullOrWhiteSpace(value);
        
        private bool IsValidDateTime(DateTime value)
        {
            DateTime startDate = DateTime.Now.AddYears(-130);

            DateTime endDate = DateTime.Now.AddYears(5);

            return startDate < value && value < endDate;
        }
    }
}