using CINEMATRIX.Data.Domain.Models;
using CINEMATRIX.Data.EF.SQL;
using CINEMATRIX.Data.Services.Abstraction;

namespace CINEMATRIX.Data.Services
{
    public interface IPersonalDataService : IBaseService<PersonalData> { }

    public class PersonalDataService : BaseService<PersonalData>, IPersonalDataService
    {
        public PersonalDataService(ApplicationDbContext dbContext) : base(dbContext)
        {

        }
    }
}
