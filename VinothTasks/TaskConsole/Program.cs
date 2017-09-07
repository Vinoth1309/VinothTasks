using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;

namespace AssignmentConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            TaskWebService.Service1 client;
            try
            {
                client = new TaskWebService.Service1();
                Console.WriteLine(client.Fibonacci(10));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
            Console.Read();
        }
    }
}
