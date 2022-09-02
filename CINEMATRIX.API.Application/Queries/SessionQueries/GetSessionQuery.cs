using AutoMapper;
using CINEMATRIX.API.Contracts.IncomingOutgoing;
using CINEMATRIX.Data.Services;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace CINEMATRIX.API.Application.Queries.SessionQueries
{
    public class GetSessionQuery : IRequest<SessionDTO>
    {
        public long Id { get; }

        public GetSessionQuery(long id)
        {
            Id = id;
        }
    }

    public class GetSessionQueryHandler : IRequestHandler<GetSessionQuery, SessionDTO>
    {
        private readonly ISessionService _sessionService;
        private readonly IMapper _mapper;

        public GetSessionQueryHandler(ISessionService sessionService, IMapper mapper)
        {
            _sessionService = sessionService;
            _mapper = mapper;
        }

        public async Task<SessionDTO> Handle(GetSessionQuery request, CancellationToken cancellationToken)
        {
            var session = await _sessionService.GetAsync(request.Id, cancellationToken);

            if (session == null)
            {
                return null;
            }

            var mappedSession = _mapper.Map<SessionDTO>(session);

            return mappedSession;
        }
    }
}
