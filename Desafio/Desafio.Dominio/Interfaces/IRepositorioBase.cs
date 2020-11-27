using System.Collections.Generic;

namespace Desafio.Dominio.Interfaces
{
   public interface IRepositorioBase<TEntidade> where TEntidade:class
    {
        IList<TEntidade> RecuperarTodos();
        TEntidade RecuperarporId(int id);
        void Inserir(TEntidade obj);
        void Alterar(TEntidade obj);
        void Remover(TEntidade obj);
        void Remover(int id);

    }
}