using System.Threading;
using System.Threading.Tasks;
using CINEMATRIX.API.Application.Queries.SeatTypeQueries;
using CINEMATRIX.Data.Services;
using FluentValidation;

namespace CINEMATRIX.API.Application.Validation.SeatType
{
    public class GetSeatTypeValidator : AbstractValidator<GetSeatTypeQuery>
    {
        private readonly ISeatTypeService _seatTypeService;

        public GetSeatTypeValidator(ISeatTypeService seatTypeService)
        {
            _seatTypeService = seatTypeService;

            CreateRules();
        }

        private void CreateRules()
        {
            RuleFor(query => query.Id)
                .NotNull()
                .WithMessage(query => string.Format(Resources.Resources.ValueRequired, nameof(query.Id)))
                .MustAsync(Exist)
                .WithMessage(Resources.Resources.SeatTypeNotFound);
        }

        private async Task<bool> Exist(long id, CancellationToken cancellationToken) 
            => await _seatTypeService.ExistsAsync(id, cancellationToken);
    }
}
