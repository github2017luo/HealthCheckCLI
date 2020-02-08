using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace HealthCheckCLI.Core.Client
{
    public class HealthCheckClient : IHealthCheckClient
    {
        //TODO replace with http client factory 
        public HttpClient _httpClient;

        public HealthCheckClient()
        {
            _httpClient = new HttpClient();
        }

        public async Task<HttpResponseMessage> CheckHealth(string url)
        {
            var message = new HttpRequestMessage()
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri(url)
            };

            var response = await _httpClient.SendAsync(message);

            return response;
        }
        
    }

    public interface IHealthCheckClient
    {
        Task<HttpResponseMessage> CheckHealth(string url);
    }
}