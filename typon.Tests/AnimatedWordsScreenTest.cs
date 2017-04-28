﻿using NUnit.Framework;
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

		[Test]
		public void checkAndRemoveExistingWordShoudlRemoveOneWord()
		{
			AnimatedWordsScreen screen = new AnimatedWordsScreen(60, 20);
			screen.addWordToGame("test");
			screen.addWordToGame("another");
            screen.addWordToGame("other");
            Assert.AreEqual(3, screen.numberOfWordsInGame());
			screen.checkAndRemoveWordInGame("test");
            Assert.AreEqual(2, screen.numberOfWordsInGame());
		}

        [Test]
        public void lostOneLifeShouldRemoveOneLife(){
            AnimatedWordsScreen screen = new AnimatedWordsScreen(60, 20);
            Assert.AreEqual(8, screen.livesLeft());
            screen.looseOneLive();
            Assert.AreEqual(7, screen.livesLeft());
        }
    }
}
