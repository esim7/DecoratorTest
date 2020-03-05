using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorTest
{
    public class PhpDeveloper : EmployeeDecorator
    {
        public PhpDeveloper(Employee employee) : base(employee, "PHPDeveloper")
        {
        }

        public override string GetMySkills()
        {
            return "MySQL, HTML, Git";
        }

        public override string GetMyWage()
        {
            return "I am PHP developer, my solary 120k";
        }
    }
}
