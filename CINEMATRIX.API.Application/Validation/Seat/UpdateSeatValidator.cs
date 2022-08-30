using CINEMATRIX.API.Application.Commands.SeatCommands;
using CINEMATRIX.API.Application.Validation.Abstractions;
using CINEMATRIX.API.Contracts.Outgoing.Abstractions;
using CINEMATRIX.Data.Services;
using FluentValidation;
using System.Threading;
using System.Threading.Tasks;

namespace CINEMATRIX.API.Application.Validation.Seat
{
    public class UpdateSeatValidator : SeatValidatorBase<UpdateSeatCommand, Response>
    {
        private readonly ISeatService _seatService;

        public UpdateSeatValidator(ISeatService seatService, ISeatTypeService seatTypeService, IHallService hallService) 
            : base(seatTypeService, hallService)
        {
            _seatService = seatService;

            CreateRules();
        }

        private void CreateRules()
        {
            RuleFor(cmd => cmd.Id)
               .NotNull()
               .WithMessage(cmd => string.Format(Resources.Resources.ValueRequired, nameof(cmd.Id)))
               .MustAsync(Exist)
               .WithMessage(cmd => string.Format(Resources.Resources.SeatNotFound, cmd.Id));
        }

        private async Task<bool> Exist(long id, CancellationToken cancellationToken)
            => await _seatService.ExistsAsync(id, cancellationToken);
    }
}
