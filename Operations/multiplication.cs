using System;
using System.Collections.Generic;
using System.Text;

namespace Operations
{
    public class Multiplication
    {
        public static int Multiply(int a, int b)
        {
            return a * b;
        }
        public static double Multiply(double a, double b)
        {
            return a * b;
        }
        public static double Multiply(double[] arrayA)
        {
            double b = 0.0;
            foreach (double a in arrayA)
            {
                b = Multiply(a, b);
            }
            return b;
        }
    }

}
