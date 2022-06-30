using System;

namespace homework_calculator_create
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculation calculation = new Calculation();

            calculation.Calculator();

            calculation.Divide();

            calculation.Multiply();
            
            calculation.Subtract();


        }
    }
}
