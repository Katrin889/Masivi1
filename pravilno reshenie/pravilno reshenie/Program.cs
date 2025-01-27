using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pravilno_reshenie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kak se kazvash");
            string a = Console.ReadLine();
            string[] items = a.Split(' ');
            string[] arr1 = new string[items.Length];
            for (int i = 0; i >= items.Length; i++)
            {
                arr1[i] = items[i];
            }
            Console.WriteLine("Kolko ocenki imash");
            int b = int.Parse(Console.ReadLine());
            int[] arr = new int[b];
            int c = 0;
            for (int i = 0; i < b; i++)
            {
                Console.Write("ocenka " + (i + 1) + " =");
                arr[i] = int.Parse(Console.ReadLine());
                c += arr[i];
            }
            Console.WriteLine(items[1]);
            Console.WriteLine(items[0]);
            Console.WriteLine(c / b);
        }
    }
}
