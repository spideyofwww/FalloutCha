using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.IO;


namespace FalloutCha
{
    internal class Character
    {
        public string? Name
        { get; set; }
        public string? Discr
        { get; set; }
        public string? Archetype
        { get; set; }
        public string? Race
        { get; set; }
        public string[][]? Perks
        { get; set; }
        public string[][]? Features
        { get; set; }
        public string[]? Weapons
        { get; set; }
        public int Hp
        { get; set; }
        public int Hp_max
        { get; set; }
        public int FT_Update
        { get; set; }
        public int FT_have
        { get; set; }
        public int Armor
        { get; set; }
        public int Caps
        { get; set; }
        public bool[] supplies = new bool[3];
        

        


        public Dictionary<string, int> attributes { get; set; } = new Dictionary<string, int>()
        {
            {"S", 0},
            {"P", 0},
            {"E", 0},
            {"C", 0},
            {"I", 0},
            {"A", 0},
            {"L", 0}
         };

        public Dictionary<string, string> skills { get; set; } = new Dictionary<string, string>()
        {
            {"Athletics", ""},
            {"Stealth", ""},
            {"Shoot", ""},
            {"Hertz", ""},
            {"Med", ""},
            {"Tech", ""},
            {"Knowledge", "" },
            {"Survive", ""},
            {"Manipulation", ""},
            {"Coercion",  ""}
        };

        public Dictionary<string, string> consequences { get; set; } = new Dictionary<string, string>()
        {
            {"Light", " "},
            {"Mid", " "},
            {"Heavy"," "}
        };

        public Dictionary<string, string> aspects { get; set; } = new Dictionary<string, string>()
        {
            {"Concept", " "},
            {"Problems", " "},
            {"Purpose"," "}
        };

        

        
    }
}
