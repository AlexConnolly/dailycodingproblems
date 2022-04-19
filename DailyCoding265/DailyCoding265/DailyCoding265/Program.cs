// See https://aka.ms/new-console-template for more information
using Xunit;

int tx = 0;
int tmultiplier = 1;

var input = new int[] { 10, 40, 200, 1000, 40, 30 };
var output = new int[input.Length];


while (tx < input.Length)
{
    var current = input[tx];
    var next = int.MaxValue;

    if(tx + 1 < input.Length)
    {
        next = input[tx + 1];
    }

    if(current < next)
    {
        output[tx] = tmultiplier;
        tmultiplier++;
    } else if (current > next)
    {
        if(tmultiplier == 1)
        {
            output[tx] = tmultiplier + 1;
        } else
        {
            output[tx] = tmultiplier;
        }

        tmultiplier = 1;
    } else
    {
        output[tx] = tmultiplier;
    }

    tx++;
}

Assert.Equal(output, new int[] { 1, 2, 3, 4, 2, 1 });