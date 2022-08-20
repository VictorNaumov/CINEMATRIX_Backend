using CINEMATRIX.API.Application.Commands.SessionCommands;
using CINEMATRIX.API.Application.Queries.SessionQueries;
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
    [Route("api/v{version:apiVersion}/session")]
    [ApiController]
    //[Authorize]
    public class SessionController : MediatingControllerBase
    {
        public SessionController(IMediator mediator) : base(mediator) { }

        [HttpPost("search")]
        [AllowAnonymous]
        [SwaggerResponse(StatusCodes.Status200OK, Type = typeof(PagedResponse<FoundSessionDTO>))]
        [SwaggerOperation(Summary = "Search sessions", OperationId = "SearchSessions")]
        public async Task<IActionResult> SearchSessions([FromBody] SessionSearchCondition searchCondition, CancellationToken cancellationToken = default)
        {
            return await ExecuteQueryAsync(new SearchSessionQuery(searchCondition), cancellationToken: cancellationToken);
        }

        [HttpPost]
        [SwaggerResponse(StatusCodes.Status200OK, Type = typeof(long))]
        [SwaggerOperation(Summary = "Add a new session", OperationId = "AddSession")]
        public async Task<IActionResult> AddSession([FromBody] SessionDTO session, CancellationToken cancellationToken = default)
        {
            return await ExecuteCommandAsync(new AddSessionCommand(session), cancellationToken: cancellationToken);
        }

        [HttpDelete("{id}")]
        [SwaggerResponse(StatusCodes.Status200OK, Type = typeof(OkResult))]
        [SwaggerOperation(Summary = "Delete a session", OperationId = "DeleteSession")]
        public async Task<IActionResult> DeleteSession([FromRoute] long id, CancellationToken cancellationToken = default)
        {
            return await ExecuteCommandAsync(new DeleteSessionCommand(id), cancellationToken: cancellationToken);
        }

        [HttpPut("{id}")]
        [SwaggerResponse(StatusCodes.Status200OK, Type = typeof(SessionDTO))]
        [SwaggerOperation(Summary = "Update a session", OperationId = "UpdateSession")]
        public async Task<IActionResult> UpdateSession([FromRoute] long id, [FromBody] SessionDTO session, CancellationToken cancellationToken = default)
        {
            return await ExecuteCommandAsync(new UpdateSessionCommand(id, session), cancellationToken: cancellationToken);
        }

        [HttpGet("{id}")]
        [AllowAnonymous]
        [SwaggerResponse(StatusCodes.Status200OK, Type = typeof(SessionDTO))]
        [SwaggerOperation(Summary = "Get the details of a session", OperationId = "GetSession")]
        public async Task<IActionResult> GetSession([FromRoute] long id, CancellationToken cancellationToken = default)
        {
            return await ExecuteQueryAsync(new GetSessionQuery(id), cancellationToken: cancellationToken);
        }
    }
}



