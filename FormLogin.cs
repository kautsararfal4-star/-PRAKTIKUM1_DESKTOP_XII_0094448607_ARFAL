using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PRAKTIKUM1_DESKTOP_XII_0094448607_ARFAL
{
    public partial class FormLogin : Form
    {
        string konfigurasi = "server=localhost;username=root;database=db_apotek_petugas;port=8803;password=;";
        public FormLogin()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormRegister pindahlog = new FormRegister();
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
           string username = textBox1.Text.Trim();
           string password = textBox2.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Username dan password wajib di isi", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void pindahdash_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
    }
}
