using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LLAH.DataLayer
{
    public interface IDataLayer<TEntity>
    {
        void Delete(int id);
        void Delete(TEntity entity);
        TEntity Find(int id, params string[] includes);
        List<TEntity> GetAll(int limit = 0, params string[] includes);
        void InsertOrUpdate(TEntity entity);
    }
}
