using System;
using System.Collections.Generic;

namespace RSA_Domain.Usuario
{
  public class UsuarioDomain: BaseDomain
	{
	
		public string NomeUsuario { get; set; }
		public string Email { get; set; }
		public string Sexo { get; set; }
		public string Rg { get; set; }
		public string Cpf { get; set; }
		public string Cnpj { get; set; }
		public string SituacaoCadastro { get; set; }
		public DateTime DataCadastro { get; set; }
		public DateTime DataModificacao { get; set; }

		public ICollection<ContatoDomain> Contato { get; set; }

		public ICollection<EnderecoDomain> Endereco { get; set; }
	}
}
