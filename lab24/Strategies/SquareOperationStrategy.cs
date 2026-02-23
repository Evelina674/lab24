using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab24.Strategies
{
    public class SquareOperationStrategy : INumericOperationStrategy
    {
        public string Name => "Square (x^2)";

        public double Execute(double value) => value * value;
    }
}