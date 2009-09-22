using System;

namespace ExtensionMethodsConsole
{


    public static class StringExtensions
    {
        public static string FormatWith(this string s, params object[] args)
        {
            return String.Format(s, args);
        }

        public static void ToConsole(this string s)
        {
            Console.WriteLine(s);
        }
    }


}