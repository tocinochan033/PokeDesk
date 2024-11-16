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

            // Extraer estadísticas base
            foreach (var stat in pokemonJson["stats"])
            {
                string statName = stat["stat"]?["name"]?.ToString();
                int baseStatValue = stat["base_stat"]?.ToObject<int>() ?? 0;
                if (statName != null)
                {
                    pokemon.BaseStats[statName] = baseStatValue;
                }
            }

            // Obtener la descripción desde el endpoint de especie
            string speciesUrl = $"https://pokeapi.co/api/v2/pokemon-species/{pokemonJson["id"]?.ToString()}/";
            string speciesResponse = await client.GetStringAsync(speciesUrl);
            var speciesJson = JObject.Parse(speciesResponse);

            foreach (var entry in speciesJson["flavor_text_entries"])
            {
                if (entry["language"]["name"]?.ToString() == "en")
                {
                    pokemon.Description = entry["flavor_text"]?.ToString().Replace("\n", " ").Replace("\f", " ");
                    break;
                }
            }

            return pokemon;
        }
    }
}
