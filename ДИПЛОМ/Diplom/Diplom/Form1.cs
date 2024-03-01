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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Покажем форму авторизации при загрузке главной формы.
            using (LoginForm loginForm = new LoginForm())
            {
                if (loginForm.ShowDialog() != DialogResult.OK)
                {
                    // Если пользователь не прошел авторизацию, закрываем приложение.
                    this.Close();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ScrollingTextForm Form1 = new ScrollingTextForm();
            Form1.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            QuizForm Form1 = new QuizForm();
            Form1.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
          
            DiagramForm Form1 = new DiagramForm();
            Form1.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            ScrollingTextForm2 Form1 = new ScrollingTextForm2();
            Form1.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            RabotaForm Form1 = new RabotaForm();
            Form1.ShowDialog();
        }
    }
}
