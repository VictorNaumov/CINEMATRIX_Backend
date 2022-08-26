using CINEMATRIX.API.Application.Commands.HallCommands;
using CINEMATRIX.API.Application.Validation.Abstractions;
using CINEMATRIX.API.Contracts.Outgoing.Abstractions;
using CINEMATRIX.Data.Services;
using FluentValidation;
using System.Threading;
using System.Threading.Tasks;

namespace CINEMATRIX.API.Application.Validation.Hall
{
    public class UpdateHallValidator : HallValidatorBase<UpdateHallCommand, Response>
    {
        private readonly IHallService _hallService;

        public UpdateHallValidator(IHallService hallService) : base()
        {
            _hallService = hallService;

            CreateRules();
        }

        private void CreateRules()
        {
            RuleFor(cmd => cmd.Id)
               .NotNull()
               .WithMessage(cmd => string.Format(Resources.Resources.ValueRequired, nameof(cmd.Id)))
               .MustAsync(Exist)
               .WithMessage(cmd => string.Format(Resources.Resources.HallNotFound, cmd.Id));
        }

        private async Task<bool> Exist(long id, CancellationToken cancellationToken)
            => await _hallService.ExistsAsync(id, cancellationToken);
    }
}
