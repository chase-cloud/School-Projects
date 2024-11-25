namespace display_multiplication_table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = Convert.ToInt16(Console.ReadLine());
            {
                for (int j = 1; j <= 10; j++)
                    Console.WriteLine($"{i} x {j} = ");
            }
        }
    }
}
