namespace home_sales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int total = 0;
            int dAmount = 0;
            int eAmount = 0;
            int fAmount = 0;
            int temp;
            while (true)
            {
                Console.Write("Enter sales person initials D, E, F, Z: ");
                char userInput = Convert.ToChar(Console.ReadLine() ?? "");
                if (userInput == 'z' || userInput == 'Z') { break; }
                if (userInput == 'd' || userInput == 'D') 
                {
                    Console.Write("D amount: ");
                    temp = Convert.ToInt32(Console.ReadLine());
                    dAmount += temp;
                    total += temp;
                }
                else if (userInput == 'e' || userInput == 'E') 
                { 
                    Console.Write("E amount: "); 
                    temp = Convert.ToInt16(Console.ReadLine());
                    eAmount += temp;
                    total += temp;
                }
                else if (userInput == 'f' || userInput == 'F') 
                {
                    Console.Write("F amount: "); 
                    temp = Convert.ToInt16(Console.ReadLine());
                    fAmount += temp;
                    total += temp;
                }    
                else { Console.WriteLine("Dumbahh");                                                 }


            }
            Console.WriteLine($"Danielle's Amount: {dAmount}");
            Console.WriteLine($"Edward's amount: {eAmount}");
            Console.WriteLine($"Francis amount: {fAmount}");
            Console.WriteLine($"Total: {total}");
            if (dAmount > eAmount && dAmount > fAmount) { Console.WriteLine("Winner: Danielle"); }
            if (eAmount > dAmount && eAmount > fAmount) { Console.WriteLine("Winner: Edward"); }
            if (fAmount > eAmount && fAmount > dAmount) { Console.WriteLine("Winner: Francis"); }

        }
    }
}
