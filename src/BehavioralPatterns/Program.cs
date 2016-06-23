﻿using ChainOfResponssibility;
using ChainOfResponssibility.PurchaseExample;
using CommandPattern;
using IteratorPattern;
using MediatorPattern;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace BehavioralPatterns
{
    public class Program
    {
        public static void Main(string[] args)
        {

            MediatorPatternExamples.Run();
            //Chain of responsibillity
            //This is usefull when you have a request and you don't know who should process it
            ChainOfResponsibillityExamples.Run();
            Console.ReadKey();
            Console.Clear();

            CommandPatternExamples.Run();
            Console.ReadKey();
            Console.Clear();

            IteratorPatternExamples.Run();
            Console.ReadKey();

            IteratorPatternExamples.Run();
            Console.ReadKey();

        }
    }
}
