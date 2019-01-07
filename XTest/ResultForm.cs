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
    public partial class ResultForm : Form
    {
        public ResultForm(int mark, string codeName, int correctAnswers, int countQuestions)
        {
            InitializeComponent();

            label3.Text = mark.ToString();
            label4.Text = codeName;
            label6.Text = correctAnswers + " из " + countQuestions;
        }
    }
}
