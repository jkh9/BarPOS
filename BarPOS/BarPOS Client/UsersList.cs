// Bar POS, class UsersList

// Versiones: 
// V0.01 14-May-2018 Moisés: Basic skeleton
// V0.02 15-May-2018 Moisés: Methods completeds
// V0.03 16-May-2018 Moisés: method Remove

using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace BarPOS
{
    public class UsersList
    {
        public const string PATH = @"..\..\..\Files1\users.dat";
        public List<User> Users { get; set; }
        public int Count { get { return Users.Count; } }
        
        public UsersList()
        {
            Load();
        }

        ~UsersList()
        {
            Save();
        }

        public void Add(User userToAdd)
        {
            Users.Add(userToAdd);
        }

        public void Remove(int index)
        {
            Users.RemoveAt(index - 1);
        }

        public User Get(int index)
        {
            return Users[index - 1];
        }

        public void Load()
        {
            if (!(File.Exists(PATH)))
            {
                MessageBox.Show("Creating the users file");
                Users = new List<User>();
            }
            else
            {
                try
                {
                    BinaryFormatter binaryFormatter = new BinaryFormatter();
                    FileStream input = new FileStream(PATH, FileMode.Open);

                    Users = (List<User>)binaryFormatter.Deserialize(input);

                    input.Close();
                }
                catch (Exception e)
                {
                    MessageBox.Show("Error loading the users file: "
                        + e.Message);
                }
            }
        }

        public void Save()
        {
            try
            {
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                FileStream output = new FileStream(PATH, FileMode.Create);

                binaryFormatter.Serialize(output, Users);

                output.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error saving the users file: "
                    + e.Message);
            }
        }
    }
}
