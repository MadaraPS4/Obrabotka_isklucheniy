using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorageApp
{
    public interface IRepository<T> where T:Entity
    {
        void Add(T entity);

        void Delete(T entity);

        void Update(T entity);

        IList<T> GetAll();

        T Get(Guid id);

  
    }
}
