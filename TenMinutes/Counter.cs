using System.Timers;

namespace TenMinutes
{
	public class Counter
	{
		public void Countdown()
		{
			var t = new Timer { Interval = 1000 * 60 * 10 };

			//t.Elapsed += FindNewToDo;
			t.Enabled = true;
			t.Start();
		}

	}
}
