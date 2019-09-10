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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        MediaDataContext db = new MediaDataContext();
        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void btn_signup_Click(object sender, EventArgs e)
        {
            Pengguna addakun = new Pengguna();
            addakun.NamaPengguna = txt_register_nama.Text;
            addakun.Username = txt_register_username.Text;
            addakun.Password = txt_register_password.Text;
            var akun = from akn in db.Penggunas
                       where txt_register_nama.Text == addakun.NamaPengguna && txt_register_username.Text == addakun.Username && txt_register_password.Text == addakun.Password
                       select addakun;

            db.Penggunas.InsertOnSubmit(addakun);
            db.SubmitChanges();

            MessageBox.Show("We accept your data :)");
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void txt_register_password_TextChanged(object sender, EventArgs e)
        {
            txt_register_password.PasswordChar = '*';
        }
    }
}
