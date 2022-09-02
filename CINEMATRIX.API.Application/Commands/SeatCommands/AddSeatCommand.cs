using AutoMapper;
using CINEMATRIX.API.Application.Commands.Abstractions;
using CINEMATRIX.API.Contracts.IncomingOutgoing;
using CINEMATRIX.Data.Domain.Models;
using CINEMATRIX.Data.Services;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace CINEMATRIX.API.Application.Commands.SeatCommands
{
    public class AddSeatCommand : CommandBase<long, SeatDTO>
    {
        public AddSeatCommand(SeatDTO seat) : base(seat) { }
    }

    public class AddSeatCommandHandler : IRequestHandler<AddSeatCommand, long>
    {
        private readonly ISeatService _seatService;
        private readonly IMapper _mapper;

        public AddSeatCommandHandler(ISeatService seatService, IMapper mapper)
        {
            _seatService = seatService;
            _mapper = mapper;
        }

        public async Task<long> Handle(AddSeatCommand request, CancellationToken cancellationToken)
        {
            var seat = _mapper.Map<Seat>(request.Entity);

            var insertedSeat = await _seatService.InsertAsync(seat);

            return insertedSeat.Id;
        }
    }
}
