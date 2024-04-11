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
        LinkedList<int> firstNumber = [];
        LinkedList<int> firstChange = new LinkedList<int>([2, 4, 6, 8 ,10]);

        int[] secondOrigin = [2, 4, 6, 8, 10];
        LinkedList<int> secondNumber = [];
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

    [TestMethod]
    public void QueueTest()
    {
        int[] array = [9, 3, 7, 2 ];
        Queue<int> firstNumber = new Queue<int>();
        Queue<int> firstChange = new Queue<int>([9, 3, 7, 2]);
        Queue<int> record = new Queue<int>([]);
        
        foreach (int value in array)
        {
            firstNumber.Enqueue(value);
        }
        
        CollectionAssert.AreEqual(firstChange, firstNumber);

        while (firstNumber.Count > 0)
        {
            firstNumber.Dequeue();
        }
        
        CollectionAssert.AreEqual(record, firstNumber);
    }

    [TestMethod]
    public void PriorityQueueTest()
    {
        List<string> finallyMessages =
        [
            "Twas 1",
            "Brillig 1",
            "Slithy 2",
            "and 2",
            "the 3",
            "Toves 3"
        ];
        
        PriorityQueue<string, int> message = new PriorityQueue<string, int>();
        List<string> changeMessage = [];
        
        message.Enqueue("Twas", 1);
        message.Enqueue("Brillig", 1);
        message.Enqueue("and", 2);
        message.Enqueue("the", 3);
        message.Enqueue("Slithy", 2);
        message.Enqueue("Toves", 3);

        while (message.TryDequeue(out string element, out int priority))
        {
            changeMessage.Add($"{element} {priority}");
            // Console.WriteLine($"{element} {priority}");
        }
        
        CollectionAssert.AreEqual(finallyMessages, changeMessage);
    }

    [TestMethod]
    public void StackPushTest()
    {
        int[] numbers = [9, 7, 2, 6];
        Stack<int> original = new Stack<int>();
        Stack<int> pushExpected = new Stack<int>([9, 7, 2, 6]);
        
        foreach (int value in numbers)
        {
            original.Push(value);
        }
        
        CollectionAssert.AreEqual(pushExpected, original);
    }
    
    [TestMethod]
    public void StackPopTest()
    {
        int number = 0;
        List<int> finallyNumbers = [];
        
        // 入栈后的访问顺序是由后到前，索引为 0 的元素是栈中的值 6
        Stack<int> original = new Stack<int>([9, 7, 2, 6]);
        
        // 当我们做 Pop 操作时，第一个被 Add 到 List 里的数是 9 （后进先出）
        Stack<int> popExpected = new Stack<int>([9, 7, 2, 6]);

        while (original.Count > 0)
        {
            int item = original.Pop();
            finallyNumbers.Add(item);
        }
        
        CollectionAssert.AreEquivalent(popExpected, finallyNumbers);
        CollectionAssert.AreEqual(popExpected, finallyNumbers);
    }

    [TestMethod]
    public void DictionaryTest()
    {
        Dictionary<string, int> info = new Dictionary<string, int>();
        info.Add("John", 57);
        info.Add("Diana", 57);
        info["James"] = 30;
        info["Francesca"] = 27;
        
        List<string> membersInfo = new ();
        List<string> membersName = new ();
        List<int> membersAge = new ();
        
        List<string> membersInfoExpected =
        [
            "John 57",
            "Diana 57",
            "James 30",
            "Francesca 27"
        ];
        
        List<string> membersNameExpected =
        [
            "John",
            "Diana",
            "James",
            "Francesca"
        ];
        
        List<int> membersAgeExpected =
        [
            57,
            57,
            30,
            27
        ];

        foreach (KeyValuePair<string, int> element in info)
        {
            membersInfo.Add($"{element.Key} {element.Value}");
            membersName.Add($"{element.Key}");
            membersAge.Add(element.Value);
        }
        
        CollectionAssert.AreEqual(membersInfoExpected, membersInfo);
        CollectionAssert.AreEqual(membersNameExpected, membersName);
        CollectionAssert.AreEqual(membersAgeExpected, membersAge);
    }

    [TestMethod]
    public void SortedListTest()
    {
        SortedList<string, int> familyInfo = new SortedList<string, int>();
        List<string> infoFinally = [];
        
        familyInfo.Add("John", 52);
        familyInfo.Add("James", 12);
        familyInfo.Add("Alice", 52);
        familyInfo.Add("Bob", 2);

        List<string> sortedExpected =
        [
            "Alice 52",
            "Bob 2",
            "James 12",
            "John 52"
        ];
        
        foreach (KeyValuePair<string, int> elementInfo in familyInfo)
        {
            infoFinally.Add($"{elementInfo.Key} {elementInfo.Value}");
        }
        
        CollectionAssert.AreEqual(sortedExpected, infoFinally);
    }
}
