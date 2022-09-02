using System.Net.Http;
using System.Threading.Tasks;

namespace CINEMATRIX.Data.Services.Abstraction
{
    public interface IHttpBaseService
    {
        Task<string> GetByUrlAsync(string url);
    }

    public abstract class HttpBaseService : IHttpBaseService
    {
        const string ApiKey = "a557294acd576395e76cdcc2c957ac12";

        public async Task<string> GetByUrlAsync(string url)
        {
            url = string.Format(url, ApiKey);

            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync(url))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();

                    return apiResponse;
                }
            }
        }
    }
}
