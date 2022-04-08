using DailyCoding253.Interfaces;
using DailyCoding253.Services;
using System.Linq;
using Xunit;

namespace DailyCoding253.Tests
{
    public class TestAll
    {
        private void Run(string input, int rows, IDebugger debugger)
        {
            var solution = new Solution(debugger);

            solution.Solve(input, rows);
        }

        [Theory]
        [InlineData("hello", 2, new string[] { "h l o", " e l" })]
        [InlineData("hello", 1, new string[] { "hello" })]
        [InlineData("hello", 3, new string[] { "h   l", " e    o", "  l" })]
        public void Test(string input, int rows, string[] expects)
        {
            var debugger = new ConsoleDebugger();

            Run(input, rows, debugger);

            var result = debugger.getAllLines().ToArray();

            Assert.Equal(result.Length, expects.Length);

            for (int x = 0; x < expects.Length; x++)
            {
                Assert.Equal(result[x], expects[x]);
            }
        }
    }
}