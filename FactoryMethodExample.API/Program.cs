using FactoryMethodExample.API.Infrastructure.Payments.Interfaces;
using FactoryMethodExample.API.Infrastructure.Payments.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddScoped<CartaoDeCreditoService>();
builder.Services.AddScoped<PixService>();
builder.Services.AddScoped<BoletoService>();
builder.Services.AddScoped<IPaymentServiceFactory, PaymentServiceFactory>();

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
