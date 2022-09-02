using CINEMATRIX.API.Application.Queries.GenreQueries;
using CINEMATRIX.API.Contracts.Incoming.SearchConditions;
using CINEMATRIX.API.Contracts.Outgoing.Abstractions;
using CINEMATRIX.API.Contracts.Outgoing;
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
    [Route("api/v{version:apiVersion}/genre")]
    [ApiController]
    //[Authorize]
    public class GenreController : MediatingControllerBase
    {
        public GenreController(IMediator mediator) : base(mediator) { }


        [HttpPost("search")]
        [AllowAnonymous]
        [SwaggerResponse(StatusCodes.Status200OK, Type = typeof(PagedResponse<FoundGenreDTO>))]
        [SwaggerOperation(Summary = "Search genres", OperationId = "SearchGenres")]
        public async Task<IActionResult> SearchGenres([FromBody] GenreSearchCondition searchCondition, CancellationToken cancellationToken = default)
        {
            return await ExecuteQueryAsync(new SearchGenreQuery(searchCondition), cancellationToken: cancellationToken);
        }

        [HttpGet("{id}")]
        [AllowAnonymous]
        [SwaggerResponse(StatusCodes.Status200OK, Type = typeof(FoundGenreDTO))]
        [SwaggerOperation(Summary = "Get the details of a genre", OperationId = "GetGenre")]
        public async Task<IActionResult> GetGenre([FromRoute] long id, CancellationToken cancellationToken = default)
        {
            return await ExecuteQueryAsync(new GetGenreQuery(id), cancellationToken: cancellationToken);
        }
    }
}



