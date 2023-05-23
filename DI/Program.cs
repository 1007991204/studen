using DI;
using Microsoft.Extensions.DependencyInjection;

var sc = new ServiceCollection();
sc.AddScoped<IAcccount, Account>();
var ps = sc.BuildServiceProvider();
var account = ps.GetService<IAcccount>();
account.Prient();
