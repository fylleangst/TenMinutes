using NUnit.Framework;
using TenMinutes;
using Assert = NUnit.Framework.Assert;

namespace TenMinutesUnitTests
{
	[TestFixture()]
	public class TasksTest
	{
		[Test]
		public void GetMainTaskTest()
		{
			var mainTask = new Tasks();

			Assert.That(mainTask.GetMainTasks(1), Is.AtLeast("Obsidian"));
			Assert.That(mainTask.GetMainTasks(10), Is.AtLeast("Game"));
			Assert.That(mainTask.GetMainTasks(20), Is.AtLeast("Develop"));
			Assert.That(mainTask.GetMainTasks(30), Is.AtLeast("Write"));
			Assert.That(mainTask.GetMainTasks(40), Is.AtLeast("Hiveworld"));
			Assert.That(mainTask.GetMainTasks(50), Is.AtLeast("Home"));
			Assert.That(mainTask.GetMainTasks(60), Is.AtLeast("Big List"));
			Assert.That(mainTask.GetMainTasks(70), Is.AtLeast("Educate"));
			Assert.That(mainTask.GetMainTasks(80), Is.AtLeast("Reinvent"));
		}

		[Test]
		public void GetDevelopSubTaskTest()
		{
			var subTask = new Tasks();

			Assert.That(subTask.GetDevelopSubTask(1), Is.EqualTo("Git"));
		}
	}
}
