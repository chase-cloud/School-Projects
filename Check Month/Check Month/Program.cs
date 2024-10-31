using System.ComponentModel.Design;

namespace Check_Month
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userInput = Console.ReadLine();
            int cm = Convert.ToInt16(userInput);
            if (cm <= 1 && cm >= 12)
            {
                Console.WriteLine("Month is valid");
            } 
            else
            {
                Console.WriteLine("Invalid");
            }
        }
    }
}
