using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace BlackJackSimulator.Library.Models
{
    [DebuggerDisplay("{Id}")]
    public class Player
    {
        public int Id { get; set; }

        public bool IsDealer { get; set; }
    }
}
