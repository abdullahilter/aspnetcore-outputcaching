using dotnet7_outputcache;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<TestContext>(options => options.UseInMemoryDatabase(nameof(TestContext)));
builder.Services.AddScoped<ICustomerService, CustomerService>();

builder.Services.AddOutputCache();

var app = builder.Build();

app.UseOutputCache();

app.RegisterCustomerEndpoints();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.Run();