using System;
using System.Collections.Generic;
using System.Text;

namespace AutofacDemo.TypeRegister
{
    public class Student : IPerson
    {
        public void Introduction()
        {
            Console.WriteLine("I am a student");
        }
    }
}
