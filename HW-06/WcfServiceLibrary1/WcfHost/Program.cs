using System;
using System.ServiceModel;

namespace WcfHost
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using(var host = new ServiceHost(typeof(WcfServiceLibrary1.Service1)))
            {
                host.Open();
                Console.WriteLine("Хост запущен");
                Console.ReadLine();
            }
        }
    }
}
