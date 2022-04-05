using System.Collections.Generic;

namespace RSA.Data
{
  public interface IBaseRepository<T>
	{
		//crud
		T Busca(int id);

		List<T> BuscarTodos();

		T Cadastrar(T entidade);

		T Altualizar(T entidade);

		void Exluir(int id);


	}
}
