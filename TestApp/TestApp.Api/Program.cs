using TestApp.Contracts;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddGrpcClients(builder.Configuration);

var app = builder.Build();

app.MapGet("/", () => "Hello World!");


app.Run();