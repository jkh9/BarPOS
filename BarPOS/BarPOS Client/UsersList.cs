// Bar POS, class UsersList

// Versiones: 
// V0.01 14-May-2018 Moisés: Basic skeleton

using System.Collections.Generic;

namespace BarPOS
{
    public class UsersList
    {
        List<User> Users;
        public int Index { get; set; }

        public void Add(User userToAdd)
        {
            Users.Add(userToAdd);
        }

        public User Get(int userIndex)
        {
            return Users[userIndex - 1];
        }

        public void Load()
        {
            //TO DO
        }

        public void Save()
        {
            //TO DO
        }
    }
}
