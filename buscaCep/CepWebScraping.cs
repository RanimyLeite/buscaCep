using buscaCep.DTOs;
using System;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace buscaCep
{
    public class CepWebScraping
    {
        private static HttpClient _httpClient;
        private static HttpClient HttpClient => _httpClient ?? (_httpClient = new HttpClient());

        public async Task GetCepInfo(string cep)
        {

            try
            {
                var url = "https://" + "viacep.com.br/ws/" + cep +"/json/";

                HttpResponseMessage response = await HttpClient.GetAsync(url);

                if (response.IsSuccessStatusCode)
                {
                    string responseBody = await response.Content.ReadAsStringAsync();

                    Console.WriteLine("As informações referentes ao CEP passado, são: ");

                    Console.WriteLine(responseBody);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            
        }
    }
}
