using AutoMapper;
using CINEMATRIX.API.Application.Commands.Abstractions;
using CINEMATRIX.API.Contracts.IncomingOutgoing;
using CINEMATRIX.Data.Domain.Models;
using CINEMATRIX.Data.Services;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace CINEMATRIX.API.Application.Commands.HallCommands
{
    public class AddHallCommand : CommandBase<long, HallDTO>
    {
        public AddHallCommand(HallDTO hall) : base(hall) { }
    }

    public class AddHallCommandHandler : IRequestHandler<AddHallCommand, long>
    {
        private readonly IHallService _hallService;
        private readonly IMapper _mapper;

        public AddHallCommandHandler(IHallService hallService, IMapper mapper)
        {
            _hallService = hallService;
            _mapper = mapper;
        }

        public async Task<long> Handle(AddHallCommand request, CancellationToken cancellationToken)
        {
            var hall = _mapper.Map<Hall>(request.Entity);

            var insertedProduct = await _hallService.InsertAsync(hall);

            return insertedProduct.Id;
        }
    }
}
