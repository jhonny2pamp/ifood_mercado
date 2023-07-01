using System;
using System.Net.Http;
using System.Threading.Tasks;
using IfoodMercado.Exceptions;

namespace IfoodMercado
{
    static class ApiService
    {
        private static HttpClient _httpClient;
        private const string _baseUrl = "https://service.sitemercado.com.br/api/v1/";

        private static HttpClient GetInstance()
        {
            if (_httpClient == null)
            {
                HttpClient client = new HttpClient
                {
                    BaseAddress = new Uri(_baseUrl)
                };
                _httpClient = client;
            }

            return _httpClient;
        }

        public static async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request)
        {
            HttpClient client = GetInstance();
            HttpResponseMessage response = await client.SendAsync(request);

            if (!response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                throw new RequestException("Falha na requisição", (int)response.StatusCode);
            }

            return response;
        }
    }
}