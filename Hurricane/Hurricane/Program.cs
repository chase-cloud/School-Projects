using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;

namespace Hurricane
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your wind speed");
            string userInput = Console.ReadLine();
            int mph = Convert.ToInt16(userInput);
            if (mph >= 74 && mph <= 95)
            {
                Console.WriteLine("Category 1");
            }
            else if (mph >= 96 && mph <= 110)
            {
                Console.WriteLine("Category2");
            }
            else if (mph >= 111 && mph <= 129)
            {
                Console.WriteLine("Category3");
            }
            else if (mph >= 130 && mph <= 156)
            {
                Console.WriteLine("Category4");
            }
            else if (mph >= 167)
            {
                Console.WriteLine("Category5");
            }
            else
            {
                Console.WriteLine("Does not exist");
            }
        }
    }
}