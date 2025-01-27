using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moqt_klas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kolko du[i sa v chas? ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Kolko momcheta shte vyvedesh? ");
            int b = int.Parse(Console.ReadLine());
            string[] arr = new string[b];
            for (int i = 0; i < b; i++)
            {
                arr[i] = Console.ReadLine();
            }
            if (b >= 10)
                Console.WriteLine("shte uchim normalno - mycki klas");
            else if (b < 10)
                Console.WriteLine("izlizame gripna ot 29");
            if (a == 29)
                Console.WriteLine("Vsichki sme");
            if (a == 14)
                Console.WriteLine("Grupa sme");
            else
                Console.WriteLine("Mnogo sme bolni");
            Console.WriteLine(arr[0]);
            Console.WriteLine(arr[b-1]);
            Console.WriteLine(arr[(b-1)/2]);

        }
    }
}
