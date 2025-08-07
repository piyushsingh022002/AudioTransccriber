// using AudioTranscriber.API;
// using AudioTranscriber.Application;
// using AudioTranscriber.Infrastructure;
// using AudioTranscriber.Shared;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Layered Dependency Injections
// builder.Services.AddApplicationServices();
// builder.Services.AddInfrastructureServices(builder.Configuration);
// builder.Services.AddSharedServices();

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