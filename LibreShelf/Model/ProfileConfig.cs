using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreShelf.Model
{
    public class ProfileConfig
    {

        public string ProfileName { get; set; }
        public string GoogleBooksAPI { get; set; }

        //ostali...

        public ProfileConfig(string profileName, string googleBooksAPI)
        {
            ProfileName = profileName;
            GoogleBooksAPI = googleBooksAPI;
        }

        public ProfileConfig() : this("EmptyProfileConfig","None")
        {

        }
    }
}
