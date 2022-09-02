using CINEMATRIX.API.Application.Queries.ProfileQueries;
using CINEMATRIX.Data.Services;
using FluentValidation;
using System.Threading;
using System.Threading.Tasks;

namespace CINEMATRIX.API.Application.Validation.Profile
{
    public class GetProfileValidator : AbstractValidator<GetProfileQuery>
    {
        private readonly IProfileService _profileService;

        public GetProfileValidator(IProfileService profileService)
        {
            _profileService = profileService;

            CreateRules();
        }

        private void CreateRules()
        {
            RuleFor(query => query.Id)
                .NotNull()
                .WithMessage(query => string.Format(Resources.Resources.ValueRequired, nameof(query.Id)))
                .MustAsync(Exist)
                .WithMessage(Resources.Resources.ProfileNotFound);
        }

        private async Task<bool> Exist(long id, CancellationToken cancellationToken)
            => await _profileService.ExistsAsync(id, cancellationToken);
    }
}
