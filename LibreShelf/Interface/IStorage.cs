using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreShelf.Interface
{
    public interface IStorage<T>
    {
        List<T> GetAll();
        void SaveAll();
    }
}
