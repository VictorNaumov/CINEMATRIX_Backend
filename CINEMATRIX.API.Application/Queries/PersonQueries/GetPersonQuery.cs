using AutoMapper;
using CINEMATRIX.API.Contracts.Outgoing;
using CINEMATRIX.Data.Services;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace CINEMATRIX.API.Application.Queries.PersonQueries
{
    public class GetPersonQuery : IRequest<FoundPersonDTO>
    {
        public long Id { get; }

        public GetPersonQuery(long id)
        {
            Id = id;
        }
    }

    public class GetPersonQueryHandler : IRequestHandler<GetPersonQuery, FoundPersonDTO>
    {
        private readonly IPersonService _personService;
        private readonly IMapper _mapper;

        public GetPersonQueryHandler(IPersonService personService, IMapper mapper)
        {
            _personService = personService;
            _mapper = mapper;
        }

        public async Task<FoundPersonDTO> Handle(GetPersonQuery request, CancellationToken cancellationToken)
        {
            var personByIdResponse = await _personService.GetByIdAsync(request.Id, cancellationToken);
            var person = _mapper.Map<FoundPersonDTO>(personByIdResponse);

            return person;
        }
    }
}
