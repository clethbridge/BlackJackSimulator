using BlackJackSimulator.Library.Decorators;
using BlackJackSimulator.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace BlackJackSimulator.Library.Generators
{
    public interface IStandardDeckGenerator
    {
        List<Card> Generate();
    }

    public class StandardDeckGenerator : IStandardDeckGenerator
    {
        private List<Suit> suits;

        private List<CardType> cardTypes;

        private Type enumType;

        public StandardDeckGenerator()
        {
            enumType = typeof(CardType);

            suits = GetEnumValues<Suit>();

            cardTypes = GetEnumValues<CardType>();
        }

        public List<Card> Generate()
        {
            var cards = 
                 suits
                .SelectMany(
                     suit => cardTypes.Select(cardType => GenerateCard(suit, cardType)))
                .ToList();

            return cards;
        }

        private Card GenerateCard(Suit suit, CardType cardType)
        {
            int value = GetValue(cardType);

            var card = new Card() { Suit = suit, CardType = cardType, DefaultValue = value };

            return card;
        }

        private int GetValue(CardType cardType)
        {
            var memberInfos = enumType.GetMember(cardType.ToString());

            MemberInfo enumValueMemberInfo = memberInfos.FirstOrDefault(m => m.DeclaringType == enumType);

            var valueAttributes = enumValueMemberInfo.GetCustomAttributes(typeof(CardValueAttribute), false);

            return ((CardValueAttribute)valueAttributes[0]).Value;
        }

        private List<TEnum> GetEnumValues<TEnum>() =>
             Enum
            .GetValues(typeof(TEnum))
            .Cast<TEnum>()
            .ToList();
    }
}
