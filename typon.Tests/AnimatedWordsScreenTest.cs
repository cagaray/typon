using NUnit.Framework;
using System;
namespace typon.Tests
{
    [TestFixture()]
    public class AnimatedWordsScreenTest
    {
        [Test()]
        public void drawScreenShouldNotThrowException()
        {
            AnimatedWordsScreen screen = new AnimatedWordsScreen(60, 20);
            Assert.DoesNotThrow(() => { screen.DrawScreen(); });
        }

		[Test()]
		public void addWordToGameShouldNotThrowException()
		{
			AnimatedWordsScreen screen = new AnimatedWordsScreen(60, 20);
            Assert.DoesNotThrow(() => { screen.addWordToGame("test"); });
		}

		[Test()]
		public void moveWordsOneRowShouldNotThrowException()
		{
			AnimatedWordsScreen screen = new AnimatedWordsScreen(60, 20);
			Assert.DoesNotThrow(() => { screen.moveWordsOneRow(); });
		}

        [Test]
        public void checkExistingWordShoudlReturnTrue()
        {
            AnimatedWordsScreen screen = new AnimatedWordsScreen(60, 20);
            screen.addWordToGame("test");
            screen.addWordToGame("another");
            Assert.True(screen.checkWordInGame("test"));
        }

		[Test]
		public void checkNonExistingWordShoudlReturnFalse()
		{
			AnimatedWordsScreen screen = new AnimatedWordsScreen(60, 20);
			screen.addWordToGame("test");
			screen.addWordToGame("another");
            Assert.False(screen.checkWordInGame("other"));
		}
    }
}
