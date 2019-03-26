using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicrosoftDotNetPlatformIntroduction
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1
            //string name = "Игорь";
            //string surname = "Скоропад";

            //Console.WriteLine($"{name} {surname}");


            // 2
            Console.Write("Введите два числа: ");
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            Console.WriteLine($"Сумма введенных чисел: {firstNumber + secondNumber}");

            Console.ReadLine();
        }
    }
}
