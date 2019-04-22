//using Microsoft.Extensions.DependencyInjection;
using Autofac;
using Autofac.Extensions.DependencyInjection;
using AutofacDemo.InterfaceRegister;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace AutofacDemo.TypeRegister
{
    public class TypeRegisterConsoles
    {
        /// <summary>
        /// 通过程序集自动注入
        /// </summary>
        public static void AssemblyRun()
        {
            var serviceProvider = new AutoRegister().Build();
            var person = serviceProvider.GetService<IPerson>();
            person.Introduction();
            Console.ReadKey();
        }
        /// <summary>
        /// 通过类型注册来注入
        /// </summary>
        public static void TypeRun()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<Worker>().As<IPerson>();
            var container = builder.Build();
            var serviceProvider = new AutofacServiceProvider(container);
            var person = serviceProvider.GetService<IPerson>();
            person.Introduction();
            Console.ReadKey();
        }
    }
}
