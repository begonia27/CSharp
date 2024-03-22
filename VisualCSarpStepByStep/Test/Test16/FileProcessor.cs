namespace Test16;

class FileProcessor
{
    private readonly FileStream _file;

    public FileProcessor(string fileName)
    {
        this._file = File.OpenRead(fileName);
    }

    ~FileProcessor()
    {
        // 针对特定的情况，采取相应的方式来释放对象所占用的资源
        // 比如本例，打开文件后，就要“关闭”文件来释放资源
        // 其他的例子，如连接数据库后，就要“断开连接”来释放资源
        this._file.Close();
    }
}

// conversion by compiler:
// class FileProcessor()
// {
//     ~FileProcessor()
//     {
//         // code
//     }
// }
//
// class FileProcessor()
// {
//     protected override void Finalize()
//     {
//         try
//         {
//              // code
//         }
//         finally
//         {
//             base.Finalize();
//         }
//     }
// }
