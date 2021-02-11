using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace BlackJackSimulator.Library.Models
{
    [DebuggerDisplay("{CardType} of {Suit}")]
    public class Card
    {
        public Suit Suit { get; set; }

        public CardType CardType { get; set; }

        public int DefaultValue { get; set; }
    }
}
