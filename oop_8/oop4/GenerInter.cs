using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop4
{
    public interface GenerInter<T>
    {
        void Add(T item);
        void Delete(T item);
        void View();
    }
}
