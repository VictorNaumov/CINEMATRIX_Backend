using CINEMATRIX.Data.Services;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace CINEMATRIX.API.Application.Commands.FoodCommands
{
    public class DeleteFoodCommand : IRequest
    {
        public long Id { get; }

        public DeleteFoodCommand(long id)
        {
            Id = id;
        }
    }

    public class DeleteFoodCommandHandler : IRequestHandler<DeleteFoodCommand>
    {
        private readonly IFoodService _foodService;

        public DeleteFoodCommandHandler(IFoodService foodService)
        {
            _foodService = foodService;
        }

        public async Task<Unit> Handle(DeleteFoodCommand request, CancellationToken cancellationToken)
        {
            await _foodService.DeleteAsync(request.Id, cancellationToken);

            return Unit.Value;
        }
    }
}
