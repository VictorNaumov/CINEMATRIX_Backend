using CINEMATRIX.API.Application.Commands.SeatTypeCommands;
using CINEMATRIX.API.Application.Validation.Abstractions;
using CINEMATRIX.API.Contracts.Outgoing.Abstractions;
using CINEMATRIX.Data.Services;
using FluentValidation;
using System.Threading;
using System.Threading.Tasks;

namespace CINEMATRIX.API.Application.Validation.SeatType
{
    public class UpdateSeatTypeValidator : SeatTypeValidatorBase<UpdateSeatTypeCommand, Response>
    {
        private readonly ISeatTypeService _seatTypeService;

        public UpdateSeatTypeValidator(ISeatTypeService seatTypeService) : base()
        {
            _seatTypeService = seatTypeService;

            CreateRules();
        }

        private void CreateRules()
        {
            RuleFor(cmd => cmd.Id)
               .NotNull()
               .WithMessage(cmd => string.Format(Resources.Resources.ValueRequired, nameof(cmd.Id)))
               .MustAsync(Exist)
               .WithMessage(cmd => string.Format(Resources.Resources.SeatTypeNotFound, cmd.Id));
        }

        private async Task<bool> Exist(long id, CancellationToken cancellationToken)
            => await _seatTypeService.ExistsAsync(id, cancellationToken);
    }
}
