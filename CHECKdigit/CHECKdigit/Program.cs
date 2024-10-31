namespace CHECKdigit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter a four-digit #");
            string userInput = Console.ReadLine();
            if (userInput.Length == 4)
            {
                int threeDigits = Convert.ToInt16(userInput.Substring(0, 2));
                if ((threeDigits % 7) == 0)
                {
                    Console.WriteLine("Valid");
                } else
                {
                    Console.WriteLine("Invalid");
                }
            } else
            {
                Console.WriteLine("Invalid");
            }
        }
    }
}
