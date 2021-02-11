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
    }
}
