using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;

namespace CINEMATRIX.Data.Services.Abstraction
{
    public interface IHttpBaseService
    {
        Task<T> GetByUrlAsync<T>(string url, long id) where T : class;
    }

    public abstract class HttpBaseService : IHttpBaseService
    {
        protected readonly string ApiKey = "a557294acd576395e76cdcc2c957ac12";

        public async Task<T> GetByUrlAsync<T>(string url, long id = -1) where T : class
        {
            url = id != -1
                ? string.Format(url, id, ApiKey)
                : string.Format(url, ApiKey);

            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync(url))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        string apiResponse = await response.Content.ReadAsStringAsync();

                        var deserializedResponse = DeserializeResponse<T>(apiResponse);

                        return deserializedResponse;
                    }

                    return null;
                }
            }
        }

        private T DeserializeResponse<T>(string apiResponse) where T : class
        {
            if (!string.IsNullOrWhiteSpace(apiResponse))
            {
                return JsonConvert.DeserializeObject<T>(apiResponse);
            }

            return null;
        }
    }
}
