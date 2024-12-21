using Microsoft.EntityFrameworkCore;
using ProductosApi;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<ProductoDbContext>(options =>
    options.UseMySql(
        builder.Configuration.GetConnectionString("DefaultConnection"),
        new MySqlServerVersion(new Version(5, 7, 0))
    )
);

builder.Services.AddCors(options =>
{
    options.AddPolicy("PolicyServiceCollectionExtensions", policy =>
    {
        policy.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader();
    });
});
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors("PolicyServiceCollectionExtensions");
app.UseHttpsRedirection();
app.MapControllers();

app.Run();
