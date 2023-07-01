using IfoodMercado.Exceptions;
using IfoodMercado.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace IfoodMercado
{
    public static class ProductService
    {
        /// <summary>
        /// Método utilizado para integração de novos produtos ou para atualiza-los.
        /// OBS: Rate Limit 60 minutos a cada envio de lote.
        /// <see href="https://developermercado.ifood.com.br/docs/produtos-api#produto---integra%C3%A7%C3%A3o-utilizando-o-m%C3%A9todo-post">Referencia</see>
        /// </summary>
        /// <param name="products"></param>
        /// <param name="resetCharge"></param>
        /// <returns></returns>
        public static async Task<ProductResponse> ReadEvents(List<Product> products, bool resetCharge = false)
        {
            if (AuthService.Token == null)
            {
                throw new RequestException("Primeiro realize a authenticação.", 401);
            }

            using (HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, $"produtointegracao?reset={resetCharge}"))
            {
                request.Headers.Add("Authorization", "Bearer " + AuthService.Token.AccessToken);

                string contentRequest = JsonConvert.SerializeObject(products);
                request.Content = new StringContent(contentRequest, Encoding.UTF8, "application/json");

                using (HttpResponseMessage response = await ApiService.SendAsync(request))
                {
                    string content = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<ProductResponse>(content);
                }
            }
        }
    }
}
