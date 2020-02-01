using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deniz_Review
{
    interface ICalculator
    {
        int sum(int a, int b);
        int multiply(int a, int b);
        int sub(int a, int b);
        int divide(int a, int b);
    }
}
