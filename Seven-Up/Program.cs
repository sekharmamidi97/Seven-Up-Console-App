﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seven_Up
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 1; i <= 1000000; i++ )
            {
                if(i % 7 == 0 && (i % 12 == 0))
                {
                    Console.WriteLine("Seven Up");
                }
                else if(i % 7 == 0)
                {
                    Console.WriteLine("Seven");
                }
                else if(i % 12 == 0)
                {
                    Console.WriteLine("Up");
                }
                else
                {
                    Console.WriteLine(i);
                }
             
            }
        }
    }
}
