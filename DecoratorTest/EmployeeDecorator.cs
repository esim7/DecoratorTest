using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorTest
{
    public abstract class EmployeeDecorator : Employee
    {
        public Employee employee;
        public EmployeeDecorator(Employee employee, string position) : base(position)
        {
            this.employee = employee;
        }
        public abstract string GetMySkills();
    }
}
