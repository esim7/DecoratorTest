using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorTest
{
    public class Manager : Employee
    {
        public Manager() : base ("Manager")
        {
        }
        public override string GetMyWage()
        {
            return "I am manager, my solary 150k";
        }
    }
}
