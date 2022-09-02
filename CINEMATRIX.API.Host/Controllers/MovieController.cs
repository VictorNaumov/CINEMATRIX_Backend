using CINEMATRIX.API.Application.Queries.MovieQueries;
using CINEMATRIX.API.Contracts.Incoming.SearchConditions;
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
    [Route("api/v{version:apiVersion}/movie")]
    [ApiController]
    //[Authorize]
    public class MovieController : MediatingControllerBase
    {
        public MovieController(IMediator mediator) : base(mediator) { }

        [HttpGet("{id}")]
        [AllowAnonymous]
        [SwaggerResponse(StatusCodes.Status200OK, Type = typeof(FoundMovieDTO))]
        [SwaggerOperation(Summary = "Get the details of a movie", OperationId = "GetMovie")]
        public async Task<IActionResult> GetMovie([FromRoute] long id, CancellationToken cancellationToken = default)
        {
            return await ExecuteQueryAsync(new GetMovieDetailsQuery(id), cancellationToken: cancellationToken);
        }

        [HttpPost("{id}/similar")]
        [AllowAnonymous]
        [SwaggerResponse(StatusCodes.Status200OK, Type = typeof(FoundMovieDTO))]
        [SwaggerOperation(Summary = "Get the similars a movies", OperationId = "GetSimilarMovies")]
        public async Task<IActionResult> GetSimilarMovies([FromRoute] long id, [FromBody] MovieSearchCondition searchCondition, CancellationToken cancellationToken = default)
        {
            return await ExecuteQueryAsync(new GetSimilarMoviesQuery(id, searchCondition), cancellationToken: cancellationToken);
        }

        [HttpPost("topRated")]
        [AllowAnonymous]
        [SwaggerResponse(StatusCodes.Status200OK, Type = typeof(FoundMovieDTO))]
        [SwaggerOperation(Summary = "Get a top rated movies", OperationId = "GetTopRatedMovies")]
        public async Task<IActionResult> GetTopRatedMovies([FromBody] MovieSearchCondition searchCondition, CancellationToken cancellationToken = default)
        {
            return await ExecuteQueryAsync(new GetTopRatedMoviesQuery(searchCondition), cancellationToken: cancellationToken);
        }

        [HttpPost("nowPlaying")]
        [AllowAnonymous]
        [SwaggerResponse(StatusCodes.Status200OK, Type = typeof(FoundMovieDTO))]
        [SwaggerOperation(Summary = "Get a now playing movies", OperationId = "GetNowPlayingMovies")]
        public async Task<IActionResult> GetNowPlayingMovies([FromBody] MovieSearchCondition searchCondition, CancellationToken cancellationToken = default)
        {
            return await ExecuteQueryAsync(new GetNowPlayingMoviesQuery(searchCondition), cancellationToken: cancellationToken);
        }

        [HttpPost("search")]
        [AllowAnonymous]
        [SwaggerResponse(StatusCodes.Status200OK, Type = typeof(FoundMovieDTO))]
        [SwaggerOperation(Summary = "Search movies", OperationId = "SearchMovies")]
        public async Task<IActionResult> SearchMovies([FromBody] MovieSearchCondition searchCondition, CancellationToken cancellationToken = default)
        {
            return await ExecuteQueryAsync(new SearchMoviesQuery(searchCondition), cancellationToken: cancellationToken);
        }
    }
}



