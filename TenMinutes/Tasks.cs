using System.Collections.Generic;

namespace TenMinutes
{
	public class Tasks
	{
		private readonly List<string> _writeList = new List<string>{"Roleplay", "Threads", "Boardgame fluff", "A short story", "Obsidian"};
		private readonly List<string> _development = new List<string> { "Fix this app", "An existing thing", "Something from the cloud", "Obsidian Development" };
		private readonly List<string> _obsidian = new List<string> { "The Big List", "TTRPG", "Boardgame", "Hiveworld", "Campaigns", "Daglige oppgaver" };
		private readonly List<string> _hiveWorld = new List<string> { "Tales", "Hotseat", "Hivehub", "Nørdheim", "fylleangst records", "GM tools", "Scoreboard" };
		private readonly List<string> _home = new List<string> { "Clean or move something", "Wash-stuff", "Garbage/Throw away", "Sell stuff"};
		private readonly List<string> _gameList = new List<string> { "Computergame", "Boardgame", "Onlinegaming", "Mobile", "Roleplaycleanup", "Boardgamecleanup" };
		private readonly List<string> _theListOfEverything = new List<string> {"Roll on the list", "Create a new list", "Clean the lists" };
		private readonly List<string> _developmentEducation = new List<string> {"Git", "TFS", "Python", "Android", "HTML", "C#", "Java", ""};
		private readonly List<string> _education = new List<string> {"Writing", "Namebuilding", "Online stuff", "Instruments"};

		public string GetMainTasks(int roll)
		{
			var mainTask = "Do what you want";
			var subTaskRoll = new Dices();

			var choice = 0;

			if (roll > 0) { choice = 1; }
			if (roll > 9) { choice = 2; }
			if (roll > 19) { choice = 3; }
			if (roll > 29) { choice = 4; }
			if (roll > 39) { choice = 5; }
			if (roll > 49) { choice = 6; }
			if (roll > 59) { choice = 7; }
			if (roll > 69) { choice = 8; }
			if (roll > 79) { choice = 9; }
			//if (roll > 89) { choice = 10; }
			switch (choice)
			{
				case 1:
					return $"Obsidian - {_obsidian[subTaskRoll.Dice(_obsidian.Count)-1]}";
				case 2:
					return $"Game - {_gameList[subTaskRoll.Dice(_gameList.Count) - 1]}";
				case 3:
					return $"Develop - {_development[subTaskRoll.Dice(_development.Count)-1]}";
				case 4:
					return $"Write - {_writeList[subTaskRoll.Dice(_writeList.Count)-1]}";
				case 5:
					return $"Hiveworld - {_hiveWorld[subTaskRoll.Dice(_hiveWorld.Count) - 1]}";
				case 6:
					return $"Home - {_home[subTaskRoll.Dice(_home.Count) - 1]}";
				case 7:
					return $"Big List on Obsidian - { _theListOfEverything[subTaskRoll.Dice(_theListOfEverything.Count) - 1]}";
				case 8:
					return $"Educate your computerskills - {_developmentEducation[subTaskRoll.Dice(_developmentEducation.Count) - 1]}";
				case 9:
					return $"Reinvent yourself - {_education[subTaskRoll.Dice(_education.Count)-1]}";
				default:
					return mainTask;
			}
		}

		private void TheChecklist()
		{

		}
		public string SomeHintsAndTips()
		{
			var d6 = new Dices();
			var d100 = new Dices();

			var hintsAndTips = $"d6: {d6.D6()} - d100: {d100.D100()}";

			return hintsAndTips;
		}

		public List<int> Done
		{
			get; set;
		}
		public string GetDevelopSubTask(int roll)
		{
			var subTask = _developmentEducation[roll - 1];
			return subTask;
		}
	}
}
