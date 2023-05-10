// See https://aka.ms/new-console-template for more information

//1、饿汉式 2、懒汉式 3、懒汉加锁 4、静态内部类 5、C#特有写法 6、破坏单例
using singleton;
using System.Reflection;

Console.WriteLine(HungryMan.GetHungryMan().GetHashCode());//GetHashCode获取对象唯一值
Console.WriteLine(HungryMan.GetHungryMan().GetHashCode());
Console.WriteLine("=================");
////好用的

//for (int i = 0; i < 10; i++)//多开线程调用
//{
//    new Thread(() => { Console.WriteLine(LazyMan.getlazyMan().GetHashCode());  }).Start();
//}

//Console.WriteLine("=================");
////好用的
//for (int i = 0; i < 10; i++)//多开线程调用
//{
//    new Thread(() => { Console.WriteLine(HungryStaticMan.GetHungryStaticMan().GetHashCode()); }).Start();
//}

//Console.WriteLine("=================");
////好用的
//for (int i = 0; i < 10; i++)//多开线程调用
//{
//    new Thread(() => { Console.WriteLine(SampleLazyClass.GetLazyClass().GetHashCode()); }).Start();
//}
Type type = Type.GetType("singleton.SampleLazyClass");
var cons = type.GetConstructors(BindingFlags.NonPublic | BindingFlags.Instance);
var lazyMan1 = (SampleLazyClass)cons[0].Invoke(null);//实例化对象
var lazyMan2 = (SampleLazyClass)cons[0].Invoke(null);
Console.WriteLine(lazyMan1.GetHashCode());
Console.WriteLine(lazyMan2.GetHashCode());
Console.ReadKey();