using System.Runtime.CompilerServices;

namespace Oddnums
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
         int num = 1;
        while (true)
            { Console.WriteLine(num);
                num += 2;
               
                if (num > 99)
                {
                    break;
                }
            }
        }
       
    }
}
