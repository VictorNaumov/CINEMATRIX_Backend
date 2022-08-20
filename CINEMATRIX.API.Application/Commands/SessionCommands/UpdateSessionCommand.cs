using AutoMapper;
using CINEMATRIX.API.Application.Commands.Abstractions;
using CINEMATRIX.API.Contracts.IncomingOutgoing;
using CINEMATRIX.API.Contracts.Outgoing.Abstractions;
using CINEMATRIX.Data.Domain.Models;
using CINEMATRIX.Data.Services;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace CINEMATRIX.API.Application.Commands.SessionCommands
{
    public class UpdateSessionCommand : CommandBase<Response, SessionDTO>
    {
        public UpdateSessionCommand(long id, SessionDTO update) : base(id, update) { }
    }

    public class UpdateSessionCommandHandler : IRequestHandler<UpdateSessionCommand, Response>
    {
        private readonly ISessionService _sessionService;
        private readonly IMapper _mapper;

        public UpdateSessionCommandHandler(ISessionService sessionService, IMapper mapper)
        {
            _sessionService = sessionService;
            _mapper = mapper;
        }

        public async Task<Response> Handle(UpdateSessionCommand request, CancellationToken cancellationToken)
        {
            var session = await _sessionService.GetAsync(request.Id, cancellationToken);

            if (session == null)
            {
                return Response.Error;
            }

            var sessionToUpdate = _mapper.Map<Session>(session);

            var updatedSession = await _sessionService.UpdateAsync(sessionToUpdate);

            if (updatedSession == null)
            {
                return Response.Error;
            }

            return Response.Successful;
        }
    }
}
