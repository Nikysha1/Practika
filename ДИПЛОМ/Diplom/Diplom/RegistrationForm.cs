using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diplom
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string newUsername = txtNewUsername.Text;
            string newPassword = txtNewPassword.Text;

           

            if (!UserRepository.IsUsernameTaken(newUsername))
            {
                UserRepository.InsertUser(newUsername, newPassword);
                MessageBox.Show($"Учетная запись {newUsername} зарегистрирована успешно!");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Этот логин уже занят. Выберите другой.");
            }

            
        }
        
    }
}
