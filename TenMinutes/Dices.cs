using System;

namespace TenMinutes
{
	public class Dices
	{
		public int D6()
		{
			return random(6);
		}

		public int D100()
		{
			return random(100);
		}

		public int Dice(int sides)
		{
			var result = random(sides);
			return result;
		}
		private int random(int eyes, int times=1)
		{
			var random = new Random();

			var result = random.Next(1, eyes);

			return result;
		}
	}
}
