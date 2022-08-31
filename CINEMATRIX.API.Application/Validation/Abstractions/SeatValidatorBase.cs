using CINEMATRIX.API.Application.Commands.Abstractions;
using CINEMATRIX.API.Application.Validation.Utilities;
using CINEMATRIX.API.Contracts.IncomingOutgoing;
using CINEMATRIX.Data.Services;
using FluentValidation;
using System.Threading;
using System.Threading.Tasks;

namespace CINEMATRIX.API.Application.Validation.Abstractions
{
    public class SeatValidatorBase<TCommand, TResponse> : AbstractValidator<TCommand>
        where TCommand : CommandBase<TResponse, SeatDTO>
    {
        private readonly ISeatTypeService _seatTypeService;
        private readonly IHallService _hallService;

        public SeatValidatorBase(ISeatTypeService seatTypeService, IHallService hallService)
        {
            _seatTypeService = seatTypeService;
            _hallService = hallService;

            CreateRules();
        }

        private void CreateRules()
        {
            RuleFor(cmd => cmd.Entity)
                .NotNull()
                .WithMessage(cmd => string.Format(Resources.Resources.ValueRequired, nameof(cmd.Entity)));

            RuleFor(cmd => cmd.Entity.Row)
                .Must(ValidationRuleUtility.IsPositiveNumber)
                .WithMessage(cmd => string.Format(Resources.Resources.ValueRequired, nameof(cmd.Entity.Row)));

            RuleFor(cmd => cmd.Entity.Number)
                .Must(ValidationRuleUtility.IsPositiveNumber)
                .WithMessage(cmd => string.Format(Resources.Resources.ValueRequired, nameof(cmd.Entity.Number)));

            RuleFor(cmd => cmd.Entity.HallId)
                .NotNull()
                .WithMessage(cmd => string.Format(Resources.Resources.ValueRequired, nameof(cmd.Entity.HallId)))
                .MustAsync(HallExist)
                .WithMessage(cmd => string.Format(Resources.Resources.HallNotFound, cmd.Entity.HallId));

            RuleFor(cmd => cmd.Entity.SeatTypeId)
                .NotNull()
                .WithMessage(cmd => string.Format(Resources.Resources.ValueRequired, nameof(cmd.Entity.SeatTypeId)))
                .MustAsync(SeatTypeExist)
                .WithMessage(cmd => string.Format(Resources.Resources.SeatTypeNotFound, cmd.Entity.SeatTypeId));
        }

        private async Task<bool> SeatTypeExist(long id, CancellationToken cancellationToken)
            => await _seatTypeService.ExistsAsync(id, cancellationToken);
        private async Task<bool> HallExist(long id, CancellationToken cancellationToken)
            => await _hallService.ExistsAsync(id, cancellationToken);
    }
}