using System;
using Operations;


namespace Subtract
{
    public interface ISubtract
    {
        public dynamic Subtraction(dynamic a, dynamic b);
    }
    public class Sub : ISubtract
    {
        public dynamic result;
        public dynamic Subtraction(dynamic a, dynamic b)
        {
            result = Operations.Subtraction.Subtract(a, b);
            return result;
        }
    }
}
