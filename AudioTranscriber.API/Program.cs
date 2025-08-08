using AudioTranscriber.Application;
using AudioTranscriber.Application.Interfaces;
using AudioTranscriber.Infrastructure;
using AudioTranscriber.Infrastructure.Persistence;
using AudioTranscriber.Infrastructure.Services;
using AudioTranscriber.Shared;
using AudioTranscriber.Shared.Config;

var builder = WebApplication.CreateBuilder(args);


builder.Services.Configure<MongoDbSettings>(builder.Configuration.GetSection("MongoDb"));
builder.Services.AddSingleton<MongoDbContext>();
builder.Services.AddScoped<IAudioMetadataRepository, AudioMetadataRepository>();


// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Layered Dependency Injections
builder.Services.AddApplicationServices();
builder.Services.AddInfrastructureServices();
builder.Services.AddSharedServices();

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