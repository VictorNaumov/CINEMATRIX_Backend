using AutoMapper;
using CINEMATRIX.API.Application.Commands.Abstractions;
using CINEMATRIX.API.Contracts.IncomingOutgoing;
using CINEMATRIX.API.Contracts.Outgoing.Abstractions;
using CINEMATRIX.Data.Domain.Models;
using CINEMATRIX.Data.Services;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace CINEMATRIX.API.Application.Commands.CinemaCommands
{
    public class UpdateCinemaCommand : CommandBase<Response, CinemaDTO>
    {
        public UpdateCinemaCommand(long id, CinemaDTO update) : base(id, update) { }
    }

    public class UpdateCinemaCommandHandler : IRequestHandler<UpdateCinemaCommand, Response>
    {
        private readonly ICinemaService _cinemaService;
        private readonly IMapper _mapper;

        public UpdateCinemaCommandHandler(ICinemaService cinemaService, IMapper mapper)
        {
            _cinemaService = cinemaService;
            _mapper = mapper;
        }

        public async Task<Response> Handle(UpdateCinemaCommand request, CancellationToken cancellationToken)
        {
            var cinema = await _cinemaService.GetByIdAsync(request.Id, cancellationToken);

            if (cinema == null)
            {
                return Response.Error;
            }

            var cinemaToUpdate = _mapper.Map<Cinema>(cinema);

            var updatedCinema = await _cinemaService.UpdateAsync(cinemaToUpdate);

            if (updatedCinema == null)
            {
                return Response.Error;
            }

            return Response.Successful;
        }
    }
}
