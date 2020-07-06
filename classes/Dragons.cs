using System;
using System.Collections.Generic;
using System.Text;



namespace WorldofAdventures.classes
{
    public class Dragon : Race
    {
        public Dragon()
        {
            Attack += 10;
        }

    }
    public class ChromaticDragon : Dragon
    {
        public ChromaticDragon()
        {
            Health += 10;
        }
    }

    public class MetallicDragon : Dragon
    {
        public MetallicDragon()
        {
            Defense += 10;
        }
    }
}
