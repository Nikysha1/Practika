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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

         

            User user = UserRepository.GetUser(username, password);

            if (user != null)
            {
                MessageBox.Show("Успешная авторизация!");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Неверные логин или пароль.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (RegistrationForm registrationForm = new RegistrationForm())
            {
                if (registrationForm.ShowDialog() == DialogResult.OK)
                {
                    // Обработка успешной регистрации, если необходимо.
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
