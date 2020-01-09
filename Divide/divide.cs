using Operations;
using System;

namespace Divide
{
    public interface IDivide
    {
        public dynamic Divide(dynamic a, dynamic b); //specifies what should be called
    }
 
    public class Div : IDivide
    {
        public dynamic result;
        public dynamic Divide(dynamic a, dynamic b)
        {
            result = Division.Divide(a, b);
            return result;
        }
    }
}
