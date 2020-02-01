using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deniz_Review
{
    class Calculator : ICalculator
    {
        public int divide(int a, int b)
        {
            //throw new NotImplementedException();
            return a / b;
        }

        public int multiply(int a, int b)
        {
            //throw new NotImplementedException();
            return a * b;
        }

        public int sub(int a, int b)
        {
            // throw new NotImplementedException();
            return a - b;
        }

        public int sum(int a, int b)
        {
            //throw new NotImplementedException();
            return a + b;
        }
    }
}
