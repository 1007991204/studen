// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");//顶级语法

internal partial class Program//通常语法 internal 同程序集可访问  
{
    private static void Main(string[] args)
    {
        var sc = new ServiceCollection();//测试全局应用
        #region using 声明
        {
            using var streamOut = File.OpenWrite("C:\\Users\\黄招宇\\Desktop\\1.txt");
            using var writer = new StreamWriter(streamOut);
            writer.WriteLine("hello");
        }

        string s = File.ReadAllText("C:\\Users\\黄招宇\\Desktop\\1.txt");
        Console.WriteLine(s);
        #endregion

        #region 记录类型 Record
        var stu1 = new Student() { Name = "张三", Age = 11 };
        var stu2 = new Student() { Name = "李四", Age = 15 };
        var stu3 = new Student() { Name = "张三", Age = 11 };
        Console.WriteLine(stu1 == stu2);
        Console.WriteLine(stu1 == stu3);
        #endregion
        Console.WriteLine("Hello World!");
        Console.ReadKey();
    }

}