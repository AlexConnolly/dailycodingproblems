using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyCoding254
{
    public class Node
    {
        public int Value { get; set; }
        public Node Left { get; set; }
        public Node Right { get; set; }

        public bool IsNodeTruthy
        {
            get
            {
                return Left != null && Right != null;
            }
        }
    }
}
