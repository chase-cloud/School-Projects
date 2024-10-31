using System.Runtime.CompilerServices;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double bankBal = 1000;
            const double INT_RATE = 0.04;
            string inputString;
            char response;
            Console.Write("Do you want to see your balance? Y or N...");
            inputString = Console.ReadLine();
            response = Convert.ToChar(inputString);
            while (response == 'Y')
            {
                Console.WriteLine("Bank balance is {0}",
                bankBal.ToString("C"));
                bankBal = bankBal + bankBal * INT_RATE;
                Console.WriteLine("Double you want to see next years balance? Y or N...");
                inputString = Console.ReadLine();
                response = Convert.ToChar(inputString);
            }
            Console.WriteLine("Have a nice day!");
        }       
    }
}
