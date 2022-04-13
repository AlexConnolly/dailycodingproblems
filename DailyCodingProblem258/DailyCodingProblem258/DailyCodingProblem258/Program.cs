using Xunit;

var tree = new Node()
{
    Value = 1,
    Left = new Node()
    {
        Value = 2,
        Left = new Node()
        {
            Value = 4
        },
        Right = new Node()
        {
            Value = 5
        }
    },
    Right = new Node()
    {
        Value = 3,
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

Assert.Equal(new int[] { 1, 3, 2, 4, 5, 6, 7}, BoustrophedonFlatten(tree));

static int[] BoustrophedonFlatten(Node tree)
{
    List<int> result = new List<int>();

    List<Node> currentNodes = new List<Node>() { tree };

    bool isReversing = false;

    while(currentNodes != null && currentNodes.Count > 0)
    {
        foreach(var nextValue in FlattenRow(currentNodes, isReversing))
        {
            result.Add(nextValue);
        }

        var nextNodes = new List<Node>();

        foreach(var node in currentNodes)
        {
            if(node.Left != null)
                nextNodes.Add(node.Left);

            if(node.Right != null)
                nextNodes.Add(node.Right);
        }

        currentNodes = nextNodes;
        isReversing = !isReversing;
    }

    return result.ToArray();
}

static int[] FlattenRow(List<Node> nodes, bool reverse)
{
    var values = new int[nodes.Count];

    for (int x = 0; x < nodes.Count; x++)
    {
        var value = nodes[x].Value;

        if (reverse)
        {
            values[nodes.Count - 1 - x] = value;
        }
        else
        {
            values[x] = value;
        }
    }

    return values;
}

public class Node
{
    public Node(int value, Node left, Node right)
    {
        this.Value = value;
        this.Left = left;
        this.Right = right;
    }

    public Node()
    {

    }

    public int Value;
    public Node Left;
    public Node Right;
}