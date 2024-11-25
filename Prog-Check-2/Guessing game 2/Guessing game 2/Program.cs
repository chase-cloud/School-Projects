namespace GuessingGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                Random ranNumberGenerator = new Random();
                int min = 1, max = 11;
                int randomNumber;
                randomNumber = ranNumberGenerator.Next(min, max);
                int timesguessed =0;
                while (true)
                {
                    timesguessed += 1;
                    Console.WriteLine("Enter a # 1 to 11");

                    int userNumber = Convert.ToInt16(Console.ReadLine());
                    if (randomNumber == userNumber)
                    {
                        Console.WriteLine("Random number " + randomNumber);
                        Console.WriteLine("Num of times guessed " + timesguessed);

                        break;
                    }                    
                } 
            } 
        }
    }
}
