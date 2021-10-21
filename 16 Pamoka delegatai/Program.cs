using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_Pamoka_delegatai
{
    public delegate void StringDelegate(string text);
    class Program
    {
        static void Main(string[] args)
        {
            StringDelegate stringDelegate = ToUpperCase;
            stringDelegate("this is lowercase");
            stringDelegate.Invoke("this is another lowers");

            stringDelegate = ToLowwerCase;
            stringDelegate.Invoke("THIS IS UPPER CASE");

            Console.ReadKey();
        }

        static void ToUpperCase(string text) => Console.WriteLine(text.ToUpper());
        static void ToLowwerCase(string text) => Console.WriteLine(text.ToLower());
        static void WriteOutPut(string text, StringDelegate stringDelegate)
        {
            Console.WriteLine($"Before: {text}");
        }
    }
}
