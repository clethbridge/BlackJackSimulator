using BlackJackSimulator.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackJackSimulator.Library.Generators
{
    public interface IStandardDeckGenerator
    { 
    
    }

    public class StandardDeckGenerator : IStandardDeckGenerator
    {
        public List<Card> Generate()
        {
            IEnumerable<Suit> suits = GetEnumValues<Suit>();

            IEnumerable<CardType> cardTypes = GetEnumValues<CardType>();

            var cards = 
                 suits
                .SelectMany(
                     suit => cardTypes.Select(cardType => GenerateCard(suit, cardType)))
                .ToList();

            return cards;
        }

        private Card GenerateCard(Suit suit, CardType cardType) =>
            new Card(){ Suit = suit, CardType = cardType };

        private IEnumerable<TEnum> GetEnumValues<TEnum>() =>
             Enum
            .GetValues(typeof(TEnum))
            .Cast<TEnum>();
    }
}
