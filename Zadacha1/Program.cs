using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("Колко числа ще въвеждаш?: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("----------------------------------------");
            List<int> numbers = new List<int>();
            for (int i = 0; i < n; i++)
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.Write("Въведи число: ");
                int item = int.Parse(Console.ReadLine());
                numbers.Add(item);
            }
            //obrabotka
            //dobavqne v sredata
            //int newindex = n / 2;//sredata na chislata na lista
            //numbers.Insert(newindex, 6);
            //dobavqne v kraq na nai-maluk element
            //int minElement = numbers.Min();
            //numbers.Add(minElement);
            //da iztriq 0 vuv vuvedeniq spisuk
            while (numbers.Contains(0))
            {
                numbers.Remove(0);
            }
            Console.WriteLine("----------------------------------------");
            for (int i = 0; i < numbers.Count; i++)
            {
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine($"numbers[{i}] = {numbers[i]}");
            }
            Console.WriteLine("----------------------------------------");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine($"Броят на елементите е: {numbers.Count}");
            Console.WriteLine("----------------------------------------");
        }
    }
}
