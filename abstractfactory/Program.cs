using abstractfactory;
using abstractfactory.demo;
using static abstractfactory.demo.DbFactory;

Factory factory = new Factory();
var pet = factory.CreatePet<WhitePet>();
pet.Talk();

Console.WriteLine("========================");
CreateDbFactory createDbFactory = new CreateDbFactory();
var mysql = createDbFactory.CreateDB<MySQLDbLocator>();
mysql.PrintInfo();
var client = mysql.GetSqlSugarClient();
Console.WriteLine(client.GetDate());