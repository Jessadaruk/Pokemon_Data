using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPokemon
{
    public class Pokemon
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string BasicStatus { get; set; }
        public string ImagePath { get; set; } // เพิ่ม property สำหรับเก็บ path รูปภาพ

        public Pokemon(string name, string type, string basicStatus, string imagePath)
        {
            Name = name;
            Type = type;
            BasicStatus = basicStatus;
            ImagePath = imagePath;
        }
    }
}
