using System;
using Operations;

namespace Squared
{
    public interface ISquare
    {
        public dynamic Squared(dynamic a);
    }
    public class Sqre : ISquare
    {
        public dynamic result;
        public dynamic Squared(dynamic a)
        {
            result = Squared(a);
            return result;
        }
    }
}
