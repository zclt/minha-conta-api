using Microsoft.EntityFrameworkCore;
using MinhaContaApi.Repositories;
using MinhaContaApi.Repositories.Abstractions;
using MinhaContaApi.Repositories.Repositories;
using MinhaContaApi.Services.Abstractions;
using MinhaContaApi.Services.Profiles;
using MinhaContaApi.Services.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services
    .AddAutoMapper(cfg => cfg.AddMaps(typeof(LancamentoProfile)))
    .AddScoped<ILancamentoService, LancamentoService>()
    .AddScoped<ILancamentoRepository, LancamentoRepository>()
    .AddDbContext<MinhaContaContext>(opt => {
        var provider = builder.Configuration.GetConnectionString("Provider");
        switch(provider) {
            case "postgres": 
                opt.UseNpgsql(builder.Configuration.GetConnectionString("Database"));
                break;
            default: 
                opt.UseInMemoryDatabase("DataBase");
                break;
        }
    }); 

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
