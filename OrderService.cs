using IfoodMercado.Exceptions;
using IfoodMercado.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace IfoodMercado
{
    public static class OrderService
    {
        /// <summary>
        /// Trás todos os eventos dos pedidos de uma loja com seus status.
        /// <see href="https://developermercado.ifood.com.br/docs/pedidos-api#consulta-de-eventos">Referencia</see>
        /// </summary>
        /// <param name="idLoja"></param>
        /// <returns></returns>
        public static async Task<List<IfoodEvent>> ListEvents(int idLoja)
        {
            if (AuthService.Token == null)
            {
                throw new RequestException("Primeiro realize a authenticação.", 401);
            }

            using (HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, $"pedido/eventos/{idLoja}"))
            {
                request.Headers.Add("Authorization", "Bearer " + AuthService.Token.AccessToken);

                using (HttpResponseMessage response = await ApiService.SendAsync(request))
                {
                    string content = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<List<IfoodEvent>>(content);
                }
            }
        }

        /// <summary>
        /// A chamada retira o “evento” das chamadas de eventos.
        /// OBS: O evendo do pedido retorna ao pooling após a mudança de status.
        /// <see href="https://developermercado.ifood.com.br/docs/pedidos-api#leitura-de-eventos">Referencia</see>
        /// </summary>
        /// <param name="eventsId"></param>
        /// <returns></returns>
        public static async Task ReadEvents(List<int> eventsId)
        {
            if (AuthService.Token == null)
            {
                throw new RequestException("Primeiro realize a authenticação.", 401);
            }

            using (HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, $"pedido/eventos/verificado"))
            {
                request.Headers.Add("Authorization", "Bearer " + AuthService.Token.AccessToken);
                request.Headers.Add("Cache-Control", "no-cache");

                List<object> parameters = new List<object>();

                foreach (int eventId in eventsId)
                {
                    parameters.Add(new { id = eventId });
                }

                string contentRequest = JsonConvert.SerializeObject(parameters);
                request.Content = new StringContent(contentRequest, Encoding.UTF8, "application/json");
                (await ApiService.SendAsync(request)).Dispose();
            }
        }

        /// <summary>
        /// Este evento retorna o json completo do pedido de acordo com o código informado.
        /// <see href="https://developermercado.ifood.com.br/docs/pedidos-api#consulta-de-pedidos">Referencia</see>
        /// </summary>
        /// <param name="codigoPedido"></param>
        /// <returns></returns>
        public static async Task<Order> GetOrder(int codigoPedido)
        {
            if (AuthService.Token == null)
            {
                throw new RequestException("Primeiro realize a authenticação.", 401);
            }

            using (HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, $"pedido/{codigoPedido}"))
            {
                request.Headers.Add("Authorization", "Bearer " + AuthService.Token.AccessToken);

                using (HttpResponseMessage response = await ApiService.SendAsync(request))
                {
                    string content = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<Order>(content);
                }
            }
        }
    }
}
