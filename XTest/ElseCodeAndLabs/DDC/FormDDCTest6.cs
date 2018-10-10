using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XTest
{
    public partial class FormDDCTest6 : Form
    {
        public FormDDCTest6()
        {
            InitializeComponent();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "8256")
                labelResult.Text = "Правильно!";
            else labelResult.Text = "Не верно";
        }
    }
}
