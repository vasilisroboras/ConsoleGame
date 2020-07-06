using System;

namespace WorldofAdventures.classes
{
    public class Dwarf : Race
    {
        public Dwarf()
        {
            Health += 10;
        }

    }
    public class MountainDwarf : Dwarf
    {
        public MountainDwarf()
        {
            Defense += 10;
        }
    }

    public class ValleyDwarf : Human
    {
        public ValleyDwarf()
        {
            Aim += 10;
        }
    }
}
