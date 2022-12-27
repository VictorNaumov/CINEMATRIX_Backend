using AutoMapper;
using CINEMATRIX.API.Application.Commands.Abstractions;
using CINEMATRIX.API.Contracts.IncomingOutgoing;
using CINEMATRIX.Data.Domain.Models;
using CINEMATRIX.Data.Services;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace CINEMATRIX.API.Application.Commands.MovieCommentCommands
{
    public class AddMovieCommentCommand : CommandBase<long, MovieCommentDTO>
    {
        public AddMovieCommentCommand(MovieCommentDTO MovieComment) : base(MovieComment) { }
    }

    public class AddMovieCommentCommandHandler : IRequestHandler<AddMovieCommentCommand, long>
    {
        private readonly IMovieCommentService _MovieCommentService;
        private readonly IMapper _mapper;

        public AddMovieCommentCommandHandler(IMovieCommentService MovieCommentService, IMapper mapper)
        {
            _MovieCommentService = MovieCommentService;
            _mapper = mapper;
        }

        public async Task<long> Handle(AddMovieCommentCommand request, CancellationToken cancellationToken)
        {
            var movieComment = _mapper.Map<MovieComment>(request.Entity);

            var insertedMovieComment = await _MovieCommentService.InsertAsync(movieComment);

            return insertedMovieComment.Id;
        }
    }
}
