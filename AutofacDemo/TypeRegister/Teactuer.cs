using AutofacDemo.InterfaceRegister;
using System;

namespace AutofacDemo.TypeRegister
{
    class Teacher : IPerson, IDependency
    {
        public void Introduction()
        {
            Console.WriteLine("I am a teacher");
        }
    }
}
