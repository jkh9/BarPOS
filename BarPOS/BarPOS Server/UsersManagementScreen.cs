﻿// Bar POS, class UserManagmentScreen

// Versiones: 
// V0.01 15-May-2018 Moisés: Basic skeleton
// V0.02 16-May-2018 Moisés: Event to close the form

using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace BarPOS
{
    public partial class UsersManagmentScreen : Form
    {
        private UserManagementClass UserManagement;
        private SearchScreen searchScreen;
        Languajes languaje;

        public UsersManagmentScreen(UsersList users, Languajes languaje)
        {
            UserManagement = new UserManagementClass(users);
            searchScreen = new SearchScreen(languaje);
            InitializeComponent();
            Draw();
            this.languaje = languaje;
            drawTexts();
        }

        private void drawTexts()
        {
            switch (languaje)
            {
                case Languajes.Castellano:
                    lblUser.Text = "Usuario";
                    btnBackToMainMenu.Text = "Volver al menu";
                    btnBack.Text = "Volver";
                    btnModify.Text = "Modificar";
                    btnDelete.Text = "Borrar";
                    btnAdd.Text = "Añadir";
                    btnValidate.Text = "Añadir";
                    btnSearch.Text = "Buscar";
                    lblPassword.Text = "Contraseña:";
                    lblCode.Text = "Código:";
                    lblName.Text = "Nombre:";
                    break;
                case Languajes.English:
                    lblUser.Text = "User";
                    btnBackToMainMenu.Text = "Back to main";
                    btnBack.Text = "Back";
                    btnModify.Text = "Modify";
                    btnDelete.Text = "Delete";
                    btnAdd.Text = "Add";
                    btnValidate.Text = "Add";
                    btnSearch.Text = "Search";
                    lblPassword.Text = "Password:";
                    lblCode.Text = "Code:";
                    lblName.Text = "Name:";
                    break;
            }
        }

        //Method to draw the actual product
        public void Draw()
        {
            if (UserManagement.Count < 1)
            {
                Controls.Clear();
                InitializeComponent();
                lblUserIndex.Text = "0/0";
            }
            else
            {
                User actualUser =
                    UserManagement.GetActualUser();

                lblUserIndex.Text =
                    UserManagement.Index + "/" + UserManagement.Count;

                txtCode.Text = actualUser.Code.ToString("000");
                pbImage.ImageLocation = actualUser.ImagePath;
                txtName.Text = actualUser.Name;
                txtPassword.Text = actualUser.Pass;
            }
            drawTexts();
        }

        public void Save()
        {
            string errorCode = UserManagement.Save();
            if (errorCode != "")
            {
                MessageBox.Show(errorCode);
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
            if (UserManagement.Count == 0)
            {
                this.txtCode.Text = "001";
            }
            else
            {
                this.txtCode.Text = (UserManagement.GetActualUser().Code + 1).
                ToString("000");
            }

            lblUserIndex.Text =
                    (UserManagement.Index+1) + "/" + UserManagement.Count;
            this.btnForward.Visible = false;
            this.btnBackward.Visible = false;
            this.btnAdd.Visible = false;
            this.btnDelete.Visible = false;
            this.btnModify.Visible = false;
            this.btnSearch.Visible = false;
            this.btnValidate.Visible = true;
        }

        private void btnBackward_Click(object sender, EventArgs e)
        {
            if (UserManagement.Count > 1 && !UserManagement.DrawFounds)
            {
                updateUser();
            }
            UserManagement.MoveBackward();
            Draw();
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            if (UserManagement.Count > 1 && !UserManagement.DrawFounds)
            {
                updateUser();
            }
            UserManagement.MoveForward();
            Draw();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            UserManagement.Remove();
            Save();
            Draw();
        }

        private void pbImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog getImage = new OpenFileDialog();
            getImage.InitialDirectory = Application.StartupPath + @"\imgs\";
            getImage.Filter = "Archivos de Imagen (*.jpg)(*.jpeg)(*.png)| " +
                "*.jpg;*.jpeg;*.png; | All files(*.*) | *.* ";
            if (getImage.ShowDialog() == DialogResult.OK)
            {
                string fileName = getImage.FileName.Substring(
                                        getImage.FileName.LastIndexOf('\\'));

                string sourceFile = getImage.FileName;
                string destFile = 
                    Application.StartupPath + @"\imgs\" + fileName;

                if (!File.Exists(destFile))
                {
                    File.Copy(sourceFile, destFile, true);
                }

                this.pbImage.ImageLocation = Application.StartupPath
                    + "\\imgs\\" + fileName;
            }
            else
            {
                MessageBox.Show("No se selecciono ninguna imagen");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            searchScreen.StartPosition = FormStartPosition.CenterParent;
            searchScreen.ShowDialog();
            if (UserManagement.Search(searchScreen.TextToSearch))
            {
                Draw();
                pnlTopBar.BackColor = Color.Gold;
                this.btnBack.Visible = true;
                this.btnAdd.Visible = false;
                this.btnModify.Visible = false;
            }
            else
            {
                MessageBox.Show("No results found");
            }
        }

        private void btnBack_Click(object sender, System.EventArgs e)
        {
            this.btnBack.Visible = false;
            this.btnAdd.Visible = true;
            this.btnModify.Visible = true;
            UserManagement.DrawFounds = false;
            pnlTopBar.BackColor = Color.Gainsboro;

            //restarting the found attribute
            for (int i = 1; i <= UserManagement.Count; i++)
            {
                UserManagement.Users.Get(i).Found = false;
            }
        }

        private void btnValidate_Click(object sender, EventArgs e)
        {
            addUser();
        }

        private void btnBackToMainMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addUser()
        {
            try
            {
                User newUser = new User();
                newUser.ImagePath = pbImage.ImageLocation;
                newUser.Code = Convert.ToInt32(txtCode.Text);
                newUser.Name = txtName.Text;
                newUser.Pass = txtPassword.Text;

                UserManagement.Add(newUser);

                Save();
            }
            catch (Exception)
            {
                MessageBox.Show("Error guardando el producto");
            }

            this.Controls.Clear();
            InitializeComponent();
            Draw();
        }

        private void updateUser()
        {
            try
            {
                User newUser = new User();
                newUser.ImagePath = pbImage.ImageLocation;
                newUser.Code = Convert.ToInt32(txtCode.Text);
                newUser.Name = txtName.Text;
                newUser.Pass = txtPassword.Text;

                UserManagement.Modify(newUser);

                Save();
            }
            catch (Exception)
            {
                MessageBox.Show("Error guardando el usuario");
            }

            Controls.Clear();
            InitializeComponent();
            Draw();
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            updateUser();
        }

        private void any_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (btnModify.Visible)
                {
                    updateUser();
                }
                else
                {
                    addUser();
                }
            }
        }
    }
}
