using CINEMATRIX.API.Application.Commands.MovieCommentCommands;
using CINEMATRIX.API.Application.Queries.MovieCommentQueries;
using CINEMATRIX.API.Contracts.Incoming.SearchConditions;
using CINEMATRIX.API.Contracts.IncomingOutgoing;
using CINEMATRIX.API.Contracts.Outgoing;
using CINEMATRIX.API.Contracts.Outgoing.Abstractions;
using CINEMATRIX.API.Host.Controllers.Abstractions;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace CINEMATRIX.API.Host.Controllers
{
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/movieComment")]
    [ApiController]
    //[Authorize]
    public class MovieCommentController : MediatingControllerBase
    {
        public MovieCommentController(IMediator mediator) : base(mediator) { }

        [HttpPost("search")]
        [AllowAnonymous]
        [SwaggerResponse(StatusCodes.Status200OK, Type = typeof(PagedResponse<FoundMovieCommentDTO>))]
        [SwaggerOperation(Summary = "Search movie comments", OperationId = "SearchMovieComments")]
        public async Task<IActionResult> SearchMovieComments([FromBody] MovieCommentSearchCondition searchCondition, CancellationToken cancellationToken = default)
        {
            return await ExecuteQueryAsync(new SearchMovieCommentQuery(searchCondition), cancellationToken: cancellationToken);
        }

        [HttpPost]
        [SwaggerResponse(StatusCodes.Status200OK, Type = typeof(long))]
        [SwaggerOperation(Summary = "Add a new movie comment", OperationId = "AddMovieComment")]
        public async Task<IActionResult> AddMovieComment([FromBody] MovieCommentDTO movieComment, CancellationToken cancellationToken = default)
        {
            return await ExecuteCommandAsync(new AddMovieCommentCommand(movieComment), cancellationToken: cancellationToken);
        }

        [HttpDelete("{id}")]
        [SwaggerResponse(StatusCodes.Status200OK, Type = typeof(OkResult))]
        [SwaggerOperation(Summary = "Delete a movie comment", OperationId = "DeleteMovieComment")]
        public async Task<IActionResult> DeleteMovieComment([FromRoute] long id, CancellationToken cancellationToken = default)
        {
            return await ExecuteCommandAsync(new DeleteMovieCommentCommand(id), cancellationToken: cancellationToken);
        }

        [HttpPut("{id}")]
        [SwaggerResponse(StatusCodes.Status200OK, Type = typeof(MovieCommentDTO))]
        [SwaggerOperation(Summary = "Update a movie comment", OperationId = "UpdateMovieComment")]
        public async Task<IActionResult> UpdateMovieComment([FromRoute] long id, [FromBody] MovieCommentDTO movieComment, CancellationToken cancellationToken = default)
        {
            return await ExecuteCommandAsync(new UpdateMovieCommentCommand(id, movieComment), cancellationToken: cancellationToken);
        }

        [HttpGet("{id}")]
        [AllowAnonymous]
        [SwaggerResponse(StatusCodes.Status200OK, Type = typeof(MovieCommentDTO))]
        [SwaggerOperation(Summary = "Get the details of a movie comment", OperationId = "GetMovieComment")]
        public async Task<IActionResult> GetMovieComment([FromRoute] long id, CancellationToken cancellationToken = default)
        {
            return await ExecuteQueryAsync(new GetMovieCommentQuery(id), cancellationToken: cancellationToken);
        }

        [HttpGet("byMovieId/{movieId}")]
        [AllowAnonymous]
        [SwaggerResponse(StatusCodes.Status200OK, Type = typeof(List<MovieCommentDTO>))]
        [SwaggerOperation(Summary = "Get the movie comments by movie id", OperationId = "GetMovieCommentsByMovieId")]
        public async Task<IActionResult> GetMovieCommentsByMovieId([FromRoute] long movieId, CancellationToken cancellationToken = default)
        {
            return await ExecuteQueryAsync(new GetMovieCommentsByMovieIdQuery(movieId), cancellationToken: cancellationToken);
        }

        [HttpGet("byProfileId/{profileId}")]
        [AllowAnonymous]
        [SwaggerResponse(StatusCodes.Status200OK, Type = typeof(List<MovieCommentDTO>))]
        [SwaggerOperation(Summary = "Get the movie comments by profile id", OperationId = "GetMovieCommentsByProfileId")]
        public async Task<IActionResult> GetProfileComment([FromRoute] long profileId, CancellationToken cancellationToken = default)
        {
            return await ExecuteQueryAsync(new GetMovieCommentsByProfileIdQuery(profileId), cancellationToken: cancellationToken);
        }
    }
}



