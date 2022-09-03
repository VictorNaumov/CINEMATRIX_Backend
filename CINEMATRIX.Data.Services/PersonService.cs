using CINEMATRIX.API.Contracts.Incoming.SearchConditions;
using CINEMATRIX.API.Contracts.Outgoing;
using CINEMATRIX.API.Contracts.Outgoing.TMDB;
using CINEMATRIX.Data.Services.Abstraction;
using CINEMATRIX.Data.Services.Extensions;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CINEMATRIX.Data.Services
{
    public interface IPersonService : IHttpBaseService
    {
        //Task<List<FoundPersonDTO>> FindAsync(PersonSearchCondition searchCondition, CancellationToken cancellationToken);
        Task<PersonByIdResponse> GetByIdAsync(long? id, CancellationToken cancellationToken);
    }

    public class PersonService : HttpBaseService, IPersonService
    {
        public PersonService() { }

        //public async Task<List<FoundPersonDTO>> FindAsync(PersonSearchCondition searchCondition, 
        //    CancellationToken cancellationToken)
        //{
        //    string url = $"https://api.themoviedb.org/3/person/movie/list?api_key={ApiKey}&language=en-US";

        //    var apiResponse = await GetByUrlAsync<PersonResponse>(url);

        //    var persons = searchCondition.SortDirection != "desc"
        //        ? apiResponse.Persons.OrderBy(searchCondition.SortProperty)
        //        : apiResponse.Persons.OrderByDescending(searchCondition.SortProperty);

        //    return persons;
        //}

        public async Task<PersonByIdResponse> GetByIdAsync(long? id, CancellationToken cancellationToken = default)
        {
            string url = $"https://api.themoviedb.org/3/person/{id}?api_key={ApiKey}&language=en-US&append_to_response=images,videos,credits,movies";

            return await GetByUrlAsync<PersonByIdResponse>(url);
        }
    }
}
