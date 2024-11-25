namespace Daily_temps
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int min = -20 , max = 130 ;
            int total = 0;
            while (true)
            {
                Console.Write("Enter daily temp: ");
                int userInput = Convert.ToInt16( Console.ReadLine());
                if (userInput >= min || userInput <= max)
                {
                    total += userInput;
                   
                }
                if (userInput > max || userInput < min)
                {
                    Console.WriteLine("Error"); 
                    Console.WriteLine(total);
                    break;
                }
            }
        }
    }
}
