// TextReader 是 System.IO 命名空间中的类
// TextReader 是 StreamReader 和 StringReader 的基类
// StreamReader 是从打开的文件中读取字符
// StringReader 是从字符串中读取字符

const string fileSystemPath = @"C:\Repos\CSharp\VisualCSarpStepByStep\Test\Test16\HelloArborDay.cs";
const string fileSystemString = "asdjf kls123424djfkl";

// StreamReader:
TextReader readerOfFile = new StreamReader(fileSystemPath);

try
{
    while (readerOfFile.ReadLine() is {} line)
    {
        Console.WriteLine(line);
    }
}
finally
{
    readerOfFile.Close();
}

// StringReader:
TextReader readerOfString = new StringReader(fileSystemString);

try
{
    while (readerOfString.ReadLine() is {} line)
    {
        Console.WriteLine(line);
    }
}
finally
{
    readerOfString.Close();
}

// "using":
using TextReader readerOfFileWithUsing = new StreamReader(fileSystemPath);
while (readerOfFileWithUsing.ReadLine() is {} line)
{
    Console.WriteLine(line);
}

// 上述 while 语句的表达式的语法糖原意如下：
// string line;
// while ((line = reader.ReadLine()) != null)
// {
//     Console.WriteLine(line);
// }
