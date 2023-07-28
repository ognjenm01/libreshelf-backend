using LibreShelf.Interface;
using LibreShelf.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreShelf.DAO
{
    public class BookDAO
    {
        private List<Book> _books;
        private IStorage<Book> _storage;

        public BookDAO(IStorage<Book> storage)
        {
            _storage = storage;
            //_books = _storage.GetAll();
        }
        public void Create(Book newBook)
        {
            _books.Add(newBook);
            //_storage.Save();
        }

        public Book? Get(int ID)
        {
            return _books.FirstOrDefault(book => book.ID == ID);
        }

        public List<Book> GetAll()
        {
            return _books;
        }
        public void Update(Book updatedBook)
        {
            Book? oldBook = Get(updatedBook.ID);
            if (oldBook != null)
            {
                oldBook = new Book(updatedBook);
                //_storage.Save();
            }
        }

        public void Delete(int ID)
        {
            if(Get(ID) != null)
            {
                _books.Remove(_books.First(book => book.ID == ID));
                //_storage.Save();
            }
        }
    }
}
