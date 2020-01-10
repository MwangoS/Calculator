using System;

namespace Operations
{
    public static class Addition
    {
        public static int Sum(int a, int b)
        {
            return a + b;
        }
        public static double Sum(double a, double b)
        {
            return a + b;
        }

       /* public static double Sum(double[] arrayA)
        {
            double c = 0.0;

            foreach (double a in arrayA)
            {
                c = Sum(a, c);
            }

            return c;
        }*/

<<<<<<< Updated upstream
        /*public static dynamic Sum(object p, dynamic[] c)
        {
            throw new NotImplementedException();
        }*/
=======
        public static int Sum(int[] arrayA)
        {
            int c = 0;
            foreach(int a in arrayA)
            {
                c = Sum(a, c);
            }
            return c;
        }

>>>>>>> Stashed changes
    }

    
}
