using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace lab24.Strategies
{
    public class SquareRootOperationStrategy : INumericOperationStrategy
    {
        public string Name => "Square Root (sqrt(x))";

        public double Execute(double value)
        {
            if (value < 0)
                throw new ArgumentOutOfRangeException(nameof(value),
                    "Cannot compute square root of a negative number.");

            return Math.Sqrt(value);
        }
    }
}
