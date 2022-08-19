using CINEMATRIX.API.Application.Commands.AuthCommands;
using CINEMATRIX.API.Contracts.IncomingOutgoing;
using CINEMATRIX.API.Contracts.Outgoing;
using CINEMATRIX.API.Host.Controllers.Abstractions;
using ComputerTechnicianBackend.API.Application.Queries.AuthQueries;
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
    [Route("api/v{version:apiVersion}/auth")]
    [ApiController]
    public class AdminController : MediatingControllerBase
    {
        public AdminController(IMediator mediator) : base(mediator)
        { }

        [HttpPost("login")]
        [AllowAnonymous]
        [SwaggerResponse(StatusCodes.Status200OK, Type = typeof(LoginUserDTO))]
        [SwaggerOperation(Summary = "Login", OperationId = "Login")]
        public async Task<IActionResult> Login([FromBody] LoginDTO user, CancellationToken cancellationToken = default)
        {
            return await ExecuteQueryAsync(new LoginUserQuery(user), cancellationToken: cancellationToken);
        }

        [HttpPost("register")]
        [AllowAnonymous]
        [SwaggerResponse(StatusCodes.Status200OK, Type = typeof(bool))]
        [SwaggerOperation(Summary = "Register", OperationId = "Register")]
        public async Task<IActionResult> Register([FromBody] UserDTO user, CancellationToken cancellationToken = default)
        {
            return await ExecuteQueryAsync(new RegisterUserCommand(user), cancellationToken: cancellationToken);
        }
    }
}
