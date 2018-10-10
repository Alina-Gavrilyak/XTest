using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XTest.SystematicCode.ElaesaCode
{
    public partial class FormElaesaTest1 : Form
    {

        public FormElaesaTest1()
        {
            InitializeComponent();
            button2.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox2.Text == "1" &&
                textBox3.Text == "1" && textBox4.Text == "0" &&
                textBox5.Text == "1" && textBox6.Text == "1" &&
                textBox7.Text == "0" && textBox8.Text == "0" &&
                textBox9.Text == "0" && textBox10.Text == "0") { label27.Text = "Правильно!"; button2.Enabled = true; }
            else label27.Text = "Не верно"; 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormElaesaTest2 fm1 = new FormElaesaTest2();
            fm1.Show();
            this.Close();
        }
    }
}
