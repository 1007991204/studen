//解决了客户端直接创建对象的责任，仅仅承担使用的责任，实现了责任隔离
// 简单工厂模式以及工厂模式主要通过反射来实现
//代码服用
using factory;
using factory.工厂模式设计模式;

var yellow = HumanFactorySimple.CreateHuman<YellowMan>();
var white = HumanFactorySimple.CreateHuman<WhiteMan>();
yellow.Talk();
white.Talk();
Console.WriteLine("===========");
var humanFactory = new HumanFactory();
var yellow2 = humanFactory.CreateHuman<YellowMan>();
yellow2.GetColor();
yellow2.Talk();
Console.WriteLine("===========");


Console.WriteLine("延迟加载");
var human = new FactoryDelay();
var yellow3 = human.GetHuman("yellow");
yellow3.GetColor();