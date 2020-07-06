using System;
using WorldofAdventures.classes;
using System.Collections.Generic;
using WorldofAdventures.Factories;
using WorldofAdventures.Enums;
using System.Linq;
using WorldofAdventures.Interfaces;

namespace WorldofAdventures
{
	
	class Program
	{
		public static List<Bot> Bots = new List<Bot>();

		private static Random _random = new Random();

		static void Main(string[] args)
		{
			string playAgain;
			do
			{

				Console.ForegroundColor = ConsoleColor.Blue;
				Console.WriteLine("In this game you choose a character of your choice and you must Fight 100 hunder enemies.Every time you win one enemy the next one will be harder, after every win you will be rewarder with some point to put in your health,attack,defens,speed,aim and dodge.Choose wisely!", Console.ForegroundColor);


				RandomBotFactory randomBotFactory = new RandomBotFactory(new DefaultBotNameGenerator());

				for (int level = 1; level <= 100; level++)
				{
					bool isBoss = level % 10 == 0;
					int botType = _random.Next((int)BotType.Easy, (int)BotType.Hard + 1);

					switch (botType)
					{
						case (int)BotType.Easy:
							Bots.Add(randomBotFactory.CreateEasyBot(level, isBoss));
							break;
						case (int)BotType.Normal:
							Bots.Add(randomBotFactory.CreateNormalBot(level, isBoss));
							break;
						case (int)BotType.Hard:
							Bots.Add(randomBotFactory.CreateHardBot(level, isBoss));
							break;
						default:
							break;
					}
				}

				//Console.WriteLine($"{nameof(Human)}: {Bots.Select(x => x.SubRace).Where(x => x.GetType().IsSubclassOf(typeof(Human))).Count()}");
				//Console.WriteLine($"{nameof(Elve)}: {Bots.Select(x => x.SubRace).Where(x => x.GetType().IsSubclassOf(typeof(Elve))).Count()}");
				//Console.WriteLine($"{nameof(Orc)}: {Bots.Select(x => x.SubRace).Where(x => x.GetType().IsSubclassOf(typeof(Orc))).Count()}");
				//Console.WriteLine($"{nameof(Dwarf)}: {Bots.Select(x => x.SubRace).Where(x => x.GetType().IsSubclassOf(typeof(Dwarf))).Count()}");
				//Console.WriteLine($"{nameof(Dragon)}: {Bots.Select(x => x.SubRace).Where(x => x.GetType().IsSubclassOf(typeof(Dragon))).Count()}");
				//Console.WriteLine($"{nameof(Race)}: {Bots.Select(x => x.SubRace).Where(x => x.GetType().IsSubclassOf(typeof(Race))).Count()}");


				Console.ForegroundColor = ConsoleColor.Blue;
				Character newchar = new Character();

				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine("You must choose your character name and subrace player.", Console.ForegroundColor);

				Console.WriteLine("Give your name");
				string charactername = Console.ReadLine();


				Console.WriteLine("Give your race. You can choose an character of ");
				Console.ForegroundColor = ConsoleColor.Green;
				Console.WriteLine("(1) DarkHuman ", Console.ForegroundColor);
				Console.WriteLine("(2) DarkElve", Console.ForegroundColor);
				Console.WriteLine("(3) ChromaticDragon", Console.ForegroundColor);
				Console.WriteLine("(4) MetallicDragon", Console.ForegroundColor);
				Console.WriteLine("(5) ValleyDwarf", Console.ForegroundColor);
				Console.WriteLine("(6)MountainDwarf", Console.ForegroundColor);
				Console.WriteLine("(7)  GreenOrc", Console.ForegroundColor);
				Console.WriteLine("(8)  GreyOrc", Console.ForegroundColor);
				Console.WriteLine("(9) LightHum", Console.ForegroundColor);
				Console.WriteLine("(10)  HighElve", Console.ForegroundColor);





				newchar.chooseNameRace(ref charactername);
				Console.WriteLine("Your characters Attack is " + newchar.characterRace.Attack);
				Console.WriteLine("Your characters Aim is " + newchar.characterRace.Aim);
				Console.WriteLine("Your characters Defense is " + newchar.characterRace.Defense);
				Console.WriteLine("Your characters Dodge is " + newchar.characterRace.Dodge);
				Console.WriteLine("Your characters Health is " + newchar.characterRace.Health);
				Console.WriteLine("Your characters Speed is " + newchar.characterRace.Speed);




				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine("Game Strats", Console.ForegroundColor);
				var startGame = new Game();
				int PlayerBar = 0;
				int BotBar = 0;
				int WhoPlays = 0;
				int dodgeOncePer3AttacksForBot = 0;
				int dodgeOncePer3AttacksForPlayer = 0;
				for (int i = 1; i <= 100; i++)
				{
					Console.ForegroundColor = ConsoleColor.White;
					Console.WriteLine("Round " + i + ".");
					do
					{

						if (i == 10)
						{
							Console.WriteLine("This is a Boss Fight.Be ready Player");
						}
						startGame.BarMode(newchar.characterRace.Speed, Bots[i].SubRace.Speed, ref WhoPlays, ref PlayerBar, ref BotBar);
						/*
							Console.WriteLine("Whopalys is " + WhoPlays  );
							Console.WriteLine("PlayerBar is " + PlayerBar );
							Console.WriteLine("BotBar is " + BotBar);
						Console.WriteLine("Players attack is " + newchar.characterRace.Attack);
						Console.WriteLine("Bot attack is " + Bots[i].SubRace.Attack);
						Console.WriteLine("bot i is " + i);
						Console.WriteLine("Players Health is" +newchar.characterRace.Attack);

						*/

						if (WhoPlays == 0)
						{
							Console.ForegroundColor = ConsoleColor.Cyan;
							Console.WriteLine("Player Is Ready To Attack.");


							int dodging = startGame.DodgeMode(newchar.characterRace.Aim, Bots[i].SubRace.Dodge);

							if (dodging <= 0 && dodgeOncePer3AttacksForBot == 0)
							{

								Console.WriteLine("Bot Dodged this attack.He will not be able to dodge the 3 nexts attacks.");
								dodgeOncePer3AttacksForBot = 3;

							}
							else
							{


								Console.WriteLine("Player is attacking");
								double criticalDamage = startGame.CriticalMode(newchar.characterRace.Attack);
								double DamageGiven = startGame.AttackingMode(criticalDamage, Bots[i].SubRace.Defense);
								Bots[i].SubRace.Health -= Convert.ToInt32(DamageGiven);
								Console.WriteLine("Bot health is now " + Bots[i].SubRace.Health + ".");

								dodgeOncePer3AttacksForBot -= 1;
							}
							Console.ForegroundColor = ConsoleColor.DarkGreen;
							Console.WriteLine("End of Attack.", Console.ForegroundColor);
						}


						else if (WhoPlays == 1)
						{
							Console.ForegroundColor = ConsoleColor.Cyan;
							Console.WriteLine("Bot Is Ready To Attack.");
							int dodging = startGame.DodgeMode(Bots[i].SubRace.Aim, newchar.characterRace.Dodge);

							if (dodging > 0 && dodgeOncePer3AttacksForPlayer == 0)
							{
								Console.WriteLine("Player Dodged this attack.He will not be able to dodge the 3 next attacks.");

								dodgeOncePer3AttacksForPlayer = 3;

							}
							else
							{


								Console.WriteLine("Bot is attacking");
								double criticalDamage = startGame.CriticalMode(Bots[i].SubRace.Attack);
								double DamageGiven = startGame.AttackingMode(criticalDamage, newchar.characterRace.Defense);
								newchar.characterRace.Health -= Convert.ToInt32(DamageGiven);
								Console.WriteLine("Players health is now " + newchar.characterRace.Health + ".");
								dodgeOncePer3AttacksForPlayer -= 1;
							}
							Console.ForegroundColor = ConsoleColor.DarkGreen;
							Console.WriteLine("End of Attack.", Console.ForegroundColor);
						}

						WhoPlays = 0;


					} while (newchar.characterRace.Health > 0 && Bots[i].SubRace.Health > 0);

					dodgeOncePer3AttacksForBot = 0;
					dodgeOncePer3AttacksForPlayer = 0;


					if (newchar.characterRace.Health <= 0)
					{
						Console.WriteLine("You died");
						break;
					}
					else if (Bots[i].SubRace.Health <= 0)
					{
						Console.WriteLine("You Won");

						bool isBoss = i % 10 == 0;
						newchar.editStats(Bots[i].BotType, i, isBoss, newchar.characterRace);

					}

					
					
				}
				Console.WriteLine("Do you want to play again?");
				Console.WriteLine("(1) YES");
				Console.WriteLine("(2) NO");
				 playAgain = Console.ReadLine();
			} while (playAgain == "1");

		}
	}
}
