using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCore.Interfaces
{
    public interface IService<T>
    {
        void Add(T t);
        List<T> GetAll();
    }
}
