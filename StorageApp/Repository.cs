using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorageApp
{
    class Repository<T> : IRepository<T> where T:Entity
    {
        public void Add(T entity)
        {
            Storage.DoWork();
        }

        public void Delete(T entity)
        {
            Storage.DoWork();
        }

        public T Get(Guid id)
        {
            throw new NotImplementedException();
        }

        public IList<T> GetAll()
        {
            
        }

        public void Update(T entity)
        {
            Storage.DoWork();
        }
    }
}
