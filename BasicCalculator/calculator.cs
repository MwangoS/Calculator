using System;
using Operations;
using Divide;
using Sum;
using Subtract;
using Multiply;
using Squared;

namespace BasicCalculator
{
    public interface ICalculatorBasic //object
    {
        public dynamic Add(dynamic a, dynamic b);
        public dynamic Divide(dynamic a, dynamic b);
        public dynamic Subtract(dynamic a, dynamic b);
        public dynamic Sqaure(dynamic a, dynamic b);
            //public dynamic Multiply(dynamic a, dynamic b);

    }
    public class Calculator : IAdd, IDivide, ISubtract, IMultiply, ISquare
    {
        
        Adding add = new Adding();
        Div divide = new Div();
        Subtraction Subtract = new Subtraction();
        Multiplication Multiply = new Multiplication();
        Square Square = new Square();

        public dynamic result;
        public dynamic Add(dynamic a, dynamic b)
        {
            result = Addition.Sum(a, b);
            return result;
        }

        public dynamic Divide(dynamic a, dynamic b)
        {
            result = Division.Divide(a, b);
            return result;
        }
        public dynamic Subtraction(dynamic a, dynamic b)
        {
            result = Operations.Subtraction.Subtract(a, b);
            return result;
        } 
        
        public dynamic Squared(dynamic a)
        {
            result = Squared(a);
            return result;
        }
        //public dynamic Subtraction(dynamic a, dynamic b)
        //{
         //   result = Multiplication.Multiply(a, b);
         //   return result;
        //}
    }
}
