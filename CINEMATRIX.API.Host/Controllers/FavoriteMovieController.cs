using CINEMATRIX.API.Application.Commands.FavoriteMovieCommands;
using CINEMATRIX.API.Application.Queries.FavoriteMovieQueries;
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
using System.Threading;
using System.Threading.Tasks;

namespace CINEMATRIX.API.Host.Controllers
{
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/favoriteMovie")]
    [ApiController]
    //[Authorize]
    public class FavoriteMovieController : MediatingControllerBase
    {
        public FavoriteMovieController(IMediator mediator) : base(mediator) { }

        [HttpPost("search")]
        [AllowAnonymous]
        [SwaggerResponse(StatusCodes.Status200OK, Type = typeof(PagedResponse<FoundFavoriteMovieDTO>))]
        [SwaggerOperation(Summary = "Search favorite movies", OperationId = "SearchFavoriteMovies")]
        public async Task<IActionResult> SearchFavoriteMovies([FromBody] FavoriteMovieSearchCondition searchCondition, CancellationToken cancellationToken = default)
        {
            return await ExecuteQueryAsync(new SearchFavoriteMovieQuery(searchCondition), cancellationToken: cancellationToken);
        }

        [HttpPost]
        [SwaggerResponse(StatusCodes.Status200OK, Type = typeof(long))]
        [SwaggerOperation(Summary = "Add a new favorite movie", OperationId = "AddFavoriteMovie")]
        public async Task<IActionResult> AddFavoriteMovie([FromBody] FavoriteMovieDTO favoriteMovie, CancellationToken cancellationToken = default)
        {
            return await ExecuteCommandAsync(new AddFavoriteMovieCommand(favoriteMovie), cancellationToken: cancellationToken);
        }

        [HttpDelete("{id}")]
        [SwaggerResponse(StatusCodes.Status200OK, Type = typeof(OkResult))]
        [SwaggerOperation(Summary = "Delete a favorite movie", OperationId = "DeleteFavoriteMovie")]
        public async Task<IActionResult> DeleteFavoriteMovie([FromRoute] long id, CancellationToken cancellationToken = default)
        {
            return await ExecuteCommandAsync(new DeleteFavoriteMovieCommand(id), cancellationToken: cancellationToken);
        }

        [HttpPut("{id}")]
        [SwaggerResponse(StatusCodes.Status200OK, Type = typeof(FavoriteMovieDTO))]
        [SwaggerOperation(Summary = "Update a favorite movie", OperationId = "UpdateFavoriteMovie")]
        public async Task<IActionResult> UpdateFavoriteMovie([FromRoute] long id, [FromBody] FavoriteMovieDTO favoriteMovie, CancellationToken cancellationToken = default)
        {
            return await ExecuteCommandAsync(new UpdateFavoriteMovieCommand(id, favoriteMovie), cancellationToken: cancellationToken);
        }

        [HttpGet("{id}")]
        [AllowAnonymous]
        [SwaggerResponse(StatusCodes.Status200OK, Type = typeof(FavoriteMovieDTO))]
        [SwaggerOperation(Summary = "Get the details of a favorite movie", OperationId = "GetFavoriteMovie")]
        public async Task<IActionResult> GetFavoriteMovie([FromRoute] long id, CancellationToken cancellationToken = default)
        {
            return await ExecuteQueryAsync(new GetFavoriteMovieQuery(id), cancellationToken: cancellationToken);
        }
    }
}



