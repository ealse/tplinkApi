using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Ealse.TPLink.Api.Models.Requests;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Text.Json.Serialization;


namespace Ealse.TPLink.Api
{
    public partial class TPLinkClient : IDisposable
    {
        private string Username { get; set; }

        private string Password { get; set; }

        private string Token { get; set; }

        private JsonSerializerOptions JsonSerializerOptions => new JsonSerializerOptions { PropertyNamingPolicy = JsonNamingPolicy.CamelCase };

        public Uri TPLinkApiBaseUrl => new Uri("https://eu-wap.tplinkcloud.com/");

        public string UserAgent => "Dalvik/2.1.0 (Linux; U; Android 6.0.1; A0001 Build/M4B30X)";

        private readonly HttpClient client;

        public TPLinkClient(string username, string password)
        {
            this.Username = username;
            this.Password = password;

            this.client = CreateHttpClient();
        }

        public TPLinkClient(string username, string password, string token) : this(username, password)
        {
            this.Token = token;
        }

        public void Dispose()
        {
            this.client?.Dispose();
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

        protected virtual async Task<TResponse> SendAsync<TRequest, TResponse>(Uri uri) where TRequest : new()
        {
            using var request = new HttpRequestMessage(HttpMethod.Post, uri);
            var requestBody = JsonSerializer.Serialize(new TRequest(), JsonSerializerOptions);
            request.Content = new StringContent(requestBody);
            request.Content.Headers.ContentType = new MediaTypeHeaderValue("application/json");

            try
            {
                using (var response = await client.SendAsync(request))
                {
                    if (response != null && response.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        var responseString = await response.Content.ReadAsStringAsync();

                        var responseEntity = JsonSerializer.Deserialize<TResponse>(responseString, JsonSerializerOptions);
                        return responseEntity;
                    }
                    return default;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}

