using AutoMapper;
using CINEMATRIX.API.Contracts.Outgoing;
using CINEMATRIX.Data.Services;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace CINEMATRIX.API.Application.Queries.ProfileQueries
{
    public class GetProfileQuery : IRequest<FoundProfileDTO>
    {
        public long Id { get; }
        public string UserName { get; set; }

        public GetProfileQuery(long id, string userName)
        {
            Id = id;
            UserName = userName;
        }
    }

    public class GetProfileQueryHandler : IRequestHandler<GetProfileQuery, FoundProfileDTO>
    {
        private readonly IProfileService _profileService;
        private readonly IUserService _userService;
        private readonly ITicketService _ticketService;
        private readonly IMapper _mapper;

        public GetProfileQueryHandler(IProfileService profileService, IUserService userService, ITicketService ticketService, IMapper mapper)
        {
            _profileService = profileService;
            _profileService = profileService;
            _userService = userService;
            _ticketService = ticketService;
            _mapper = mapper;
        }

        public async Task<FoundProfileDTO> Handle(GetProfileQuery request, CancellationToken cancellationToken)
        {
            var user = await _userService.GetByUserNameAsync(request.UserName, cancellationToken);
            var profile = await _profileService.GetByIdAsync(request.Id, cancellationToken);

            if (profile == null)
            {
                return null;
            }

            var isMyProfile = user.Profile.Id == request.Id;
            if (isMyProfile)
            {
                profile.Tickets = await _ticketService.GetTicketsByProfileId(profile.Id, cancellationToken);
            }

            var mappedProfile = _mapper.Map<FoundProfileDTO>(profile);

            return mappedProfile;
        }
    }
}
