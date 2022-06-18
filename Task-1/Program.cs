using System;

namespace Task_1
{
    internal class Program
    {
        static string[] WordSeparation(string s)
        {
            string[] separator = s.Split(' ');

            foreach(string word in separator)
            {
                Console.WriteLine(word);
            }
            return separator;

        }
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            WordSeparation(s);
            Console.ReadKey();
        }
    }
}
