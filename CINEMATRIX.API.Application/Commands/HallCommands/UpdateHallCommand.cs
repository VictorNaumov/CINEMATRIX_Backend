using AutoMapper;
using CINEMATRIX.API.Application.Commands.Abstractions;
using CINEMATRIX.API.Contracts.IncomingOutgoing;
using CINEMATRIX.API.Contracts.Outgoing.Abstractions;
using CINEMATRIX.Data.Domain.Models;
using CINEMATRIX.Data.Services;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace CINEMATRIX.API.Application.Commands.HallCommands
{
    public class UpdateHallCommand : CommandBase<Response, HallDTO>
    {
        public UpdateHallCommand(long id, HallDTO update) : base(id, update) { }
    }

    public class UpdateHallCommandHandler : IRequestHandler<UpdateHallCommand, Response>
    {
        private readonly IHallService _hallService;
        private readonly IMapper _mapper;

        public UpdateHallCommandHandler(IHallService hallService, IMapper mapper)
        {
            _hallService = hallService;
            _mapper = mapper;
        }

        public async Task<Response> Handle(UpdateHallCommand request, CancellationToken cancellationToken)
        {
            var hall = await _hallService.GetAsync(request.Id, cancellationToken);

            if (hall == null)
            {
                return Response.Error;
            }

            var hallToUpdate = _mapper.Map<Hall>(hall);

            var updatedHall = await _hallService.UpdateAsync(hallToUpdate);

            if (updatedHall == null)
            {
                return Response.Error;
            }

            return Response.Successful;
        }
    }
}
