using LAHH.DataAccess;
using LLAH.Model.Base;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLAH.DataLayer
{
    public class DataLayerBase : IDisposable
    {
        internal LAHHDataContext MyDbContext { get; set; }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (MyDbContext != null)
                {
                    MyDbContext.Dispose();
                    MyDbContext = null;
                }
            }
        }

        ~DataLayerBase()
        {
            Dispose();
        }
    }

    public abstract class DataLayerBase<TEntity> : DataLayerBase, IDataLayer<TEntity> where  TEntity : BaseModel
    {
        public DataLayerBase(DataLayerBase managerThatWillShareContext = null)
        {
            MyDbContext = managerThatWillShareContext != null ? managerThatWillShareContext.MyDbContext : new LAHHDataContext();
        }

        private DbSet<TEntity> _dbSet;
        protected DbSet<TEntity> DbSet
        {
            get
            {
                if (_dbSet == null)
                    _dbSet = MyDbContext.Set<TEntity>();
                return _dbSet;
            }
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Delete(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public TEntity Find(int id, params string[] includes)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="limit">0 = All</param>
        /// <param name="includes"></param>
        /// <returns></returns>
        public List<TEntity> GetAll(int limit = 0, params string[] includes)
        {
            DbQuery<TEntity> query = DbSet;
            foreach (var currentIncludes in includes)
            {
                query = query.Include(currentIncludes);
            }

            if (limit > 0)
                return query.Take(limit).ToList();

            return query.ToList();
        }

        public TEntity GetFirst()
        {
            DbQuery<TEntity> query = DbSet;
            return query.First();
        }

        public void InsertOrUpdate(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
