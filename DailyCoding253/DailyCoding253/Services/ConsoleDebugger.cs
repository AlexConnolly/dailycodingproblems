using DailyCoding253.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyCoding253.Services
{
    public class ConsoleDebugger : IDebugger
    {
        private List<string> lines;

        public ConsoleDebugger()
        {
            this.lines = new List<string>();
        }
        public IEnumerable<string> getAllLines()
        {
            return this.lines;
        }

        public void writeline(string message)
        {
            this.lines.Add(message);
            Console.WriteLine(message);
        }
    }

}
