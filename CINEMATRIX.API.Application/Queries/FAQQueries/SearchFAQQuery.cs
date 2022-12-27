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

namespace CINEMATRIX.API.Application.Queries.FAQQueries
{
    public class SearchFAQQuery : PagedSearchQuery<FoundFAQDTO, FAQSearchCondition>
    {
        public SearchFAQQuery(FAQSearchCondition searchCondition) : base(searchCondition) { }
    }

    public class SearchFAQQueryHandler : IRequestHandler<SearchFAQQuery, PagedResponse<FoundFAQDTO>>
    {
        private readonly IFAQService _FAQService;
        private readonly IMapper _mapper;

        public SearchFAQQueryHandler(IFAQService FAQService, IMapper mapper)
        {
            _FAQService = FAQService;
            _mapper = mapper;
        }

        public async Task<PagedResponse<FoundFAQDTO>> Handle(SearchFAQQuery request, CancellationToken cancellationToken)
        {
            var searchCondition = request.SearchCondition;
            searchCondition.Questions = request.SearchCondition.Questions.GetFilterValues();
            searchCondition.Answers = request.SearchCondition.Answers.GetFilterValues();
            searchCondition.Categories = request.SearchCondition.Categories.GetFilterValues();
            searchCondition.SortProperty = typeof(FoundFAQDTO).GetSortProperty(searchCondition.SortProperty);

            IReadOnlyCollection<FAQ> foundFAQs = await _FAQService.FindAsync(searchCondition);
            var mappedFAQ = _mapper.Map<IEnumerable<FoundFAQDTO>>(foundFAQs);
            var totalCount = await _FAQService.CountAsync(searchCondition);

            return new PagedResponse<FoundFAQDTO>
            {
                Items = mappedFAQ,
                TotalCount = totalCount
            };
        }
    }
}