using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyCoding254
{
    public class Solver
    {
        public Node Solve(Node tree)
        {
            if(!tree.IsNodeTruthy)
            {
                return new Node()
                {
                    Value = tree.Value
                };
            } else
            {
                tree.Left = GetAcceptableNode(tree.Left);
                tree.Right = GetAcceptableNode(tree.Right);
            }

            return tree;
        }

        public Node GetAcceptableNode(Node node)
        {
            if (node == null)
            {
                return null;
            }

            Node leftAcceptable = GetAcceptableNode(node.Left);
            Node rightAcceptable = GetAcceptableNode(node.Right);

            if(leftAcceptable != null)
            {
                if (leftAcceptable.IsNodeTruthy)
                {
                    node.Left = leftAcceptable;
                }
            }

            if(rightAcceptable != null)
            {
                if(rightAcceptable.IsNodeTruthy)
                {
                    node.Right = rightAcceptable;
                }
            }

            if (node.IsNodeTruthy)
            {
                return node;
            } else
            {
                if (leftAcceptable != null)
                {
                    if (leftAcceptable.IsNodeTruthy)
                    {
                        return leftAcceptable;
                    }

                    return new Node()
                    {
                        Value = leftAcceptable.Value
                    };

                } else if(rightAcceptable != null)
                {
                    if (rightAcceptable.IsNodeTruthy)
                    {
                        return rightAcceptable;
                    }

                    return new Node()
                    {
                        Value = rightAcceptable.Value
                    };

                } else if(node.Left != null)
                {
                    return new Node()
                    {
                        Value = node.Left.Value
                    };
                } else if (node.Right != null)
                {
                    return new Node()
                    {
                        Value = node.Right.Value
                    };
                }
            }

            return new Node()
            {
                Value = node.Value
            };
        }
    }
}
