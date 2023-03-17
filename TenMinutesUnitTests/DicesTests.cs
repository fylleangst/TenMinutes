using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using TenMinutes;
using Assert = NUnit.Framework.Assert;

namespace TenMinutesUnitTests
{
	[TestFixture]
	public class DicesTests
	{
		[Test]
		public void TestD6Roll()
		{
			var roll = new Dices();
			Assert.That(roll.D6(), Is.InRange(1,6));
		}

		[Test]
		public void TestDice()
		{
			var roll = new Dices().Dice(4);
			Assert.That(roll, Is.InRange(1,4));
		}
	}
}
