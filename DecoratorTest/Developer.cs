using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorTest
{
    public class Developer : Employee
    {
        public Developer() : base ("Developer")
        {
        }
        public override string GetMyWage()
        {
            return "I am developer, my solary 300k";
        }
    }
}
