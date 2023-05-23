using Autofac;
using Autofac.Core;
using Autofac.Extensions.DependencyInjection;
using DI;
using DIWebAPI;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSignalR();  
//builder.Services.AddScoped<IAcccount,Account>();
//使用Autofac扩充原来的DI容器
builder.Host.UseServiceProviderFactory(new  AutofacServiceProviderFactory());
builder.Host.ConfigureContainer<ContainerBuilder>(op => {
    op.RegisterModule<AutofaacModule>();
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapHub<ChatRoomServer>("/chatRoomServer");
app.MapControllers();

app.Run();
