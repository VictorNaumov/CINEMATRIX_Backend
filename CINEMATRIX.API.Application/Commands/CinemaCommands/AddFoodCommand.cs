using AutoMapper;
using CINEMATRIX.API.Application.Commands.Abstractions;
using CINEMATRIX.API.Contracts.IncomingOutgoing;
using CINEMATRIX.Data.Domain.Models;
using CINEMATRIX.Data.Services;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace CINEMATRIX.API.Application.Commands.CinemaCommands
{
    public class AddCinemaCommand : CommandBase<long, CinemaDTO>
    {
        public AddCinemaCommand(CinemaDTO cinema) : base(cinema) { }
    }

    public class AddCinemaCommandHandler : IRequestHandler<AddCinemaCommand, long>
    {
        private readonly ICinemaService _cinemaService;
        private readonly IMapper _mapper;

        public AddCinemaCommandHandler(ICinemaService cinemaService, IMapper mapper)
        {
            _cinemaService = cinemaService;
            _mapper = mapper;
        }

        public async Task<long> Handle(AddCinemaCommand request, CancellationToken cancellationToken)
        {
            var cinema = _mapper.Map<Cinema>(request.Entity);

            var insertedCinema = await _cinemaService.InsertAsync(cinema);

            return insertedCinema.Id;
        }
    }
}
