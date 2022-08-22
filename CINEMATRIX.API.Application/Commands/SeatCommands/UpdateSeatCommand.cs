using AutoMapper;
using CINEMATRIX.API.Application.Commands.Abstractions;
using CINEMATRIX.API.Contracts.IncomingOutgoing;
using CINEMATRIX.API.Contracts.Outgoing.Abstractions;
using CINEMATRIX.Data.Domain.Models;
using CINEMATRIX.Data.Services;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace CINEMATRIX.API.Application.Commands.SeatCommands
{
    public class UpdateSeatCommand : CommandBase<Response, SeatDTO>
    {
        public UpdateSeatCommand(long id, SeatDTO update) : base(id, update) { }
    }

    public class UpdateSeatCommandHandler : IRequestHandler<UpdateSeatCommand, Response>
    {
        private readonly ISeatService _seatService;
        private readonly IMapper _mapper;

        public UpdateSeatCommandHandler(ISeatService seatService, IMapper mapper)
        {
            _seatService = seatService;
            _mapper = mapper;
        }

        public async Task<Response> Handle(UpdateSeatCommand request, CancellationToken cancellationToken)
        {
            var seat = await _seatService.GetAsync(request.Id, cancellationToken);

            if (seat == null)
            {
                return Response.Error;
            }

            var seatToUpdate = _mapper.Map<Seat>(seat);

            var updatedSeat = await _seatService.UpdateAsync(seatToUpdate);

            if (updatedSeat == null)
            {
                return Response.Error;
            }

            return Response.Successful;
        }
    }
}
