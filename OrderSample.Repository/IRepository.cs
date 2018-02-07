using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderSample.Models;

namespace OrderSample.Repository
{
    public interface IRepository<T> where T : class
    {
        void Add(T entity); // Service is a class defined somewhere
        void Delete(T entity);
        void Update(T entity);
        IEnumerable<T> GetAll();
        T GetById(int id);
    }
}
