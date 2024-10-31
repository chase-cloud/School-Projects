namespace Twitter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userInput = Console.ReadLine();
            int az = userInput.Length;
            if (az > 140)
            {
                Console.WriteLine("NO");
            }
            else { Console.WriteLine("YES"); }
            Console.WriteLine(userInput.Length);
            
        }
    }
}
