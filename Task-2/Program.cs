using System;

namespace Task_2
{
    internal class Program
    {
        static string[] WordSeparaiton(string text)
        {
            string[] separator = text.Split(' ');
            return separator;
        }
        static string ReverseWord(string[] text)
        {
            
            Array.Reverse(text);
            string result = string.Join(" ", text);
            return result;
        }
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            var met = WordSeparaiton(s);

            s = ReverseWord(met);

            Console.WriteLine(s);
            Console.ReadKey();
        }
    }
}
