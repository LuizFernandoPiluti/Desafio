using Desafio.Dominio.Interfaces;
using Desafio.Infraestrutura.Dados.Contexto;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace Desafio.Infraestrutura.Dados
{
    public class RepositorioBase<TEntity> : IRepositorioBase<TEntity> where TEntity : class
    {
        protected readonly ContextoBaseDados _contexto;
        public RepositorioBase(ContextoBaseDados Contexto)
        {
            _contexto = Contexto;
        }

        public void Alterar(TEntity obj)
        {
            try
            {
                _contexto.Entry(obj).State = EntityState.Modified;
                _contexto.SaveChanges();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public void Inserir(TEntity obj)
        {
            try
            {
                _contexto.Set<TEntity>().Add(obj);
                _contexto.SaveChanges();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public TEntity RecuperarporId(int id)
        {
            try
            {
                return _contexto.Set<TEntity>().Find(id);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public System.Collections.Generic.IList<TEntity> RecuperarTodos()
        {
            try
            {
                return _contexto.Set<TEntity>().ToList();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public void Remover(TEntity obj)
        {
            try
            {
                _contexto.Set<TEntity>().Remove(obj);
                _contexto.SaveChanges();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public void Remover(int id)
        {
            TEntity obj = RecuperarporId(id);
            Remover(obj);
        }
    }
}
