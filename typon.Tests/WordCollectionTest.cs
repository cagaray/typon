using NUnit.Framework;
using System;
using typon;
namespace typon.Tests
{
    [TestFixture()]
    public class WordCollectionTest
    {
        [Test()]
        public void getOneWordShouldGetOneWord()
        {
            WordCollection words = new WordCollection();
            Assert.IsNotEmpty(words.getOneRandomWord());
        }
    }
}
