using AppBloodWeb.Infrastructure.Context;
using AppBloodWeb.Application.Filters;
using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;
using AppBloodWeb.CrossCutting.IoCc;
using AppBloodWeb.Application.Interfaces;
using AppBloodWeb.Application.Services;




using AppBloodWeb.Infrastructure.Logging;


internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        //configura�oes de Logs e tratamentos de exepcoes de erros


        builder.Services.AddControllers(options =>
        {
            options.Filters.Add(typeof(ApiExceptionFilter));
        })
        .AddJsonOptions(options =>
        {
            options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
        });

        //configura��es de uso do filtros * Microsoft.Extensions.Logging * microsoft.aspnetcoreMvc;

        builder.Services.AddScoped<ApiLoggingFilter>();

        builder.Logging.AddProvider(new CustomLoggerProvider(new CustomLoggerProviderConfiguration
        {
            LogLevel = LogLevel.Information
        }));





        builder.Services.AddControllers();
        // chamos a class onde configuramos o Dbcontext
        builder.Services.AddInfrastructureAPI(builder.Configuration);


        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();


        //configuracao de servi;o de AutoMap
        builder.Services.AddAutoMapper(typeof(Program));
        // Registrar o AutoMapper com os perfis de mapeamento
        //builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

        


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
    }
}