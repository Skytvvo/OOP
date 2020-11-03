using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop4
{
    public interface GenerInter<U>
    {
        void Add(U item);
        void Delete(U item);
        void View();
    }
}
