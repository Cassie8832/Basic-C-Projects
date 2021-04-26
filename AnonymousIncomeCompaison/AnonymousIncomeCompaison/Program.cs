using System;

namespace AnonymousIncomeComparison
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine();//line break
            Console.WriteLine("Person 1");
            Console.WriteLine("Hourly Rate?");// user inputs number
            int rate1 = Convert.ToInt32(Console.ReadLine());//assigning variable and casting to int
            Console.WriteLine();//line break
            Console.WriteLine("Hours worked per week?");//user inputs number
            int hours1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();//line break
            Console.WriteLine("Person 2");
            Console.WriteLine("Hourly Rate?");
            int rate2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();//line break
            Console.WriteLine("Hours worked per week?");
            int hours2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();//line break
            Console.WriteLine("Annual salary of Person 1:");
            int total1 = rate1 * hours1 * 52;// 52 weeks in a year by how much per week
            Console.WriteLine(total1);// total annual salary
            Console.WriteLine("Annual salary of Person 2:");
            int total2 = rate2 * hours2 * 52;// 52 weeks in a year by how much per week
            Console.WriteLine(total2);// total annual salary
            Console.WriteLine();//line break
            Console.WriteLine("Does Person 1 make more money than Person 2?");
            bool moreMoney = total1 >= total2;// boolean variable to find if total1 is greater than or equal to total2
            Console.WriteLine(moreMoney);
            Console.ReadLine();

        }
    }
}
