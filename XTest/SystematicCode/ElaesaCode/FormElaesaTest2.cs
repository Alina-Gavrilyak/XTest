using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Components;
using MetroFramework.Forms;

namespace XTest.SystematicCode.ElaesaCode
{
    public partial class FormElaesaTest2 : MetroForm
    {
        public FormElaesaTest2()
        {
            InitializeComponent();
            button2.Enabled = false;
            if (Settings.Theme == MyTheme.Black)
                BlackTheme();
        }
        private void BlackTheme()
        {
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            foreach (Control c in this.Controls)
            {
                if (c.GetType() == typeof(Label))
                {
                    ((Label)c).BackColor = Color.Black;
                    ((Label)c).ForeColor = Color.White;
                }
                if (c.GetType() == typeof(Button))
                {
                    ((Button)c).BackColor = Color.FromArgb(34, 34, 34);
                    ((Button)c).ForeColor = Color.White;
                }
                if (c.GetType() == typeof(TextBox))
                {
                    ((TextBox)c).BackColor = Color.FromArgb(34, 34, 34);
                    ((TextBox)c).ForeColor = Color.White;
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox2.Text == "1" &&
                textBox3.Text == "1" && textBox4.Text == "0" &&
                textBox5.Text == "1" && textBox6.Text == "1" &&
                textBox7.Text == "0" && textBox8.Text == "0" &&
                textBox9.Text == "0" && textBox10.Text == "0") { label27.Text = "Правильно!"; button2.Enabled = true; }
            else label27.Text = "Не верно";
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            FormElaesaTest3 fm1 = new FormElaesaTest3();
            fm1.Show();
            this.Close();
        }
    }
}
