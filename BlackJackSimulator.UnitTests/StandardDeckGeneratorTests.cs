using BlackJackSimulator.Library.Generators;
using BlackJackSimulator.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace BlackJackSimulator.UnitTests
{
    public class StandardDeckGeneratorTests
    {
        private StandardDeckGenerator sut;

        public StandardDeckGeneratorTests()
        {
            sut = new StandardDeckGenerator();
        }

        [Fact(DisplayName = "Generates 52 Cards")]
        public void Generates52Cards()
        {
            //Act
            List<Card> deck = sut.Generate();

            //Assert
            Assert.Equal(52, deck.Count);
        }

        [Theory(DisplayName = "Suit has 13 cards")]
        [InlineData(Suit.Hearts)]
        [InlineData(Suit.Clubs)]
        [InlineData(Suit.Spades)]
        [InlineData(Suit.Diamonds)]
        public void SuitHas13Cards(Suit suit)
        {
            //Act
            List<Card> deck = sut.Generate();

            //Assert
            int clubCount = deck.Where(card => card.Suit == suit).Count();
            Assert.Equal(13, clubCount);
        }

        [Theory(DisplayName = "Card Type has 4 cards")]
        [InlineData(CardType.Ace)]
        [InlineData(CardType.Two)]
        [InlineData(CardType.Three)]
        [InlineData(CardType.Four)]
        [InlineData(CardType.Five)]
        [InlineData(CardType.Six)]
        [InlineData(CardType.Seven)]
        [InlineData(CardType.Eight)]
        [InlineData(CardType.Nine)]
        [InlineData(CardType.Ten)]
        [InlineData(CardType.Jack)]
        [InlineData(CardType.Queen)]
        [InlineData(CardType.King)]
        public void CardTypeHas4Cards(CardType cardType)
        {
            //Act
            List<Card> deck = sut.Generate();

            //Assert
            int aceCount = deck.Where(card => card.CardType == cardType).Count();
            Assert.Equal(4, aceCount);
        }

        [Theory(DisplayName = "Generates a deck with the correct default values for each card")]
        [InlineData(Suit.Hearts, CardType.Ace, 1)]
        [InlineData(Suit.Hearts, CardType.Two, 2)]
        [InlineData(Suit.Hearts, CardType.Three, 3)]
        [InlineData(Suit.Hearts, CardType.Four, 4)]
        [InlineData(Suit.Hearts, CardType.Five, 5)]
        [InlineData(Suit.Hearts, CardType.Six, 6)]
        [InlineData(Suit.Hearts, CardType.Seven, 7)]
        [InlineData(Suit.Hearts, CardType.Eight, 8)]
        [InlineData(Suit.Hearts, CardType.Nine, 9)]
        [InlineData(Suit.Hearts, CardType.Ten, 10)]
        [InlineData(Suit.Hearts, CardType.Jack, 10)]
        [InlineData(Suit.Hearts, CardType.Queen, 10)]
        [InlineData(Suit.Hearts, CardType.King, 10)]
        [InlineData(Suit.Clubs, CardType.Ace, 1)]
        [InlineData(Suit.Clubs, CardType.Two, 2)]
        [InlineData(Suit.Clubs, CardType.Three, 3)]
        [InlineData(Suit.Clubs, CardType.Four, 4)]
        [InlineData(Suit.Clubs, CardType.Five, 5)]
        [InlineData(Suit.Clubs, CardType.Six, 6)]
        [InlineData(Suit.Clubs, CardType.Seven, 7)]
        [InlineData(Suit.Clubs, CardType.Eight, 8)]
        [InlineData(Suit.Clubs, CardType.Nine, 9)]
        [InlineData(Suit.Clubs, CardType.Ten, 10)]
        [InlineData(Suit.Clubs, CardType.Jack, 10)]
        [InlineData(Suit.Clubs, CardType.Queen, 10)]
        [InlineData(Suit.Clubs, CardType.King, 10)]
        [InlineData(Suit.Diamonds, CardType.Ace, 1)]
        [InlineData(Suit.Diamonds, CardType.Two, 2)]
        [InlineData(Suit.Diamonds, CardType.Three, 3)]
        [InlineData(Suit.Diamonds, CardType.Four, 4)]
        [InlineData(Suit.Diamonds, CardType.Five, 5)]
        [InlineData(Suit.Diamonds, CardType.Six, 6)]
        [InlineData(Suit.Diamonds, CardType.Seven, 7)]
        [InlineData(Suit.Diamonds, CardType.Eight, 8)]
        [InlineData(Suit.Diamonds, CardType.Nine, 9)]
        [InlineData(Suit.Diamonds, CardType.Ten, 10)]
        [InlineData(Suit.Diamonds, CardType.Jack, 10)]
        [InlineData(Suit.Diamonds, CardType.Queen, 10)]
        [InlineData(Suit.Diamonds, CardType.King, 10)]
        [InlineData(Suit.Spades, CardType.Ace, 1)]
        [InlineData(Suit.Spades, CardType.Two, 2)]
        [InlineData(Suit.Spades, CardType.Three, 3)]
        [InlineData(Suit.Spades, CardType.Four, 4)]
        [InlineData(Suit.Spades, CardType.Five, 5)]
        [InlineData(Suit.Spades, CardType.Six, 6)]
        [InlineData(Suit.Spades, CardType.Seven, 7)]
        [InlineData(Suit.Spades, CardType.Eight, 8)]
        [InlineData(Suit.Spades, CardType.Nine, 9)]
        [InlineData(Suit.Spades, CardType.Ten, 10)]
        [InlineData(Suit.Spades, CardType.Jack, 10)]
        [InlineData(Suit.Spades, CardType.Queen, 10)]
        [InlineData(Suit.Spades, CardType.King, 10)]

        public void CardValuesAreCorrect(Suit suit, CardType cardType, int expectedValue)
        {
            var deck = sut.Generate();

            Card card = deck.FirstOrDefault(card => card.Suit == suit && card.CardType == cardType);

            Assert.NotNull(card);
            Assert.Equal(expectedValue, card?.DefaultValue);
        }
    }
}
