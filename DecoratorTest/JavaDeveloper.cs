using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorTest
{
    public class JavaDeveloper : EmployeeDecorator
    {
        public JavaDeveloper(Employee employee) : base(employee, "JavaDeveloper")
        {
        }

        public override string GetMySkills()
        {
            return "ReactJS/Redux, Vue, Angular, JS ES6, HTML5";
        }

        public override string GetMyWage()
        {
            return "I am Java developer, my solary 200k";
        }
    }
}
