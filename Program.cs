﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_8_15_ExperIT_ConditionalLab2
{
    class Program
    {
        static void Main(string[] args)
        {

           int seconds = System.DateTime.Now.Second;

            switch(seconds)
            {
                    case 0:
                    Console.WriteLine("The new minute is just beginning");
                    break;

                case 15:
                    Console.WriteLine("We're one quarter done");

                    break;

                case 30:
                    Console.WriteLine("Half way there");
                    break;

                case 45:
                    Console.WriteLine("Getting close to done");
                    break;

                default:
                    Console.WriteLine("Working on it");
                    break;

            }

            Console.ReadLine();


        }
    }
}
