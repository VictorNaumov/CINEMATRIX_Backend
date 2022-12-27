using CINEMATRIX.API.Application.Commands.FAQCommands;
using CINEMATRIX.API.Application.Queries.FAQQueries;
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
    [Route("api/v{version:apiVersion}/faq")]
    [ApiController]
    //[Authorize]
    public class FAQController : MediatingControllerBase
    {
        public FAQController(IMediator mediator) : base(mediator) { }

        [HttpPost("search")]
        [AllowAnonymous]
        [SwaggerResponse(StatusCodes.Status200OK, Type = typeof(PagedResponse<FoundFAQDTO>))]
        [SwaggerOperation(Summary = "Search faqs", OperationId = "SearchFAQs")]
        public async Task<IActionResult> SearchFAQs([FromBody] FAQSearchCondition searchCondition, CancellationToken cancellationToken = default)
        {
            return await ExecuteQueryAsync(new SearchFAQQuery(searchCondition), cancellationToken: cancellationToken);
        }

        [HttpPost]
        [SwaggerResponse(StatusCodes.Status200OK, Type = typeof(long))]
        [SwaggerOperation(Summary = "Add a new faq", OperationId = "AddFAQ")]
        public async Task<IActionResult> AddFAQ([FromBody] FAQDTO faq, CancellationToken cancellationToken = default)
        {
            return await ExecuteCommandAsync(new AddFAQCommand(faq), cancellationToken: cancellationToken);
        }

        [HttpDelete("{id}")]
        [SwaggerResponse(StatusCodes.Status200OK, Type = typeof(OkResult))]
        [SwaggerOperation(Summary = "Delete a faq", OperationId = "DeleteFAQ")]
        public async Task<IActionResult> DeleteFAQ([FromRoute] long id, CancellationToken cancellationToken = default)
        {
            return await ExecuteCommandAsync(new DeleteFAQCommand(id), cancellationToken: cancellationToken);
        }

        [HttpPut("{id}")]
        [SwaggerResponse(StatusCodes.Status200OK, Type = typeof(FAQDTO))]
        [SwaggerOperation(Summary = "Update a faq", OperationId = "UpdateFAQ")]
        public async Task<IActionResult> UpdateFAQ([FromRoute] long id, [FromBody] FAQDTO faq, CancellationToken cancellationToken = default)
        {
            return await ExecuteCommandAsync(new UpdateFAQCommand(id, faq), cancellationToken: cancellationToken);
        }

        [HttpGet("{id}")]
        [AllowAnonymous]
        [SwaggerResponse(StatusCodes.Status200OK, Type = typeof(FAQDTO))]
        [SwaggerOperation(Summary = "Get the details of a faq", OperationId = "GetFAQ")]
        public async Task<IActionResult> GetFAQ([FromRoute] long id, CancellationToken cancellationToken = default)
        {
            return await ExecuteQueryAsync(new GetFAQQuery(id), cancellationToken: cancellationToken);
        }
    }
}



