using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreShelf.Model
{
    public class Shelf
    {
        public List<Book> Books { get; private set; }
        public Shelf(List<Book> books)
        {
            Books = books;
        }

        public void AddBook(Book book)
        {
            if(!ContainsBook(book))
                Books.Add(book);
        }

        public void AddBooks(List<Book> books)
        {
            foreach(Book book in books)
                AddBook(book);
        }


        public void RemoveBook(Book book)
        {
            if(ContainsBook(book)) 
                Books.Remove(book);
        }

        public void RemoveBooks(List<Book> books)
        {
            foreach(Book book in books)
                RemoveBook(book);
        }

        private bool ContainsBook(Book book)
        {
            bool sameByDetails = Books.Find(b => b.Title == book.Title && b.PublishedDate == book.PublishedDate) == null? false : true;
            bool sameByID = Books.Find(b => b.ID == book.ID) == null? false : true;
            return sameByDetails || sameByID;        
        }
    }
}
