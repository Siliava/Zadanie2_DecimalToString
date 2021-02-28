using System;

namespace Zadanie2_DecimalToString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Decimal");
            int decimalNumber = int.Parse(Console.ReadLine());

            int remainder;
            string result = string.Empty;
            while (decimalNumber > 0)
            {
                remainder = decimalNumber % 2;//остаток
                decimalNumber /= 2;//делитель
                result = remainder.ToString()+ result;
            }

            Console.WriteLine("Binary: {0}", result);
            Console.ReadKey();
            
        }
    }

}
