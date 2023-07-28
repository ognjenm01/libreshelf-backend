using LibreShelf.Interface;
using LibreShelf.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreShelf.DAO
{
    public class ProfileDAO
    {
        private Dictionary<string, Profile> _profiles;
        private IStorage<Profile> _storage;

        public ProfileDAO(IStorage<Profile> storage)
        {
            _storage = storage;
            //_profiles = storage.GetAll();
        }

        public void Create(Profile profile)
        {
            if (Get(profile.Name) == null)
            {
                _profiles.Add(profile.Name, profile);
                //_storage.Save();
            }
        }

        public Profile? Get(string name)
        {
            try
            {
                return _profiles[name];
            }
            catch(KeyNotFoundException)
            {
                return null;
            }
        }

        public List<Profile> GetAll()
        {
            return _profiles.Values.ToList();
        }

        public void Update(Profile updatedProfile) 
        { 
            Profile? oldProfile = Get(updatedProfile.Name);
            if(oldProfile != null)
            {
                oldProfile.Books = updatedProfile.Books;
                oldProfile.BookDirectory = updatedProfile.BookDirectory;
                oldProfile.Config = updatedProfile.Config;
                //_storage.Save();
            }
        }

        public void Delete(string name)
        {
            Profile? deletedProfile = Get(name);
            if(deletedProfile != null)
            {
                _profiles.Remove(deletedProfile.Name);
                //_storage.Save();
            }
        }
    }
}
