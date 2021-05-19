using System;

namespace Enums_with_byte
{
    public enum names : byte
    {
        Ram = 1,
        Ashwin = 2,
        Tej = 3,
        john = 4
    }

    class Program
    {
        static void Main(string[] args)
        {
            names name = names.Ram;
            byte directionByte;
            string directionString;
            Console.WriteLine("name = {0}", name);
            directionByte = (byte)name;
            directionString = Convert.ToString(name);
            Console.WriteLine("byte equivalent = {0}", directionByte);
            Console.WriteLine("string equivalent = {0}", directionString);
        }
    }
}
