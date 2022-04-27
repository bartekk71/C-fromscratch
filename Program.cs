using System;

namespace CsharpBasic
{
    class Program
    {
        static void Main(string[] args)
        {
            //Basic
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

            //Types of variables
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

            //String
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

            //operators
            int result;

            int x = 10;
            int y = 25;

            result = x + y;
            Console.WriteLine(result);
            
            result = x - y;
            Console.WriteLine(result);

            result = x * y;
            Console.WriteLine(result);

            result = x / y;
            Console.WriteLine(result);

            result = x % y;
            Console.WriteLine(result);

            Console.WriteLine("****************");

            int value1 = 15;
            int value2 = 30;

            Console.WriteLine("Pre-increment result");
            Console.WriteLine(++value1);

            Console.WriteLine("Post-increment result");
            Console.WriteLine(value2++);
            Console.WriteLine(value2);
            
            //Bool
            Console.WriteLine("****************");
            bool boolResult;
            int a = 18;
            int b = 20;

            boolResult = (a == b);
            Console.WriteLine(boolResult);

            boolResult = (a > b);
            Console.WriteLine(boolResult);

            boolResult = (a < b);
            Console.WriteLine(boolResult);

            boolResult = (a >= b);
            Console.WriteLine(boolResult);

            boolResult = (a <= b);
            Console.WriteLine(boolResult);

            boolResult = (a != b);
            Console.WriteLine(boolResult);

            Console.WriteLine("****************");
            bool boolResult2;
            bool c = true;
            bool d = false;

            boolResult2 = c && d;
            Console.WriteLine(boolResult2);

            boolResult2 = c || d;
            Console.WriteLine(boolResult2);

            boolResult2 = !c;
            Console.WriteLine(boolResult2);

            int e, f;
            e = 13;
            f = 24;

            int greaterNumber = e > f ? e : f;
            Console.WriteLine(greaterNumber);

            //Comments

        }
    }
}
