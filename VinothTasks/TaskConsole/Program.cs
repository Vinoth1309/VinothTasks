using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AssignmentConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            string result = string.Empty;
            Console.WriteLine("Please enter a number for Fibonacci sequence");
            TaskWebService.Service1 obj = new TaskWebService.Service1();
            result = obj.Fibonacci(Console.Read());
            Console.WriteLine(result);
            Console.Read();
        }
    }
}
