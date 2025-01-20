using CarvajalJProgreso3.Models;
using System.Text.Json;

using System.Text.Json.Nodes;

namespace CarvajalJProgreso3.Interfaces
{
    internal class CarvajalPaisI : ICarvajalPais
    {
        private string urlApi = "https://restcountries.com/v3.1/name/ecuador";
        public async Task<List<CarvajalPaisAPI>> Obtener()
        {
            var client = new HttpClient();
            var response = await client.GetAsync(urlApi);
            var responseBody = await response.Content.ReadAsStringAsync();
            JsonNode nodos = JsonNode.Parse(responseBody);
            JsonNode results = nodos["results"];

            var paisData = JsonSerializer.Deserialize<List<CarvajalPaisAPI>>(results.ToString());
            return paisData;
        }


    }
}

