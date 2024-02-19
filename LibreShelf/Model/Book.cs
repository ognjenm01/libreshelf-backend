using System;
using System.Collections.Generic;

namespace LibreShelf.Model
{
    public enum BookStatus { NOT_STARTED, READING, FINISHED }
    public class Book
    {
        public int ID { get; set; }
        public string Title { get; set; } = null!;
        public string Description { get; set; }
        public List<string> Authors { get; set; } = null!;
        public string Publisher { get; set; } = null!;
        public DateOnly PublishedDate { get; set; }
        public int PageCount { get; set; }

        public Book(int id, string title, string description, List<string> authors, 
        string publisher, DateOnly publishedDate, int pageCount)
        {
            ID = id;
            Title = title;
            Description = description;
            Authors = authors;
            Publisher = publisher;
            PublishedDate = publishedDate;
            PageCount = pageCount;
        }

        public Book() : this(-1, "EmptyBook", "None", new List<string>(), 
        "None", DateOnly.FromDateTime(DateTime.Now), -1)
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
        }
    }
}
