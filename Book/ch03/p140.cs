﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.ch03
{
    internal class p140
    {
        static void Main1(string[] args)
        {
            //변수를 선업합니다
            Console.WriteLine("break키워드를 사용하지 않는 switch조건문" + "\n" + "\n");
            Console.WriteLine("이번 달은 몇 월인가요 : ");
            int input = int.Parse(Console.ReadLine());  

            //조건문
            switch (input)
            {
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("겨울입니다.");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("봄입니다.");
                    break;

                case 6:
                case 7:
                case 8:
                    Console.WriteLine("여름입니다.");
                    break;

                case 9:
                case 10:
                case 11:
                    Console.WriteLine("가을입니다");
                    break;
                default:
                    Console.WriteLine("대체 어떤 행성에 살고 계신가요?");
                    break;
            }



        
        }

    }
}
