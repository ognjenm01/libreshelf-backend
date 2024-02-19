using LibreShelf.Interface;
using LibreShelf.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreShelf.Storage.MemoryStorage
{
    public class ShelfMemoryStorage : IStorage<Shelf>
    {
        public List<Shelf> shelves;
        public ShelfMemoryStorage() 
        {
            shelves = new List<Shelf>();
        }

        List<Shelf> IStorage<Shelf>.GetAll()
        {
            return shelves;
        }

        void IStorage<Shelf>.SaveAll()
        {
            
        }
    }
}
