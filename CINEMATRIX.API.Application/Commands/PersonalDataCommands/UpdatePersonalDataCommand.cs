using AutoMapper;
using CINEMATRIX.API.Application.Commands.Abstractions;
using CINEMATRIX.API.Contracts.IncomingOutgoing;
using CINEMATRIX.API.Contracts.Outgoing.Abstractions;
using CINEMATRIX.Data.Domain.Models;
using CINEMATRIX.Data.Services;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace CINEMATRIX.API.Application.Commands.ProfileCommands
{
    public class UpdateProfileCommand : CommandBase<Response, ProfileDTO>
    {
        public UpdateProfileCommand(long id, ProfileDTO update) : base(id, update) { }
    }

    public class UpdateProfileCommandHandler : IRequestHandler<UpdateProfileCommand, Response>
    {
        private readonly IProfileService _profileService;
        private readonly IMapper _mapper;

        public UpdateProfileCommandHandler(IProfileService profileService, IMapper mapper)
        {
            _profileService = profileService;
            _mapper = mapper;
        }

        public async Task<Response> Handle(UpdateProfileCommand request, CancellationToken cancellationToken)
        {
            var profile = await _profileService.GetAsync(request.Id, cancellationToken);

            if (profile == null)
            {
                return Response.Error;
            }

            var profileToUpdate = _mapper.Map<Data.Domain.Models.Profile>(profile);

            var updatedProfile = await _profileService.UpdateAsync(profileToUpdate);

            if (updatedProfile == null)
            {
                return Response.Error;
            }

            return Response.Successful;
        }
    }
}
