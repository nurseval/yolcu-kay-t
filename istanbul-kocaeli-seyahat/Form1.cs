using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace istanbul_kocaeli_seyahat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Yönetici" && textBox2.Text == "369")
            {
                Form3 seyahat = new Form3();
                seyahat.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Yanlış Giriş yaptınız! Tekrardan Deneyiniz! :)");
                textBox1.Clear();
                textBox2.Clear();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 seyahat = new Form3();
            seyahat.Show();
            this.Hide();
        }
    }
}
