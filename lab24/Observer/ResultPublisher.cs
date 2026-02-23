using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace lab24.Observer
{
    public class ResultPublisher
    {
        // (result, operationName)
        public event Action<double, string>? ResultCalculated;

        public void PublishResult(double result, string operationName)
        {
            ResultCalculated?.Invoke(result, operationName);
        }
    }
}