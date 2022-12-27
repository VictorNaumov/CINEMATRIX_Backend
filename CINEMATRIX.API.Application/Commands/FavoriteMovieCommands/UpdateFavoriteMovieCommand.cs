using AutoMapper;
using CINEMATRIX.API.Application.Commands.Abstractions;
using CINEMATRIX.API.Contracts.IncomingOutgoing;
using CINEMATRIX.API.Contracts.Outgoing.Abstractions;
using CINEMATRIX.Data.Domain.Models;
using CINEMATRIX.Data.Services;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace CINEMATRIX.API.Application.Commands.FavoriteMovieCommands
{
    public class UpdateFavoriteMovieCommand : CommandBase<Response, FavoriteMovieDTO>
    {
        public UpdateFavoriteMovieCommand(long id, FavoriteMovieDTO update) : base(id, update) { }
    }

    public class UpdateFavoriteMovieCommandHandler : IRequestHandler<UpdateFavoriteMovieCommand, Response>
    {
        private readonly IFavoriteMovieService _FavoriteMovieService;
        private readonly IMapper _mapper;

        public UpdateFavoriteMovieCommandHandler(IFavoriteMovieService FavoriteMovieService, IMapper mapper)
        {
            _FavoriteMovieService = FavoriteMovieService;
            _mapper = mapper;
        }

        public async Task<Response> Handle(UpdateFavoriteMovieCommand request, CancellationToken cancellationToken)
        {
            var favoriteMovie = await _FavoriteMovieService.GetByIdAsync(request.Id, cancellationToken);

            if (favoriteMovie == null)
            {
                return Response.Error;
            }

            var favoriteMovieToUpdate = _mapper.Map<FavoriteMovie>(favoriteMovie);

            var updatedFavoriteMovie = await _FavoriteMovieService.UpdateAsync(favoriteMovieToUpdate);

            if (updatedFavoriteMovie == null)
            {
                return Response.Error;
            }

            return Response.Successful;
        }
    }
}
