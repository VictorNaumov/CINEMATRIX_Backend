using CINEMATRIX.Data.Domain.Models;
using CINEMATRIX.Data.EF.SQL;
using CINEMATRIX.Data.Services.Abstraction;

namespace CINEMATRIX.Data.Services
{
    public interface ITicketService : IBaseService<Ticket> { }

    public class TicketService : BaseService<Ticket>, ITicketService
    {
        public TicketService(ApplicationDbContext dbContext) : base(dbContext) { }
    }
}
