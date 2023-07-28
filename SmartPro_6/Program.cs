using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartPro_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double number;

            Console.Write("Sayı giriniz: ");
            number = double.Parse(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.Clear();
                Console.WriteLine("Girdiğiniz sayı çift sayıdır.");
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Girdiğiniz sayı tek sayıdır.");
            }
            Console.ReadKey();
        }
    }
}
