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
    public partial class FormDDCTest1 : Form
    {
        public FormDDCTest1()
        {
            InitializeComponent();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0000001011101001")
                labelResult.Text = "Правильно!";
            else labelResult.Text = "Не верно";
        }
    }
}
