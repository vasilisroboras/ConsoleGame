using System;
using System.Collections.Generic;
using System.Text;

namespace WorldofAdventures.classes
{
    class Game : Race
    {

        public int PlayerBar { get; set; } = 0;
        public int BotBar { get; set; } = 0;

        
        public  void  BarMode(int PlayerSpeed,int  BotSpeed, ref int  WhoPlays, ref int PlayerBar, ref int BotBar)
        {
            int timer = 0;
            int max = 10000;
            while (timer < max)
            {

                PlayerBar += PlayerSpeed;
                BotBar += BotSpeed;


                System.Threading.Thread.Sleep(1000);
                if(PlayerBar >= 100 || BotBar >= 100)
                {
                    if(PlayerBar >= 100)
                    {
                        PlayerBar = 0;
                        WhoPlays += 1;
                        break;
                    }
                    else if(BotBar >= 100)
                    {
                        BotBar = 0;
                        break;
                        
                        
                    }
                }
                
            }
            
        }
        public double AttackingMode(double Attack,int Defense)
        {
            double Attacking = Attack - Defense;
            if(Attacking < 0)
            {
                Attacking = 1;
                Console.WriteLine("He is dealing " + Attacking + " points of damage.");
                return Attacking;
            }
            Console.WriteLine("He is dealing " + Attacking + " points of damage.");
            return Attacking;
        }

        public int DodgeMode(int Aim,int Dodge)
        {
            int Dodging = Aim - Dodge;
            return Dodging;
        }

        public Double CriticalMode( int Attack)
        {
            Random r = new Random();
            int luck = r.Next(0, 100);
            if (luck >= 90)

            {
                Console.WriteLine("He is doing Critical Damage.");
                double Critical = Attack * 1.5;
                return Critical;
            }
          
            return Attack;
        }

    }
}
