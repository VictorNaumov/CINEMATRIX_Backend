using CINEMATRIX.Data.Services;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace CINEMATRIX.API.Application.Commands.FAQCommands
{
    public class DeleteFAQCommand : IRequest
    {
        public long Id { get; }

        public DeleteFAQCommand(long id)
        {
            Id = id;
        }
    }

    public class DeleteFAQCommandHandler : IRequestHandler<DeleteFAQCommand>
    {
        private readonly IFAQService _faqService;

        public DeleteFAQCommandHandler(IFAQService FAQService)
        {
            _faqService = FAQService;
        }

        public async Task<Unit> Handle(DeleteFAQCommand request, CancellationToken cancellationToken)
        {
            await _faqService.DeleteAsync(request.Id, cancellationToken);

            return Unit.Value;
        }
    }
}
