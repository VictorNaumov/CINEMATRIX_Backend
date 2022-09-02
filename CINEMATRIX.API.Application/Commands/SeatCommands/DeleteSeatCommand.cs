using CINEMATRIX.Data.Services;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace CINEMATRIX.API.Application.Commands.SeatCommands
{
    public class DeleteSeatCommand : IRequest
    {
        public long Id { get; }

        public DeleteSeatCommand(long id)
        {
            Id = id;
        }
    }

    public class DeleteSeatCommandHandler : IRequestHandler<DeleteSeatCommand>
    {
        private readonly ISeatService _seatService;

        public DeleteSeatCommandHandler(ISeatService seatService)
        {
            _seatService = seatService;
        }

        public async Task<Unit> Handle(DeleteSeatCommand request, CancellationToken cancellationToken)
        {
            await _seatService.DeleteAsync(request.Id, cancellationToken);

            return Unit.Value;
        }
    }
}
