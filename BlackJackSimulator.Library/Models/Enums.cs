using BlackJackSimulator.Library.Decorators;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlackJackSimulator.Library.Models
{
    public enum CardType
    { 
        [CardValue(1)]
        Ace,
        [CardValue(2)]
        Two,
        [CardValue(3)]
        Three,
        [CardValue(4)]
        Four,
        [CardValue(5)]
        Five,
        [CardValue(6)]
        Six,
        [CardValue(7)]
        Seven,
        [CardValue(8)]
        Eight,
        [CardValue(9)]
        Nine,
        [CardValue(10)]
        Ten,
        [CardValue(10)]
        Jack,
        [CardValue(10)]
        Queen,
        [CardValue(10)]
        King
    }

    public enum Suit
    { 
        Hearts,
        Clubs,
        Spades,
        Diamonds
    }
}
