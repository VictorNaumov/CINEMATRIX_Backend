using CINEMATRIX.API.Application.Commands.TicketCommands;
using CINEMATRIX.API.Application.Queries.TicketQueries;
using CINEMATRIX.API.Contracts.IncomingOutgoing;
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
    [Route("api/v{version:apiVersion}/ticket")]
    [ApiController]
    [Authorize]
    public class TicketController : MediatingControllerBase
    {
        public TicketController(IMediator mediator) : base(mediator) { }

        [HttpPost]
        [SwaggerResponse(StatusCodes.Status200OK, Type = typeof(long))]
        [SwaggerOperation(Summary = "Add a new ticket", OperationId = "AddTicket")]
        public async Task<IActionResult> AddTicket([FromBody] TicketDTO ticket, CancellationToken cancellationToken = default)
        {
            return await ExecuteCommandAsync(new AddTicketCommand(ticket, User.Identity.Name), cancellationToken: cancellationToken);
        }

        [HttpDelete("{id}")]
        [SwaggerResponse(StatusCodes.Status200OK, Type = typeof(OkResult))]
        [SwaggerOperation(Summary = "Delete a ticket", OperationId = "DeleteTicket")]
        public async Task<IActionResult> DeleteTicket([FromRoute] long id, CancellationToken cancellationToken = default)
        {
            return await ExecuteCommandAsync(new DeleteTicketCommand(id), cancellationToken: cancellationToken);
        }

        [HttpPut("{id}")]
        [SwaggerResponse(StatusCodes.Status200OK, Type = typeof(TicketDTO))]
        [SwaggerOperation(Summary = "Update a ticket", OperationId = "UpdateTicket")]
        public async Task<IActionResult> UpdateTicket([FromRoute] long id, [FromBody] TicketDTO ticket, CancellationToken cancellationToken = default)
        {
            return await ExecuteCommandAsync(new UpdateTicketCommand(id, ticket), cancellationToken: cancellationToken);
        }

        [HttpGet("{id}")]
        [AllowAnonymous]
        [SwaggerResponse(StatusCodes.Status200OK, Type = typeof(TicketDTO))]
        [SwaggerOperation(Summary = "Get the details of a ticket", OperationId = "GetTicket")]
        public async Task<IActionResult> GetTicket([FromRoute] long id, CancellationToken cancellationToken = default)
        {
            return await ExecuteQueryAsync(new GetTicketQuery(id), cancellationToken: cancellationToken);
        }

        [HttpGet("getBySessionId/{sessionId}")]
        [AllowAnonymous]
        [SwaggerResponse(StatusCodes.Status200OK, Type = typeof(FoundTicketDTO))]
        [SwaggerOperation(Summary = "Get the a tickets by session id", OperationId = "GetTicketsBySessionId")]
        public async Task<IActionResult> GetTicketsBySessionId([FromRoute] long sessionId, CancellationToken cancellationToken = default)
        {
            return await ExecuteQueryAsync(new GetTicketsBySessionIdQuery(sessionId), cancellationToken: cancellationToken);
        }
    }
}



