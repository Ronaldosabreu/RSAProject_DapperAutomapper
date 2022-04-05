using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using RSAMail_API.InputModels;
using RSA.Data;
using RSA_Domain.Usuario;
using AutoMapper;
using Dapper;
using Npgsql;
using RSAMail_API.OutPutModel;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RSAMail_API.Controllers.Usuario
{
  [Route("api/usuario/[controller]")]
  [ApiController]
  public class UsuarioController : ControllerBase
  {

    //static readonly IBaseRepository<UsuarioDomain> respository = new UsuarioRepository(" ");

    IMapper _mapper;
    IBaseRepository<UsuarioDomain> _repository;
    public UsuarioController(IMapper mapper, IBaseRepository<UsuarioDomain> repository)
    {
      _mapper = mapper;
      _repository = repository;
    }

    // GET: api/usuario/<UsuarioController>
    [HttpGet]
    public IEnumerable<UsuarioOutPut> Get()
    {
      List<UsuarioDomain> empDTO = _repository.BuscarTodos();

      List<UsuarioOutPut> usuarioOutPut = _mapper.Map<List<UsuarioOutPut>>(empDTO);

      return usuarioOutPut;
    }

    // GET api/usuario/<UsuarioController>/5
    [HttpGet("{id}")]
    public UsuarioOutPut Get(int id)
    {

      UsuarioDomain empDTO = _repository.Busca(id);

      UsuarioOutPut usuarioOutPut = _mapper.Map<UsuarioOutPut>(empDTO);

      return usuarioOutPut;

    }

    // POST api/usuario/<UsuarioController>
    [HttpPost]
    public UsuarioDomain Post([FromBody] UsuarioInputModel value)
    {

      UsuarioDomain empDTO = _mapper.Map<UsuarioDomain>(value);
      _repository.Cadastrar(empDTO);

      return empDTO;

    }

    // PUT api/usuario/<UsuarioController>/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] UsuarioInputModel value)
    {
    }

    // DELETE api/usuario/<UsuarioController>/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
    }
  }
}
