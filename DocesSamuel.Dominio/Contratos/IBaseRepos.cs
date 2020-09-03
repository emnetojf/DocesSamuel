using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Text;

namespace DocesSamuel.Dominio.Contratos
{
    public interface IBaseRepos<TEntity> : IDisposable where TEntity : class 
    {
        void Create(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
        TEntity ListById(int id);
        IEnumerable<TEntity> ListAll();
    }
}
