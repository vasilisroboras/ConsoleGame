using System;
using System.Collections.Generic;
using System.Text;

namespace WorldofAdventures.classes
{
    public class  Elve : Race
    {
        public Elve()
        {
            Aim += 10;
        }

    }

    public class HighElve : Elve
    {
        public HighElve()
        {
            Speed += 10;
        }
    }

    public class DarkElve : Elve
    {
        public DarkElve()
        {
            Attack += 10;
        }

    }

}