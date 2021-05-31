using DemoLibrary.Utilites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public class BusinessLogic : IBusinessLogic
    {
        private readonly ILogger _logger;
        private readonly IDataAccess _dataAccess;

        public BusinessLogic(ILogger logger,IDataAccess dataAccess)
        {
            this._logger = logger;
            this._dataAccess = dataAccess;
        }
        public void ProcessData()
        {
            _logger.Log("starting the processing of data");
            Console.WriteLine("Processing the data");
            _dataAccess.LoadData();
            _dataAccess.SaveData("Process info");
            _logger.Log("Finished processing of the data");


        }
    }
}
