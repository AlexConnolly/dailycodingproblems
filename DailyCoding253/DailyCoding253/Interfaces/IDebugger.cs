using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyCoding253.Interfaces
{
    public interface IDebugger
    {
        void writeline(string message);
        IEnumerable<string> getAllLines();
    }
}
