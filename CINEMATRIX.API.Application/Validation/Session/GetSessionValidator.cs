using System.Threading;
using System.Threading.Tasks;
using CINEMATRIX.API.Application.Queries.SessionQueries;
using CINEMATRIX.Data.Services;
using FluentValidation;

namespace CINEMATRIX.API.Application.Validation.Session
{
    public class GetSessionValidator : AbstractValidator<GetSessionQuery>
    {
        private readonly ISessionService _sessionService;

        public GetSessionValidator(ISessionService sessionService)
        {
            _sessionService = sessionService;

            CreateRules();
        }

        private void CreateRules()
        {
            RuleFor(query => query.Id)
                .NotNull()
                .WithMessage(query => string.Format(Resources.Resources.ValueRequired, nameof(query.Id)))
                .MustAsync(Exist)
                .WithMessage(Resources.Resources.SessionNotFound);
        }

        private async Task<bool> Exist(long id, CancellationToken cancellationToken) 
            => await _sessionService.ExistsAsync(id, cancellationToken);
    }
}
