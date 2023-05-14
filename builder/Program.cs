//创建者模式：
//核心概念：导演者、创建者、实现链式调用
using builder;
CreatemyComputer CreatemyComputer = new CreatemyComputer();
Director director = new Director(CreatemyComputer);