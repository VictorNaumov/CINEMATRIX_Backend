using System.Threading;
using System.Threading.Tasks;
using CINEMATRIX.API.Application.Commands.SeatCommands;
using CINEMATRIX.Data.Services;
using FluentValidation;

namespace CINEMATRIX.API.Application.Validation.Seat
{
    public class DeleteSeatValidator : AbstractValidator<DeleteSeatCommand>
    {
        private readonly ISeatService _seatService;

        public DeleteSeatValidator(ISeatService seatService)
        {
            _seatService = seatService;

            CreateRules();
        }

        private void CreateRules()
        {
            RuleFor(cmd => cmd.Id)
                .MustAsync(Exist)
                .WithMessage(cmd => string.Format(Resources.Resources.SeatNotFound, cmd.Id));
        }

        private async Task<bool> Exist(long id, CancellationToken cancellationToken) 
            => await _seatService.ExistsAsync(id, cancellationToken);
    }
}
