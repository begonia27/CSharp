using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Runtime.InteropServices.JavaScript;

namespace UnitTests.Chapter18;

[TestClass]
public class ListTests
{
    [TestMethod]
    public void ListTest()
    {
        int[] original = [10, 9, 8, 7, 7, 6, 5, 10, 4, 3, 2, 1];
        List<int> firstChange = [10, 9, 8, 7, 7, 6, 5, 10, 4, 3, 2, 99, 1];
        List<int> finallyNumbers = [];
        List<int> secondChange = [10, 9, 8, 7, 6, 5, 10, 4, 3, 2, 99, 1];
        List<int> thirdChange = [10, 9, 8, 7, 6, 5, 4, 3, 2, 99, 1];
        string headerString = "Iterating using a for statement: ";
        List<object> useForExpected = ["Iterating using a for statement: 10, 9, 8, 7, 6, 5, 4, 3, 2, 99, 1"];

        // first test: Add "99"
        foreach (int number in original)
        {
            finallyNumbers.Add(number);
        }
        
        finallyNumbers.Insert(finallyNumbers.Count - 1, 99);
        CollectionAssert.AreEqual(firstChange, finallyNumbers);
        
        // second test: Remove "7" from first meet
        finallyNumbers.Remove(7);
        CollectionAssert.AreEqual(secondChange, finallyNumbers);
        
        // third test: RemoveAt elements where the index is 6
        finallyNumbers.RemoveAt(6);
        CollectionAssert.AreEqual(thirdChange, finallyNumbers);
        
        // fourth test: add string with numbers
        string useForString = string.Join(", ", finallyNumbers);
        List<object> finallyString = [$"{headerString}{useForString}"];
        CollectionAssert.AreEqual(useForExpected, finallyString);
    }

    [TestMethod]
    public void LinkedListTest()
    {
        int[] firstOrigin = [10, 8, 6, 4, 2];
        LinkedList<int> firstNumber = new LinkedList<int>();
        LinkedList<int> firstChange = new LinkedList<int>([2, 4, 6, 8 ,10]);

        int[] secondOrigin = [2, 4, 6, 8, 10];
        LinkedList<int> secondNumber = new LinkedList<int>();
        LinkedList<int> secondChange = new LinkedList<int>([2, 4, 6, 8, 10]);
        
        LinkedList<int> thirdNumber = new LinkedList<int>([1, 3, 5]);
        LinkedList<int> thirdChange = new LinkedList<int>([1, 3, 5, 7]);
        LinkedListNode<int>? node = thirdNumber.Last;

        LinkedList<int> fourthNumber = new LinkedList<int>([1, 3, 5]);
        LinkedList<int> fourthChange = new LinkedList<int>([-1, 1, 3, 5]);
        LinkedListNode<int>? nodeOther = fourthNumber.First;
        
        LinkedList<int> fifthNumber = new LinkedList<int>([2, 4, 6, 8, 10]);
        LinkedList<int> fifthChange = new LinkedList<int>([4, 6, 8, 10]);
        LinkedListNode<int>? nodeFive = fifthNumber.Last;
        
        // first tests
        foreach (int value in firstOrigin)
        {
            firstNumber.AddFirst(value);
        }
        
        CollectionAssert.AreEqual(firstChange, firstNumber);
        
        // second test
        foreach (int number in secondOrigin)
        {
            secondNumber.AddLast(number);
        }
        
        CollectionAssert.AreEqual(secondChange, secondNumber);

        // third test
        if (node != null)
        {
            thirdNumber.AddLast(7);
        }
        
        CollectionAssert.AreEqual(thirdChange, thirdNumber);
        
        // fourth test
        if (nodeOther != null)
        {
            fourthNumber.AddFirst(-1);
        }
        
        CollectionAssert.AreEqual(fourthChange, fourthNumber);
        
        // fifth test
        if (nodeFive != null)
        {
            fifthNumber.Remove(2);
            
            // remove first element:
            // fifthNumber.RemoveFirst();
            
            // remove last element:
            // fifthNumber.RemoveLast();
        }
        
        CollectionAssert.AreEqual(fifthChange, fifthNumber);
    }
}
