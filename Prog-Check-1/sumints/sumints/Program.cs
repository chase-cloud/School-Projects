using System.ComponentModel.Design;

namespace sumints
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int num = 0;
            while (true)
            {
                num = Convert.ToInt32(Console.ReadLine());
                if (num == 999) { break; }
                sum += num;
            }
            Console.WriteLine($"amount without 999: {sum}");




        }
    }
}
