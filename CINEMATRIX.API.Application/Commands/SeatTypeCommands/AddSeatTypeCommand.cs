using AutoMapper;
using CINEMATRIX.API.Application.Commands.Abstractions;
using CINEMATRIX.API.Contracts.IncomingOutgoing;
using CINEMATRIX.Data.Domain.Models;
using CINEMATRIX.Data.Services;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace CINEMATRIX.API.Application.Commands.SeatTypeCommands
{
    public class AddSeatTypeCommand : CommandBase<long, SeatTypeDTO>
    {
        public AddSeatTypeCommand(SeatTypeDTO seatType) : base(seatType) { }
    }

    public class AddSeatTypeCommandHandler : IRequestHandler<AddSeatTypeCommand, long>
    {
        private readonly ISeatTypeService _seatTypeService;
        private readonly IMapper _mapper;

        public AddSeatTypeCommandHandler(ISeatTypeService seatTypeService, IMapper mapper)
        {
            _seatTypeService = seatTypeService;
            _mapper = mapper;
        }

        public async Task<long> Handle(AddSeatTypeCommand request, CancellationToken cancellationToken)
        {
            var seatType = _mapper.Map<SeatType>(request.Entity);

            var insertedSeatType = await _seatTypeService.InsertAsync(seatType);

            return insertedSeatType.Id;
        }
    }
}
