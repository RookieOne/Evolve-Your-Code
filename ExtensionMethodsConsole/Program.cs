using System;

namespace ExtensionMethodsConsole
{
    internal class Program
    {
        private static void Main(string[] args)
        {

            Console.WriteLine(String.Format("Hello my name is {0}.", "JB"));

            "Hello my name is {0}.".FormatWith("JB").ToConsole();

        }

    }
}