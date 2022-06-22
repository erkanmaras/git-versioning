using System;
using Lib;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(
                new HelloWorldProvider().Provide()
            );
        }
    }
}
