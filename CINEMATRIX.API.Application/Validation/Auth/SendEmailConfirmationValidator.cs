using CINEMATRIX.API.Application.Commands.AuthCommands;
using CINEMATRIX.Data.Services;
using FluentValidation;

namespace CINEMATRIX.API.Application.Validation.Auth
{
    public class SendEmailConfirmationValidator : AbstractValidator<SendEmailConfirmationCommand>
    {
        private readonly IUserService _userService;

        public SendEmailConfirmationValidator(IUserService userService)
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

            RuleFor(cmd => cmd.Entity)
                .Must(UserWithThisUserNameExist)
                .WithMessage(cmd => string.Format(Resources.Resources.ValueRequired, nameof(cmd.Entity)));

            RuleFor(cmd => cmd.Entity)
                .Must(IsUsersEmailNotConfirmited)
                .WithMessage(cmd => string.Format(Resources.Resources.ValueRequired, nameof(cmd.Entity)));
        }

        private bool UserWithThisUserNameExist(string userName) =>
            _userService.GetByUserNameAsync(userName).Result != null;

        private bool IsUsersEmailNotConfirmited(string userName) =>
            !_userService.GetByUserNameAsync(userName).Result.IsEmailConfirmed;
    }
}
