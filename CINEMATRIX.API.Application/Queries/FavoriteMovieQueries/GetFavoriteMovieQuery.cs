using AutoMapper;
using CINEMATRIX.API.Contracts.IncomingOutgoing;
using CINEMATRIX.Data.Services;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace CINEMATRIX.API.Application.Queries.FavoriteMovieQueries
{
    public class GetFavoriteMovieQuery : IRequest<FavoriteMovieDTO>
    {
        public long Id { get; }

        public GetFavoriteMovieQuery(long id)
        {
            Id = id;
        }
    }

    public class GetFavoriteMovieQueryHandler : IRequestHandler<GetFavoriteMovieQuery, FavoriteMovieDTO>
    {
        private readonly IFavoriteMovieService _favoriteMovieService;
        private readonly IMapper _mapper;

        public GetFavoriteMovieQueryHandler(IFavoriteMovieService favoriteMovieService, IMapper mapper)
        {
            _favoriteMovieService = favoriteMovieService;
            _mapper = mapper;
        }

        public async Task<FavoriteMovieDTO> Handle(GetFavoriteMovieQuery request, CancellationToken cancellationToken)
        {
            var favoriteMovie = await _favoriteMovieService.GetByIdAsync(request.Id, cancellationToken);

            if (favoriteMovie == null)
            {
                return null;
            }

            var mappedFavoriteMovie = _mapper.Map<FavoriteMovieDTO>(favoriteMovie);

            return mappedFavoriteMovie;
        }
    }
}
