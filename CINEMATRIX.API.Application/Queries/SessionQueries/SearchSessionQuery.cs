﻿using AutoMapper;
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

namespace CINEMATRIX.API.Application.Queries.SessionQueries
{
    public class SearchSessionQuery : PagedSearchQuery<FoundSessionDTO, SessionSearchCondition>
    {
        public SearchSessionQuery(SessionSearchCondition searchCondition) : base(searchCondition) { }
    }

    public class SearchSessionQueryHandler : IRequestHandler<SearchSessionQuery, PagedResponse<FoundSessionDTO>>
    {
        private readonly ISessionService _sessionService;
        private readonly IMapper _mapper;

        public SearchSessionQueryHandler(ISessionService sessionService, IMapper mapper)
        {
            _sessionService = sessionService;
            _mapper = mapper;
        }

        public async Task<PagedResponse<FoundSessionDTO>> Handle(SearchSessionQuery request, CancellationToken cancellationToken)
        {
            var searchCondition = request.SearchCondition;
            searchCondition.MovieName = GetFilterValues(request.SearchCondition.MovieName);

            var sortProperty = GetSortProperty(searchCondition.SortProperty);

            IReadOnlyCollection<Session> foundSessions = await _sessionService.FindAsync(searchCondition, sortProperty);
            var mappedSession = _mapper.Map<IEnumerable<FoundSessionDTO>>(foundSessions);
            var totalCount = await _sessionService.CountAsync(searchCondition);

            return new PagedResponse<FoundSessionDTO>
            {
                Items = mappedSession,
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
                    case "moviename": return nameof(Session.MovieName);
                }
            }

            return nameof(Session.Id);
        }
    }
}