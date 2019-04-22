using System;

namespace AutofacDemo.TypeRegister
{
    public class Worker : IPerson
    {
        public void Introduction()
        {
            Console.WriteLine("I am a worker");
        }
    }
}
