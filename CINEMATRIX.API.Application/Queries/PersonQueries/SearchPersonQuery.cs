using CINEMATRIX.API.Application.Queries.Abstractions;
using CINEMATRIX.API.Application.Queries.Extensions;
using CINEMATRIX.API.Contracts.Incoming.SearchConditions;
using CINEMATRIX.API.Contracts.Outgoing;
using CINEMATRIX.API.Contracts.Outgoing.Abstractions;
using CINEMATRIX.Data.Services;
using MediatR;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CINEMATRIX.API.Application.Queries.PersonQueries
{
    //public class SearchPersonQuery : PagedSearchQuery<FoundPersonDTO, PersonSearchCondition>
    //{
    //    public SearchPersonQuery(PersonSearchCondition searchCondition) : base(searchCondition) { }
    //}

    //public class SearchPersonQueryHandler : IRequestHandler<SearchPersonQuery, PagedResponse<FoundPersonDTO>>
    //{
    //    private readonly IPersonService _personService;

    //    public SearchPersonQueryHandler(IPersonService personService)
    //    {
    //        _personService = personService;
    //    }

    //    public async Task<PagedResponse<FoundPersonDTO>> Handle(SearchPersonQuery request, CancellationToken cancellationToken)
    //    {
    //        var searchCondition = request.SearchCondition;
    //        searchCondition.Name = request.SearchCondition.Name.GetFilterValues();
    //        searchCondition.SortProperty = GetSortProperty(searchCondition.SortProperty);

    //        var foundPersons = await _personService.FindAsync(searchCondition, cancellationToken);
    //        var totalCount = foundPersons.Count();

    //        return new PagedResponse<FoundPersonDTO>
    //        {
    //            Items = foundPersons,
    //            TotalCount = totalCount
    //        };
    //    }

    //    protected string GetSortProperty(string propertyName)
    //    {
    //        if (!string.IsNullOrWhiteSpace(propertyName))
    //        {
    //            switch (propertyName.ToLowerInvariant())
    //            {
    //                case "name": return nameof(FoundPersonDTO.Name);
    //            }
    //        }

    //        return nameof(FoundPersonDTO.Id);
    //    }
    //}
}