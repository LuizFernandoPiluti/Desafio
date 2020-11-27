using Desafio.Dominio.Interfaces;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;

namespace Desafio.Aplicacao
{
    public class ServicoAplicacaoDados<TObject> : IServicoAplicacaoDados<TObject> where TObject : class
    {
        protected readonly IRepositorioBase<TObject> _repositorioBase;
        public void Alterar(TObject obj)
        {
            try
            {
                _repositorioBase.Alterar(obj);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);

            }
        }

        public void Inserir(TObject obj)
        {
            try
            {
                _repositorioBase.Inserir(obj);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

        }

        public TObject RecuperarporId(int id)
        {
            try
            {
                return _repositorioBase.RecuperarporId(id);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public IList<TObject> RecuperarTodos()
        {
            try
            {
                return _repositorioBase.RecuperarTodos();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public void Remover(TObject obj)
        {
            try
            {
                _repositorioBase.Remover(obj);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public void Remover(int id)
        {
            try
            {
                _repositorioBase.Remover(id);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
}
