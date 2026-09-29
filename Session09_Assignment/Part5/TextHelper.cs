using System;
using System.Collections.Generic;
using System.Text;

namespace DEPICSharpTask7.Part5
{
    public static class TextHelper
    {
        // Q9 (Bonus - step 1): the NORMAL static method version.
        // It would be called like:  TextHelper.IsShorterThanNormal("Hello", 10)
        public static bool IsShorterThanNormal(string value, int length)
        {
            return value.Length < length;
        }

        // Q9 (1) + (Bonus - step 2): same method converted to an EXTENSION method
        // by adding the "this" keyword before the first parameter.
        // Now it can be called like:  "Hello".IsShorterThan(10)
        public static bool IsShorterThan(this string value, int length)
        {
            return value.Length < length;
        }

        // Q9 (2): repeats the string "times" times.  "Ha".Repeat(3) -> "HaHaHa"
        public static string Repeat(this string value, int times)
        {
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < times; i++)
            {
                result.Append(value);
            }

            return result.ToString();
        }
    }

}
