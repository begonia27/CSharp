namespace Source.Chapter17;

public class Tree<TItem> where TItem : IComparable<TItem>
{
    public TItem NodeData { get; set; }
    public Tree<TItem>? LeftTree { get; set; }
    public Tree<TItem>? RightTree { get; set; }

    public Tree(TItem nodeValue)
    {
        NodeData = nodeValue;
        LeftTree = null;
        RightTree = null;
    }

    public void Insert(TItem newTItem)
    {
        TItem currentNodeValue = NodeData;
        if (currentNodeValue.CompareTo(newTItem) > 0)
        {
            if (LeftTree == null)
            {
                LeftTree = new Tree<TItem>(newTItem);
            }
            else
            {
                LeftTree.Insert(newTItem);
            }
        }
        else
        {
            if (RightTree == null)
            {
                RightTree = new Tree<TItem>(newTItem);
            }
            else
            {
                RightTree.Insert(newTItem);
            }
        }
    }

    public List<TItem> WalkTree()
    {
        List<TItem> result = [];

        if (LeftTree is not null)
        {
            result = result.Concat(LeftTree.WalkTree()).ToList();
        }

        result.Add(NodeData);

        if (RightTree is not null)
        {
            result = result.Concat(RightTree.WalkTree()).ToList();
        }

        return result;
    }
}

// class BinaryTree
// {
//     public string value;
//     public BinaryTree left;
//     public BinaryTree right;
//
//     public void Walk()
//     {
//         right?.Walk();
//         left?.Walk();
//         Console.WriteLine(value);
//     }
// }
