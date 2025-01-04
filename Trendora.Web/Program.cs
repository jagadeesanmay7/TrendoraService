using Microsoft.EntityFrameworkCore;
using Trendora.Infrastructure.DbContexts;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

#region CORS Configuration
builder.Services.AddCors(options =>
{
    options.AddPolicy("CustomPolicy", x => x.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod());
});
#endregion

#region Database Connectivity
builder.Services.AddDbContext<TrendoraDbContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnections")));
#endregion

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
