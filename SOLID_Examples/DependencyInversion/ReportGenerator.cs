using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Examples.DependencyInversion
{
    public class ReportGenerator
    {
        private readonly IDataFetcher _dataFetcher;

        public ReportGenerator(IDataFetcher dataFetcher)
        {
            _dataFetcher = dataFetcher;
        }

        public void GenerateReport()
        {
            var data = _dataFetcher.FetchData();

            Console.WriteLine("Generating Report...");
        }
    }

    public interface IDataFetcher
    {
        string FetchData();
    }

    public class DatabaseFetcher : IDataFetcher
    {
        public string FetchData()
        {
            return "Data fetched from the database.";
        }
    }

    public class ApiFetcher : IDataFetcher
    {
        public string FetchData()
        {
            return "Data fetched from the API.";
        }
    }

}
