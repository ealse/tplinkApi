using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Net.Http.Headers;
using System.Text.Json;

namespace Ealse.TPLink.Api
{
    public partial class TPLinkClient : IDisposable
    {
        public string? Token { get; set; }

#pragma warning disable S1075 // URIs should not be hardcoded
        public Uri TPLinkApiBaseUrl => new Uri("https://eu-wap.tplinkcloud.com/");
#pragma warning restore S1075 // URIs should not be hardcoded

        public string UserAgent => "Dalvik/2.1.0 (Linux; U; Android 6.0.1; A0001 Build/M4B30X)";

        private readonly HttpClient client;

        private JsonSerializerOptions JsonSerializerOptions => new JsonSerializerOptions { PropertyNamingPolicy = JsonNamingPolicy.CamelCase };

        public TPLinkClient(string? token = null) 
        {
            this.Token = token;
            this.client = CreateHttpClient();
        }

        protected virtual void Dispose(bool disposing)
        {
            this.client?.Dispose();
        }        
        
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private HttpClient CreateHttpClient()
        {
            var handler = new HttpClientHandler();

            var httpClient = new HttpClient(handler)
            {
                BaseAddress = TPLinkApiBaseUrl
            };

            if (!string.IsNullOrEmpty(UserAgent))
            {
                httpClient.DefaultRequestHeaders.Add("User-Agent", UserAgent);
            }

            return httpClient;
        }

        protected virtual async Task<TResponse?> SendAsync<TRequest, TResponse>(TRequest? requestData = null) where TRequest : class, new() where TResponse: class
        {
            using var request = new HttpRequestMessage(HttpMethod.Post, $"{TPLinkApiBaseUrl}?token={Token}");
            var requestBody = JsonSerializer.Serialize(requestData ?? new TRequest(), JsonSerializerOptions);
            request.Content = new StringContent(requestBody);
            request.Content.Headers.ContentType = new MediaTypeHeaderValue("application/json");

            using var response = await client.SendAsync(request);

            if (response != null && response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                var responseString = await response.Content.ReadAsStringAsync();

                var responseEntity = JsonSerializer.Deserialize<TResponse>(responseString, JsonSerializerOptions);
                return responseEntity;
            }

            return default;

        }
    }
}

