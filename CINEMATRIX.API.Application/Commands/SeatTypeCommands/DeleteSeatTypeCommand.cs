using CINEMATRIX.Data.Services;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace CINEMATRIX.API.Application.Commands.SeatTypeCommands
{
    public class DeleteSeatTypeCommand : IRequest
    {
        public long Id { get; }

        public DeleteSeatTypeCommand(long id)
        {
            Id = id;
        }
    }

    public class DeleteSeatTypeCommandHandler : IRequestHandler<DeleteSeatTypeCommand>
    {
        private readonly ISeatTypeService _seatTypeService;

        public DeleteSeatTypeCommandHandler(ISeatTypeService seatTypeService)
        {
            _seatTypeService = seatTypeService;
        }

        public async Task<Unit> Handle(DeleteSeatTypeCommand request, CancellationToken cancellationToken)
        {
            await _seatTypeService.DeleteAsync(request.Id, cancellationToken);

            return Unit.Value;
        }
    }
}
