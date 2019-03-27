using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileSystemPractic
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1
            //var allSymbolsCount = new Dictionary<char, int>();

            //byte[] fileText;
            //Console.WriteLine("Введите путь к файлу:");
            //string path = Console.ReadLine();
            //using (FileStream stream = new FileStream(path, FileMode.OpenOrCreate))
            //{
            //    fileText = new byte[stream.Length];
            //    stream.Read(fileText, 0, (int)stream.Length);
            //}
            //string fileTextInString = Encoding.UTF8.GetString(fileText);

            //foreach (var symbol in fileTextInString)
            //{
            //    if (allSymbolsCount.ContainsKey(symbol) == false)
            //        allSymbolsCount.Add(symbol, 1);
            //    else
            //        allSymbolsCount[symbol]++;
            //}

            //Console.WriteLine("Символы в файле, и насколько часто они встречаются");
            //foreach (var symbolCount in allSymbolsCount)
            //{
            //    Console.WriteLine($"Символ '{symbolCount.Key}': {symbolCount.Value} раз");
            //}


            // 2
            string path = @"C:\me.txt";
            string name = "Игорь";
            string surname = "Скоропад";
            int age = 16;

            if(!File.Exists(path))
                File.Create(path);
            using (var stream = new StreamWriter(path))
            {
                stream.WriteLine(name);
                stream.WriteLine(surname);
                stream.WriteLine(age);    
            }

                Console.ReadLine();
        }
    }
}
