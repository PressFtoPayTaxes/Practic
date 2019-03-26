using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalWork1
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1
            //int x;
            //Console.Write("Введите число x для вычисления y: ");
            //x = int.Parse(Console.ReadLine());
            //int y = 7 * (x * x) - 3 * x + 4;
            //Console.WriteLine("y = 7x^2 - 3x + 4");
            //Console.Write("y = ");
            //Console.Write(y);

            // 2
            //int radius;
            //Console.Write("Введите радиус окружности: ");
            //radius = int.Parse(Console.ReadLine());

            //int diameter = radius + radius;
            //Console.WriteLine("Диаметр окружности: " + diameter);

            //double length = Math.PI * diameter;
            //Console.WriteLine("Длина окружности: " + length);

            // 3
            //int santimeters;
            //Console.Write("Введите расстояние в сантиметрах: ");
            //santimeters = int.Parse(Console.ReadLine());

            //int santimetersInMetres = 100;
            //int meters = santimeters / santimetersInMeter;
            //Console.Write("Количество полных метров: " + meters);

            // 4
            //int pastTimeInDays = 234;
            //int daysInWeek = 7;
            //int pastTimeInWeeks = pastTimeInDays / daysInWeek;
            //Console.Write("За 234 дня прошло " + pastTimeInWeeks + " полных недели");

            // 5
            //int twosignedNumber;
            //Console.Write("Введите двузначное число: ");
            //twosignedNumber = int.Parse(Console.ReadLine());

            //int unitsInTen = 10;

            //int tens = twosignedNumber / unitsInTen;
            //Console.WriteLine("Количество десятков: " + tens);

            //int units = twosignedNumber % unitsInTen;
            //Console.WriteLine("Количество единиц: " + units);

            //int sum = tens + units;
            //Console.WriteLine("Сумма цифр в числе: " + sum);

            //int composition = tens * units;
            //Console.WriteLine("Произведение цифр в числе: " + composition);

            // 6
            //int foursignedNumber;
            //Console.Write("Введите четырёхзначное число: ");
            //foursignedNumber = int.Parse(Console.ReadLine());

            //int unitsInTen = 10;
            //int sum = 0;
            //int composition = 1;

            //while (foursignedNumber != 0)
            //{
            //    int lastNumeral = foursignedNumber % unitsInTen;
            //    sum += lastNumeral;
            //    composition *= lastNumeral;
            //    foursignedNumber /= unitsInTen;
            //}

            //Console.WriteLine("Сумма цифр в числе: " + sum);
            //Console.WriteLine("Произведение цифр в числе: " + composition);

            // 7
            //int finalNumber = 456;
            //int unitsInTen = 10;
            //int unitInHundred = 100;

            //int deletedNumber = finalNumber % unitsInTen;
            //finalNumber /= unitsInTen;
            //int initialNumber = finalNumber / unitsInTen;
            //initialNumber *= unitInHundred;
            //initialNumber += deletedNumber * unitsInTen;
            //initialNumber += finalNumber % unitsInTen;

            //Console.WriteLine("В трехзначном числе x зачеркнули его вторую цифру. Когда к образованному при этом двузначному числу справа приписали вторую цифру числа x, то получилось число 456.");
            //Console.Write("x = " + initialNumber);

            // 8
            bool x = false;
            bool y = false;
            Console.WriteLine(!x && !y);
            Console.WriteLine(x || (!x && y));
            Console.WriteLine((!x && y) || y);

            Console.ReadLine();
        }
    }
}
