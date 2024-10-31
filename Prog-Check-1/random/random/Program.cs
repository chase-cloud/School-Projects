namespace random
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x;
            const int LIMIT = 10;
            x = 1;
            while (x <= LIMIT) 
            {
                Console.WriteLine(x);
                x++;
            }
            for (x =1; x <= LIMIT; x++)
                Console.WriteLine(x);

        }
        
    }
}
