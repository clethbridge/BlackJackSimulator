using BlackJackSimulator.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackJackSimulator.Library.Services
{
    public interface IAceService
    {
        int GetValueOfAce(IEnumerable<Card> hand);
    }

    public class AceService : IAceService
    {
        private const int blackJackLimit = 21;

        private const int highAceValue = 11;

        private const int lowAceValue = 1;

        public int GetValueOfAce(IEnumerable<Card> hand)
        {
            bool anyAces = hand.Any(card => card.CardType == CardType.Ace);

            if (anyAces)
            {
                var sumOfOtherCards = GetSumOfOtherCards(hand);

                bool exceedsLimit = sumOfOtherCards + highAceValue > blackJackLimit;

                return exceedsLimit ? lowAceValue : highAceValue;
            }
            else
            {
                throw new NoAceException();
            }
        }

        private int GetSumOfOtherCards(IEnumerable<Card> hand) =>
             hand
            .Where(card => card.CardType != CardType.Ace)
            .Sum(card => card.DefaultValue);
    }
}
