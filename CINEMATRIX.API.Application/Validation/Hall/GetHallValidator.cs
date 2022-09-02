using CINEMATRIX.API.Application.Queries.HallQueries;
using CINEMATRIX.Data.Services;
using FluentValidation;
using System.Threading;
using System.Threading.Tasks;

namespace CINEMATRIX.API.Application.Validation.Hall
{
    public class GetHallValidator : AbstractValidator<GetHallQuery>
    {
        private readonly IHallService _hallService;

        public GetHallValidator(IHallService hallService)
        {
            _hallService = hallService;

            CreateRules();
        }

        private void CreateRules()
        {
            RuleFor(query => query.Id)
                .NotNull()
                .WithMessage(query => string.Format(Resources.Resources.ValueRequired, nameof(query.Id)))
                .MustAsync(Exist)
                .WithMessage(Resources.Resources.HallNotFound);
        }

        private async Task<bool> Exist(long id, CancellationToken cancellationToken)
            => await _hallService.ExistsAsync(id, cancellationToken);
    }
}
