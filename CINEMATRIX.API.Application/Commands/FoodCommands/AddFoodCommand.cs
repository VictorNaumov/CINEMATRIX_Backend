using AutoMapper;
using CINEMATRIX.API.Application.Commands.Abstractions;
using CINEMATRIX.API.Contracts.IncomingOutgoing;
using CINEMATRIX.Data.Domain.Models;
using CINEMATRIX.Data.Services;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace CINEMATRIX.API.Application.Commands.FoodCommands
{
    public class AddFoodCommand : CommandBase<long, FoodDTO>
    {
        public AddFoodCommand(FoodDTO food) : base(food) { }
    }

    public class AddFoodCommandHandler : IRequestHandler<AddFoodCommand, long>
    {
        private readonly IFoodService _foodService;
        private readonly IMapper _mapper;

        public AddFoodCommandHandler(IFoodService foodService, IMapper mapper)
        {
            _foodService = foodService;
            _mapper = mapper;
        }

        public async Task<long> Handle(AddFoodCommand request, CancellationToken cancellationToken)
        {
            var food = _mapper.Map<Food>(request.Entity);

            var insertedProduct = await _foodService.InsertAsync(food);

            return insertedProduct.Id;
        }
    }
}
