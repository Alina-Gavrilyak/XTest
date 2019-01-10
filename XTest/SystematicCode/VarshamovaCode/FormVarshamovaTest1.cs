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

namespace XTest.SystematicCode.VarshamovaCode
{
    public partial class FormVarshamovaTest1 : MetroForm
    {

        private string correctAnswer;
        private static int countPassedQuestion;
        private static int countCorrectAnswer;
        private static int maxCount = 1;

        private bool _isTest;

        public FormVarshamovaTest1(bool isTest)
        {
            InitializeComponent();

            _isTest = isTest;

            FillFormData();
            ChangeForm();

            if (Settings.Theme == MyTheme.Black)
                BlackTheme();
        }

        private void FillFormData()
        {
            Random r = new Random();
            VarshamoveData data = new VarshamoveData();
            KeyValuePair<string[], string[]> item;
            if (_isTest)
            {
                item = data.Form1CodecData.First();
            }
            else
            {
                item = data.Form1CodecData.First();
            }

            string[] keys = item.Key;
            string[] values = item.Value;

            nLabel.Text = keys[0];
            dLabel.Text = keys[0];

            //textBox1.Text = values[0];
            //textBox2.Text = values[1];
            //textBox3.Text = values[2];
            //textBox4.Text = values[3];


            correctAnswer = string.Join(",", item.Value);

          
        }

        private void ChangeForm()
        {
            if (_isTest)
            {
                Check.Enabled = false;
                ShowAnswer.Enabled = false;
            }
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

        private void FormVarshamovaTest1_Load(object sender, EventArgs e)
        {

        }

        private void ShowAnswer_Click(object sender, EventArgs e)
        {
            string[] values = correctAnswer.Split(',');

            textBox1.Text = values[0];
            textBox2.Text = values[1];
            textBox3.Text = values[2];
            textBox4.Text = values[3];
        }

        private void Check_Click(object sender, EventArgs e)
        {
            string result = textBox1.Text
                          + "," + textBox2.Text
                          + "," + textBox3.Text
                          + "," + textBox4.Text;

            if (result == correctAnswer)
            {
                CheckingResultLabel.Text = "Правильно";
            }
            else
            {
                CheckingResultLabel.Text = "Не правильно";
            }
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            if (_isTest)
            {
                countPassedQuestion++;
                string result = textBox1.Text
                               + "," + textBox2.Text
                               + "," + textBox3.Text
                               + "," + textBox4.Text;

                if (result == correctAnswer)
                {
                    countCorrectAnswer++;
                }


                if (maxCount > countPassedQuestion)
                {
                    FormVarshamovaTest1 form = new FormVarshamovaTest1(true);
                    form.Show();
                    this.Close();
                }
                else
                {
                    FormVarshamovaTest2 form = new FormVarshamovaTest2(true, countCorrectAnswer);
                    form.Show();
                    countPassedQuestion = 0;
                    countCorrectAnswer = 0;
                    this.Close();
                }
            }
            else
            {
                FormVarshamovaTest2 form = new FormVarshamovaTest2(false, countCorrectAnswer);
                form.Show();
                this.Close();
            }
        }
           
    }
}
