using CINEMATRIX.Data.Services;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace CINEMATRIX.API.Application.Commands.PersonalDataCommands
{
    public class DeletePersonalDataCommand : IRequest
    {
        public long Id { get; }

        public DeletePersonalDataCommand(long id)
        {
            Id = id;
        }
    }

    public class DeletePersonalDataCommandHandler : IRequestHandler<DeletePersonalDataCommand>
    {
        private readonly IPersonalDataService _personalDataService;

        public DeletePersonalDataCommandHandler(IPersonalDataService personalDataService)
        {
            _personalDataService = personalDataService;
        }

        public async Task<Unit> Handle(DeletePersonalDataCommand request, CancellationToken cancellationToken)
        {
            await _personalDataService.DeleteAsync(request.Id, cancellationToken);

            return Unit.Value;
        }
    }
}
