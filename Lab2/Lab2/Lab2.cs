﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Lab2
    {
        static void Main(string[] args)
        {
        using (StreamReader sr = new StreamReader(@"..\..\..\..\Data\input.txt"))
            {
                while(sr.Peek() != -1)
                {
                    string line = sr.ReadLine();
                    foreach(var ch in line)
                    {
                        Console.Write(ch);
                        if('.' == ch || '?' == ch || '!' == ch)
                        {
                            Console.WriteLine();
                        }
                    }
                }
                Console.Read();
            }
        }
    }
}
