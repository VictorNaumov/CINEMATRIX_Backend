using CINEMATRIX.Data.Services;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace CINEMATRIX.API.Application.Commands.CinemaCommands
{
    public class DeleteCinemaCommand : IRequest
    {
        public long Id { get; }

        public DeleteCinemaCommand(long id)
        {
            Id = id;
        }
    }

    public class DeleteCinemaCommandHandler : IRequestHandler<DeleteCinemaCommand>
    {
        private readonly ICinemaService _cinemaService;

        public DeleteCinemaCommandHandler(ICinemaService cinemaService)
        {
            _cinemaService = cinemaService;
        }

        public async Task<Unit> Handle(DeleteCinemaCommand request, CancellationToken cancellationToken)
        {
            await _cinemaService.DeleteAsync(request.Id, cancellationToken);

            return Unit.Value;
        }
    }
}
