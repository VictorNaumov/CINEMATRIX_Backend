using CINEMATRIX.API.Application.Queries.AuthQueries;
using CINEMATRIX.API.Contracts.IncomingOutgoing;
using CINEMATRIX.Data.Domain.Models;
using CINEMATRIX.Data.Services;
using FluentValidation;

namespace CINEMATRIX.API.Application.Validation.Auth
{
    public class ConfirmEmailValidator : AbstractValidator<ConfirmEmailQuery>
    {
        private readonly IUserService _userService;

        public ConfirmEmailValidator(IUserService userService)
        {
            _userService = userService;

            CreateRules();
        }

        private void CreateRules()
        {
            //TODO update messages
            RuleFor(cmd => cmd.Entity)
                .NotNull()
                .WithMessage(cmd => string.Format(Resources.Resources.ValueRequired, nameof(cmd.Entity)));

            RuleFor(cmd => cmd.Entity.UserId)
                .NotNull()
                .WithMessage(cmd => string.Format(Resources.Resources.ValueRequired, nameof(cmd.Entity)));

            RuleFor(cmd => cmd.Entity.Token)
                .NotNull()
                .WithMessage(cmd => string.Format(Resources.Resources.ValueRequired, nameof(cmd.Entity)));

            RuleFor(cmd => cmd.Entity.UserId)
                .Must(IsUserExist)
                .WithMessage(cmd => string.Format(Resources.Resources.ValueRequired, nameof(cmd.Entity)));

            RuleFor(cmd => cmd.Entity.UserId)
                .Must(IsUsersEmailNotConfirmited)
                .WithMessage(cmd => string.Format(Resources.Resources.ValueRequired, nameof(cmd.Entity)));

            RuleFor(cmd => cmd.Entity)
                .Must(IsValidTokenAndExpiresDate)
                .WithMessage(cmd => string.Format(Resources.Resources.ValueRequired, nameof(cmd.Entity)));
        }


        private bool IsUserExist(long userId) =>
            _userService.GetByIdAsync(userId).Result != null;

        private bool IsUsersEmailNotConfirmited(long userId) =>
            !_userService.GetByIdAsync(userId).Result.IsEmailConfirmed;

        private bool IsValidTokenAndExpiresDate(ConfirmEmailDTO confirmEmailDTO) =>
            _userService.IsValidEmailConfirmationToken(confirmEmailDTO).Result;

    }
}
