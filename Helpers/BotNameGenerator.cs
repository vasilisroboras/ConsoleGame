using System;
using System.Collections.Generic;

namespace WorldofAdventures.Interfaces
{
	public interface IBotNameGenerator
	{
		string GenerateName();
	}

	public class DefaultBotNameGenerator : IBotNameGenerator
	{
		private Random _random = new Random();

		private List<string> _randomNames = new List<string>
		{
			"Dynamo",
			"Soula",
			"Grrrepsilon",
			"Luna"
		};

		public string GenerateName()
		{
			int nameIndex = _random.Next(0, _randomNames.Count);
			string name = _randomNames[nameIndex];

			if (name.Length < 4)
				throw new Exception("Name must be more than 4 characters!");

			return name + _random.Next(0, 10000).ToString().PadLeft(4, '0');
		}
	}

	class OnlineBotNameGenerator : IBotNameGenerator
	{
		public string GenerateName()
		{
			throw new NotImplementedException();
		}
	}
}
