using CINEMATRIX.API.Application.Commands.SeatCommands;
using CINEMATRIX.API.Application.Queries.SeatQueries;
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
    [Route("api/v{version:apiVersion}/seat")]
    [ApiController]
    //[Authorize]
    public class SeatController : MediatingControllerBase
    {
        public SeatController(IMediator mediator) : base(mediator) { }

        [HttpPost("search")]
        [AllowAnonymous]
        [SwaggerResponse(StatusCodes.Status200OK, Type = typeof(PagedResponse<FoundSeatDTO>))]
        [SwaggerOperation(Summary = "Search seat types", OperationId = "SearchSeats")]
        public async Task<IActionResult> SearchSeats([FromBody] SeatSearchCondition searchCondition, CancellationToken cancellationToken = default)
        {
            return await ExecuteQueryAsync(new SearchSeatQuery(searchCondition), cancellationToken: cancellationToken);
        }

        [HttpPost]
        [SwaggerResponse(StatusCodes.Status200OK, Type = typeof(long))]
        [SwaggerOperation(Summary = "Add a new seat type", OperationId = "AddSeat")]
        public async Task<IActionResult> AddSeat([FromBody] SeatDTO seat, CancellationToken cancellationToken = default)
        {
            return await ExecuteCommandAsync(new AddSeatCommand(seat), cancellationToken: cancellationToken);
        }

        [HttpDelete("{id}")]
        [SwaggerResponse(StatusCodes.Status200OK, Type = typeof(OkResult))]
        [SwaggerOperation(Summary = "Delete a seat type", OperationId = "DeleteSeat")]
        public async Task<IActionResult> DeleteSeat([FromRoute] long id, CancellationToken cancellationToken = default)
        {
            return await ExecuteCommandAsync(new DeleteSeatCommand(id), cancellationToken: cancellationToken);
        }

        [HttpPut("{id}")]
        [SwaggerResponse(StatusCodes.Status200OK, Type = typeof(SeatDTO))]
        [SwaggerOperation(Summary = "Update a seat type", OperationId = "UpdateSeat")]
        public async Task<IActionResult> UpdateSeat([FromRoute] long id, [FromBody] SeatDTO seat, CancellationToken cancellationToken = default)
        {
            return await ExecuteCommandAsync(new UpdateSeatCommand(id, seat), cancellationToken: cancellationToken);
        }

        [HttpGet("{id}")]
        [AllowAnonymous]
        [SwaggerResponse(StatusCodes.Status200OK, Type = typeof(SeatDTO))]
        [SwaggerOperation(Summary = "Get the details of a seat type", OperationId = "GetSeat")]
        public async Task<IActionResult> GetSeat([FromRoute] long id, CancellationToken cancellationToken = default)
        {
            return await ExecuteQueryAsync(new GetSeatQuery(id), cancellationToken: cancellationToken);
        }
    }
}



