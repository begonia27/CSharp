using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Source.Chapter19;

public partial class Tree<TItem> : IEnumerable<TItem> where TItem : IComparable<TItem>
{
    public TItem NodeData { get; set; }
    public Tree<TItem> LeftTree { get; set; }
    public Tree<TItem> RightTree { get; set; }

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

    IEnumerator<TItem> IEnumerable<TItem>.GetEnumerator()
    {
        if (LeftTree is not null)
        {
            foreach (TItem item in LeftTree)
            {
                yield return item;
            }
        }
        
        yield return NodeData;

        if (RightTree is not null)
        {
            foreach (TItem item in RightTree)
            {
                yield return item;
            }
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        throw new NotImplementedException();
    }
}
