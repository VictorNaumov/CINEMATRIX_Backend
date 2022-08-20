using CINEMATRIX.Data.Services;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace CINEMATRIX.API.Application.Commands.SessionCommands
{
    public class DeleteSessionCommand : IRequest
    {
        public long Id { get; }

        public DeleteSessionCommand(long id)
        {
            Id = id;
        }
    }

    public class DeleteSessionCommandHandler : IRequestHandler<DeleteSessionCommand>
    {
        private readonly ISessionService _sessionService;

        public DeleteSessionCommandHandler(ISessionService sessionService)
        {
            _sessionService = sessionService;
        }

        public async Task<Unit> Handle(DeleteSessionCommand request, CancellationToken cancellationToken)
        {
            await _sessionService.DeleteAsync(request.Id, cancellationToken);

            return Unit.Value;
        }
    }
}
