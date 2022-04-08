

using DailyCoding253;
using DailyCoding253.Interfaces;
using DailyCoding253.Services;
using Xunit;

/*
 * This solution requirse an input string and a row count. 
 * The result should be that the input text is printed in a zig zag pattern
 * Where the row count defines the depth of each zig-zag
 * https://www.geeksforgeeks.org/print-concatenation-of-zig-zag-string-form-in-n-rows/
 * */

void Run(string input, int rows, IDebugger debugger)
{
    var solution = new Solution(debugger);

    solution.Solve(input, rows);
}

Run("Helloworldthisisateststring", 5, new ConsoleDebugger());
Run("hello", 1, new ConsoleDebugger());