using AutoMapper;
using CINEMATRIX.API.Contracts.IncomingOutgoing;
using CINEMATRIX.Data.Services;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace CINEMATRIX.API.Application.Queries.ProfileQueries
{
    public class GetProfileQuery : IRequest<ProfileDTO>
    {
        public long Id { get; }

        public GetProfileQuery(long id)
        {
            Id = id;
        }
    }

    public class GetProfileQueryHandler : IRequestHandler<GetProfileQuery, ProfileDTO>
    {
        private readonly IProfileService _profileService;
        private readonly IMapper _mapper;

        public GetProfileQueryHandler(IProfileService profileService, IMapper mapper)
        {
            _profileService = profileService;
            _mapper = mapper;
        }

        public async Task<ProfileDTO> Handle(GetProfileQuery request, CancellationToken cancellationToken)
        {
            var profile = await _profileService.GetByIdAsync(request.Id, cancellationToken);

            if (profile == null)
            {
                return null;
            }

            var mappedProfile = _mapper.Map<ProfileDTO>(profile);

            return mappedProfile;
        }
    }
}
