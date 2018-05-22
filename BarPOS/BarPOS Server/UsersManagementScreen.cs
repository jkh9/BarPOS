// Bar POS, class UserManagmentScreen

// Versiones: 
// V0.01 15-May-2018 Moisés: Basic skeleton
// V0.02 16-May-2018 Moisés: Event to close the form

using System;
using System.Drawing;
using System.Windows.Forms;

namespace BarPOS
{
    public partial class UsersManagmentScreen : Form
    {
        private UserManagementClass UserManagement;
        private bool DrawFounds;

        public UsersManagmentScreen(UsersList users)
        {
            UserManagement = new UserManagementClass(users);
            InitializeComponent();
            Draw();
        }

        //Method to draw the actual product
        public void Draw()
        {
            if (UserManagement.Count < 1)
            {
                Controls.Clear();
                InitializeComponent();
                lblUserCode.Text = "000";
            }
            else
            {
                User actualUser =
                    UserManagement.GetActualProduct();

                if (DrawFounds && actualUser.Found || !DrawFounds)
                {
                    lblUserCode.Text = actualUser.Code.ToString("000");
                    pbImage.ImageLocation = actualUser.ImagePath;
                    txtName.Text = actualUser.Name;
                }
                else
                {
                    UserManagement.MoveForward();
                    Draw();
                }
            }
        }

        //Event to close the window
        private void btnClose_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.InitializeComponent();
            this.lblUserCode.Text = (UserManagement.Count + 1).
                ToString("000");

            this.btnAdd.Visible = false;
            this.btnDelete.Visible = false;
            this.btnModify.Visible = false;
            this.btnSearch.Visible = false;
            this.btnValidate.Visible = true;
        }

        private void btnBackward_Click(object sender, EventArgs e)
        {
            UserManagement.MoveBackward();
            Draw();
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            UserManagement.MoveForward();
            Draw();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            UserManagement.Remove();
            Draw();
        }

        private void pbImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog getImage = new OpenFileDialog();
            getImage.InitialDirectory = "C:\\";
            getImage.Filter = "Archivos de Imagen (*.jpg)(*.jpeg)(*.png)| " +
                "*.jpg;*.jpeg;*.png; | All files(*.*) | *.* ";
            if (getImage.ShowDialog() == DialogResult.OK)
            {
                this.pbImage.ImageLocation = getImage.FileName;
            }
            else
            {
                MessageBox.Show("No se selecciono ninguna imagen");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchScreen searchScreen = new SearchScreen();
            searchScreen.StartPosition = FormStartPosition.CenterParent;
            searchScreen.ShowDialog();
            if (UserManagement.Search(searchScreen.TextToSearch))
            {
                DrawFounds = true;
                Draw();
                pnlTopBar.BackColor = Color.Gold;
                this.btnBack.Visible = true;
            }
            else
            {
                MessageBox.Show("No results found");
            }
        }

        private void btnBack_Click(object sender, System.EventArgs e)
        {
            this.btnBack.Visible = false;
            DrawFounds = false;
            pnlTopBar.BackColor = Color.Gainsboro;

            //restarting the found attribute
            for (int i = 1; i <= UserManagement.Count; i++)
            {
                UserManagement.Users.Get(i).Found = false;
            }
        }

        private void btnValidate_Click(object sender, EventArgs e)
        {
            try
            {
                User newUser = new User();
                newUser.ImagePath = pbImage.ImageLocation;
                newUser.Code = Convert.ToInt32(lblUserCode.Text);
                newUser.Name = txtName.Text;

                UserManagement.Add(newUser);

            }
            catch (Exception)
            {
                MessageBox.Show("Error guardando el producto");
            }

            this.Controls.Clear();
            InitializeComponent();
            Draw();
        }

        private void btnBackToMainMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            try
            {
                User newUser = new User();
                newUser.ImagePath = pbImage.ImageLocation;
                newUser.Code = Convert.ToInt32(lblUserCode.Text);
                newUser.Name = txtName.Text;

                UserManagement.Modify(newUser);
            }
            catch (Exception)
            {
                MessageBox.Show("Error guardando el usuario");
            }

            this.Controls.Clear();
            InitializeComponent();
            Draw();
        }
    }
}
