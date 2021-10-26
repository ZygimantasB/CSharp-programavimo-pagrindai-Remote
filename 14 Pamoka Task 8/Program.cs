     using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_Pamoka_Task_8
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"G:\My Drive\C Sharp mokymai video\Paskaitos video\14 Pamoka\Task 7\mytest.txt";

            File.Create(filePath);
        }
    }
}
