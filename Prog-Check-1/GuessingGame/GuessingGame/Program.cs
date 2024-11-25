namespace GuessingGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random ranNumberGenerator = new Random();
            int min = 1, max = 1;
            int randomNumber;
            randomNumber = ranNumberGenerator.Next (min, max);
            Console.WriteLine("Enter a # 1 to 11");
            string userInput = Console.ReadLine ();
            int userNumber = Convert.ToInt16(userInput);
            if (randomNumber == userNumber)
            {
                Console.WriteLine("You win");
            }
            if (randomNumber !=userNumber)
            {
                Console.WriteLine("Low");
            }
            Console.WriteLine("Random number" + randomNumber);
            
           

            
        }
    }
}
