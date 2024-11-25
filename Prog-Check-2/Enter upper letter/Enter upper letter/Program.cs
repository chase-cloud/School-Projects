namespace Enter_upper_letter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Type an upper case letter, not q: ");
                char userInput = Convert.ToChar(Console.ReadLine());
                if (userInput == 'q' || userInput =='Q') { break; }
                if (char.IsUpper(userInput))
                {
                    Console.WriteLine("OK");
                }
                if (!char.IsUpper(userInput))
                {
                    Console.WriteLine("Error");

                }
                
            }
        }
    }
}