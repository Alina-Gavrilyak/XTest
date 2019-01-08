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

namespace XTest
{
    public partial class ResultForm : MetroForm
    {
        private string codeName;
        private int mark;
        private int correctAnswers;
        private int countQuestions;

        public ResultForm(int mark, string codeName, int correctAnswers, int countQuestions)
        {
            InitializeComponent();
            if (Settings.Theme == MyTheme.Black)
                BlackTheme();

            this.codeName = codeName;
            this.mark = mark;
            this.correctAnswers = correctAnswers;
            this.countQuestions = countQuestions;

            label3.Text = mark.ToString();
            label4.Text = codeName;
            label6.Text = correctAnswers + " из " + countQuestions;
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

        private void button1_Click(object sender, EventArgs e)
        {
            Report.AddReportRow(textBox1.Text,codeName,mark,correctAnswers,countQuestions);
            this.Close();
        }
    }
}
