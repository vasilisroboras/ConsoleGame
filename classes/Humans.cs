using System;
namespace WorldofAdventures.classes
{
    public class Human : Race
    {
        public Human()
        {
            Health += 10;
        }

    }
    public class LightHum : Human
    {
        public LightHum()
        {
            Attack += 10;
        }
    }

    public class DarkHum : Human
    {
        public DarkHum()
        {
            Speed += 10;
        }
    }
}