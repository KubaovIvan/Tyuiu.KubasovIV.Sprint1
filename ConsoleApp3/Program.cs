using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст:");
            string text = Console.ReadLine();

            string[] words = text.Split(' ');

            Console.WriteLine("Текст с перенесенными первыми буквами:");
            foreach (string word in words)
            {
                string modifiedWord = word.Substring(1) + word[0];
                Console.Write(modifiedWord + " ");
            }

            Console.ReadLine();
        }
    }
}
