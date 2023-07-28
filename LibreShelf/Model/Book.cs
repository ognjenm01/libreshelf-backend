using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static LibreShelf.Util.Enums;

namespace LibreShelf.Model
{
    public class Book
    {
        public int ID { get; set; }
        public string Title { get; set; } = null!;
        public string Description { get; set; }
        public List<string> Authors { get; set; } = null!;
        public string Publisher { get; set; } = null!;
        public DateTime PublishedDate { get; set; }
        public int PageCount { get; set; }
        public BookStatus Status { get; set; }
        public string LogoLink { get; set; } = null!;
        public string FilePath { get; set; } = null!;
        public Book(int id, string title, string description, List<string> authors, 
        string publisher, DateTime publishedDate, int pageCount, BookStatus status,
        string logoLink, string filePath)
        {
            ID = id;
            Title = title;
            Description = description;
            Authors = authors;
            Publisher = publisher;
            PublishedDate = publishedDate;
            PageCount = pageCount;
            Status = status;
            LogoLink = logoLink;
            FilePath = filePath;
        }

        //TODO Change logolink to point to a default cover
        public Book() : this(-1, "EmptyBook", "None", new List<string>(), 
        "None", DateTime.Now, -1, BookStatus.WAITING, "DefaultCoverLinkHere", "DefaultFilePathHere")
        {

        }

        public Book(Book book)
        {
            ID = book.ID;
            Title = book.Title;
            Description = book.Description;
            Authors = book.Authors;
            Publisher = book.Publisher;
            PublishedDate = book.PublishedDate;
            PageCount = book.PageCount;
            LogoLink = book.LogoLink;
            FilePath = book.FilePath;
        }
    }
}
