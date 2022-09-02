using CINEMATRIX.API.Application.Queries.MovieQueries;
using CINEMATRIX.API.Contracts.Incoming.SearchConditions;
using CINEMATRIX.API.Contracts.Outgoing.Abstractions;
using CINEMATRIX.API.Contracts.Outgoing.TMDB;
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
    [Route("api/v{version:apiVersion}/movie")]
    [ApiController]
    //[Authorize]
    public class MovieController : MediatingControllerBase
    {
        public MovieController(IMediator mediator) : base(mediator) { }


        //[HttpPost("search")]
        //[AllowAnonymous]
        //[SwaggerResponse(StatusCodes.Status200OK, Type = typeof(PagedResponse<FoundMovieDTO>))]
        //[SwaggerOperation(Summary = "Search genres", OperationId = "SearchMovies")]
        //public async Task<IActionResult> SearchMovies([FromBody] MovieSearchCondition searchCondition, CancellationToken cancellationToken = default)
        //{
        //    return await ExecuteQueryAsync(new SearchMovieQuery(searchCondition), cancellationToken: cancellationToken);
        //}

        [HttpGet("{id}")]
        [AllowAnonymous]
        [SwaggerResponse(StatusCodes.Status200OK, Type = typeof(FoundMovieDTO))]
        [SwaggerOperation(Summary = "Get the details of a movie", OperationId = "GetMovie")]
        public async Task<IActionResult> GetMovie([FromRoute] long id, CancellationToken cancellationToken = default)
        {
            return await ExecuteQueryAsync(new GetMovieQuery(id), cancellationToken: cancellationToken);
        }
    }
}



