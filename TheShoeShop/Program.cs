using theshoeshop.userservice.infrasturcture;
using customlogging;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.AddLogging(builder.Configuration);

builder.Services.AddInfrasturcture(builder.Configuration);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseLogContext();


app.UseHttpsRedirection();


app.UseAuthorization();

app.MapControllers();

app.Run();
