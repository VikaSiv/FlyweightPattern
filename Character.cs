﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightPattern
{
    public partial class Character
    {
        public string Name { get; private set; }
        public string Type { get; private set; }
        public string Image { get; private set; }
        public int Level { get; set; }
        public int Experience { get; set; }

        private Character(string name, string type, string image)
        {
            Name = name;
            Type = type;
            Image = image;
            Level = 1; 
            Experience = 0; 
        }
       

    }
}
