using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kalkulator_desimal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            lbl_hasil.Text=" ";
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Angka 1 dan 2 harus di isi terlebih dahulu");
            }
            else
            {
                float a, b, c;
                a = float.Parse(this.textBox1.Text);
                b = float.Parse(this.textBox2.Text);
                c = a + b;
                this.lbl_hasil.Text = c.ToString();
            }
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            lbl_hasil.Text = " ";
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Angka 1 dan 2 harus di isi terlebih dahulu");
            }
            else
            {
                float a, b, c;
                a = float.Parse(this.textBox1.Text);
                b = float.Parse(this.textBox2.Text);
                c = a - b;
                this.lbl_hasil.Text = c.ToString();
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Angka 1 dan 2 harus di isi terlebih dahulu");
            }
            else
            {
                float a, b, c;
                a = float.Parse(this.textBox1.Text);
                b = float.Parse(this.textBox2.Text);
                c = a * b;
                this.lbl_hasil.Text = c.ToString();
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Angka 1 dan 2 harus di isi terlebih dahulu");
            }
            else
            {
                float a, b, c;
                a = float.Parse(this.textBox1.Text);
                b = float.Parse(this.textBox2.Text);
                c = a / b;
                this.lbl_hasil.Text = c.ToString();
            }
        }
    }
}
