using CINEMATRIX.API.Application.Queries.PersonQueries;
using CINEMATRIX.API.Contracts.Incoming.SearchConditions;
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
    [Route("api/v{version:apiVersion}/person")]
    [ApiController]
    //[Authorize]
    public class PersonСontroller : MediatingControllerBase
    {
        public PersonСontroller(IMediator mediator) : base(mediator) { }


        [HttpPost("popular")]
        [AllowAnonymous]
        [SwaggerResponse(StatusCodes.Status200OK, Type = typeof(PagedResponse<FoundPersonDTO>))]
        [SwaggerOperation(Summary = "Get popular people", OperationId = "GetPopularPeople")]
        public async Task<IActionResult> GetPopularPeople([FromBody] PersonSearchCondition searchCondition, CancellationToken cancellationToken = default)
        {
            return await ExecuteQueryAsync(new GetPopularPeopleQuery(searchCondition), cancellationToken: cancellationToken);
        }

        [HttpGet("{id}")]
        [AllowAnonymous]
        [SwaggerResponse(StatusCodes.Status200OK, Type = typeof(FoundPersonDTO))]
        [SwaggerOperation(Summary = "Get the details of a person", OperationId = "GetPerson")]
        public async Task<IActionResult> GetPerson([FromRoute] long id, CancellationToken cancellationToken = default)
        {
            return await ExecuteQueryAsync(new GetPersonQuery(id), cancellationToken: cancellationToken);
        }
    }
}



