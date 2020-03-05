using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorTest
{
    public class Designer : Employee
    {
        public Designer() : base("Designer")
        {
        }
        public override string GetMyWage()
        {
            return "I am designer, my solary 220k";
        }
    }
}
