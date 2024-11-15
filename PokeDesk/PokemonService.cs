using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net.Http;

namespace PokeDesk
{
    public class PokemonService
    {
        private readonly HttpClient client;

        public PokemonService(HttpClient httpClient)
        {
            client = httpClient;
        }

        public async Task<Pokemon> GetPokemonAsync(string pokemonName)
        {
            // Obtener los datos básicos del Pokémon
            string pokemonUrl = $"https://pokeapi.co/api/v2/pokemon/{pokemonName.ToLower()}";
            string pokemonResponse = await client.GetStringAsync(pokemonUrl);
            var pokemonData = JsonConvert.DeserializeObject<Pokemon>(pokemonResponse);

            // Obtener la descripción en español desde el endpoint de especie
            string speciesUrl = $"https://pokeapi.co/api/v2/pokemon-species/{pokemonData.Id}/";
            string speciesResponse = await client.GetStringAsync(speciesUrl);
            var speciesData = JObject.Parse(speciesResponse);

            // Filtra las entradas de texto para obtener una en español
            foreach (var entry in speciesData["flavor_text_entries"])
            {
                if (entry["language"]["name"].ToString() == "es")
                {
                    pokemonData.Description = entry["flavor_text"].ToString().Replace("\n", " ").Replace("\f", " ");
                    break;
                }
            }

            return pokemonData;
        }
    }
}
