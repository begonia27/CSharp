namespace Source.Chapter17;

public partial class Tree<TItem>
{
    public static void InsertIntoTree<TItem>(ref Tree<TItem> tree, params TItem[] data) where TItem : IComparable<TItem>
    {
        foreach (TItem datum in data)
        {
            if (tree is null)
            {
                tree = new Tree<TItem>(datum);
            }
            else
            {
                tree.Insert(datum);
            }
        }
    }
}
