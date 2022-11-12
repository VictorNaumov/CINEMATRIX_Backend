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

namespace CINEMATRIX.API.Application.Queries.SessionQueries
{
    public class SearchSessionQuery : PagedSearchQuery<FoundSessionDTO, SessionSearchCondition>
    {
        public SearchSessionQuery(SessionSearchCondition searchCondition) : base(searchCondition) { }
    }

    public class SearchSessionQueryHandler : IRequestHandler<SearchSessionQuery, PagedResponse<FoundSessionDTO>>
    {
        private readonly ISessionService _sessionService;
        private readonly IMovieService _movieService;
        private readonly IMapper _mapper;

        public SearchSessionQueryHandler(ISessionService sessionService, IMovieService movieService, IMapper mapper)
        {
            _sessionService = sessionService;
            _movieService = movieService;
            _mapper = mapper;
        }

        public async Task<PagedResponse<FoundSessionDTO>> Handle(SearchSessionQuery request, CancellationToken cancellationToken)
        {
            var searchCondition = request.SearchCondition;
            searchCondition.SortProperty = typeof(FoundSessionDTO).GetSortProperty(searchCondition.SortProperty);

            IReadOnlyCollection<Session> foundSessions = await _sessionService.FindAsync(searchCondition);
            var mappedSession = _mapper.Map<IEnumerable<FoundSessionDTO>>(foundSessions);
            var totalCount = await _sessionService.CountAsync(searchCondition);

            foreach (var session in mappedSession)
            {
                var movie = await _movieService.GetByIdAsync(session.MovieId, cancellationToken);
                session.Movie = _mapper.Map<FoundMovieDTO>(movie);
            }

            return new PagedResponse<FoundSessionDTO>
            {
                Items = mappedSession,
                TotalCount = totalCount
            };
        }
    }
}