using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace PokeDesk
{
    internal class PokemonDescription
    {
        private readonly HttpClient client;

        public PokemonDescription(HttpClient httpClient)
        {
            client = httpClient;
        }

        public async Task<Pokemon> GetPokemonAsync(string pokemonName)
        {
            var pokemon = new Pokemon();

            // Obtener los datos básicos del Pokémon
            string pokemonUrl = $"https://pokeapi.co/api/v2/pokemon/{pokemonName.ToLower()}";
            string pokemonResponse = await client.GetStringAsync(pokemonUrl);

            var pokemonJson = JObject.Parse(pokemonResponse);

            // Extraer el nombre, imagen y tipos
            pokemon.Name = pokemonJson["name"]?.ToString();
            pokemon.Sprites = new Sprites { FrontDefault = pokemonJson["sprites"]?["front_default"]?.ToString() };

            foreach (var type in pokemonJson["types"])
            {
                string typeName = type["type"]?["name"]?.ToString();
                if (typeName != null)
                {
                    pokemon.Types.Add(typeName);
                }
            }

            // Obtener la descripción en español desde el endpoint de especie
            string speciesUrl = $"https://pokeapi.co/api/v2/pokemon-species/{pokemonJson["id"]?.ToString()}/";
            string speciesResponse = await client.GetStringAsync(speciesUrl);
            var speciesJson = JObject.Parse(speciesResponse);

            foreach (var entry in speciesJson["flavor_text_entries"])
            {
                if (entry["language"]["name"]?.ToString() == "es")
                {
                    pokemon.Description = entry["flavor_text"]?.ToString().Replace("\n", " ").Replace("\f", " ");
                    break;
                }
            }

            return pokemon;
        }
    }
}
