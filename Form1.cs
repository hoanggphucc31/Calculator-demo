using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        float data1, data2;
        string pheptinh;

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }      
        private void hienthi1_TextChanged(object sender, EventArgs e)
        {

        }
        private void button5_Click(object sender, EventArgs e)
        {
            pheptinh = "cong";          
            data1 = float.Parse(hienthi1.Text);
            hienthi2.Text = data1.ToString() + " + ";
            hienthi1.Clear();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            pheptinh = "tru";
            data1 = float.Parse(hienthi1.Text);
            hienthi2.Text = data1.ToString() + " - ";          
            hienthi1.Clear();
        }
        private void button13_Click(object sender, EventArgs e)
        {
            pheptinh = "nhan";
            data1 = float.Parse(hienthi1.Text);
            hienthi2.Text = data1.ToString() + " * ";         
            hienthi1.Clear();
        }
        private void button17_Click(object sender, EventArgs e)
        {
            pheptinh = "chia";
            data1 = float.Parse(hienthi1.Text);
            hienthi2.Text = data1.ToString() + " / ";          
            hienthi1.Clear();
        }
        private void button_Click(object sender, EventArgs e)
        {
            if(hienthi1.Text == "0")
            {
                hienthi1.Clear();
            }
            Button button = (Button)sender;
            hienthi1.Text = hienthi1.Text + button.Text;
        }
        private void ketqua_Click(object sender, EventArgs e)
        {
            if (pheptinh == "cong")
            {
                hienthi2.Text = data1.ToString() + " + " + float.Parse(hienthi1.Text);
                data2 = data1 + float.Parse(hienthi1.Text);             
                hienthi1.Text = data2.ToString();               
            }
            if (pheptinh == "tru")
            {
                hienthi2.Text = data1.ToString() + " - " + float.Parse(hienthi1.Text);
                data2 = data1 - float.Parse(hienthi1.Text);               
                hienthi1.Text = data2.ToString();

            }
            if (pheptinh == "nhan")
            {
                hienthi2.Text = data1.ToString() + " * " + float.Parse(hienthi1.Text);
                data2 = data1 * float.Parse(hienthi1.Text);              
                hienthi1.Text = data2.ToString();

            }
            if (pheptinh == "chia")
            {
                if (float.Parse(hienthi1.Text) == 0)
                {
                    hienthi2.Text = data1.ToString() + " / " + float.Parse(hienthi1.Text);
                    hienthi1.Text = "Loi phep tinh";
                }
                else
                {
                    hienthi2.Text = data1.ToString() + " / " + float.Parse(hienthi1.Text);
                    data2 = data1 / float.Parse(hienthi1.Text);                  
                    hienthi1.Text = data2.ToString();
                }
            }
            if (pheptinh == "²√x")
            {
                hienthi2.Text = " ²√ " + float.Parse(hienthi1.Text);
                data2 = float.Parse(hienthi1.Text);
                hienthi1.Text = Math.Sqrt(data2).ToString();
            }
            if (pheptinh == "x²")
            {
                hienthi2.Text = " x² " + float.Parse(hienthi1.Text);
                data2 = float.Parse(hienthi1.Text);
                hienthi1.Text = Math.Pow(data2,2).ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pheptinh = "²√x";
            data1 = float.Parse(hienthi1.Text);
            hienthi2.Text = " ²√ ";
            hienthi1.Clear();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            pheptinh = "x²";
            data1 = float.Parse(hienthi1.Text);
            hienthi2.Text = " x² ";
            hienthi1.Clear();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            hienthi1.Clear();
            hienthi2.Clear();
            hienthi1.Text = hienthi1.Text + "0";
        }
    }
}
