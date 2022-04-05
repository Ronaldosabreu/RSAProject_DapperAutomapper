using AutoMapper;
using RSA_Domain.Usuario;
using RSAMail_API.InputModels;
using RSAMail_API.OutPutModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RSAMail_API.Mapper
{
  public class MapperObjects
  {
    public MapperConfiguration mapper()
    {
      MapperConfiguration configuration = new MapperConfiguration(cfg =>
      {
        cfg.CreateMap<UsuarioInputModel, UsuarioDomain>();
        cfg.CreateMap<UsuarioDomain, UsuarioInputModel>();
        cfg.CreateMap<UsuarioOutPut, UsuarioDomain>();
        cfg.CreateMap<UsuarioDomain, UsuarioOutPut>();
      });
      return configuration;
    }

  }
}
