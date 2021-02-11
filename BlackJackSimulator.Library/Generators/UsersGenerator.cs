using BlackJackSimulator.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackJackSimulator.Library.Generators
{
    public interface IUsersGenerator
    { 
    
    }

    public class PlayerGenerator : IUsersGenerator
    {
        public List<Player> Generate(int amount) =>
             Enumerable
            .Range(0, amount)
            .Select(i => new Player() { Id = i + 1, IsDealer = i == amount - 1})
            .ToList();
    }
}
