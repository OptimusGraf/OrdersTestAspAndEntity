using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using Orders.Models;



var builder = WebApplication.CreateBuilder(args);

string connection = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<OrdersContext>(options => options.UseSqlServer(connection));

builder.Services.AddMvc();
var app = builder.Build();
app.MapControllers();

app.Run();



