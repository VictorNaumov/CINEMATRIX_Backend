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

namespace CINEMATRIX.API.Application.Queries.MovieCommentQueries
{
    public class SearchMovieCommentQuery : PagedSearchQuery<FoundMovieCommentDTO, MovieCommentSearchCondition>
    {
        public SearchMovieCommentQuery(MovieCommentSearchCondition searchCondition) : base(searchCondition) { }
    }

    public class SearchMovieCommentQueryHandler : IRequestHandler<SearchMovieCommentQuery, PagedResponse<FoundMovieCommentDTO>>
    {
        private readonly IMovieCommentService _movieCommentService;
        private readonly IMapper _mapper;

        public SearchMovieCommentQueryHandler(IMovieCommentService movieCommentService, IMapper mapper)
        {
            _movieCommentService = movieCommentService;
            _mapper = mapper;
        }

        public async Task<PagedResponse<FoundMovieCommentDTO>> Handle(SearchMovieCommentQuery request, CancellationToken cancellationToken)
        {
            var searchCondition = request.SearchCondition;
            searchCondition.Text = request.SearchCondition.Text.GetFilterValues();
            searchCondition.SortProperty = typeof(FoundMovieCommentDTO).GetSortProperty(searchCondition.SortProperty);

            IReadOnlyCollection<MovieComment> foundMovieComments = await _movieCommentService.FindAsync(searchCondition);
            var mappedMovieComment = _mapper.Map<IEnumerable<FoundMovieCommentDTO>>(foundMovieComments);
            var totalCount = await _movieCommentService.CountAsync(searchCondition);

            return new PagedResponse<FoundMovieCommentDTO>
            {
                Items = mappedMovieComment,
                TotalCount = totalCount
            };
        }
    }
}