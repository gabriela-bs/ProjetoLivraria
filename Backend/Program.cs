using Backend.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore;

var myAllowSpecificOrigins = "myAllowSpecificOrigins";
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddDbContext<ApiDbContext>(op => 
    op.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"))
);

builder.Services.AddCors(op => 
{
    op.AddPolicy(name: myAllowSpecificOrigins, 
    builder => 
    {
        builder.WithOrigins("https://localhost:4200")
        .AllowAnyMethod()
        .AllowAnyHeader();
});
});

builder.Services.AddSwaggerGen();

builder.Services.AddSwaggerGen(op => {
    op.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo{
        
        Title = "Estoque",
        Version = "v1"
    });

});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(op => {
        op.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
    });
}
//middleware?
app.UseCors(myAllowSpecificOrigins); //habilita conexão com o angular


app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
