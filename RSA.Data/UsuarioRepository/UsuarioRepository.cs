using Npgsql;
using RSA_Domain;
using RSA_Domain.Usuario;
using System;
using System.Collections.Generic;
using System.Data;

namespace RSA.Data
{
  public class UsuarioRepository<UsuarioDomain> : IBaseRepository<UsuarioDomain>
  {

    private IDbConnection _db;

    public UsuarioRepository(string connectionString)
    {
      //this._db = new NpgsqlConnection(connectionString);
    }

    public UsuarioDomain Busca(int id)
    {
      throw new NotImplementedException();
    }

    public List<UsuarioDomain> BuscarTodos()
    {
      throw new NotImplementedException();
    }

    public UsuarioDomain Cadastrar(UsuarioDomain entidade)
    {
      throw new NotImplementedException();
    }
    public UsuarioDomain Altualizar(UsuarioDomain entidade)
    {
      throw new NotImplementedException();
    }
    public void Exluir(int id)
    {
      throw new NotImplementedException();
    }
  }
} 
