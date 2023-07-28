using LibreShelf.Interface;
using LibreShelf.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreShelf.DAO
{
    public class ProfileConfigDAO
    {
        private Dictionary<string, ProfileConfig> _configs;
        private IStorage<ProfileConfig> _storage;

        public ProfileConfigDAO(IStorage<ProfileConfig> storage)
        {
            _storage = storage;
            //_configs = storage.GetAll();
        }

        public void Create(ProfileConfig config)
        {
            if (Get(config.ProfileName) == null)
            {
                _configs.Add(config.ProfileName, config);
                //_storage.Save();
            }
        }

        public ProfileConfig? Get(string name)
        {
            try
            {
                return _configs[name];
            }
            catch (KeyNotFoundException)
            {
                return null;
            }
        }

        public List<ProfileConfig> GetAll()
        {
            return _configs.Values.ToList();
        }

        public void Update(ProfileConfig updatedConfig)
        {
            ProfileConfig? oldConfig = Get(updatedConfig.ProfileName);
            if (oldConfig != null)
            {
                oldConfig.GoogleBooksAPI = updatedConfig.GoogleBooksAPI;
                //_storage.Save();
            }
        }

        public void Delete(string name)
        {
            ProfileConfig? deletedConfig = Get(name);
            if (deletedConfig!= null)
            {
                _configs.Remove(deletedConfig.ProfileName);
                //_storage.Save();
            }
        }
    }
}
