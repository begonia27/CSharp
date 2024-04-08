using Source.Chapter17;
namespace UnitTests.Chapter17;

    [TestClass]
    public class BinaryTreeTests
    {
        [TestMethod]
        public void BinaryTreeTest()
        {
            Tree<int> tree1 = new Tree<int>(10);

            List<int> values = [-12, -8, 0, 5, 5, 8, 8, 10, 11, 14, 15];

            foreach (int value in values)
            {
                tree1.Insert(value);
            }

            List<int> sortedData = tree1.WalkTree();
            string expectedData = "-12 -8 0 5 5 8 8 10 10 11 14 15";
        
            Assert.AreEqual(expectedData, String.Join(" ", sortedData.Select(n => n.ToString())));
        }

        [TestMethod]
        public void BinaryTreeStringTest()
        {
            Tree<string> tree2 = new Tree<string>("Hello");
        
            List<string> stringValues = ["World", "How", "Are", "You", "Today", "I", "Hope", "You", "Are", "Feeling", "Well",
                "!"];

            foreach (string value in stringValues)
            {
                tree2.Insert(value);
            }

            List<string> sortedData = tree2.WalkTree();
            string expectedData = "! Are Are Feeling Hello Hope How I Today Well World You You";
        
            Assert.AreEqual(expectedData, String.Join(" ", sortedData.Select(n => n.ToString())));
        }
    }
