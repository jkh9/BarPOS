// Bar POS, class UsersList

// Versiones: 
// V0.01 14-May-2018 Moisés: Basic skeleton
// V0.02 15-May-2018 Moisés: Methods completeds
// V0.03 16-May-2018 Moisés: method Remove
// V0.04 18-May-2018 Moisés: Load and save methods changeds

using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace BarPOS
{
    public class UsersList
    {
        public const string PATH = @"..\..\..\Files\users.txt";
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
            Users = new List<User>();

            if (!(File.Exists(PATH)))
            {
                MessageBox.Show("Creating the users file");
            }
            else
            {
                try
                {
                    StreamReader input = new StreamReader(PATH);

                    string line = "";
                    do
                    {
                        line = input.ReadLine();
                        if (line != null)
                        {
                            string[] parts = line.Split('·');

                            User user = new User();

                            user.Name = parts[0];
                            user.Code = Convert.ToInt32(parts[1]);
                            user.ImagePath = parts[2];
                            this.Add(user);
                        }
                    } while (line != null);

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
                StreamWriter output = new StreamWriter(PATH);

                foreach (User user in Users)
                {
                    output.WriteLine(user);
                }

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
