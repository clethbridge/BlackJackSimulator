using BlackJackSimulator.Library.Generators;
using BlackJackSimulator.Library.Models;
using System;

namespace BlackJackSimulator.Runner
{
    class Program
    {
        static void Main(string[] args)
        {
            string json = System.IO.File.ReadAllText($"{AppContext.BaseDirectory}/appsettings.json");

            AppSettings settings = Newtonsoft.Json.JsonConvert.DeserializeObject<AppSettings>(json);

            StandardDeckGenerator standardDeckGenerator = new StandardDeckGenerator();

            var deck = standardDeckGenerator.Generate();

            PlayerGenerator playerGenerator = new PlayerGenerator();

            var players = playerGenerator.Generate(settings.NumberOfPlayers);

            Console.WriteLine("Done");
        }
    }
}
