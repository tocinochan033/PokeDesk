using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using Newtonsoft.Json;
using System.Runtime.Remoting;

namespace PokeDesk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }



        private static readonly HttpClient client = new HttpClient();
        private async void LoadPokemon(string pokemonName)
        {
            string url = $"https://pokeapi.co/api/v2/pokemon/{pokemonName.ToLower()}";
            try
            {
                string responseBody = await client.GetStringAsync(url);

                // Deserializa el JSON en un objeto de tipo Pokemon
                Pokemon pokemonData = JsonConvert.DeserializeObject<Pokemon>(responseBody);

                // Obtén el nombre y la URL de la imagen
                string name = pokemonData.Name;
                string imageUrl = pokemonData.Sprites.FrontDefault;

                // Actualiza la interfaz
                pokemonNameLabel.Text = name;
                pokemonPictureBox.Load(imageUrl);
            }
            catch (HttpRequestException e)
            {
                MessageBox.Show("Error al obtener los datos del Pokémon: " + e.Message);
            }
        }

        public class Pokemon
        {
            public string Name { get; set; }
            public Sprites Sprites { get; set; }
        }

        public class Sprites
        {
            [JsonProperty("front_default")]
            public string FrontDefault { get; set; }
        }



        private void pokemonTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void pokemonButton_Click(object sender, EventArgs e)
        {
            string pokename = pokemonTextBox.Text.ToString();
            LoadPokemon(pokename);
            pokemonTextBox.Clear();
        }
    }
}
