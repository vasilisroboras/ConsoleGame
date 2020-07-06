using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using WorldofAdventures.classes;
using WorldofAdventures.Enums;
namespace WorldofAdventures.classes
{
    class Character : Player
    {

        private static Random _random = new Random();
        string characterName;
        public Race characterRace;
        public Race chooseNameRace(ref string name)
        {
            characterName = name;

            
            bool correctOption;

            do
            {
                string characterRaceChoice = Console.ReadLine();
                correctOption = true;


                if (characterRaceChoice == "1")
                {
                    Console.WriteLine("Your character name is " + characterName + " he is a DarkHuman.");
                    characterRace = new DarkHum();
                }
                else if (characterRaceChoice == "2")
                {
                    Console.WriteLine("Your character name is " + characterName + " he is a DarkElve.");
                    characterRace = new DarkElve();
                }
                else if (characterRaceChoice == "3")
                {
                    Console.WriteLine("Your character name is " + characterName + " he is a ChromaticDragon.");
                    characterRace = new ChromaticDragon();
                }
                else if (characterRaceChoice == "4")
                {
                    Console.WriteLine("Your character name is " + characterName + " he is a MetallicDragon.");
                    characterRace = new MetallicDragon();
                }
                else if (characterRaceChoice == "5")
                {
                    Console.WriteLine("Your character name is " + characterName + " he is a ValleyDwarf.");
                    characterRace = new ValleyDwarf();
                }
                else if (characterRaceChoice == "6")
                {
                    Console.WriteLine("Your character name is " + characterName + " he is a MountainDwarf.");
                    characterRace = new ValleyDwarf();
                }
                else if (characterRaceChoice == "7")
                {
                    Console.WriteLine("Your character name is " + characterName + " he is a GreenOrc.");
                    characterRace = new GreenOrc();
                }
                else if (characterRaceChoice == "8")
                {
                    Console.WriteLine("Your character name is " + characterName + " he is a GreyOrc.");
                    characterRace = new GreyOrc();
                }
                else if (characterRaceChoice == "9")
                {
                    Console.WriteLine("Your character name is " + characterName + " he is a LightHuman.");
                    characterRace = new LightHum();
                }
                else if (characterRaceChoice == "10")
                {
                    Console.WriteLine("Your character name is " + characterName + " he is a HighElve.");
                    characterRace = new HighElve();
                }
                else
                {
                    Console.WriteLine("Invalide choice. Pick again:");

                    correctOption = false;
                }
            } while (correctOption == false);

            return characterRace;
            




        }
        
        
        public void editStats(int botType, int level, bool isBoss,Race CharacterRace)
        {
            Console.WriteLine("Bot type is "+(int)botType);
            int statPoints = GetBotStats(botType, level, isBoss);

            Console.WriteLine("You have " + statPoints + "points to add.");
            Console.WriteLine("Choose where to put  point :" );
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("(1) Attack ", Console.ForegroundColor);
            Console.WriteLine("(2) Health", Console.ForegroundColor);
            Console.WriteLine("(3) Defense", Console.ForegroundColor);
            Console.WriteLine("(4) Speed", Console.ForegroundColor);
            Console.WriteLine("(5) Dodge", Console.ForegroundColor);
            Console.WriteLine("(6) Aim", Console.ForegroundColor);
            

            for (int i = 0; i <= statPoints-1; i++)
            {

                Console.WriteLine(statPoints-i+" points left");

                string modifie = Console.ReadLine();
                if(modifie == "1")
                {
                    CharacterRace.Attack += 1;
                    Console.WriteLine("Your characters Attack now is " + CharacterRace.Attack);
                }
                else if(modifie == "2")
                {
                    CharacterRace.Health += 1;
                    Console.WriteLine("Your characters Health now is " + CharacterRace.Health);
                }
                else if (modifie == "3")
                {
                    CharacterRace.Defense += 1;
                    Console.WriteLine("Your characters Defense now is " + CharacterRace.Defense);
                }
                else if (modifie == "4")
                {
                    CharacterRace.Speed += 1;
                    Console.WriteLine("Your characters Speed now is " + CharacterRace.Speed);
                }
                else if (modifie == "5")
                {
                    CharacterRace.Dodge += 1;
                    Console.WriteLine("Your characters Dodge now is " + CharacterRace.Dodge);
                }
                else if (modifie == "6")
                {
                    CharacterRace.Aim += 1;
                    Console.WriteLine("Your characters Aim now is " + CharacterRace.Aim);
                }
                else
                {
                    Console.WriteLine("Wrong input.Give again.");
                    i -= 1;
                }

                
                
            }
            
            

        }

        private int GetBotStats(int botType, int level, bool isBoss)
            => level * (
                    botType * _random.Next(0, 6) + 5 +
                    (isBoss ? (_random.Next(0, 10) + 10) : 0)
                );


    }
}
