using AutoMapper;
using CINEMATRIX.API.Application.Commands.Abstractions;
using CINEMATRIX.API.Contracts.IncomingOutgoing;
using CINEMATRIX.Data.Domain.Models;
using CINEMATRIX.Data.Services;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace CINEMATRIX.API.Application.Commands.FAQCommands
{
    public class AddFAQCommand : CommandBase<long, FAQDTO>
    {
        public AddFAQCommand(FAQDTO FAQ) : base(FAQ) { }
    }

    public class AddFAQCommandHandler : IRequestHandler<AddFAQCommand, long>
    {
        private readonly IFAQService _FAQService;
        private readonly IMapper _mapper;

        public AddFAQCommandHandler(IFAQService FAQService, IMapper mapper)
        {
            _FAQService = FAQService;
            _mapper = mapper;
        }

        public async Task<long> Handle(AddFAQCommand request, CancellationToken cancellationToken)
        {
            var faq = _mapper.Map<FAQ>(request.Entity);

            var insertedFAQ = await _FAQService.InsertAsync(faq);

            return insertedFAQ.Id;
        }
    }
}
