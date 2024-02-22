using System;

namespace DataTypeApp
{
    class DataTypeProgram
    {
        static void Main(string[] args)
        {
            int intValue = 10;
            double doubleValue = 3.14;
            char charValue = 'A';
            bool boolValue = true;
            string stringValue = "ced";

            Console.WriteLine($"integer: {intValue}");
            Console.WriteLine($"double: {doubleValue}");
            Console.WriteLine($"character: {charValue}");
            Console.WriteLine($"boolean: {boolValue}");
            Console.WriteLine($"String: {stringValue}");

        }
    }
}
