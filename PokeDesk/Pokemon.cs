using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PokeDesk.Form1;

namespace PokeDesk
{
    internal class Pokemon
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Sprites Sprites { get; set; }
        public string Description { get; set; }
        public List<string> Types { get; set; } = new List<string>();
        public Dictionary<string, int> BaseStats { get; set; } = new Dictionary<string, int>();
    }
}


    public class Sprites
    {
        [JsonProperty("front_default")]
        public string FrontDefault { get; set; }
    }
