using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statistics
{
    class Program
    {
        static void Main(string[] args)
        {
            Statistic stat = new Statistic();

            string text = "Вот дом, Который построил Джек. А это пшеница, Которая в темном  чулане хранится В доме, " +
                "Который построил Джек. А это веселая птица-синица, Которая часто ворует пшеницу, Которая в темном " +
                "чулане хранится В доме, Который построил Джек.";

            Dictionary<string, int> words = stat.WordsCount(text);

            int counter = 1;
            Console.WriteLine("\tСлово:\t\tКол-во:");

            int tabSpace = 8;
            foreach(var word in words)
            {
                if (word.Key != "всего")
                {
                    if (word.Key.Length >= tabSpace)
                        Console.WriteLine($"{counter}.\t{word.Key}\t{word.Value}");
                    else
                        Console.WriteLine($"{counter}.\t{word.Key}\t\t{word.Value}");
                    counter++;
                }
            }

            Console.WriteLine($"Всего слов: {words["всего"]} из них уникальных: {counter - 1}");

            Console.ReadLine();
        }
    }
}
