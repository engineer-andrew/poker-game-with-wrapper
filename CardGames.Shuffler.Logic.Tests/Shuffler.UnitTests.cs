using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CardGames.Shuffler.Logic.Tests
{
    [TestClass]
    public class ShufflerUnitTests
    {
        [TestMethod]
        public void ShuffleShouldRandomizeADeckOfCards()
        {
            // arrange
            var shuffler = new Shuffler();

            // act
            var deck = shuffler.Shuffle();

            // assert 
            Assert.AreNotEqual("AH", deck.Cards[0]);
            Assert.AreNotEqual("AD", deck.Cards[13]);
            Assert.AreNotEqual("AC", deck.Cards[26]);
            Assert.AreNotEqual("AS", deck.Cards[39]);
        }
    }
}