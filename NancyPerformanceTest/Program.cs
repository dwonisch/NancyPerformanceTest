using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nancy.Hosting.Self;

namespace NancyPerformanceTest
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var nancyHost = new NancyHost(new Uri("http://localhost:8888/")))
            {
                nancyHost.Start();

                Console.WriteLine("Nancy now listening - navigating to http://localhost:8888/. Press enter to stop");
                try
                {
                    Process.Start("http://localhost:8888/Partials");
                    Process.Start("http://localhost:8888/Plain");
                }
                catch (Exception)
                {
                }
                Console.ReadKey();
            }

            Console.WriteLine("Stopped. Good bye!");
        }
    }
}
