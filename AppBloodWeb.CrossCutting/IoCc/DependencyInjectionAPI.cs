using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using AppBloodWeb.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

using System.Security;
using AppBloodWeb.Infrastructure.Repositories;
using AppBloodWeb.Domain.Interfaces;
using AutoMapper;
using AppBloodWeb.Application.Mapings;
using AppBloodWeb.Application.Interfaces;
using AppBloodWeb.Application.Services;
using AppBloodWeb.Application.DTOs;
using AppBloodWeb.Domain.Entities;

namespace AppBloodWeb.CrossCutting.IoCc
{
    public static class DependencyInjectionAPI
    {
        public static IServiceCollection AddInfrastructureAPI(this IServiceCollection services,
        IConfiguration configuration)
        {
            services.AddDbContext<AppDbContext>(options =>
               options.UseMySql(configuration.GetConnectionString("DefaultConnection"),
                     new MySqlServerVersion(new Version(8, 2, 0))));

             
           

             services.AddScoped<IpermissaoRepository, PermissaoRepository>();
             services.AddScoped<IpermissaoServices,  PermissaoServices>();

    
              
              services.AddScoped<IusuarioServices , UsuarioServices>();
              services.AddScoped<IusuarioRepository,UsuarioRepository>();
              
              services.AddScoped<ItriagemServices , TriagemServices>();
              services.AddScoped<ItriagemRepository ,TriagemRepository>();

              services.AddScoped<IdoadorServices , DoadorServices>();
              services.AddScoped<IdoadorRepository, DoadorRepository>();

            services.AddAutoMapper(typeof(ModeloDToMappingsProfile));
            // Registrar o AutoMapper com os perfis de mapeamento
         // services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

            return services;


           
        }
    }
}
