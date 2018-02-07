using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSample.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        public void Add(T entity)
        {
            // add to database
        }

        public void Delete(T entity)
        {
            // delete from database
        }

        public IEnumerable<T> GetAll()
        {
            // get from database
            throw new NotImplementedException();
        }

        public T GetById(int id)
        {
            // get from database
            throw new NotImplementedException();
        }

        public void Update(T entity)
        {
            // update in database
            throw new NotImplementedException();
        }
    }
}
