using CINEMATRIX.API.Application.Commands.FoodCommands;
using CINEMATRIX.API.Application.Queries.FoodQueries;
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
    [Route("api/v{version:apiVersion}/food")]
    [ApiController]
    //[Authorize]
    public class FoodController : MediatingControllerBase
    {
        public FoodController(IMediator mediator) : base(mediator) { }

        [HttpPost("search")]
        [AllowAnonymous]
        [SwaggerResponse(StatusCodes.Status200OK, Type = typeof(PagedResponse<FoundFoodDTO>))]
        [SwaggerOperation(Summary = "Search foods", OperationId = "SearchFoods")]
        public async Task<IActionResult> SearchFoods([FromBody] FoodSearchCondition searchCondition, CancellationToken cancellationToken = default)
        {
            return await ExecuteQueryAsync(new SearchFoodQuery(searchCondition), cancellationToken: cancellationToken);
        }

        [HttpPost]
        [SwaggerResponse(StatusCodes.Status200OK, Type = typeof(long))]
        [SwaggerOperation(Summary = "Add a new food", OperationId = "AddFood")]
        public async Task<IActionResult> AddFood([FromBody] FoodDTO food, CancellationToken cancellationToken = default)
        {
            return await ExecuteCommandAsync(new AddFoodCommand(food), cancellationToken: cancellationToken);
        }

        [HttpDelete("{id}")]
        [SwaggerResponse(StatusCodes.Status200OK, Type = typeof(OkResult))]
        [SwaggerOperation(Summary = "Delete a food", OperationId = "DeleteFood")]
        public async Task<IActionResult> DeleteFood([FromRoute] long id, CancellationToken cancellationToken = default)
        {
            return await ExecuteCommandAsync(new DeleteFoodCommand(id), cancellationToken: cancellationToken);
        }

        [HttpPut("{id}")]
        [SwaggerResponse(StatusCodes.Status200OK, Type = typeof(FoodDTO))]
        [SwaggerOperation(Summary = "Update a food", OperationId = "UpdateFood")]
        public async Task<IActionResult> UpdateFood([FromRoute] long id, [FromBody] FoodDTO food, CancellationToken cancellationToken = default)
        {
            return await ExecuteCommandAsync(new UpdateFoodCommand(id, food), cancellationToken: cancellationToken);
        }

        [HttpGet("{id}")]
        [AllowAnonymous]
        [SwaggerResponse(StatusCodes.Status200OK, Type = typeof(FoodDTO))]
        [SwaggerOperation(Summary = "Get the details of a food", OperationId = "GetFood")]
        public async Task<IActionResult> GetFood([FromRoute] long id, CancellationToken cancellationToken = default)
        {
            return await ExecuteQueryAsync(new GetFoodQuery(id), cancellationToken: cancellationToken);
        }
    }
}



