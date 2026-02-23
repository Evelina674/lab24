using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab24.Strategies
{
    public class CubeOperationStrategy : INumericOperationStrategy
    {
        public string Name => "Cube (x^3)";

        public double Execute(double value)
        {
            return value * value * value;
        }
    }
}