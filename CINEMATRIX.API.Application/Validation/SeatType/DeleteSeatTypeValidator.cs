using System.Threading;
using System.Threading.Tasks;
using CINEMATRIX.API.Application.Commands.SeatTypeCommands;
using CINEMATRIX.Data.Services;
using FluentValidation;

namespace CINEMATRIX.API.Application.Validation.SeatType
{
    public class DeleteSeatTypeValidator : AbstractValidator<DeleteSeatTypeCommand>
    {
        private ISeatTypeService _profileService;

        public DeleteSeatTypeValidator(ISeatTypeService profileService)
        {
            _profileService = profileService;

            CreateRules();
        }

        private void CreateRules()
        {
            RuleFor(cmd => cmd.Id)
                .MustAsync(Exist)
                .WithMessage(cmd => string.Format(Resources.Resources.SeatTypeNotFound, cmd.Id));
        }

        private async Task<bool> Exist(long id, CancellationToken cancellationToken) 
            => await _profileService.ExistsAsync(id, cancellationToken);
    }
}
