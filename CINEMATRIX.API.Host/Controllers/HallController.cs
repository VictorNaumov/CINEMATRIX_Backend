using CINEMATRIX.API.Application.Commands.HallCommands;
using CINEMATRIX.API.Application.Queries.HallQueries;
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
    [Route("api/v{version:apiVersion}/hall")]
    [ApiController]
    //[Authorize]
    public class HallController : MediatingControllerBase
    {
        public HallController(IMediator mediator) : base(mediator) { }

        [HttpPost("search")]
        [AllowAnonymous]
        [SwaggerResponse(StatusCodes.Status200OK, Type = typeof(PagedResponse<FoundHallDTO>))]
        [SwaggerOperation(Summary = "Search halls", OperationId = "SearchHalls")]
        public async Task<IActionResult> SearchHalls([FromBody] HallSearchCondition searchCondition, CancellationToken cancellationToken = default)
        {
            return await ExecuteQueryAsync(new SearchHallQuery(searchCondition), cancellationToken: cancellationToken);
        }

        [HttpPost]
        [SwaggerResponse(StatusCodes.Status200OK, Type = typeof(long))]
        [SwaggerOperation(Summary = "Add a new hall", OperationId = "AddHall")]
        public async Task<IActionResult> AddHall([FromBody] HallDTO hall, CancellationToken cancellationToken = default)
        {
            return await ExecuteCommandAsync(new AddHallCommand(hall), cancellationToken: cancellationToken);
        }

        [HttpDelete("{id}")]
        [SwaggerResponse(StatusCodes.Status200OK, Type = typeof(OkResult))]
        [SwaggerOperation(Summary = "Delete a hall", OperationId = "DeleteHall")]
        public async Task<IActionResult> DeleteHall([FromRoute] long id, CancellationToken cancellationToken = default)
        {
            return await ExecuteCommandAsync(new DeleteHallCommand(id), cancellationToken: cancellationToken);
        }

        [HttpPut("{id}")]
        [SwaggerResponse(StatusCodes.Status200OK, Type = typeof(HallDTO))]
        [SwaggerOperation(Summary = "Update a hall", OperationId = "UpdateHall")]
        public async Task<IActionResult> UpdateHall([FromRoute] long id, [FromBody] HallDTO hall, CancellationToken cancellationToken = default)
        {
            return await ExecuteCommandAsync(new UpdateHallCommand(id, hall), cancellationToken: cancellationToken);
        }

        [HttpGet("{id}")]
        [AllowAnonymous]
        [SwaggerResponse(StatusCodes.Status200OK, Type = typeof(HallDTO))]
        [SwaggerOperation(Summary = "Get the details of a hall", OperationId = "GetHall")]
        public async Task<IActionResult> GetHall([FromRoute] long id, CancellationToken cancellationToken = default)
        {
            return await ExecuteQueryAsync(new GetHallQuery(id), cancellationToken: cancellationToken);
        }
    }
}



