using NUnit.Framework;
using System;
using typon;
namespace typon.Tests
{
    [TestFixture()]
    public class WordCollectionTest
    {
        [Test()]
        public void getOneWordShouldNotBeEmpty()
        {
            WordCollection words = new WordCollection();
            Assert.IsNotEmpty(words.getOneRandomWord());
        }

        [Test()]
        public void twoConsecutivegetOneRandomWordShouldNotBeEqual()
        {
            WordCollection words = new WordCollection();
            Assert.That(words.getOneRandomWord(), Is.Not.EqualTo(words.getOneRandomWord()));
        }
    }
}
