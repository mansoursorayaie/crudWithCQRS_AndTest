using Crud.Data.DataBase;
using Crud.Service.ServiceConfig;

var builder = WebApplication.CreateBuilder(args);
// Add services to the container.
string connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddCrudServices(connectionString);
builder.Services.AddControllers();


builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();


if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

using (var scope = app.Services.CreateScope())
{
    var iDbCrud = scope.ServiceProvider.GetRequiredService<IDbCrud>();
    iDbCrud.EnsureCreated();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
