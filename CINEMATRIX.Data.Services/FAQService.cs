using CINEMATRIX.Data.Domain.Models;
using CINEMATRIX.Data.EF.SQL;
using CINEMATRIX.Data.Services.Abstraction;

namespace CINEMATRIX.Data.Services
{
    public interface IFAQService : IBaseService<FAQ>
    {
    }

    public class FAQService : BaseService<FAQ>, IFAQService
    {
        public FAQService(ApplicationDbContext dbContext) : base(dbContext) { }
    }
}
