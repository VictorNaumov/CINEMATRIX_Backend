using CINEMATRIX.API.Application.Commands.ProfileCommands;
using CINEMATRIX.Data.Services;
using FluentValidation;
using System.Threading;
using System.Threading.Tasks;

namespace CINEMATRIX.API.Application.Validation.Profile
{
    public class DeleteProfileValidator : AbstractValidator<DeleteProfileCommand>
    {
        private readonly IProfileService _profileService;

        public DeleteProfileValidator(IProfileService profileService)
        {
            _profileService = profileService;

            CreateRules();
        }

        private void CreateRules()
        {
            RuleFor(cmd => cmd.Id)
                .MustAsync(Exist)
                .WithMessage(cmd => string.Format(Resources.Resources.ProfileNotFound, cmd.Id));
        }

        private async Task<bool> Exist(long id, CancellationToken cancellationToken)
            => await _profileService.ExistAsync(id, cancellationToken);
    }
}
