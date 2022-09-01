using Microsoft.EntityFrameworkCore;
using ReportService.Data.Context;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<ReportContext>(options => options.UseNpgsql(builder.Configuration.GetConnectionString("ReportConnection"), b => b.MigrationsAssembly("ReportService.Data")));
builder.Services.AddScoped<DbContext>(provider => provider.GetService<ReportContext>());

var app = builder.Build();

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
