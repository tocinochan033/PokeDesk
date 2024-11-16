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
        public async void LoadPokemon(string pokemonName)
        {
            PokemonDescription pokemonService = new PokemonDescription(client);

            try
            {
                // Obtén los datos del Pokémon a través de PokemonDescription
                Pokemon pokemonData = await pokemonService.GetPokemonAsync(pokemonName);

                // Actualiza la interfaz con los datos obtenidos
                pokemonNameLabel.Text = pokemonData.Name;
                pokemonPictureBox.Load(pokemonData.Sprites.FrontDefault);
                pokemonDescriptionLabel.Text = pokemonData.Description;
                pokemonTypelabel.Text = string.Join(", ", pokemonData.Types);

                // Mostrar estadísticas base
                var statsDisplay = string.Join(Environment.NewLine, pokemonData.BaseStats.Select(stat => $" - {stat.Key}: {stat.Value} "));
                pokemonStatsTextBox.Text = statsDisplay;
            }
            catch (HttpRequestException e)
            {
                MessageBox.Show("Error al obtener los datos del Pokémon: " + e.Message);
            }
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

        private void pokemonTypelabel_Click(object sender, EventArgs e)
        {

        }
    }
}
