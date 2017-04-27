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
    }
}
