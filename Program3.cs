using System;

namespace Day1
{
    class Program3
    {
        static void Main()
        {
            Console.Write("Enter your salary: ");
            string salarystring = Console.ReadLine();

            //convert text contained in salaryString into salary variable
            double salary = Double.Parse(salarystring);

            //calculate tax assuming 10% tax rate
            double tax = 0.0567891 * salary;


            Console.WriteLine("Your tax is ${0} from your salary of ${1}.", tax, salary);

            //{1.00} forces two decimal points (CUSTOM FORMATTING)
            Console.WriteLine("Your tax is ${0} from your salary of ${1:0.00}.", tax, salary);

            //{1:#.##} puts in two decimal points when necessary (CUSTOM FORMATTING)
            Console.WriteLine("Your tax is ${0} from your salary of ${1:#.##}.", tax, salary);

            //{1:C} C is for currency (STANDARD FORMATTING ie. it's in the library)
            Console.WriteLine("Your tax is ${0:C} from your salary of ${1:C}.", tax, salary);

            //(CUSTOM FORMATTING)  
            Console.WriteLine("Your tax is ${0:0,000.00} from your salary of ${1:#,###.##}.", tax, salary);
        }
    }
}
