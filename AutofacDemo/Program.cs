﻿using AutofacDemo.TypeRegister;
using System;

namespace AutofacDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("autofac demo");
            RegisterConsoles.TypeRun();
            RegisterConsoles.AssemblyRun();
        }
    }
}
