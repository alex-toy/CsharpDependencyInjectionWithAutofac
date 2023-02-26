using DemoLibrary.Utilities;
using System;

namespace DemoLibrary
{
    public class BetterBusinessLogic : IBusinessLogic
    {
        ILogger _logger;
        IDataAccess _dataAccess;
        ISupplyChainAlgo _supplyChainAlgo;

        public BetterBusinessLogic(ILogger logger, IDataAccess dataAccess, ISupplyChainAlgo supplyChainAlgo)
        {
            _logger = logger;
            _dataAccess = dataAccess;
            _supplyChainAlgo = supplyChainAlgo;
        }

        public void ProcessData()
        {
            _logger.Log("Starting the better processing of data.");
            Console.WriteLine("Better Processing the data");
            _dataAccess.LoadData();
            _supplyChainAlgo.ExecuteBestFit();
            _dataAccess.SaveData("Better ProcessedInfo");
            _logger.Log("Finished better processing of the data.");
        }
    }
}
