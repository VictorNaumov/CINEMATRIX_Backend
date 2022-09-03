using AutoMapper;
using CINEMATRIX.API.Application.Commands.Abstractions;
using CINEMATRIX.API.Contracts.IncomingOutgoing;
using CINEMATRIX.API.Contracts.Outgoing.Abstractions;
using CINEMATRIX.Data.Domain.Models;
using CINEMATRIX.Data.Services;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace CINEMATRIX.API.Application.Commands.SeatTypeCommands
{
    public class UpdateSeatTypeCommand : CommandBase<Response, SeatTypeDTO>
    {
        public UpdateSeatTypeCommand(long id, SeatTypeDTO update) : base(id, update) { }
    }

    public class UpdateSeatTypeCommandHandler : IRequestHandler<UpdateSeatTypeCommand, Response>
    {
        private readonly ISeatTypeService _seatTypeService;
        private readonly IMapper _mapper;

        public UpdateSeatTypeCommandHandler(ISeatTypeService seatTypeService, IMapper mapper)
        {
            _seatTypeService = seatTypeService;
            _mapper = mapper;
        }

        public async Task<Response> Handle(UpdateSeatTypeCommand request, CancellationToken cancellationToken)
        {
            var seatType = await _seatTypeService.GetByIdAsync(request.Id, cancellationToken);

            if (seatType == null)
            {
                return Response.Error;
            }

            var seatTypeToUpdate = _mapper.Map<SeatType>(seatType);

            var updatedSeatType = await _seatTypeService.UpdateAsync(seatTypeToUpdate);

            if (updatedSeatType == null)
            {
                return Response.Error;
            }

            return Response.Successful;
        }
    }
}
