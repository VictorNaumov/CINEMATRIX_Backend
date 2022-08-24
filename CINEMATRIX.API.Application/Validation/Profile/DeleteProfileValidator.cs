using System.Threading;
using System.Threading.Tasks;
using CINEMATRIX.API.Application.Commands.ProfileCommands;
using CINEMATRIX.Data.Services;
using FluentValidation;

namespace CINEMATRIX.API.Application.Validation.Profile
{
    public class DeleteProfileValidator : AbstractValidator<DeleteProfileCommand>
    {
        private IProfileService _profileService;

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
            => await _profileService.ExistsAsync(id, cancellationToken);
    }
}
