using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio.Dominio.Interfaces
{
    public interface IServicoAplicacaoDados<TObject> where TObject: class
    {
        IList<TObject> RecuperarTodos();
        TObject RecuperarporId(int id);
        void Inserir(TObject obj);
        void Alterar(TObject obj);
        void Remover(TObject obj);
        void Remover(int id);
    }
}
