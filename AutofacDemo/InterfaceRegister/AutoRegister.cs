using Autofac;
using Autofac.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace AutofacDemo.InterfaceRegister
{
    public class AutoRegister
    {
        /// <summary>
        /// 自动注入
        /// </summary>
        /// <returns></returns>
        public AutofacServiceProvider Build()
        {
            var builder = new ContainerBuilder();
            Type dependencyType = typeof(IDependency);
            var assemblys = AppDomain.CurrentDomain.GetAssemblies().ToArray();
            builder.RegisterAssemblyTypes(assemblys)
                .Where(type => dependencyType.IsAssignableFrom(type) && !type.IsAbstract)
                .AsImplementedInterfaces().InstancePerLifetimeScope();
            var container = builder.Build();
            var serviceProvider = new AutofacServiceProvider(container);
            return serviceProvider;
        }
    }
}
