using AutoMapper;
using CINEMATRIX.API.Application.Queries.Abstractions;
using CINEMATRIX.API.Contracts.Incoming.SearchConditions;
using CINEMATRIX.API.Contracts.Outgoing;
using CINEMATRIX.API.Contracts.Outgoing.Abstractions;
using CINEMATRIX.Data.Domain.Models;
using CINEMATRIX.Data.Services;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
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
            searchCondition.Name = GetFilterValues(request.SearchCondition.Name);
            searchCondition.Description = GetFilterValues(request.SearchCondition.Description);

            var sortProperty = GetSortProperty(searchCondition.SortProperty);

            IReadOnlyCollection<Food> foundFoods = await _foodService.FindAsync(searchCondition, sortProperty);
            var mappedFood = _mapper.Map<IEnumerable<FoundFoodDTO>>(foundFoods);
            var totalCount = await _foodService.CountAsync(searchCondition);

            return new PagedResponse<FoundFoodDTO>
            {
                Items = mappedFood,
                TotalCount = totalCount
            };
        }
        private string[] GetFilterValues(ICollection<string> values)
        {
            return values == null
                ? Array.Empty<string>()
                : values.Select(v => v.ToUpper().Trim()).Distinct().ToArray();
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