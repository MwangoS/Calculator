using System;
using System.Collections.Generic;
using System.Text;

namespace Operations
{
    public static class Division
    {
        public static int Divide(int a, int b)
        {
            return  a / b;

        }
        public static double Divide(double a, double b)
        {
            return a / b;

        }
        public static double Divide(double[] arrayA)
        {
            double d = 0.0;
            foreach(double a in arrayA)
            {
                d = Divide(a, d);
            }
            return d;
        }

        public static int Divide(int[] arrayA)
        {
            int g = 0;
            foreach (int a in arrayA)
            {
                g = Divide(a, g);
            }
            return g;
        }
    }
}
