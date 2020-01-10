using System;
using Operations;


namespace Multiply
{
    public interface IMultiply
    {
        public dynamic Multiplication(dynamic a, dynamic b); 
    }
    public class Multiple : IMultiply
    {
        public dynamic result;        
        public dynamic Multiplication(dynamic a, dynamic b)
        {
            result = Operations.Multiplication.Multiply(a, b);
            return result;
        }

    }
}
