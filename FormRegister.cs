using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRAKTIKUM1_DESKTOP_XII_0094448607_ARFAL
{
    public partial class FormRegister : Form
    {
        public FormRegister()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormRegister_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormLogin pindahlog = new FormLogin();
            pindahlog.FormClosed += Pindah_FormClosed;
            pindahlog.Show();
            this.Hide();
        }

        private void Pindah_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // password tidak boleh kurang dari 6
            string user = textBox1.Text.Trim();
            string password = textBox2.Text.Trim();
            string konfirmasi = textBox3.Text.Trim();

            // password harus sama dengan konfirmasi password
            if (textBox2.Text != textBox3.Text)
            {
                MessageBox.Show("Konfirmasi kata sandi tidak cocok!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox3.Focus();
                return;
            }
            //password tidak boleh kurang dari 6
            if (password.Length > 6)
            {
                textBox1.Focus();
            }
            else
            {
                MessageBox.Show("Jangan");
            }

            // validasi  input: seluruhh field wajib terisi 
            if (string.IsNullOrWhiteSpace(textBox1.Text) ||
                string.IsNullOrWhiteSpace(textBox2.Text) ||
                string.IsNullOrWhiteSpace(textBox3.Text))
            {
                MessageBox.Show("seluruh field wajib terisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }
    }
}
