using AutoMapper;
using CINEMATRIX.API.Contracts.IncomingOutgoing;
using CINEMATRIX.Data.Services;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace CINEMATRIX.API.Application.Queries.FAQQueries
{
    public class GetFAQQuery : IRequest<FAQDTO>
    {
        public long Id { get; }

        public GetFAQQuery(long id)
        {
            Id = id;
        }
    }

    public class GetFAQQueryHandler : IRequestHandler<GetFAQQuery, FAQDTO>
    {
        private readonly IFAQService _faqService;
        private readonly IMapper _mapper;

        public GetFAQQueryHandler(IFAQService faqService, IMapper mapper)
        {
            _faqService = faqService;
            _mapper = mapper;
        }

        public async Task<FAQDTO> Handle(GetFAQQuery request, CancellationToken cancellationToken)
        {
            var faq = await _faqService.GetByIdAsync(request.Id, cancellationToken);

            if (faq == null)
            {
                return null;
            }

            var mappedFAQ = _mapper.Map<FAQDTO>(faq);

            return mappedFAQ;
        }
    }
}
