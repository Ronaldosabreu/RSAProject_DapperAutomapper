using AutoMapper;
using RSA_Domain.Usuario;
using RSAMail_API.InputModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RSAMail_API.Mapper
{
  public class MapperObjects
  {



    public void mapper()
    {
      var configuration = new MapperConfiguration(cfg =>
      {
        cfg.CreateMap<UsuarioInputModel, UsuarioDomain>();
      });

      var mapper = configuration.CreateMapper();

    }

  }
}
