using RSA_Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RSAMail_API.OutPutModel
{
  public class UsuarioOutPut : BaseDomain
	{
		public string NomeUsuario { get; set; }
		public string Email { get; set; }
		public string Sexo { get; set; }
		public string Rg { get; set; }
		public string Cpf { get; set; }
		public string Cnpj { get; set; }

	}
}
