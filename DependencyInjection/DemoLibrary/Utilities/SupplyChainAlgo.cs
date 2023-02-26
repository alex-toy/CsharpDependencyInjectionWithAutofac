using System;

namespace DemoLibrary.Utilities
{
    public class SupplyChainAlgo : ISupplyChainAlgo
    {
        ILogger _logger;

        public SupplyChainAlgo(ILogger logger)
        {
            _logger = logger;
        }

        public void ExecuteBestFit()
        {
            Console.WriteLine("executing best fit");
            _logger.Log("executing best fit");
        }
    }
}
