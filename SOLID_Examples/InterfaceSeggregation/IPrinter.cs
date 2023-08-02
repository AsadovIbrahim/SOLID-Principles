using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Examples.InterfaceSeggregation
{
    public interface IPrinter
    {
        void Print();
    }
    public interface IScanner
    {
        void Scan();
    }
    public interface IFax
    {
        void Fax();
    }
    public class SimplePrinter : IPrinter
    {
        public void Print()
        {
            Console.WriteLine("Printing...");
        }
    }

}
