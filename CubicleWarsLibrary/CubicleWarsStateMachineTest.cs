using System;
using NUnit.Framework;
using NSubstitute;

namespace CubicleWarsLibrary
{
	[TestFixture]
	public class CubicleWarsStateMachineTest
	{
		[Test]
		public void TestCreation()
		{
			var playerOne = Substitute.For<Player>();
			var playerTwo = Substitute.For<Player>();
			
			var stateMachine = new CubicleWarsStateMachineTest(playerOne, playerTwo);
			
			Assert.IsNotNull(stateMachine);
		}
	}
}

