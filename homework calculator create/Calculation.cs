using System;
using System.Collections.Generic;
using System.Text;

namespace homework_calculator_create
{
    public class Calculation : ICalculation
    {
        public void Calculator()
        {
            int a = 5;
            int b = 26;
            int c = a + b;
            Console.WriteLine(c);
        }

        public void Divide()
        {
            int a = 5;
            int b = 26;
            int c = a / b;
            Console.WriteLine(c);
        }

        public void Multiply()
        {
            int a = 5;
            int b = 26;
            int c = a * b;
            Console.WriteLine(c);
        }

        public void Subtract()
        {
            int a = 5;
            int b = 26;
            int c = a - b;
            Console.WriteLine(c);
        }
    }
}
