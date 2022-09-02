using AutoMapper;
using CINEMATRIX.API.Application.Queries.Abstractions;
using CINEMATRIX.API.Application.Queries.Extensions;
using CINEMATRIX.API.Contracts.Incoming.SearchConditions;
using CINEMATRIX.API.Contracts.Outgoing.Abstractions;
using CINEMATRIX.API.Contracts.Outgoing.TMDB;
using CINEMATRIX.Data.Services;
using MediatR;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CINEMATRIX.API.Application.Queries.MovieQueries
{
    public class SearchGenreQuery : PagedSearchQuery<FoundGenreDTO, GenreSearchCondition>
    {
        public SearchGenreQuery(GenreSearchCondition searchCondition) : base(searchCondition) { }
    }

    public class SearchGenreQueryHandler : IRequestHandler<SearchGenreQuery, PagedResponse<FoundGenreDTO>>
    {
        private readonly IGenreService _genreService;
        private readonly IMapper _mapper;

        public SearchGenreQueryHandler(IGenreService genreService, IMapper mapper)
        {
            _genreService = genreService;
            _mapper = mapper;
        }

        public async Task<PagedResponse<FoundGenreDTO>> Handle(SearchGenreQuery request, CancellationToken cancellationToken)
        {
            var searchCondition = request.SearchCondition;
            searchCondition.Name = request.SearchCondition.Name.GetFilterValues();

            var sortProperty = GetSortProperty(searchCondition.SortProperty);

            IEnumerable<FoundGenreDTO> foundGenres = await _genreService.FindAsync(searchCondition, sortProperty);
            var mappedGenres = _mapper.Map<IEnumerable<FoundGenreDTO>>(foundGenres);
            var totalCount = mappedGenres.Count();

            return new PagedResponse<FoundGenreDTO>
            {
                Items = mappedGenres,
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