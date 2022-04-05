using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using RSA.Data;
using RSA_Domain.Usuario;
using RSAMail_API.InputModels;
using RSAMail_API.Mapper;
using RSAMail_API.OutPutModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RSAMail_API
{
  public class Startup
  {
    public Startup(IConfiguration configuration)
    {
      Configuration = configuration;
    }

    public IConfiguration Configuration { get; }

    // This method gets called by the runtime. Use this method to add services to the container.
    public void ConfigureServices(IServiceCollection services)
    {

      services.AddControllers();
      services.AddSwaggerGen(c =>
      {
        c.SwaggerDoc("v1", new OpenApiInfo { Title = "RSAMail_API", Version = "v1" });
      });

      //Criando AutoMapper
      //Using automapper
      MapperObjects mapperObjct = new MapperObjects();
      var configurationMapper = mapperObjct.mapper();
      IMapper mapper = configurationMapper.CreateMapper();
      services.AddSingleton(mapper);

      //Injeção de dependencia 
      services.AddScoped(typeof(IBaseRepository<>), typeof(UsuarioRepository<>));

      //connection string
      services.AddSingleton(this.Configuration.GetConnectionString("MyConn"));
    }

    // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
      if (env.IsDevelopment())
      {
        app.UseDeveloperExceptionPage();
        app.UseSwagger();
        app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "RSAMail_API v1"));
      }

      app.UseHttpsRedirection();

      app.UseRouting();

      app.UseAuthorization();

      app.UseEndpoints(endpoints =>
      {
        endpoints.MapControllers();
      });
    }
  }
}
