using System;

namespace DecoratorTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee developer = new Developer();
            Console.WriteLine(developer.GetMyWage());
            
            developer = new JavaDeveloper(developer);
            Console.WriteLine(developer.GetMyWage());
            Console.WriteLine((developer as JavaDeveloper).GetMySkills());
            
        }
    }
}
