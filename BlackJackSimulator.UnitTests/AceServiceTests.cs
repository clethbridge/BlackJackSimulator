using BlackJackSimulator.Library;
using BlackJackSimulator.Library.Models;
using BlackJackSimulator.Library.Services;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace BlackJackSimulator.UnitTests
{
    public class AceServiceTests
    {
        public AceService sut;

        public AceServiceTests()
        {
            sut = new AceService();
        }

        [Fact(DisplayName = "Derives the high ace value when hand's value doesn't exceed 21")]
        public void CorrectHighAceValue()
        {
            //Arrange
            var hand = new List<Card>()
            {
                { new Card() { Suit = Suit.Clubs, CardType = CardType.Ace, DefaultValue = 1 } },
                { new Card() { Suit = Suit.Clubs, CardType = CardType.Ten, DefaultValue = 10 } }
            };

            //Act
            int value = sut.GetValueOfAce(hand);

            //Assert
            Assert.Equal(11, value);
        }

        [Fact(DisplayName = "Derives the low ace value when hand's value would exceed 21")]
        public void CorrectLowAceValue()
        {
            //Arrange
            var hand = new List<Card>()
            {
                { new Card() { Suit = Suit.Clubs, CardType = CardType.Ace, DefaultValue = 1 } },
                { new Card() { Suit = Suit.Clubs, CardType = CardType.Ten, DefaultValue = 10 } },
                { new Card() { Suit = Suit.Hearts, CardType = CardType.Ten, DefaultValue = 10 } }
            };

            //Act
            int value = sut.GetValueOfAce(hand);

            //Assert
            Assert.Equal(1, value);
        }

        [Fact(DisplayName = "Throws an error when the player's hand doesn't have an Ace")]
        public void ThrowsErrorWhenNoAce()
        {
            //Arrange
            var hand = new List<Card>()
            {
                { new Card() { Suit = Suit.Clubs, CardType = CardType.Four } },
                { new Card() { Suit = Suit.Clubs, CardType = CardType.Ten } }
            };
            
            //Act
            Assert.Throws<NoAceException>(() => sut.GetValueOfAce(hand));
        }
    }
}
