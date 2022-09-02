using AutoMapper;
using CINEMATRIX.API.Application.Commands.Abstractions;
using CINEMATRIX.API.Contracts.IncomingOutgoing;
using CINEMATRIX.Data.Domain.Models;
using CINEMATRIX.Data.Services;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace CINEMATRIX.API.Application.Commands.SessionCommands
{
    public class AddSessionCommand : CommandBase<long, SessionDTO>
    {
        public AddSessionCommand(SessionDTO session) : base(session) { }
    }

    public class AddSessionCommandHandler : IRequestHandler<AddSessionCommand, long>
    {
        private readonly ISessionService _sessionService;
        private readonly IMapper _mapper;

        public AddSessionCommandHandler(ISessionService sessionService, IMapper mapper)
        {
            _sessionService = sessionService;
            _mapper = mapper;
        }

        public async Task<long> Handle(AddSessionCommand request, CancellationToken cancellationToken)
        {
            var session = _mapper.Map<Session>(request.Entity);

            var insertedSession = await _sessionService.InsertAsync(session);

            return insertedSession.Id;
        }
    }
}
