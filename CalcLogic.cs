using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    public class Calculator
    {
        public int Add(int a, int b) => a + b;
        public int Sub(int a, int b) => a - b;
        public int Mul(int a, int b) => a * b;
        public double Div(int a, int b)
        {
            if (b == 0)
                throw new DivideByZeroException();
            return (double)a / b;
        }
        public bool IsEven(int number) => number % 2 == 0;
    }