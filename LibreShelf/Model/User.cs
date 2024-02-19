using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace LibreShelf.Model
{
    public enum Role {USER, MODERATOR, ADMIN}
    public class User
    {
        public string Username { get;  private set; }
        public string Password { get; private set; }
        public string Email { get; private set; }
        public Blob Picture { get; private set; }
        public Role Role { get; private set; }
        public Shelf Shelf { get; private set; }

        public User(string username, string password, string email, Blob picture, Role role, Shelf shelf)
        {
            Username = username;
            Password = password;
            Email = email;
            Picture = picture;
            Role = role;
            Shelf = shelf;
        }
    }
}
