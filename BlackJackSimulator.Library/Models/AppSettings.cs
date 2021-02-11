using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlackJackSimulator.Library.Models
{
    public class AppSettings
    {
        [JsonProperty("NUMBER_OF_PLAYERS")]
        public int NumberOfPlayers { get; set; }
    }
}
