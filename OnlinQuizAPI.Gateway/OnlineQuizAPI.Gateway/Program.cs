using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Ocelot.DependencyInjection;
using Ocelot.Middleware;
using MMLib.SwaggerForOcelot;

var builder = WebApplication.CreateBuilder(args);

// Downloading configuration Ocelot from file configuration.json
builder.Configuration.AddJsonFile("configuration.json", optional: false, reloadOnChange: true);
builder.Services.AddOcelot(builder.Configuration);

// Adding swagger support for for Ocelot
// This library collects all configs from all services, and swagger UI become shared 
builder.Services.AddSwaggerForOcelot(builder.Configuration);


builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();


var app = builder.Build();

app.UseSwagger();
app.UseSwaggerForOcelotUI(opt => {
    opt.PathToSwaggerGenerator = "/swagger/docs";
}).UseOcelot().Wait();


app.MapControllers();

app.Run();