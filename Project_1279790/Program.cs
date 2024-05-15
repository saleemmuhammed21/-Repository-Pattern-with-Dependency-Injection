using Project_1279790.Controllers;
using Project_1279790.Factories;
using Project_1279790.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1279790
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IObjectFactory factory = new ObjectFactory();
            TestController controller = new TestController(factory);
            controller.Run();
            Console.WriteLine("*******************");
            TestController2 controller2 = new TestController2();
            controller2.Run(factory);
            Console.ReadLine();
        }
    }
}
