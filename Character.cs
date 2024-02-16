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
using System.Reflection.Metadata.Ecma335;

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
        public int Armor
        { get; set; }
        public int Caps
        { get; set; }
        public int StatPoints
        { get; set; }
        public bool[] supplies = new bool[3];


        public Dictionary<string, int> FT { get; set; } = new Dictionary<string, int>()
        {
            {"FT_Update", 0},
            {"FT_have", 0 }
        };


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

        public Dictionary<string, int> attributesMax { get; set; } = new Dictionary<string, int>()
        {
            {"S", 0},
            {"P", 0},
            {"E", 0},
            {"C", 0},
            {"I", 0},
            {"A", 0},
            {"L", 0}
         };

        public Dictionary<string, int> attributesMin { get; set; } = new Dictionary<string, int>()
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

        
        public void FtUpadatecheck()
        {
            FT["FT_Update"] = 2 + attributes["L"];
        }
        
        public void MaxHPCount()
        {
            Hp_max = 15 + attributes["E"] * 3;
            if(Race == "Супермутант" || Race == "Розумний Пазур Смерті"){
                Hp_max += 5;
            }
        }

        public void StatMaxMin()
        {
            switch(Race)
            {
                case "Людина":
                    attributesMax["S"] = 3;
                    attributesMax["P"] = 3;
                    attributesMax["E"] = 3;
                    attributesMax["C"] = 3;
                    attributesMax["I"] = 3;
                    attributesMax["A"] = 3;
                    attributesMax["L"] = 3;

                    attributesMin["S"] = -1;
                    attributesMin["P"] = -1;
                    attributesMin["E"] = -1;
                    attributesMin["C"] = -1;
                    attributesMin["I"] = -1;
                    attributesMin["A"] = -1;
                    attributesMin["L"] = -1;
                    break;
                case "Гуль":
                    attributesMax["S"] = 2;
                    attributesMax["P"] = 4;
                    attributesMax["E"] = 2;
                    attributesMax["C"] = 2;
                    attributesMax["I"] = 4;
                    attributesMax["A"] = 2;
                    attributesMax["L"] = 4;

                    attributesMin["S"] = -1;
                    attributesMin["P"] = -1;
                    attributesMin["E"] = -1;
                    attributesMin["C"] = -2;
                    attributesMin["I"] = -1;
                    attributesMin["A"] = -1;
                    attributesMin["L"] = -1;
                    break;
                case "Супермутант":
                    attributesMax["S"] = 4;
                    attributesMax["P"] = 3;
                    attributesMax["E"] = 4;
                    attributesMax["C"] = 2;
                    attributesMax["I"] = 1;
                    attributesMax["A"] = 3;
                    attributesMax["L"] = 3;

                    attributesMin["S"] = 0;
                    attributesMin["P"] = -1;
                    attributesMin["E"] = 0;
                    attributesMin["C"] = -2;
                    attributesMin["I"] = -2;
                    attributesMin["A"] = -1;
                    attributesMin["L"] = -1;
                    break;
                case "Робот":
                    attributesMax["S"] = 3;
                    attributesMax["P"] = 4;
                    attributesMax["E"] = 3;
                    attributesMax["C"] = 2;
                    attributesMax["I"] = 4;
                    attributesMax["A"] = 2;
                    attributesMax["L"] = 2;

                    attributesMin["S"] = -1;
                    attributesMin["P"] = -1;
                    attributesMin["E"] = -1;
                    attributesMin["C"] = -1;
                    attributesMin["I"] = 0;
                    attributesMin["A"] = -2;
                    attributesMin["L"] = -1;
                    break;
                case "Розумний Пазур Смерті":
                    attributesMax["S"] = 4;
                    attributesMax["P"] = 3;
                    attributesMax["E"] = 4;
                    attributesMax["C"] = 1;
                    attributesMax["I"] = 2;
                    attributesMax["A"] = 4;
                    attributesMax["L"] = 2;

                    attributesMin["S"] = 0;
                    attributesMin["P"] = -1;
                    attributesMin["E"] = -1;
                    attributesMin["C"] = -2;
                    attributesMin["I"] = -2;
                    attributesMin["A"] = 0;
                    attributesMin["L"] = -1;
                    break;
            }
        }
    }
}
