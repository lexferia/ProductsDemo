using Microsoft.EntityFrameworkCore;
using ProductsDemo.WebAPI.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<DemoDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

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

app.PrepPopulation();

//app.MapGet("/weatherforecast", async () =>
//{
//    var handler = new HttpClientHandler
//    {
//        ServerCertificateCustomValidationCallback = (message, cert, chain, errors) => true
//    };
//    using (var httpClient = new HttpClient(handler) { BaseAddress = new Uri("http://productsdemo-networktest") })
//    {
//        return await httpClient.GetFromJsonAsync<IEnumerable<WeatherForecast>>("weatherforecast");
//    }
//})
//.WithName("GetWeatherForecast");

//internal record WeatherForecast(DateTime Date, int TemperatureC, string? Summary)
//{
//    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
//}

app.Run();

