using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreShelf.Model
{
    public class Profile
    {
        public string Name { get;  set; }
        public List<Book> Books { get; set; }
        public string BookDirectory { get; set; }
        public ProfileConfig Config { get; set; }

        public Profile(string name, List<Book> books, string bookDirectory,
        ProfileConfig config)
        {
            Name = name;
            Books = books;
            BookDirectory = bookDirectory;
            Config = config;
        }

        public Profile() : this("EmptyProfile", new List<Book>(), 
        "DefaultBookDirectoryHere", new ProfileConfig())
        {

        }
    }
}
