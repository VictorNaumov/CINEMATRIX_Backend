using AutoMapper;
using CINEMATRIX.API.Application.Queries.Abstractions;
using CINEMATRIX.API.Application.Queries.Extensions;
using CINEMATRIX.API.Contracts.Incoming.SearchConditions;
using CINEMATRIX.API.Contracts.Outgoing;
using CINEMATRIX.API.Contracts.Outgoing.Abstractions;
using CINEMATRIX.Data.Domain.Models;
using CINEMATRIX.Data.Services;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace CINEMATRIX.API.Application.Queries.FoodQueries
{
    public class SearchFoodQuery : PagedSearchQuery<FoundFoodDTO, FoodSearchCondition>
    {
        public SearchFoodQuery(FoodSearchCondition searchCondition) : base(searchCondition) { }
    }

    public class SearchFoodQueryHandler : IRequestHandler<SearchFoodQuery, PagedResponse<FoundFoodDTO>>
    {
        private readonly IFoodService _foodService;
        private readonly IMapper _mapper;

        public SearchFoodQueryHandler(IFoodService foodService, IMapper mapper)
        {
            _foodService = foodService;
            _mapper = mapper;
        }

        public async Task<PagedResponse<FoundFoodDTO>> Handle(SearchFoodQuery request, CancellationToken cancellationToken)
        {
            var searchCondition = request.SearchCondition;
            searchCondition.Name = request.SearchCondition.Name.GetFilterValues();
            searchCondition.Description = request.SearchCondition.Description.GetFilterValues();
            searchCondition.SortProperty = GetSortProperty(searchCondition.SortProperty);

            IReadOnlyCollection<Food> foundFoods = await _foodService.FindAsync(searchCondition);
            var mappedFood = _mapper.Map<IEnumerable<FoundFoodDTO>>(foundFoods);
            var totalCount = await _foodService.CountAsync(searchCondition);

            return new PagedResponse<FoundFoodDTO>
            {
                Items = mappedFood,
                TotalCount = totalCount
            };
        }

        protected string GetSortProperty(string propertyName)
        {
            if (!string.IsNullOrWhiteSpace(propertyName))
            {
                switch (propertyName.ToLowerInvariant())
                {
                    case "name": return nameof(Food.Name);
                    case "description": return nameof(Food.Description);
                    case "price": return nameof(Food.Price);
                }
            }

            return nameof(Food.Id);
        }
    }
}