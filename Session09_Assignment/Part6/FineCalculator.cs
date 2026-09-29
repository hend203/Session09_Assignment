using System;
using System.Collections.Generic;
using System.Text;

namespace DEPICSharpTask7.Part6
{
    public class FineCalculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Subtract(int a, int b)
        {
            return a - b;
        }

        public int Multiply(int a, int b)
        {
            return a * b;
        }

        // Q11: must throw DivideByZeroException when b == 0
        public int Divide(int a, int b)
        {
            if (b == 0)
                throw new DivideByZeroException("Cannot divide by zero.");

            return a / b;
        }
    }

}
