using CINEMATRIX.API.Application.Commands.SeatTypeCommands;
using CINEMATRIX.API.Application.Queries.SeatTypeQueries;
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
    [Route("api/v{version:apiVersion}/seatType")]
    [ApiController]
    //[Authorize]
    public class SeatTypeController : MediatingControllerBase
    {
        public SeatTypeController(IMediator mediator) : base(mediator) { }

        [HttpPost("search")]
        [AllowAnonymous]
        [SwaggerResponse(StatusCodes.Status200OK, Type = typeof(PagedResponse<FoundSeatTypeDTO>))]
        [SwaggerOperation(Summary = "Search seat types", OperationId = "SearchSeatTypes")]
        public async Task<IActionResult> SearchSeatTypes([FromBody] SeatTypeSearchCondition searchCondition, CancellationToken cancellationToken = default)
        {
            return await ExecuteQueryAsync(new SearchSeatTypeQuery(searchCondition), cancellationToken: cancellationToken);
        }

        [HttpPost]
        [SwaggerResponse(StatusCodes.Status200OK, Type = typeof(long))]
        [SwaggerOperation(Summary = "Add a new seat type", OperationId = "AddSeatType")]
        public async Task<IActionResult> AddSeatType([FromBody] SeatTypeDTO seatType, CancellationToken cancellationToken = default)
        {
            return await ExecuteCommandAsync(new AddSeatTypeCommand(seatType), cancellationToken: cancellationToken);
        }

        [HttpDelete("{id}")]
        [SwaggerResponse(StatusCodes.Status200OK, Type = typeof(OkResult))]
        [SwaggerOperation(Summary = "Delete a seat type", OperationId = "DeleteSeatType")]
        public async Task<IActionResult> DeleteSeatType([FromRoute] long id, CancellationToken cancellationToken = default)
        {
            return await ExecuteCommandAsync(new DeleteSeatTypeCommand(id), cancellationToken: cancellationToken);
        }

        [HttpPut("{id}")]
        [SwaggerResponse(StatusCodes.Status200OK, Type = typeof(SeatTypeDTO))]
        [SwaggerOperation(Summary = "Update a seat type", OperationId = "UpdateSeatType")]
        public async Task<IActionResult> UpdateSeatType([FromRoute] long id, [FromBody] SeatTypeDTO seatType, CancellationToken cancellationToken = default)
        {
            return await ExecuteCommandAsync(new UpdateSeatTypeCommand(id, seatType), cancellationToken: cancellationToken);
        }

        [HttpGet("{id}")]
        [AllowAnonymous]
        [SwaggerResponse(StatusCodes.Status200OK, Type = typeof(SeatTypeDTO))]
        [SwaggerOperation(Summary = "Get the details of a seat type", OperationId = "GetSeatType")]
        public async Task<IActionResult> GetSeatType([FromRoute] long id, CancellationToken cancellationToken = default)
        {
            return await ExecuteQueryAsync(new GetSeatTypeQuery(id), cancellationToken: cancellationToken);
        }
    }
}



