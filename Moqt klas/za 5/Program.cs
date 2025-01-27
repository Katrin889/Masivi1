using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace za_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kak se kazvash");
            string[] arr1 = new string[4];
            for (int i = 0; i < 4; i++)
            {
                arr1[i] = Console.ReadLine();
            }
            Console.WriteLine("Kolko ocenki imash");
            int b = int.Parse(Console.ReadLine());
            int[] arr = new int[b];
            int c = 0;
            for (int i = 0; i < b; i++)
            {
                Console.Write("ocenka " + (i+1) + " =");
                arr[i] = int.Parse(Console.ReadLine());
                c += arr[i];
            }
            Console.WriteLine(arr1[1]);
            Console.WriteLine(arr1[0]);
            Console.WriteLine(c/b);
        }
    }
}
