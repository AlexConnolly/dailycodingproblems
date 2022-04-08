using Xunit;

namespace DailyCoding254.Tests
{
    public class TestAll
    {
        [Fact]
        public void RunTestAll()
        {
            Solver solver = new Solver();
            var result = solver.Solve(Test1Input);

            Assert.Equal(Test1Input, Test1Expected);
        }

        private Node Test1Expected = new Node()
        {
            Value = 0,
            Left = new Node()
            {
                Value = 5
            },
            Right = new Node()
            {
                Value = 4,
                Left = new Node()
                {
                    Value = 6
                },
                Right = new Node()
                {
                    Value = 7
                }
            }
        };

        private Node Test1Input = new Node()
        {
            Value = 0,
            Left = new Node()
            {
                Value = 1,
                Left = new Node()
                {
                    Value = 3,
                    Right = new Node()
                    {
                        Value = 5
                    }
                }
            },
            Right = new Node()
            {
                Value = 2,
                Right = new Node()
                {
                    Value = 4,
                    Left = new Node()
                    {
                        Value = 6
                    },
                    Right = new Node()
                    {
                        Value = 7
                    }
                }
            }
        };
    }
}