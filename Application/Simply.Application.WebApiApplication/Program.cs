using Simply.Application.ApplicationModel;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddSimply(builder.Configuration);

WebApplication app = builder.Build();

app.ConfigureWebApplication();

app.Run();

