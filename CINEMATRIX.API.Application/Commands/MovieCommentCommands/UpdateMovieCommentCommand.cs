using AutoMapper;
using CINEMATRIX.API.Application.Commands.Abstractions;
using CINEMATRIX.API.Contracts.IncomingOutgoing;
using CINEMATRIX.API.Contracts.Outgoing.Abstractions;
using CINEMATRIX.Data.Domain.Models;
using CINEMATRIX.Data.Services;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace CINEMATRIX.API.Application.Commands.MovieCommentCommands
{
    public class UpdateMovieCommentCommand : CommandBase<Response, MovieCommentDTO>
    {
        public UpdateMovieCommentCommand(long id, MovieCommentDTO update) : base(id, update) { }
    }

    public class UpdateMovieCommentCommandHandler : IRequestHandler<UpdateMovieCommentCommand, Response>
    {
        private readonly IMovieCommentService _MovieCommentService;
        private readonly IMapper _mapper;

        public UpdateMovieCommentCommandHandler(IMovieCommentService MovieCommentService, IMapper mapper)
        {
            _MovieCommentService = MovieCommentService;
            _mapper = mapper;
        }

        public async Task<Response> Handle(UpdateMovieCommentCommand request, CancellationToken cancellationToken)
        {
            var movieComment = await _MovieCommentService.GetByIdAsync(request.Id, cancellationToken);

            if (movieComment == null)
            {
                return Response.Error;
            }

            var movieCommentToUpdate = _mapper.Map<MovieComment>(movieComment);

            var updatedMovieComment = await _MovieCommentService.UpdateAsync(movieCommentToUpdate);

            if (updatedMovieComment == null)
            {
                return Response.Error;
            }

            return Response.Successful;
        }
    }
}
