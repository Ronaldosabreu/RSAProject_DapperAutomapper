using RSA_Domain.Usuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSA_Domain
{
  public class ContatoDomain: BaseDomain
  {
    
    public int UsuarioId { get; set; }
    public string Telefone { get; set; }
    public string Celular { get; set; }
    public string NomeContato { get; set; }
  }
}
