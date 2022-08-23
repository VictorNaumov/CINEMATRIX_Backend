using AutoMapper;
using CINEMATRIX.API.Contracts.IncomingOutgoing;
using CINEMATRIX.Data.Services;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace CINEMATRIX.API.Application.Queries.PersonalDataQueries
{
    public class GetPersonalDataQuery : IRequest<PersonalDataDTO>
    {
        public long Id { get; }

        public GetPersonalDataQuery(long id)
        {
            Id = id;
        }
    }

    public class GetProductQueryHandler : IRequestHandler<GetPersonalDataQuery, PersonalDataDTO>
    {
        private readonly IPersonalDataService _personalDataService;
        private readonly IMapper _mapper;

        public GetProductQueryHandler(IPersonalDataService personalDataService, IMapper mapper)
        {
            _personalDataService = personalDataService;
            _mapper = mapper;
        }

        public async Task<PersonalDataDTO> Handle(GetPersonalDataQuery request, CancellationToken cancellationToken)
        {
            var personalData = await _personalDataService.GetAsync(request.Id, cancellationToken);

            if (personalData == null)
            {
                return null;
            }

            var mappedPersonalData = _mapper.Map<PersonalDataDTO>(personalData);

            return mappedPersonalData;
        }
    }
}
