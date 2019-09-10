using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Insyallah_buat_besok
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        MediaDataContext db = new MediaDataContext();
        private void txt_username_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            var UserLogin = from usr in db.Penggunas
                            where usr.Username == txt_username.Text && usr.Password == txt_password.Text
                            select usr;

            if (UserLogin.Count() == 1)
            {
                Form1 f1 = new Form1();
                f1.Show();
                this.Hide();
            }

            if (txt_username.Text == null && txt_password.Text != null)
            {
                MessageBox.Show("Username and password must be filled");
            }

            if (txt_username.Text != null && txt_password.Text == null)
            {
                MessageBox.Show("Username and password must be filled");
            }

            else
            {
                MessageBox.Show("Sorry, You don't have account");
            }

            if (txt_username.Text == "" && txt_password.Text == "")
            {
                MessageBox.Show("Fill the box !!!");
            }

        }

        private void txt_password_TextChanged(object sender, EventArgs e)
        {
            txt_password.PasswordChar = '*';
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
            this.Hide();
        }
    }
}
