using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.interfaces
{
    public interface IRepository<T>
    {
        void Add(T t);
        List<T> GetAll();
    }
}
