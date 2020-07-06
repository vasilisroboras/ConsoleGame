using System;


namespace WorldofAdventures.classes
{
	public class Orc : Race
	{
		public Orc()
		{
			Attack += 10;
		}
	}

	public class GreenOrc : Orc
	{
		public GreenOrc()
		{
			Defense += 10;
		}
	}

	public class GreyOrc : Orc
	{
		public GreyOrc()
		{
			Attack += 10;
		}
	}
}