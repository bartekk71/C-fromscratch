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

            string message1;
            message1 = "some value";
            Console.WriteLine(message1);

            string message2 = null;
            Console.WriteLine(message2);

            string message3 = string.Empty;

            string text = "some text";

            string windowsLocation = "c\\:windows";

            string fontsFolder = @"c\\windows\fonts";

            string concatenated = string.Concat(text, " sto me");
            Console.WriteLine(concatenated);

            string concatenated2 = text + "to" + "me";
            Console.WriteLine(concatenated2);

            //string interpolated = 
            string interpolated = $"{text} to me";

          
        }
    }
}
