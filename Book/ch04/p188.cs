﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.ch04
{
    internal class p188
    {
        static void Main1(string[] args)
        {
            Console.WriteLine("무한반복하며 이동");
            bool state = true;
            while(state)
            {
                ConsoleKeyInfo info = Console.ReadKey();
                
                switch(info.Key)
                    {
                    case ConsoleKey.UpArrow:
                        Console.WriteLine( "위로 이동");
                    break;
                    case ConsoleKey.RightArrow:
                        Console.WriteLine("오른쪽으로 이동");
                    break;
                    case ConsoleKey.DownArrow:
                        Console.WriteLine("아래로 이동");
                    break;
                    case ConsoleKey.LeftArrow:
                        Console.WriteLine( "왼쪽으로 이동");
                    break;
                    case ConsoleKey.X:
                        state = false;
                    break;
                        
                    }
            }
        }
    }
}
