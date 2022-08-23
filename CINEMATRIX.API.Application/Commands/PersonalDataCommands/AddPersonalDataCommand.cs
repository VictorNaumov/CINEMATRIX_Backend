using AutoMapper;
using CINEMATRIX.API.Application.Commands.Abstractions;
using CINEMATRIX.API.Contracts.IncomingOutgoing;
using CINEMATRIX.Data.Domain.Models;
using CINEMATRIX.Data.Services;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace CINEMATRIX.API.Application.Commands.PersonalDataCommands
{
    public class AddPersonalDataCommand : CommandBase<long, PersonalDataDTO>
    {
        public AddPersonalDataCommand(PersonalDataDTO personalData) : base(personalData) { }
    }

    public class AddPersonalDataCommandHandler : IRequestHandler<AddPersonalDataCommand, long>
    {
        private readonly IPersonalDataService _personalDataService;
        private readonly IMapper _mapper;

        public AddPersonalDataCommandHandler(IPersonalDataService personalDataService, IMapper mapper)
        {
            _personalDataService = personalDataService;
            _mapper = mapper;
        }

        public async Task<long> Handle(AddPersonalDataCommand request, CancellationToken cancellationToken)
        {
            var personalData = _mapper.Map<PersonalData>(request.Entity);

            var insertedProduct = await _personalDataService.InsertAsync(personalData);

            return insertedProduct.Id;
        }
    }
}
