using Infrastructure.EntityFramework;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using WebApi.Extensions;
using WebApi.Filters;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//регистрируем зависимости
builder.Services.AddBLLServices();
builder.Services.AddSwaggerGen(c =>
{
    c.EnableAnnotations();
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "Микросервис ядра", Version = "v1" });
});
builder.Services.AddAutoMapper(typeof(Program).Assembly, typeof(DateBaseContext).Assembly);
ConfigurationManager configuration = builder.Configuration;
builder.Services.AddDbContext<DateBaseContext>(options => options
                .UseNpgsql(configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddControllers(x => x.Filters.Add(typeof(ApiExceptionFilter)));
var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
