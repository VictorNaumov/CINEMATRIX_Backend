﻿using AutoMapper;
using CINEMATRIX.API.Contracts.Outgoing.TMDB;
using CINEMATRIX.Data.Services;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace CINEMATRIX.API.Application.Queries.GenreQueries
{
    public class GetGenreQuery : IRequest<FoundGenreDTO>
    {
        public long Id { get; }

        public GetGenreQuery(long id)
        {
            Id = id;
        }
    }

    public class GetGenreQueryHandler : IRequestHandler<GetGenreQuery, FoundGenreDTO>
    {
        private readonly IGenreService _genreService;
        private readonly IMapper _mapper;

        public GetGenreQueryHandler(IGenreService genreService, IMapper mapper)
        {
            _genreService = genreService;
            _mapper = mapper;
        }

        public async Task<FoundGenreDTO> Handle(GetGenreQuery request, CancellationToken cancellationToken)
        {
            var genre = await _genreService.GetAsync(request.Id, cancellationToken);

            if (genre == null)
            {
                return null;
            }

            var mappedGenre = _mapper.Map<FoundGenreDTO>(genre);

            return mappedGenre;
        }
    }
}
