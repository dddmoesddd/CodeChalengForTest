using CodeChalengeForTest.Application;
using CodeChalengeForTest.Infrustrcture;

var builder = WebApplication.CreateBuilder(args);
var config = new ConfigurationBuilder()
 .SetBasePath(AppContext.BaseDirectory)
 .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
 .Build();
builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(policy =>
    {
        policy.AllowAnyOrigin()
              .AllowAnyHeader()
              .AllowAnyMethod();
    });
});
builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(Program).Assembly));
builder.Services.AddInfrustrctureservices(config);
builder.Services.AddApplicationDependencyInjection();
builder.Services.AddControllers();
builder.Services.AddOpenApi();

var app = builder.Build();

foreach (var service in builder.Services)
{
    if (service.ServiceType.FullName?.Contains("MediatR") == true)
    {
        Console.WriteLine($"{service.ServiceType.FullName} -> {service.ImplementationType?.FullName}");
    }
}

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}
app.UseCors(); 
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
