using System;
using System.Collections.Generic;
using System.Text;
using WorldofAdventures.classes;

namespace WorldofAdventures.FightGame
{
    class Fight : Race
    {
        private static Random _random = new Random();

        private int PlayerBar { get; set; } = 0;
        private int BotBar { get; set; } = 0;



        public void BarMode(int PlayerSpeed, int BotSpeed, ref int WhoPlays, ref int PlayerBar, ref int BotBar)
        {
            int timer = 0;
            int max = 10000;
            while (timer < max)
            {

                PlayerBar += PlayerSpeed;
                BotBar += BotSpeed;
                System.Threading.Thread.Sleep(1000);
                if (PlayerBar >= 100 || BotBar >= 100)
                {
                    if (PlayerBar >= 100)
                    {
                        PlayerBar = 0;
                        WhoPlays += 1;
                        break;
                    }
                    else if (BotBar >= 100)
                    {
                        BotBar = 0;
                        break;


                    }
                }

            }

        }
        public double AttackingMode(double Attack, int Defense)
        {
            double Attacking = Attack - Defense;
            return Attacking;
        }

        public int DodgeMode(int Aim, int Defense)
        {
            int Dodging = Aim - Dodge;
            return Dodging;
        }

        public Double CriticalMode(int Attack)
        {
            Random r = new Random();
            int luck = r.Next(0, 100);
            if (luck >= 90)

            {
                double Critical = Attack * 1.5;
                return Critical;
            }

            return Attack;
        }
    
    }
}

