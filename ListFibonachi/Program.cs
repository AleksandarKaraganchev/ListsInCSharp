using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListFibonachi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            List<int> listFib = new List<int>();
            listFib.Add(1);
            listFib.Add(1);
            Console.Write("Въведи до кое число на фибоначи искаш да се изчисли:  " );
            byte numFib = byte.Parse(Console.ReadLine());
            for (int i = 2; i < numFib; i++)
            {
                listFib.Add(listFib[i - 2] + listFib[i - 1]);
            }          
            Console.WriteLine(string.Join(", ",listFib)); ;
        }
    }
}
