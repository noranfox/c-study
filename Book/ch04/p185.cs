﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.ch04
{
    internal class p185
    {
        static void Main1(string[] args)
        {
                Console.WriteLine("배열을 문자열로 변환");
                string[] array = { "감자", "고구마", "토마토", "가지" };
                Console.WriteLine(string.Join(",", array));
        }
    }
}
