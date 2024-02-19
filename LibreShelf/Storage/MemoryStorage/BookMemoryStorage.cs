using LibreShelf.Interface;
using LibreShelf.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreShelf.Storage.MemoryStorage
{
    public class BookMemoryStorage : IStorage<Book>
    {
        public List<Book> books;

        public BookMemoryStorage()
        {
            books = new List<Book>() {
                new Book(1, "1984", "A dystopian novel by Orwell", new List<string>{"George Orwell"},
                "Secker & Warburg", DateOnly.FromDateTime(new DateTime(8,6,1949)), 328),

                new Book(2, "Brave New World", "Brave New World is a dystopian novel by English author Aldous Huxley.",
                new List<string>{"Aldous Huxley"}, "New Longman Literature", DateOnly.FromDateTime(new DateTime(2,3,1932)),
                311),

                new Book(3, "Fahrenheit 451", "Fahrenheit 451 is a dystopian novel by Ray Bradbury about a future society where books are banned and 'firemen' burn any that are found.",
                new List<string>{"Ray Bradbury"}, "Simon & Schuster", DateOnly.FromDateTime(new DateTime(1953, 10, 19)),
                249),
            };
        }

        List<Book> IStorage<Book>.GetAll()
        {
            return books;
        }

        void IStorage<Book>.SaveAll()
        {

        }
    }
}
