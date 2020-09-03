using DocesSamuel.Dominio.Contratos;
using DocesSamuel.Repositorio.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DocesSamuel.Repositorio.Repositorio
{
    public class BaseRepositorio<TEntity> : IBaseRepos<TEntity> where TEntity : class
    {
        protected readonly DocesSamuelContext _docesSamuelContext;

        public BaseRepositorio(DocesSamuelContext docesSamuelContext)
        {
            _docesSamuelContext = docesSamuelContext;
        }


        public void Create(TEntity entity)
        {
            _docesSamuelContext.Set<TEntity>().Add(entity);
            _docesSamuelContext.SaveChanges();
        }

        public void Update(TEntity entity)
        {
            _docesSamuelContext.Set<TEntity>().Update(entity);
            _docesSamuelContext.SaveChanges();
        }

        public void Delete(TEntity entity)
        {
            _docesSamuelContext.Set<TEntity>().Remove(entity);
            _docesSamuelContext.SaveChanges();
        }

        public TEntity ListById(int id)
        {
            return _docesSamuelContext.Set<TEntity>().Find(id);
        }

        public IEnumerable<TEntity> ListAll()
        {
            return _docesSamuelContext.Set<TEntity>().ToList();
        }

        public void Dispose()
        {
            _docesSamuelContext.Dispose();
        }
    }
}
