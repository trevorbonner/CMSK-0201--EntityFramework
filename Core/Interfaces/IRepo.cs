using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IRepo<T>
    {
        public List<T> GetAll();
        public void Create(T newItem);
        public T Read(int id);
        public void Update(T item);
        public void Delete(int id);
    }
}
