using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class ClassUnderTest
    {
        public int GoodAddIntegers(int x, int y)
        {
            return x + y; // good
        }
        public int BadAddIntegers(int x, int y)
        {
            return x * y; // bad
        }
    }
}
