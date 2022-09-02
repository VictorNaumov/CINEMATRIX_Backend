using CINEMATRIX.API.Application.Commands.ProfileCommands;
using CINEMATRIX.API.Application.Queries.ProfileQueries;
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
    public class ProfileController : MediatingControllerBase
    {
        public ProfileController(IMediator mediator) : base(mediator) { }

        [HttpPost]
        [SwaggerResponse(StatusCodes.Status200OK, Type = typeof(long))]
        [SwaggerOperation(Summary = "Add a new profile", OperationId = "AddProfile")]
        public async Task<IActionResult> AddProfile([FromBody] ProfileDTO profile, CancellationToken cancellationToken = default)
        {
            return await ExecuteCommandAsync(new AddProfileCommand(profile), cancellationToken: cancellationToken);
        }

        [HttpDelete("{id}")]
        [SwaggerResponse(StatusCodes.Status200OK, Type = typeof(OkResult))]
        [SwaggerOperation(Summary = "Delete a profile", OperationId = "DeleteProfile")]
        public async Task<IActionResult> DeleteProfile([FromRoute] long id, CancellationToken cancellationToken = default)
        {
            return await ExecuteCommandAsync(new DeleteProfileCommand(id), cancellationToken: cancellationToken);
        }

        [HttpPut("{id}")]
        [SwaggerResponse(StatusCodes.Status200OK, Type = typeof(ProfileDTO))]
        [SwaggerOperation(Summary = "Update a profile", OperationId = "UpdateProfile")]
        public async Task<IActionResult> UpdateProfile([FromRoute] long id, [FromBody] ProfileDTO profile, CancellationToken cancellationToken = default)
        {
            return await ExecuteCommandAsync(new UpdateProfileCommand(id, profile), cancellationToken: cancellationToken);
        }

        [HttpGet("{id}")]
        [AllowAnonymous]
        [SwaggerResponse(StatusCodes.Status200OK, Type = typeof(ProfileDTO))]
        [SwaggerOperation(Summary = "Get the details of a profile", OperationId = "GetProfile")]
        public async Task<IActionResult> GetProfile([FromRoute] long id, CancellationToken cancellationToken = default)
        {
            return await ExecuteQueryAsync(new GetProfileQuery(id), cancellationToken: cancellationToken);
        }
    }
}



