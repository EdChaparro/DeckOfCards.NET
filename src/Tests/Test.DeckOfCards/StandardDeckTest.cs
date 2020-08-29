using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace IntrepidProducts.DeckOfCards.Test
{
    [TestClass]
    public class StandardDeckTest
    {
        [TestMethod]
        public void ShouldContain52Cards()
        {
            var deck = new StandardDeck();
            Assert.AreEqual(52, deck.Cards.Count);
        }

        [TestMethod]
        public void ShouldShuffleCards()
        {
            var deck1 = new StandardDeck();
            var deck2 = new StandardDeck();

            Assert.IsTrue(deck1.Cards.SequenceEqual(deck2.Cards));

            deck1.Shuffle();
            deck2.Shuffle();

            Assert.AreEqual(52, deck1.Cards.Count);
            Assert.AreEqual(52, deck2.Cards.Count);

            Assert.IsFalse(deck1.Cards.SequenceEqual(deck2.Cards));
        }
    }
}
