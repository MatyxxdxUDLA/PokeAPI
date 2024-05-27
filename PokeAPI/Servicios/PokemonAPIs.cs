using Newtonsoft.Json;
using PokeAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeAPI.Servicios
{
    public class PokemonAPIs
    {
        public HttpClient _httpClient;
        public PokemonAPIs() {
            _httpClient = new HttpClient();
        }
        public async Task <List<PokemonInfo>> DevuelveListadoPokemones()
        {
            string url = "https://pokeapi.co/api/v2/pokemon/?limit=40&offset=0";
            string json = await _httpClient.GetStringAsync(url);
            ResourceList resourcelist_pokemon = JsonConvert.DeserializeObject<ResourceList>(json);
            return resourcelist_pokemon.results;
        }
    }
}
