using Dapper;
using Npgsql;
using RSA_Domain;
using RSA_Domain.Usuario;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace RSA.Data
{
  public class UsuarioRepository<T> : IBaseRepository<UsuarioDomain>
  {

    private NpgsqlConnection _db;

    public UsuarioRepository(string connectionString)
    {
     _db = new NpgsqlConnection(connectionString);
    }

    public UsuarioDomain Busca(int id)
    {
      string sql = $@"SELECT * FROM USUARIO WHERE IDUSUARIO = @IDUSUARIO";
      
      UsuarioDomain user = _db.QuerySingle<UsuarioDomain>(sql, new { IDUSUARIO = id });

      return user;
    }

    public List<UsuarioDomain> BuscarTodos()
    {
      string sql = $@"SELECT * FROM USUARIO";

      List<UsuarioDomain> user = _db.Query<UsuarioDomain>(sql).ToList();

      return user;
    }

    public UsuarioDomain Cadastrar(UsuarioDomain entidade)
    {
      var trans = this._db.BeginTransaction();

      string sql = $@"INSERT INTO USUARIO (NOMEUSUARIO, 
                                          EMAIL, 
                                          SEXO, 
                                          RG, 
                                          CPF, 
                                          CNPJ, 
                                          SITUACAOCADASTRO, 
                                          DATACADASTRO) 
													VALUES (@NOMEUSUARIO, @EMAIL, @SEXO, @RG, @CPF, @CNPJ, @SITUACAOCADASTRO, '{DateTime.Now}' ) RETURNING IDUSUARIO ;";
      
      entidade.IdUsuario = _db.Query<int>(sql, entidade).Single();
      
      trans.Commit();

      return entidade;
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
