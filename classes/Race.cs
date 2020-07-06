using System;
using System.Collections.Generic;
using System.Text;

namespace WorldofAdventures.classes
{
    public abstract class Race
    {
        public int Health { get; set; } = 5;
        public int Attack { get; set; } = 5;
        public int Defense { get; set; } = 5;
        public int Speed { get; set; } = 5;
        public int Dodge { get; set; } = 5;
        public int Aim { get; set; } = 6;
    }
}