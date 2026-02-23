using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.Collections.Generic;

namespace lab24.Observer
{
    public class HistoryLoggerObserver
    {
        public List<string> History { get; } = new();

        public void Subscribe(ResultPublisher publisher)
        {
            publisher.ResultCalculated += OnResultCalculated;
        }

        public void Unsubscribe(ResultPublisher publisher)
        {
            publisher.ResultCalculated -= OnResultCalculated;
        }

        private void OnResultCalculated(double result, string operationName)
        {
            History.Add($"Operation: {operationName} | Result: {result}");
        }

        public void PrintHistory()
        {
            Console.WriteLine("\n=== HistoryLogger: History ===");
            if (History.Count == 0)
            {
                Console.WriteLine("(empty)");
                return;
            }

            for (int i = 0; i < History.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {History[i]}");
            }
        }
    }
}