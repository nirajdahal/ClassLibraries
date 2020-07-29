using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace DemoLibrary
{
    public static class Calculation
    {

        public static string AskInput(string message)
        {
            Console.WriteLine(message);
            string output = Console.ReadLine();
            return output;
        }
        public static double AddNum(double num1, double num2)
        {
            double output = num1 + num2;
            return output;
        }
    }
}
