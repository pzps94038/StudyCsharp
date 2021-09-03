using System;
using static System.Console;
namespace Ex0511
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Learning programming";
            string wds = "Visul C#";
            string sentence = str.Insert(9, wds);
            WriteLine($"原來字串{str},插入後{sentence}");
            string word = "Writing";
            sentence.Replace("Learning", word);
            WriteLine($"取代後字串{sentence}");
            char[] separ = { ' ' };//分割空白字元
            string[] str2 = sentence.Split(separ);
            WriteLine("分割字串");
            foreach (string item in str2) 
            {
                WriteLine(item);
            }
            ReadKey();
        }
    }
}
