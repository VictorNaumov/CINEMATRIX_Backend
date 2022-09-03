using AutoMapper;
using CINEMATRIX.API.Application.Commands.Abstractions;
using CINEMATRIX.API.Contracts.IncomingOutgoing;
using CINEMATRIX.API.Contracts.Outgoing.Abstractions;
using CINEMATRIX.Data.Domain.Models;
using CINEMATRIX.Data.Services;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace CINEMATRIX.API.Application.Commands.FoodCommands
{
    public class UpdateFoodCommand : CommandBase<Response, FoodDTO>
    {
        public UpdateFoodCommand(long id, FoodDTO update) : base(id, update) { }
    }

    public class UpdateFoodCommandHandler : IRequestHandler<UpdateFoodCommand, Response>
    {
        private readonly IFoodService _foodService;
        private readonly IMapper _mapper;

        public UpdateFoodCommandHandler(IFoodService foodService, IMapper mapper)
        {
            _foodService = foodService;
            _mapper = mapper;
        }

        public async Task<Response> Handle(UpdateFoodCommand request, CancellationToken cancellationToken)
        {
            var food = await _foodService.GetByIdAsync(request.Id, cancellationToken);

            if (food == null)
            {
                return Response.Error;
            }

            var foodToUpdate = _mapper.Map<Food>(food);

            var updatedFood = await _foodService.UpdateAsync(foodToUpdate);

            if (updatedFood == null)
            {
                return Response.Error;
            }

            return Response.Successful;
        }
    }
}
