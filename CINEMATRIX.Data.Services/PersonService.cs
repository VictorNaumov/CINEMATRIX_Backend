using CINEMATRIX.API.Contracts.Incoming.SearchConditions;
using CINEMATRIX.API.Contracts.Outgoing.TMDB;
using CINEMATRIX.Data.Services.Abstraction;
using CINEMATRIX.Data.Services.Extensions;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CINEMATRIX.Data.Services
{
    public interface IPersonService : IHttpBaseService
    {

        Task<PagedPeopleResponse> GetPopularPeopleAsync(PersonSearchCondition searchCondition, CancellationToken cancellationToken = default);
        Task<PersonDetailByIdResponse> GetByIdAsync(long? id, CancellationToken cancellationToken);
    }

    public class PersonService : HttpBaseService, IPersonService
    {
        public PersonService() { }

        public async Task<PagedPeopleResponse> GetPopularPeopleAsync(PersonSearchCondition searchCondition, CancellationToken cancellationToken = default)
        {
            string url = $"https://api.themoviedb.org/3/person/popular?api_key={ApiKey}&page={searchCondition.Page + 1}";

            var apiResponse = await GetByUrlAsync<PagedPeopleResponse>(url);

            apiResponse.Results = searchCondition.SortDirection != "desc"
                ? apiResponse.Results.OrderBy(searchCondition.SortProperty)
                : apiResponse.Results.OrderByDescending(searchCondition.SortProperty);

            return apiResponse;
        }

        public async Task<PersonDetailByIdResponse> GetByIdAsync(long? id, CancellationToken cancellationToken = default)
        {
            string url = $"https://api.themoviedb.org/3/person/{id}?api_key={ApiKey}&language=en-US&append_to_response=images,credits";

            return await GetByUrlAsync<PersonDetailByIdResponse>(url);
        }
    }
}
