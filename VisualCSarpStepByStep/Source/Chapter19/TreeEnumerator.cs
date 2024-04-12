using System.Collections;

namespace Source.Chapter19;

public class TreeEnumerator<TItem>: IEnumerator<TItem> where TItem: IComparable<TItem>
{
    private Tree<TItem> currentData = null;
    private TItem currentITem = default(TItem);
    private Queue<TItem> enumData = null;
    
     public TreeEnumerator (Tree<TItem> data)
     {
         currentData = data;
     }

     private void populate(Queue<TItem> enumQueue, Tree<TItem> tree)
     {
         if (tree.LeftTree is not null)
         {
             populate(enumQueue, tree.LeftTree);
         }
         
         enumQueue.Enqueue(tree.NodeData);
         
         if (tree.RightTree is not null)
         {
             populate(enumQueue, tree.RightTree);
         }
         
     }
     
     // public bool MoveNext()
     // {
     //     throw new NotImplementedException();
     // }

     bool System.Collections.IEnumerator.MoveNext()
     {
         if (this.enumData is not null)
         {
             enumData = new Queue<TItem>();
             populate(enumData, currentData);
         }

         if (enumData.Count > 0)
         {
             currentITem = enumData.Dequeue();
             return true;
         }

         return false;
     }

     public void Reset()
     {
         throw new NotImplementedException();
     }

     public TItem Current
     {
         get
         {
             if (enumData is null)
             {
                 throw new InvalidOperationException("Use MoveNext before calling Current");
             }

             return currentITem;
         }
     }

     object IEnumerator.Current => Current;

     public void Dispose()
     {
         // throw new NotImplementedException();
     }
}
