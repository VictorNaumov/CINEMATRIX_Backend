using CINEMATRIX.API.Application.Commands.CinemaCommands;
using CINEMATRIX.API.Application.Queries.CinemaQueries;
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
    [Route("api/v{version:apiVersion}/cinema")]
    [ApiController]
    //[Authorize]
    public class CinemaController : MediatingControllerBase
    {
        public CinemaController(IMediator mediator) : base(mediator) { }

        [HttpPost("search")]
        [AllowAnonymous]
        [SwaggerResponse(StatusCodes.Status200OK, Type = typeof(PagedResponse<FoundCinemaDTO>))]
        [SwaggerOperation(Summary = "Search cinemas", OperationId = "SearchCinemas")]
        public async Task<IActionResult> SearchCinemas([FromBody] CinemaSearchCondition searchCondition, CancellationToken cancellationToken = default)
        {
            return await ExecuteQueryAsync(new SearchCinemaQuery(searchCondition), cancellationToken: cancellationToken);
        }

        [HttpPost]
        [SwaggerResponse(StatusCodes.Status200OK, Type = typeof(long))]
        [SwaggerOperation(Summary = "Add a new cinema", OperationId = "AddCinema")]
        public async Task<IActionResult> AddCinema([FromBody] CinemaDTO cinema, CancellationToken cancellationToken = default)
        {
            return await ExecuteCommandAsync(new AddCinemaCommand(cinema), cancellationToken: cancellationToken);
        }

        [HttpDelete("{id}")]
        [SwaggerResponse(StatusCodes.Status200OK, Type = typeof(OkResult))]
        [SwaggerOperation(Summary = "Delete a cinema", OperationId = "DeleteCinema")]
        public async Task<IActionResult> DeleteCinema([FromRoute] long id, CancellationToken cancellationToken = default)
        {
            return await ExecuteCommandAsync(new DeleteCinemaCommand(id), cancellationToken: cancellationToken);
        }

        [HttpPut("{id}")]
        [SwaggerResponse(StatusCodes.Status200OK, Type = typeof(CinemaDTO))]
        [SwaggerOperation(Summary = "Update a cinema", OperationId = "UpdateCinema")]
        public async Task<IActionResult> UpdateCinema([FromRoute] long id, [FromBody] CinemaDTO cinema, CancellationToken cancellationToken = default)
        {
            return await ExecuteCommandAsync(new UpdateCinemaCommand(id, cinema), cancellationToken: cancellationToken);
        }

        [HttpGet("{id}")]
        [AllowAnonymous]
        [SwaggerResponse(StatusCodes.Status200OK, Type = typeof(CinemaDTO))]
        [SwaggerOperation(Summary = "Get the details of a cinema", OperationId = "GetCinema")]
        public async Task<IActionResult> GetCinema([FromRoute] long id, CancellationToken cancellationToken = default)
        {
            return await ExecuteQueryAsync(new GetCinemaQuery(id), cancellationToken: cancellationToken);
        }
    }
}



