using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace modul2_1302200119
{
    public partial class Form1 : Form
    {
        int angka1;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void label_hasil_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(label_hasil.Text == "label output")
            {
                label_hasil.Text = ""+1;
            }
            else
            {
                label_hasil.Text = label_hasil.Text + 1;
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (label_hasil.Text == "label output")
            {
                label_hasil.Text = "" + 2;
            }
            else
            {
                label_hasil.Text = label_hasil.Text + 2;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (label_hasil.Text == "label output")
            {
                label_hasil.Text = "" + 3;
            }
            else
            {
                label_hasil.Text = label_hasil.Text + 3;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (label_hasil.Text == "label output")
            {
                label_hasil.Text = "" + 4;
            }
            else
            {
                label_hasil.Text = label_hasil.Text + 4;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (label_hasil.Text == "label output")
            {
                label_hasil.Text = "" + 5;
            }
            else
            {
                label_hasil.Text = label_hasil.Text + 5;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (label_hasil.Text == "label output")
            {
                label_hasil.Text = "" + 6;
            }
            else
            {
                label_hasil.Text = label_hasil.Text + 6;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (label_hasil.Text == "label output")
            {
                label_hasil.Text = "" + 7;
            }
            else
            {
                label_hasil.Text = label_hasil.Text + 7;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (label_hasil.Text == "label output")
            {
                label_hasil.Text = "" + 8;
            }
            else
            {
                label_hasil.Text = label_hasil.Text + 8;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (label_hasil.Text == "label output")
            {
                label_hasil.Text = "" + 9;
            }
            else
            {
                label_hasil.Text = label_hasil.Text + 9;
            }
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (label_hasil.Text == "label output")
            {
                label_hasil.Text = "" + 0;
            }
            else
            {
                label_hasil.Text = label_hasil.Text + 0;
            }
        }

        private void button_tambah_Click(object sender, EventArgs e)
        {
            angka1 = Convert.ToInt32(label_hasil.Text);
            label_hasil.Text = label_hasil.Text+"+";
        }

        private void button_hasil_Click(object sender, EventArgs e)
        {
            int angka2, hasil;

            string angka2str = label_hasil.Text.Substring(label_hasil.Text.IndexOf("+"));

            angka2 = Convert.ToInt32(angka2str);
            hasil = angka1 + angka2;

            label_hasil.Text = ""+hasil;
        }
    }
}
