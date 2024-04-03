// using Test19;
//
// namespace QueueIntTest;
//
// [TestClass]
// public class UnitTestExample
// {
//     [TestMethod]
//     public void TestMethod1()
//     {
//         Triangle tri1 = new Triangle("") { Side3Length = 15 };
//         Triangle tri2 = new Triangle("") { Side1Length = 15, Side3Length = 20 };
//         Triangle tri3 = new Triangle("") { Side2Length = 12, Side3Length = 17 };
//         Triangle tri4 = new Triangle("") { Side1Length = 9, Side2Length = 12, Side3Length = 15};
//         Triangle tri5 = new Triangle("equilateral triangle") {Side1Length = 6, Side2Length = 6, Side3Length = 6};
//             
//         Console.WriteLine($"In tri1, Side1Length is {tri1.Side1Length}, Side2Length is {tri1.Side2Length}, Side3Length is {tri1.Side3Length}");
//         Console.WriteLine($"In tri2, Side1Length is {tri2.Side1Length}, Side2Length is {tri2.Side2Length}, Side3Length is {tri2.Side3Length}");
//         Console.WriteLine($"In tri3, Side1Length is {tri3.Side1Length}, Side2Length is {tri3.Side2Length}, Side3Length is {tri3.Side3Length}");
//         Console.WriteLine($"In tri4, Side1Length is {tri4.Side1Length}, Side2Length is {tri4.Side2Length}, Side3Length is {tri4.Side3Length}");
//         Console.WriteLine($"In tri5, shape is {tri5.shapeName}, Side1Length is {tri5.Side1Length}, Side2Length is {tri5.Side2Length}, Side3Length is {tri5.Side3Length}");
//             
//         var grade1 = new Grade(1, "Math", 'A');
//         var grade2 = new Grade(1, "French", 'C');
//         var grade3 = grade1;
//         var grade4 = grade1 with { StudentID = 2 };
//             
//         Console.WriteLine(grade1);
//         Console.WriteLine(grade2);
//         Console.WriteLine(grade3);
//         Console.WriteLine($"{grade1 == grade3}");
//         Console.WriteLine($"{grade1 == grade2}");
//         Console.WriteLine($"{grade4}");
//
//         var (studentID, subjectName, grade) = grade1;
//         Console.WriteLine($"{studentID}, {subjectName}, {grade}");
//     }
// }
