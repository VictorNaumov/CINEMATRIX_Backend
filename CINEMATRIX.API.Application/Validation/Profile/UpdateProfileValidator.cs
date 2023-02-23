using CINEMATRIX.API.Application.Commands.ProfileCommands;
using CINEMATRIX.API.Application.Validation.Abstractions;
using CINEMATRIX.API.Contracts.Outgoing.Abstractions;
using CINEMATRIX.Data.Services;
using FluentValidation;
using System.Threading;
using System.Threading.Tasks;

namespace CINEMATRIX.API.Application.Validation.Profile
{
    public class UpdateProfileValidator : ProfileValidatorBase<UpdateProfileCommand, Response>
    {
        private readonly IProfileService _profileService;

        public UpdateProfileValidator(IProfileService profileService) : base()
        {
            _profileService = profileService;

            CreateRules();
        }

        private void CreateRules()
        {
            RuleFor(cmd => cmd.Id)
               .NotNull()
               .WithMessage(cmd => string.Format(Resources.Resources.ValueRequired, nameof(cmd.Id)))
               .MustAsync(Exist)
               .WithMessage(cmd => string.Format(Resources.Resources.ProfileNotFound, cmd.Id));
        }

        private async Task<bool> Exist(long id, CancellationToken cancellationToken)
            => await _profileService.ExistAsync(id, cancellationToken);
    }
}
