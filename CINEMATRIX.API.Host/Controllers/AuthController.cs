using CINEMATRIX.API.Application.Commands.AuthCommands;
using CINEMATRIX.API.Application.Queries.AuthQueries;
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
    [Route("api/v{version:apiVersion}/auth")]
    [ApiController]
    public class AuthController : MediatingControllerBase
    {
        public AuthController(IMediator mediator) : base(mediator)
        { }

        [HttpPost("login")]
        [AllowAnonymous]
        [SwaggerResponse(StatusCodes.Status200OK, Type = typeof(LoginUserDTO))]
        [SwaggerOperation(Summary = "Login", OperationId = "Login")]
        public async Task<IActionResult> Login([FromBody] LoginDTO user, CancellationToken cancellationToken = default)
        {
            return await ExecuteQueryAsync(new LoginUserQuery(user), cancellationToken: cancellationToken);
        }

        [HttpGet("whoami")]
        [AllowAnonymous]
        [SwaggerResponse(StatusCodes.Status200OK, Type = typeof(FoundUserDTO))]
        [SwaggerOperation(Summary = "GetCurrentUser", OperationId = "GetCurrentUser")]
        public async Task<IActionResult> GetCurrentUser(CancellationToken cancellationToken = default)
        {
            return await ExecuteQueryAsync(new GetCurrentUserQuery(User.Identity.Name), cancellationToken: cancellationToken);
        }

        [HttpPost("register")]
        [AllowAnonymous]
        [SwaggerResponse(StatusCodes.Status200OK, Type = typeof(LoginUserDTO))]
        [SwaggerOperation(Summary = "Register", OperationId = "Register")]
        public async Task<IActionResult> Register([FromBody] UserDTO user, CancellationToken cancellationToken = default)
        {
            return await ExecuteQueryAsync(new RegisterUserCommand(user), cancellationToken: cancellationToken);
        }

        [HttpPost("sendEmailConfirmation")]
        [AllowAnonymous]
        [SwaggerResponse(StatusCodes.Status200OK, Type = typeof(bool))]
        [SwaggerOperation(Summary = "SendEmailConfirmation", OperationId = "SendEmailConfirmation")]
        public async Task<IActionResult> SendEmailConfirmation(CancellationToken cancellationToken = default)
        {
            return await ExecuteQueryAsync(new SendEmailConfirmationCommand(User.Identity.Name), cancellationToken: cancellationToken);
        }

        [HttpGet("confirmEmail")]
        [AllowAnonymous]
        [SwaggerResponse(StatusCodes.Status200OK, Type = typeof(string))]
        [SwaggerOperation(Summary = "ConfirmEmail", OperationId = "ConfirmEmail")]
        public async Task<IActionResult> ConfirmEmail([FromQuery] long userId, [FromQuery] string token, CancellationToken cancellationToken = default)
        {
            return await ExecuteQueryAsync(new ConfirmEmailQuery(new ConfirmEmailDTO() { UserId = userId, Token = token }), cancellationToken: cancellationToken);
        }
    }
}
