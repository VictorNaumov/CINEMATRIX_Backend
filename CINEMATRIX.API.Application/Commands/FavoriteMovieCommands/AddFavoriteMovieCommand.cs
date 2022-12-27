using AutoMapper;
using CINEMATRIX.API.Application.Commands.Abstractions;
using CINEMATRIX.API.Contracts.IncomingOutgoing;
using CINEMATRIX.Data.Domain.Models;
using CINEMATRIX.Data.Services;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace CINEMATRIX.API.Application.Commands.FavoriteMovieCommands
{
    public class AddFavoriteMovieCommand : CommandBase<long, FavoriteMovieDTO>
    {
        public AddFavoriteMovieCommand(FavoriteMovieDTO FavoriteMovie) : base(FavoriteMovie) { }
    }

    public class AddFavoriteMovieCommandHandler : IRequestHandler<AddFavoriteMovieCommand, long>
    {
        private readonly IFavoriteMovieService _FavoriteMovieService;
        private readonly IMapper _mapper;

        public AddFavoriteMovieCommandHandler(IFavoriteMovieService FavoriteMovieService, IMapper mapper)
        {
            _FavoriteMovieService = FavoriteMovieService;
            _mapper = mapper;
        }

        public async Task<long> Handle(AddFavoriteMovieCommand request, CancellationToken cancellationToken)
        {
            var favoriteMovie = _mapper.Map<FavoriteMovie>(request.Entity);

            var insertedFavoriteMovie = await _FavoriteMovieService.InsertAsync(favoriteMovie);

            return insertedFavoriteMovie.Id;
        }
    }
}
