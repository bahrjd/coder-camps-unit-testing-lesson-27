using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Ski
    {
        public string SkiResort { get; set; }
        public int LiftTicketCost { get; set; }

        public override string ToString()
        {
            return $"Ski Resort: {SkiResort}, Lift Ticket Cost: {LiftTicketCost}";
        }
    }
}
