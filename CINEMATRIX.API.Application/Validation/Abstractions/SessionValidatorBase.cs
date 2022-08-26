using CINEMATRIX.API.Application.Commands.Abstractions;
using CINEMATRIX.API.Application.Validation.Utilities;
using CINEMATRIX.API.Contracts.IncomingOutgoing;
using CINEMATRIX.Data.Services;
using FluentValidation;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace CINEMATRIX.API.Application.Validation.Abstractions
{
    public class SessionValidatorBase<TCommand, TResponse> : AbstractValidator<TCommand>
        where TCommand : CommandBase<TResponse, SessionDTO>
    {

        private readonly IHallService _hallService;
        public SessionValidatorBase(IHallService hallService)
        {
            _hallService = hallService;

            CreateRules();
        }

        private void CreateRules()
        {
            RuleFor(cmd => cmd.Entity)
                .NotNull()
                .WithMessage(cmd => string.Format(Resources.Resources.ValueRequired, nameof(cmd.Entity)));

            RuleFor(cmd => cmd.Entity.MovieId)
                .NotNull()
                .WithMessage(cmd => string.Format(Resources.Resources.ValueRequired, nameof(cmd.Entity.MovieId)));

            RuleFor(cmd => cmd.Entity.HallId)
                .NotNull()
                .WithMessage(cmd => string.Format(Resources.Resources.ValueRequired, nameof(cmd.Entity.HallId)))
                .MustAsync(HallExist)
                .WithMessage(cmd => string.Format(Resources.Resources.HallNotFound, cmd.Entity.HallId));

            RuleFor(cmd => cmd.Entity.DateTime)
                .Must(ValidationUtility.IsValidDateTime)
                .WithMessage(cmd => string.Format(Resources.Resources.SessionDateTimeMustBeInRange, DateTime.Now.AddYears(-100).ToShortDateString(), DateTime.Now.AddYears(1).ToShortDateString()));
        }


        private async Task<bool> HallExist(long id, CancellationToken cancellationToken)
            => await _hallService.ExistsAsync(id, cancellationToken);
    }
}