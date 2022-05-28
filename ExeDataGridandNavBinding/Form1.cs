using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExeDataGridandNavBinding
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            {
                // Membuat Code Login dan Pindah Ke halaman Dashboard atau Halaman Selanjutnya 
                // Code Perulangan Username dan Password dan pembuatan message Box

                if (textBox1.Text.Equals("") || textBox2.Text.Equals(""))
                {
                    MessageBox.Show("Data Tidak Boleh Kosong", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (textBox1.Text.Equals("alfin") && textBox2.Text.Equals("123"))
                {
                    Form2 alfin = new Form2();
                    alfin.Show();
                }
                else
                {
                    MessageBox.Show("Periksa Kembali Username dan Password Anda !!!!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
