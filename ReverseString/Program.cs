using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseString
{
    class Program
    {        
        static void Main(string[] args)
        {
            string result = string.Empty;
            Console.WriteLine("Inserte un texto: ");
            string value = Console.ReadLine();

            for (int i = value.Length; i > 0; i--)
            {
                result = result + value.Substring(i - 1, 1);
            }
            Console.WriteLine();
            Console.WriteLine("Texto con orden inverso:");
            Console.WriteLine(result);
            Console.ReadKey(true);
        }

        
    }
}
