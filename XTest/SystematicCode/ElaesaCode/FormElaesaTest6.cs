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
    public partial class FormElaesaTest6 : MetroForm
    {
        public FormElaesaTest6()
        {
            InitializeComponent();
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
        private void button2_Click(object sender, EventArgs e)
        {
            int v1 = Convert.ToInt32(textBox1.Text) + Convert.ToInt32(textBox2.Text) +
               Convert.ToInt32(textBox3.Text) + Convert.ToInt32(textBox4.Text) +
               Convert.ToInt32(textBox5.Text);
            int v2 = Convert.ToInt32(textBox6.Text) + Convert.ToInt32(textBox7.Text) +
                Convert.ToInt32(textBox8.Text) + Convert.ToInt32(textBox9.Text) +
                Convert.ToInt32(textBox10.Text);
            int v3 = Convert.ToInt32(textBox16.Text) + Convert.ToInt32(textBox17.Text) +
                Convert.ToInt32(textBox18.Text) + Convert.ToInt32(textBox19.Text) +
                Convert.ToInt32(textBox20.Text);
            int v4 = Convert.ToInt32(textBox11.Text) + Convert.ToInt32(textBox12.Text) +
                Convert.ToInt32(textBox13.Text) + Convert.ToInt32(textBox14.Text) +
                Convert.ToInt32(textBox15.Text);
            int v5 = Convert.ToInt32(textBox21.Text) + Convert.ToInt32(textBox22.Text) +
                Convert.ToInt32(textBox23.Text) + Convert.ToInt32(textBox24.Text) +
                Convert.ToInt32(textBox25.Text);

            int w1 = Convert.ToInt32(textBox1.Text) + Convert.ToInt32(textBox6.Text) +
                Convert.ToInt32(textBox20.Text) + Convert.ToInt32(textBox15.Text) +
                Convert.ToInt32(textBox25.Text);
            int w2 = Convert.ToInt32(textBox2.Text) + Convert.ToInt32(textBox7.Text) +
                Convert.ToInt32(textBox19.Text) + Convert.ToInt32(textBox14.Text) +
                Convert.ToInt32(textBox24.Text);
            int w3 = Convert.ToInt32(textBox3.Text) + Convert.ToInt32(textBox8.Text) +
                Convert.ToInt32(textBox18.Text) + Convert.ToInt32(textBox13.Text) +
                Convert.ToInt32(textBox23.Text);
            int w4 = Convert.ToInt32(textBox4.Text) + Convert.ToInt32(textBox9.Text) +
                Convert.ToInt32(textBox17.Text) + Convert.ToInt32(textBox12.Text) +
                Convert.ToInt32(textBox22.Text);
            int w5 = Convert.ToInt32(textBox5.Text) + Convert.ToInt32(textBox10.Text) +
                Convert.ToInt32(textBox16.Text) + Convert.ToInt32(textBox11.Text) +
                Convert.ToInt32(textBox21.Text);

            if (v1 % 2 == 0 && v2 % 2 == 0 && v3 % 2 == 1 && v4 % 2 == 1 && v5 % 2 == 0 &&
                w1 % 2 == 0 && w2 % 2 == 0 && w3 % 2 == 1 && w4 % 2 == 0 && w5 % 2 == 1) { label4.Text = "Правильно!"; button1.Enabled = true; }
            else { label4.Text = "Не верно"; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }
    }
}
