using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public interface IService<T>
    {
        public T GetById(int id);
        public List<T> GetAll();
        public T Add(T entity);
        public T Update(T entity);
        public void Delete(int id);
    }
}
