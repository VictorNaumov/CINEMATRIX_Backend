using CINEMATRIX.Data.Services;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace CINEMATRIX.API.Application.Commands.ProfileCommands
{
    public class DeleteProfileCommand : IRequest
    {
        public long Id { get; }

        public DeleteProfileCommand(long id)
        {
            Id = id;
        }
    }

    public class DeleteProfileCommandHandler : IRequestHandler<DeleteProfileCommand>
    {
        private readonly IProfileService _profileService;

        public DeleteProfileCommandHandler(IProfileService profileService)
        {
            _profileService = profileService;
        }

        public async Task<Unit> Handle(DeleteProfileCommand request, CancellationToken cancellationToken)
        {
            await _profileService.DeleteAsync(request.Id, cancellationToken);

            return Unit.Value;
        }
    }
}
