using System;

namespace MethodOverloading
{
    internal class Calculator
    {
        public int Calculate(int a, int b) {

            return a + b;
        }
        public double Calculate(double a, double b) {

            return a + b;
        }
        public int Calculate(int a, int b, int c) {

            return a + b + c;
        }
    }
}
