using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;

namespace CardGames.Shuffler.Logic.Tests
{
    [TestClass]
    public class ShufflerUnitTests
    {
    private Mock<IWrapRandom> _moqRandomWrapper;

        [TestInitialize]
        public void Setup()
        {
            _moqRandomWrapper = new Mock<IWrapRandom>();

            var random = new Random();
            _moqRandomWrapper.Setup(p => p.Next(It.IsAny<int>(), It.IsAny<int>()))
                .Returns(() => random.Next(1, 53));
        }

        [TestMethod]
        public void ShuffleShouldMoveAces()
        {
            // arrange
            var shuffler = new Shuffler(_moqRandomWrapper.Object);

            // act
            var deck = shuffler.Shuffle();

            // assert 
            Assert.AreNotEqual("AH", deck.Cards[0]);
            Assert.AreNotEqual("AD", deck.Cards[13]);
            Assert.AreNotEqual("AC", deck.Cards[26]);
            Assert.AreNotEqual("AS", deck.Cards[39]);
        }

        [TestMethod]
        public void ShuffleShouldRandomizeADeckOfCards()
        {
            // arrange
            var unshuffledDeck = new List<string>
            {
                "AH", "2H", "3H", "4H", "5H", "6H", "7H", "8H", "9H", "10H",
                "JH", "QH", "KH", "AD", "2D", "3D", "4D", "5D", "6D", "7D",
                "8D", "9D", "10D", "JD", "QD", "KD", "AC", "2C", "3C", "4C",
                "5C", "6C", "7C", "8C", "9C", "10C", "JC", "QC", "KC", "AS",
                "2S", "3S", "4S", "5S", "6S", "7S", "8S", "9S", "10S", "JS",
                "QS", "KS"
            };
            var shuffler = new Shuffler(_moqRandomWrapper.Object);

            // act
            var deck = shuffler.Shuffle();

            // assert
            var numberOfMatches = 0;
            for (var i = 0; i < 52; i++)
            {
                if (unshuffledDeck[i] == deck.Cards[i] ||
                    (i > 0 && deck.Cards[i - 1] == unshuffledDeck[i]) ||
                    (i < 51 && deck.Cards[i + 1] == unshuffledDeck[i]))
                {
                    numberOfMatches++;
                }
            }
            Assert.IsTrue(numberOfMatches < 5,
                $"{numberOfMatches} is not less than 5");
        }

        [TestMethod]
        public void ShuffleShouldGetAtLeast52RandomNumbersBetween1And53()
        {
            // arrange
            var shuffler = new Shuffler(_moqRandomWrapper.Object);

            // act
            shuffler.Shuffle();

            // assert
            _moqRandomWrapper.Verify(p => p.Next(1, 53), Times.AtLeast(52));
        }
    }
}