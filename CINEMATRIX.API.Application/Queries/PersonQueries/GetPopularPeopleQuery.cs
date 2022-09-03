using AutoMapper;
using CINEMATRIX.API.Application.Queries.Abstractions;
using CINEMATRIX.API.Application.Queries.Extensions;
using CINEMATRIX.API.Contracts.Incoming.SearchConditions;
using CINEMATRIX.API.Contracts.Outgoing;
using CINEMATRIX.API.Contracts.Outgoing.Abstractions;
using CINEMATRIX.Data.Services;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace CINEMATRIX.API.Application.Queries.PersonQueries
{
    public class GetPopularPeopleQuery : PagedSearchQuery<FoundPersonDTO, PersonSearchCondition>
    {
        public GetPopularPeopleQuery(PersonSearchCondition searchCondition) : base(searchCondition) { }
    }

    public class GetPopularPeopleQueryHandler : IRequestHandler<GetPopularPeopleQuery, PagedResponse<FoundPersonDTO>>
    {
        private readonly IPersonService _personService;
        private readonly IMapper _mapper;

        public GetPopularPeopleQueryHandler(IPersonService personService, IMapper mapper)
        {
            _personService = personService;
            _mapper = mapper;
        }

        public async Task<PagedResponse<FoundPersonDTO>> Handle(GetPopularPeopleQuery request, CancellationToken cancellationToken)
        {
            var searchCondition = request.SearchCondition;
            searchCondition.Name = request.SearchCondition.Name.GetFilterValues();
            searchCondition.SortProperty = typeof(FoundPersonDTO).GetSortProperty(searchCondition.SortProperty);

            var personTopRatedApiResponse = await _personService.GetPopularPeopleAsync(searchCondition, cancellationToken);

            return _mapper.Map<PagedResponse<FoundPersonDTO>>(personTopRatedApiResponse);
        }
    }
}
