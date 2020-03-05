using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorTest
{
    public abstract class Employee
    {
        public string Position { get; set; }

        public Employee(string position)
        {
            this.Position = position;
        }
        public abstract string GetMyWage();
    }
}
