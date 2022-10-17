using Microsoft.EntityFrameworkCore;
using Web_API_DOTNET_CORE.Models;

var builder = WebApplication.CreateBuilder(args);

//Configure the sql server datadase connectionStrings
builder.Services.AddDbContext<API_MVCContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("TEConnection")));

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Cross Policy
builder.Services.AddCors(c =>
{
    c.AddPolicy("AllowOrigin",options => options.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
});

var app = builder.Build();

app.UseCors(options => options.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
