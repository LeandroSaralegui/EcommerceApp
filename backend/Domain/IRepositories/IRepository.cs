using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.IRepositories
{
    public interface IRepository<T> where T : class
    {
        public void Add(T obj);
        public List<T> FindAll();
        public T FindById(int id);
        public void Remove(int id);
        public void Update(T obj);
    }
}
