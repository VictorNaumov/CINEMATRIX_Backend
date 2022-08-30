using System.Threading;
using System.Threading.Tasks;
using CINEMATRIX.API.Application.Commands.SeatTypeCommands;
using CINEMATRIX.Data.Services;
using FluentValidation;

namespace CINEMATRIX.API.Application.Validation.SeatType
{
    public class DeleteSeatTypeValidator : AbstractValidator<DeleteSeatTypeCommand>
    {
        private readonly ISeatTypeService _seatTypeService;

        public DeleteSeatTypeValidator(ISeatTypeService seatTypeService)
        {
            _seatTypeService = seatTypeService;

            CreateRules();
        }

        private void CreateRules()
        {
            RuleFor(cmd => cmd.Id)
                .MustAsync(Exist)
                .WithMessage(cmd => string.Format(Resources.Resources.SeatTypeNotFound, cmd.Id));
        }

        private async Task<bool> Exist(long id, CancellationToken cancellationToken) 
            => await _seatTypeService.ExistsAsync(id, cancellationToken);
    }
}
