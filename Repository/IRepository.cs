using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laborator1.Repository
{
    internal interface IRepository<T>
    {
        void Add(T o);
        void Update( T o2);
        void Delete(int id);
        IEnumerable<T> GetAll();
        T FindById(int id);
    }
}
