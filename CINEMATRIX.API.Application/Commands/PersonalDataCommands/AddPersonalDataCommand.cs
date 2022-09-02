using AutoMapper;
using CINEMATRIX.API.Application.Commands.Abstractions;
using CINEMATRIX.API.Contracts.IncomingOutgoing;
using CINEMATRIX.Data.Services;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace CINEMATRIX.API.Application.Commands.ProfileCommands
{
    public class AddProfileCommand : CommandBase<long, ProfileDTO>
    {
        public AddProfileCommand(ProfileDTO profile) : base(profile) { }
    }

    public class AddProfileCommandHandler : IRequestHandler<AddProfileCommand, long>
    {
        private readonly IProfileService _profileService;
        private readonly IMapper _mapper;

        public AddProfileCommandHandler(IProfileService profileService, IMapper mapper)
        {
            _profileService = profileService;
            _mapper = mapper;
        }

        public async Task<long> Handle(AddProfileCommand request, CancellationToken cancellationToken)
        {
            var profile = _mapper.Map<Data.Domain.Models.Profile>(request.Entity);

            var insertedProfile = await _profileService.InsertAsync(profile);

            return insertedProfile.Id;
        }
    }
}
