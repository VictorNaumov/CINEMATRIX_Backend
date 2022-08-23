using CINEMATRIX.API.Application.Commands.PersonalDataCommands;
using CINEMATRIX.API.Application.Queries.PersonalDataQueries;
using CINEMATRIX.API.Contracts.IncomingOutgoing;
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
    [Route("api/v{version:apiVersion}/profile")]
    [ApiController]
    //[Authorize]
    public class PersonalDataController : MediatingControllerBase
    {
        public PersonalDataController(IMediator mediator) : base(mediator) { }

        [HttpPost]
        [SwaggerResponse(StatusCodes.Status200OK, Type = typeof(long))]
        [SwaggerOperation(Summary = "Add a new profile", OperationId = "AddProfile")]
        public async Task<IActionResult> AddPersonalData([FromBody] PersonalDataDTO personalData, CancellationToken cancellationToken = default)
        {
            return await ExecuteCommandAsync(new AddPersonalDataCommand(personalData), cancellationToken: cancellationToken);
        }

        [HttpDelete("{id}")]
        [SwaggerResponse(StatusCodes.Status200OK, Type = typeof(OkResult))]
        [SwaggerOperation(Summary = "Delete a profile", OperationId = "DeleteProfile")]
        public async Task<IActionResult> DeletePersonalData([FromRoute] long id, CancellationToken cancellationToken = default)
        {
            return await ExecuteCommandAsync(new DeletePersonalDataCommand(id), cancellationToken: cancellationToken);
        }

        [HttpPut("{id}")]
        [SwaggerResponse(StatusCodes.Status200OK, Type = typeof(PersonalDataDTO))]
        [SwaggerOperation(Summary = "Update a profile", OperationId = "UpdateProfile")]
        public async Task<IActionResult> UpdatePersonalData([FromRoute] long id, [FromBody] PersonalDataDTO personalData, CancellationToken cancellationToken = default)
        {
            return await ExecuteCommandAsync(new UpdatePersonalDataCommand(id, personalData), cancellationToken: cancellationToken);
        }

        [HttpGet("{id}")]
        [AllowAnonymous]
        [SwaggerResponse(StatusCodes.Status200OK, Type = typeof(PersonalDataDTO))]
        [SwaggerOperation(Summary = "Get the details of a profile", OperationId = "GetProfile")]
        public async Task<IActionResult> GetPersonalData([FromRoute] long id, CancellationToken cancellationToken = default)
        {
            return await ExecuteQueryAsync(new GetPersonalDataQuery(id), cancellationToken: cancellationToken);
        }
    }
}



