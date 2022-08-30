using System.Threading;
using System.Threading.Tasks;
using CINEMATRIX.API.Application.Queries.SeatQueries;
using CINEMATRIX.Data.Services;
using FluentValidation;

namespace CINEMATRIX.API.Application.Validation.Seat
{
    public class GetSeatValidator : AbstractValidator<GetSeatQuery>
    {
        private readonly ISeatService _seatService;

        public GetSeatValidator(ISeatService seatService)
        {
            _seatService = seatService;

            CreateRules();
        }

        private void CreateRules()
        {
            RuleFor(query => query.Id)
                .NotNull()
                .WithMessage(query => string.Format(Resources.Resources.ValueRequired, nameof(query.Id)))
                .MustAsync(Exist)
                .WithMessage(Resources.Resources.SeatNotFound);
        }

        private async Task<bool> Exist(long id, CancellationToken cancellationToken) 
            => await _seatService.ExistsAsync(id, cancellationToken);
    }
}
