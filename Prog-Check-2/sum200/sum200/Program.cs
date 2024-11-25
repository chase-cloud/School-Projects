using System.ComponentModel.DataAnnotations;

namespace sum200
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int total = 0;
            for (int i = 1; i <= 100; i++)
            {
                total += i;
            }
            Console.WriteLine($"Total: {total}");
            for (int i = 101; i <= 200; i++)
            {
                total += i;
            }


        }
    }
}
