using AutoMapper;
using CINEMATRIX.API.Application.Commands.Abstractions;
using CINEMATRIX.API.Contracts.IncomingOutgoing;
using CINEMATRIX.API.Contracts.Outgoing.Abstractions;
using CINEMATRIX.Data.Domain.Models;
using CINEMATRIX.Data.Services;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace CINEMATRIX.API.Application.Commands.PersonalDataCommands
{
    public class UpdatePersonalDataCommand : CommandBase<Response, PersonalDataDTO>
    {
        public UpdatePersonalDataCommand(long id, PersonalDataDTO update) : base(id, update) { }
    }

    public class UpdatePersonalDataCommandHandler : IRequestHandler<UpdatePersonalDataCommand, Response>
    {
        private readonly IPersonalDataService _personalDataService;
        private readonly IMapper _mapper;

        public UpdatePersonalDataCommandHandler(IPersonalDataService personalDataService, IMapper mapper)
        {
            _personalDataService = personalDataService;
            _mapper = mapper;
        }

        public async Task<Response> Handle(UpdatePersonalDataCommand request, CancellationToken cancellationToken)
        {
            var personalData = await _personalDataService.GetAsync(request.Id, cancellationToken);

            if (personalData == null)
            {
                return Response.Error;
            }

            var personalDataToUpdate = _mapper.Map<PersonalData>(personalData);

            var updatedPersonalData = await _personalDataService.UpdateAsync(personalDataToUpdate);

            if (updatedPersonalData == null)
            {
                return Response.Error;
            }

            return Response.Successful;
        }
    }
}
