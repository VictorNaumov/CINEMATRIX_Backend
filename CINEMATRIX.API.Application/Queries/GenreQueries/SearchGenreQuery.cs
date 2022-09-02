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

namespace CINEMATRIX.API.Application.Queries.GenreQueries
{
    public class SearchGenreQuery : PagedSearchQuery<FoundGenreDTO, GenreSearchCondition>
    {
        public SearchGenreQuery(GenreSearchCondition searchCondition) : base(searchCondition) { }
    }

    public class SearchGenreQueryHandler : IRequestHandler<SearchGenreQuery, PagedResponse<FoundGenreDTO>>
    {
        private readonly IGenreService _genreService;

        public SearchGenreQueryHandler(IGenreService genreService)
        {
            _genreService = genreService;
        }

        public async Task<PagedResponse<FoundGenreDTO>> Handle(SearchGenreQuery request, CancellationToken cancellationToken)
        {
            var searchCondition = request.SearchCondition;
            searchCondition.Name = request.SearchCondition.Name.GetFilterValues();
            searchCondition.SortProperty = GetSortProperty(searchCondition.SortProperty);

            var foundGenres = await _genreService.FindAsync(searchCondition, cancellationToken);
            var totalCount = foundGenres.Count();

            return new PagedResponse<FoundGenreDTO>
            {
                Items = foundGenres,
                TotalCount = totalCount
            };
        }

        protected string GetSortProperty(string propertyName)
        {
            if (!string.IsNullOrWhiteSpace(propertyName))
            {
                switch (propertyName.ToLowerInvariant())
                {
                    case "name": return nameof(FoundGenreDTO.Name);
                }
            }

            return nameof(FoundGenreDTO.Id);
        }
    }
}