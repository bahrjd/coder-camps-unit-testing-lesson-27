using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Classy
    {
        public string Who { get; set; }
        public string When { get; set; }
        
        public override string ToString()
        {
            return $"Pow...how {Who} like me {When}!";
        }
                
    }
}
