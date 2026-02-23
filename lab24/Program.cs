using System;
using lab24.Core;
using lab24.Observer;
using lab24.Strategies;

namespace lab24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1) Strategy processor + publisher
            var processor = new NumericProcessor(new SquareOperationStrategy());
            var publisher = new ResultPublisher();

            // 2) Observers
            var consoleLogger = new ConsoleLoggerObserver();
            var historyLogger = new HistoryLoggerObserver();
            var thresholdNotifier = new ThresholdNotifierObserver(threshold: 50);

            // 3) Subscribe observers
            consoleLogger.Subscribe(publisher);
            historyLogger.Subscribe(publisher);
            thresholdNotifier.Subscribe(publisher);

            // 4) Inputs
            double[] inputs = { 2, 3, 8, 10, 25 };

            // 5) Run multiple strategies + publish after each calculation
            RunStrategy(processor, publisher, new SquareOperationStrategy(), inputs);
            RunStrategy(processor, publisher, new CubeOperationStrategy(), inputs);
            RunStrategy(processor, publisher, new SquareRootOperationStrategy(), new double[] { 4, 9, 16, 25 });

            // 6) Print history
            historyLogger.PrintHistory();

            Console.WriteLine("\nDone. Press any key...");
            Console.ReadKey();
        }

        private static void RunStrategy(
            NumericProcessor processor,
            ResultPublisher publisher,
            INumericOperationStrategy strategy,
            double[] inputs)
        {
            processor.SetStrategy(strategy);

            Console.WriteLine($"\n--- Running strategy: {processor.CurrentOperationName} ---");

            foreach (var input in inputs)
            {
                try
                {
                    double result = processor.Process(input);

                    // IMPORTANT: publish after each processing
                    publisher.PublishResult(result, processor.CurrentOperationName);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"[Error] Input: {input} | Operation: {processor.CurrentOperationName} | {ex.Message}");
                }
            }
        }
    }
}