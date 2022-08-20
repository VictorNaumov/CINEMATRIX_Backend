using CINEMATRIX.Data.Services;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace CINEMATRIX.API.Application.Commands.HallCommands
{
    public class DeleteHallCommand : IRequest
    {
        public long Id { get; }

        public DeleteHallCommand(long id)
        {
            Id = id;
        }
    }

    public class DeleteHallCommandHandler : IRequestHandler<DeleteHallCommand>
    {
        private readonly IHallService _hallService;

        public DeleteHallCommandHandler(IHallService hallService)
        {
            _hallService = hallService;
        }

        public async Task<Unit> Handle(DeleteHallCommand request, CancellationToken cancellationToken)
        {
            await _hallService.DeleteAsync(request.Id, cancellationToken);

            return Unit.Value;
        }
    }
}
