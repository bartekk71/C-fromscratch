using System;

namespace CsharpBasic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine("Hello World!11");
            Console.WriteLine("Hello World!22");
            Console.WriteLine("Hello World!33");

            Console.Write("Hello");
            Console.Write("World!");

            Console.WriteLine("What's your name?");
            string userName = Console.ReadLine();
            Console.WriteLine("Hello");
            Console.WriteLine(userName);

            string someText = "Text lalalala";

            char jChar = 'j';
            char jCharUnicode = '\u006A';

            bool isUserReady = true;
            Console.WriteLine(isUserReady);

            DateTime now = DateTime.Now;
            Console.WriteLine(DateTime.Now);
            DateTime dateOfBirth = new DateTime(1996, 4, 1);
            Console.WriteLine(dateOfBirth);

            byte byteNumber = 200;
            float floatNumber = 1.5F;
            decimal decimalNumber = 1.5M;
            double dubleNumber = 1.5;
        }
    }
}
