using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Pokedex.Models;

namespace Pokedex.Services
{
    public class PokemonProcessor
    {
        const string URL = "https://pokeapi.co/api/v2/pokemon/";
        public static async Task<Pokemon> LoadPokemonInfo(string pokemonName)
        {
            pokemonName = pokemonName.ToLower();
            string curRequest = URL + pokemonName;
            
            using(HttpResponseMessage responseMessage = await ApiHelper.client.GetAsync(curRequest))
            {
                if (responseMessage.IsSuccessStatusCode)
                {
                    Pokemon curPokemon = await responseMessage.Content.ReadAsAsync<Pokemon>();
                    return curPokemon;
                }
                else
                {
                    throw new Exception(responseMessage.ReasonPhrase);
                }
            }
        }

    }
}
