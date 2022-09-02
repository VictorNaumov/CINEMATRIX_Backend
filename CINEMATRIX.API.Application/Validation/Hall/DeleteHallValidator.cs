using CINEMATRIX.API.Application.Commands.HallCommands;
using CINEMATRIX.Data.Services;
using FluentValidation;
using System.Threading;
using System.Threading.Tasks;

namespace CINEMATRIX.API.Application.Validation.Hall
{
    public class DeleteHallValidator : AbstractValidator<DeleteHallCommand>
    {
        private readonly IHallService _hallService;

        public DeleteHallValidator(IHallService hallService)
        {
            _hallService = hallService;

            CreateRules();
        }

        private void CreateRules()
        {
            RuleFor(cmd => cmd.Id)
                .MustAsync(Exist)
                .WithMessage(cmd => string.Format(Resources.Resources.HallNotFound, cmd.Id));
        }

        private async Task<bool> Exist(long id, CancellationToken cancellationToken)
            => await _hallService.ExistsAsync(id, cancellationToken);
    }
}
