using System.Collections.Generic;
namespace senai.ifood.domain.Contracts
{
    public interface IBaseRepository<T> where T : class
    {
         IEnumerable<T> Listar(string [] includes = null);

         int Atualizar(T dados);

         int Inserir(T dados);

         int Deletar(T dados);

         T BuscarporId(int id, string [] includes = null);
         
    }
}