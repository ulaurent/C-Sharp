using System;
namespace CSharpFundamentals.Math
{
    public class Calculator
    {
        private int a;
        private int b;

        public Calculator()
        {
            a = 0;
            b = 0;
        }
        public int Add ( int aIn, int bIn){
            a = aIn;
            b = bIn;
            return aIn + bIn;
        }
    }
}
