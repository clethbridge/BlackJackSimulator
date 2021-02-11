using BlackJackSimulator.Library.Generators;
using BlackJackSimulator.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace BlackJackSimulator.UnitTests
{
    public class PlayerGeneratorTests
    {
        private PlayerGenerator sut;

        public PlayerGeneratorTests()
        {
            sut = new PlayerGenerator();
        }

        [Fact(DisplayName = "Generates the specified amount of users")]
        public void CorrectAmountOfUsersGenerated()
        {
            List<Player> players = sut.Generate(amount:2);

            Assert.Equal(2, players.Count);
        }

        [Fact(DisplayName = "A single dealer was generated")]
        public void GeneratesOneDealer()
        {
            List<Player> players = sut.Generate(amount: 6);

            Assert.Single(players.Where(p => p.IsDealer));
        }
    }
}
