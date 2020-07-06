using System;
using System.Collections.Generic;
using System.Text;

namespace WorldofAdventures.classes
{
    public  class BotFactory
    {
        public  Race GetRandomBot(int exp)
        {
            Random r = new Random();
            int random = r.Next(1, 1);

            switch (random)
            {
                case 1:
                    var x1 = new DarkHum();
                    for(int i=0; i<= exp ; i++)
                    {
                        
                        Random rr = new Random();
                        int randomexp = r.Next(1, 6);
                        
                        switch (randomexp)
                        {
                            case 1:
                                
                                x1.Health += 1;
                                continue;
                            case 2:
                                x1.Aim += 1;
                                continue;
                            case 3:
                                x1.Attack += 1;
                                continue;
                            case 4:
                                x1.Defense += 1;
                                continue;
                            case 5:
                                x1.Dodge += 1;
                                continue;
                            case 6:
                                x1.Speed += 1;
                                continue;
                        }
                    }
                    
                    return x1;

                case 2:
                    var x2 = new DarkElve();
                    for (int i = exp; i == 0; i--)
                    {
                        Random rr = new Random();
                        int randomexp = r.Next(1, 6);
                        switch (randomexp)
                        {
                            case 1:
                                x2.Health += 1;
                                break;
                            case 2:
                                x2.Aim += 1;
                                break;
                            case 3:
                                x2.Attack += 1;
                                break;
                            case 4:
                                x2.Defense += 1;
                                break;
                            case 5:
                                x2.Dodge += 1;
                                break;
                            case 6:
                                x2.Speed += 1;
                                break;
                        }
                    }

                    return x2;

                case 3:
                    var x3 = new ChromaticDragon();
                    for (int i = exp; i == 0; i--)
                    {
                        Random rr = new Random();
                        int randomexp = r.Next(1, 6);
                        switch (randomexp)
                        {
                            case 1:
                                x3.Health += 1;
                                break;
                            case 2:
                                x3.Aim += 1;
                                break;
                            case 3:
                                x3.Attack += 1;
                                break;
                            case 4:
                                x3.Defense += 1;
                                break;
                            case 5:
                                x3.Dodge += 1;
                                break;
                            case 6:
                                x3.Speed += 1;
                                break;
                        }
                    }

                    return x3;

                case 4:
                    var x4 = new MetallicDragon();
                    for (int i = exp; i == 0; i--)
                    {
                        Random rr = new Random();
                        int randomexp = r.Next(1, 6);
                        switch (randomexp)
                        {
                            case 1:
                                x4.Health += 1;
                                break;
                            case 2:
                                x4.Aim += 1;
                                break;
                            case 3:
                                x4.Attack += 1;
                                break;
                            case 4:
                                x4.Defense += 1;
                                break;
                            case 5:
                                x4.Dodge += 1;
                                break;
                            case 6:
                                x4.Speed += 1;
                                break;
                        }
                    }

                    return x4;

                case 5:
                    var x5 = new GreenOrc();
                    for (int i = exp; i == 0; i--)
                    {
                        Random rr = new Random();
                        int randomexp = r.Next(1, 6);
                        switch (randomexp)
                        {
                            case 1:
                                x5.Health += 1;
                                break;
                            case 2:
                                x5.Aim += 1;
                                break;
                            case 3:
                                x5.Attack += 1;
                                break;
                            case 4:
                                x5.Defense += 1;
                                break;
                            case 5:
                                x5.Dodge += 1;
                                break;
                            case 6:
                                x5.Speed += 1;
                                break;
                        }
                    }

                    return x5;

                case 6:
                    var x6 = new GreyOrc();
                    for (int i = exp; i == 0; i--)
                    {
                        Random rr = new Random();
                        int randomexp = r.Next(1, 6);
                        switch (randomexp)
                        {
                            case 1:
                                x6.Health += 1;
                                break;
                            case 2:
                                x6.Aim += 1;
                                break;
                            case 3:
                                x6.Attack += 1;
                                break;
                            case 4:
                                x6.Defense += 1;
                                break;
                            case 5:
                                x6.Dodge += 1;
                                break;
                            case 6:
                                x6.Speed += 1;
                                break;
                        }
                    }

                    return x6;

                case 7:
                    var x7 = new GreyOrc();
                    for (int i = exp; i == 0; i--)
                    {
                        Random rr = new Random();
                        int randomexp = r.Next(1, 6);
                        switch (randomexp)
                        {
                            case 1:
                                x7.Health += 1;
                                break;
                            case 2:
                                x7.Aim += 1;
                                break;
                            case 3:
                                x7.Attack += 1;
                                break;
                            case 4:
                                x7.Defense += 1;
                                break;
                            case 5:
                                x7.Dodge += 1;
                                break;
                            case 6:
                                x7.Speed += 1;
                                break;
                        }
                    }

                    return x7;

                case 8:
                    var x8 = new ValleyDwarf();
                    for (int i = exp; i == 0; i--)
                    {
                        Random rr = new Random();
                        int randomexp = r.Next(1, 6);
                        switch (randomexp)
                        {
                            case 1:
                                x8.Health += 1;
                                break;
                            case 2:
                                x8.Aim += 1;
                                break;
                            case 3:
                                x8.Attack += 1;
                                break;
                            case 4:
                                x8.Defense += 1;
                                break;
                            case 5:
                                x8.Dodge += 1;
                                break;
                            case 6:
                                x8.Speed += 1;
                                break;
                        }
                    }

                    return x8;

                case 9:
                    var x9 = new LightHum();
                    for (int i = exp; i == 0; i--)
                    {
                        Random rr = new Random();
                        int randomexp = r.Next(1, 6);
                        switch (randomexp)
                        {
                            case 1:
                                x9.Health += 1;
                                break;
                            case 2:
                                x9.Aim += 1;
                                break;
                            case 3:
                                x9.Attack += 1;
                                break;
                            case 4:
                                x9.Defense += 1;
                                break;
                            case 5:
                                x9.Dodge += 1;
                                break;
                            case 6:
                                x9.Speed += 1;
                                break;
                        }
                    }

                    return x9;

                case 10:
                    var x10 = new HighElve();
                    for (int i = exp; i == 0; i--)
                    {
                        Random rr = new Random();
                        int randomexp = r.Next(1, 6);
                        switch (randomexp)
                        {
                            case 1:
                                x10.Health += 1;
                                break;
                            case 2:
                                x10.Aim += 1;
                                break;
                            case 3:
                                x10.Attack += 1;
                                break;
                            case 4:
                                x10.Defense += 1;
                                break;
                            case 5:
                                x10.Dodge += 1;
                                break;
                            case 6:
                                x10.Speed += 1;
                                break;
                        }
                    }

                    return x10;
                    
            }
            return null;
        }
    }


}
