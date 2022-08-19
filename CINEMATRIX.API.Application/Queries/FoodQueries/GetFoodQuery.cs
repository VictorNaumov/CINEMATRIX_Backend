using AutoMapper;
using CINEMATRIX.API.Contracts.IncomingOutgoing;
using CINEMATRIX.Data.Services;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace CINEMATRIX.API.Application.Queries.FoodQueries
{
    public class GetFoodQuery : IRequest<FoodDTO>
    {
        public long Id { get; }

        public GetFoodQuery(long id)
        {
            Id = id;
        }
    }

    public class GetProductQueryHandler : IRequestHandler<GetFoodQuery, FoodDTO>
    {
        private readonly IFoodService _foodService;
        private readonly IMapper _mapper;

        public GetProductQueryHandler(IFoodService foodService, IMapper mapper)
        {
            _foodService = foodService;
            _mapper = mapper;
        }

        public async Task<FoodDTO> Handle(GetFoodQuery request, CancellationToken cancellationToken)
        {
            var food = await _foodService.GetAsync(request.Id, cancellationToken);

            if (food == null)
            {
                return null;
            }

            var mappedFood = _mapper.Map<FoodDTO>(food);

            return mappedFood;
        }
    }
}
