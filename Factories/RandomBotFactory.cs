using System;
using System.Collections.Generic;
using WorldofAdventures.classes;
using WorldofAdventures.Enums;
using WorldofAdventures.Interfaces;

namespace WorldofAdventures.Factories
{
	class RandomBotFactory
	{
		private static Random _random = new Random();
		private static List<Type> _allRaces = new List<Type>
		{
			typeof(DarkHum),
			typeof(LightHum),
			typeof(DarkElve),
			typeof(HighElve),
			typeof(ChromaticDragon),
			typeof(MetallicDragon),
			typeof(GreenOrc),
			typeof(GreyOrc),
			typeof(MountainDwarf),
			typeof(ValleyDwarf)
		};

		private readonly IBotNameGenerator _botNameGenerator;

		public RandomBotFactory(IBotNameGenerator botNameGenerator)
		{
			_botNameGenerator = botNameGenerator;
		}

		public Bot CreateEasyBot(int level, bool isBoss)
			=> new Bot
			{
				Name = _botNameGenerator.GenerateName(),
				BotType=1,
				SubRace = GetBotRace(BotType.Easy, level, isBoss)

			};


		public Bot CreateNormalBot(int level, bool isBoss)
			=> new Bot
			{
				Name = _botNameGenerator.GenerateName(),
				BotType = 2,
				SubRace = GetBotRace(BotType.Normal, level, isBoss)
			};

		public Bot CreateHardBot(int level, bool isBoss)
			=> new Bot
			{
				Name = _botNameGenerator.GenerateName(),
				BotType = 3,
				SubRace = GetBotRace(BotType.Hard, level, isBoss)
			};

		private Race GetBotRace(BotType botType, int level, bool isBoss)
		{
			int randomRaceIndex = _random.Next(0, _allRaces.Count);

			Race race = (Race)Activator.CreateInstance(_allRaces[randomRaceIndex]);

			int statPoints = GetBotStats(botType, level, isBoss);

			var properties = race.GetType().GetProperties();

			for (int i = 0; i <= statPoints; i++)
			{
				int propertyIndex = _random.Next(0, properties.Length);

				int currentValue = (int)properties[propertyIndex].GetValue(race);

				int newValue = currentValue + 1;

				properties[propertyIndex].SetValue(race, newValue);
			}

			return race;
		}

		private int GetBotStats(BotType botType, int level, bool isBoss)
			=> level * (
					((int)botType) * _random.Next(0, 6) + 5 +
					(isBoss ? (_random.Next(0, 10) + 10) : 0)
				);
	}
}
