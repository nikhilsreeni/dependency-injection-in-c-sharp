using System;
using Autofac;
using System.Reflection;
using DemoService;
using DemoRepository;

namespace SampleConsole
{
    class Program
    {
        static void Main(string[] args)
        {

            //best
            using (var container = BootStrap.Components())
            {
                var obj = container.Resolve<IClassSer>();
                Console.WriteLine(obj.add(1, 2));
            }

            // another 
            CustomClass newobj = BootStrap.Components().Resolve<CustomClass>();

            newobj.show();

            Console.ReadKey();
        }
    }


    public class CustomClass
    {
        public IClassSer _classSer;
        public CustomClass(IClassSer classSer)
        {
            _classSer = classSer;
        }

        public void show()
        {
            Console.WriteLine(_classSer.add(1, 2));
        }
    }


    public class BootStrap
    {

        public static IContainer Components()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<ClassSer>().As<IClassSer>();
            builder.RegisterType<ClassRepo>().As<IClassRepo>();
            builder.RegisterType<CustomClass>();
            return builder.Build();
        }

    }

}

