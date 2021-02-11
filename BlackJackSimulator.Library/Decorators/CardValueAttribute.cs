using System;
using System.Collections.Generic;
using System.Text;

namespace BlackJackSimulator.Library.Decorators
{
    public class CardValueAttribute: Attribute
    {
        public int Value { get; set; }

        public CardValueAttribute(int value)
        {
            Value = value;
        }
    }
}
