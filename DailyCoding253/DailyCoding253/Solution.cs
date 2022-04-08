using DailyCoding253.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace DailyCoding253
{
    public class Solution
    {
        private IDebugger debugger;

        public Solution(IDebugger debugger)
        {
            this.debugger = debugger;
        }

        public void Solve(string input, int rows)
        {
            if(rows == 1)
            {
                debugger.writeline(input);
                return;
            }

            string[] output = new string[rows];

            int currentCharacter = 0;
            int currentRow = 0;

            bool isReversing = false;

            while (currentCharacter < input.Length)
            {
                if (output[currentRow] == null)
                {
                    output[currentRow] = "";
                }

                if (output[currentRow].Length != currentCharacter)
                {
                    while (output[currentRow].Length != currentCharacter)
                    {
                        output[currentRow] += " ";
                    }
                }

                output[currentRow] += input[currentCharacter];

                // We could probably just work out the row by the character but... eh
                currentCharacter++;

                if (currentRow == 0 && isReversing)
                {
                    isReversing = false;
                }
                else if (currentRow == output.Length - 1)
                {
                    isReversing = true;
                }

                if (isReversing)
                {
                    currentRow -= 1;
                }
                else
                {
                    currentRow++;
                }
            }

            foreach (var str in output)
            {
                debugger.writeline(str);
            }
        }
    }
}
