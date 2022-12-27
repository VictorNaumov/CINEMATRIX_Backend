using AutoMapper;
using CINEMATRIX.API.Application.Commands.Abstractions;
using CINEMATRIX.API.Contracts.IncomingOutgoing;
using CINEMATRIX.API.Contracts.Outgoing.Abstractions;
using CINEMATRIX.Data.Domain.Models;
using CINEMATRIX.Data.Services;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace CINEMATRIX.API.Application.Commands.FAQCommands
{
    public class UpdateFAQCommand : CommandBase<Response, FAQDTO>
    {
        public UpdateFAQCommand(long id, FAQDTO update) : base(id, update) { }
    }

    public class UpdateFAQCommandHandler : IRequestHandler<UpdateFAQCommand, Response>
    {
        private readonly IFAQService _FAQService;
        private readonly IMapper _mapper;

        public UpdateFAQCommandHandler(IFAQService FAQService, IMapper mapper)
        {
            _FAQService = FAQService;
            _mapper = mapper;
        }

        public async Task<Response> Handle(UpdateFAQCommand request, CancellationToken cancellationToken)
        {
            var faq = await _FAQService.GetByIdAsync(request.Id, cancellationToken);

            if (faq == null)
            {
                return Response.Error;
            }

            var faqToUpdate = _mapper.Map<FAQ>(faq);

            var updatedFAQ = await _FAQService.UpdateAsync(faqToUpdate);

            if (updatedFAQ == null)
            {
                return Response.Error;
            }

            return Response.Successful;
        }
    }
}
