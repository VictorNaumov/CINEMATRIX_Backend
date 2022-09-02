﻿using AutoMapper;
using CINEMATRIX.API.Application.Queries.Abstractions;
using CINEMATRIX.API.Application.Queries.Extensions;
using CINEMATRIX.API.Contracts.Incoming.SearchConditions;
using CINEMATRIX.API.Contracts.Outgoing;
using CINEMATRIX.API.Contracts.Outgoing.Abstractions;
using CINEMATRIX.Data.Services;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace CINEMATRIX.API.Application.Queries.MovieQueries
{
    public class GetNowPlayingMoviesQuery : PagedSearchQuery<FoundMovieDTO, MovieSearchCondition>
    {
        public GetNowPlayingMoviesQuery(MovieSearchCondition searchCondition) : base(searchCondition) { }
    }

    public class GetNowPlayingMoviesQueryHandler : IRequestHandler<GetNowPlayingMoviesQuery, PagedResponse<FoundMovieDTO>>
    {
        private readonly IMovieService _movieService;
        private readonly IMapper _mapper;

        public GetNowPlayingMoviesQueryHandler(IMovieService movieService, IMapper mapper)
        {
            _movieService = movieService;
            _mapper = mapper;
        }

        public async Task<PagedResponse<FoundMovieDTO>> Handle(GetNowPlayingMoviesQuery request, CancellationToken cancellationToken)
        {
            var searchCondition = request.SearchCondition;
            searchCondition.Title = request.SearchCondition.Title.GetFilterValues();

            var sortProperty = GetSortProperty(searchCondition.SortProperty);

            var movieNowPlayingApiResponse = await _movieService.GetNowPlayingMoviesAsync(searchCondition, sortProperty);

            return _mapper.Map<PagedResponse<FoundMovieDTO>>(movieNowPlayingApiResponse);
        }

        protected string GetSortProperty(string propertyName)
        {
            if (!string.IsNullOrWhiteSpace(propertyName))
            {
                switch (propertyName.ToLowerInvariant())
                {
                    case "title": return nameof(FoundMovieDTO.Title);
                    case "overview": return nameof(FoundMovieDTO.Overview);
                    case "budget": return nameof(FoundMovieDTO.Budget);
                    case "originallanguage": return nameof(FoundMovieDTO.OriginalLanguage);
                    case "originaltitle": return nameof(FoundMovieDTO.OriginalTitle);
                    case "popularity": return nameof(FoundMovieDTO.Popularity);
                    case "releasedate": return nameof(FoundMovieDTO.ReleaseDate);
                    case "runtime": return nameof(FoundMovieDTO.Runtime);
                    case "status": return nameof(FoundMovieDTO.Status);
                    case "tagline": return nameof(FoundMovieDTO.Tagline);
                    case "voteaverage": return nameof(FoundMovieDTO.VoteAverage);
                    case "votecount": return nameof(FoundMovieDTO.VoteCount);
                }
            }

            return nameof(FoundMovieDTO.Id);
        }
    }
}
