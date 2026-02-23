using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab24.Strategies
{
    public interface INumericOperationStrategy
    {
        double Execute(double value);
        string Name { get; }
    }
}
