//原型设计模式
//采用克隆的方式创建对象而不是用new的方式
//性能高，逃避构造函数的约束，在内存中进行二级制流的拷贝
//应用场景：资源优化场景，性能和安全要求的场景，一个对象多个修改者的场景
//深浅拷贝
//浅拷贝只能拷贝值类型，引用类型类型的地址
//深拷贝 应用包直接使用
//映射DTO几种方式
//可拓展
//1、手写
//2、表达式目录树+缓存
//3、AutoMapper
//4、反射
//5、Json字符串序列化
//6、对象二进制序列化
using CloneExtensions;
using prototype;

student student = new student();
student.SetName("小明");
student cloneStudent = student.GetClone() as student;
cloneStudent.SetName("小王");
Console.WriteLine(student.name);
Console.WriteLine(cloneStudent.name);