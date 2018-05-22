// Bar POS, class UserManagmentClass

// Versiones: 
// V0.01 22-May-2018 Moisés: Class implemented

namespace BarPOS
{
    public class UserManagementClass
    {
        public int Index { get; set; }
        public UsersList Users { get; set; }
        public int Count { get { return Users.Count; } }

        public UserManagementClass(UsersList users)
        {
            Users = users;
            Index = 1;
        }

        public User GetActualProduct()
        {
            return Users.Get(Index);
        }

        public void Add(User user)
        {
            Users.Add(user);
        }

        public void Remove()
        {
            if (Count > 0)
            {
                Users.Remove(Index);
            }
            MoveBackward();
        }

        public void Modify(User newUser)
        {
            Users.Reeplace(Index, newUser);
        }

        public bool Search(string text)
        {
            if (text != null)
            {
                text = text.ToLower();

                bool found = false;

                for (int i = 1; i <= Count; i++)
                {
                    User actualUser = Users.Get(i);

                    if (actualUser.ToString().ToLower().Contains(text))
                    {
                        actualUser.Found = true;
                        found = true;
                    }
                }
                return found;
            }
            return false;
        }

        public void MoveForward()
        {
            if (Index < Count)
            {
                Index++;
            }
            else
            {
                Index = 1;
            }
        }

        public void MoveBackward()
        {
            if (Index > 1)
            {
                Index--;
            }
            else
            {
                Index = Count;
            }
        }
    }
}

