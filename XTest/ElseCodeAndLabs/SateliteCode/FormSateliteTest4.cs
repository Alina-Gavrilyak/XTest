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

namespace XTest.ElseCodeAndLabs.SateliteCode
{
    public partial class FormSateliteTest4 : MetroForm
    {

        private string correctAnswer;
        private static int countPassedQuestion = 5;
        private static int countCorrectAnswer;
        private static int maxCount = 10;
        private bool _isTest;


        public FormSateliteTest4(bool isTest, int correctAnswers = 0)
        {
            if (correctAnswers != 0)
                countCorrectAnswer = correctAnswers;

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
            SateliteData data = new SateliteData();
            KeyValuePair<string[], string> item;
            if (_isTest)
            {
                int skipNumber = r.Next(0, 3);
                item = data.DeCodecData.Skip(skipNumber).First();
            }
            else
            {
                int skipNumber = r.Next(3, 6);
                item = data.DeCodecData.Skip(skipNumber).First();
            }

            taskLabel.Text = item.Key.First();
            string[] keys = item.Key;
            label3.Text = keys[1];
            label4.Text = keys[2];
            label5.Text = keys[3];
            label6.Text = keys[4];
            label7.Text = keys[5];
            label8.Text = keys[6];
            label9.Text = keys[7];

            correctAnswer = item.Value;
        }
        private void ChangeForm()
        {
            if (_isTest)
            {
                btnCheck.Enabled = false;
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

        private void BtnNext_Click(object sender, EventArgs e)
        {
            if (_isTest)
            {
                countPassedQuestion++;

                if (result.Text == correctAnswer)
                {
                    countCorrectAnswer++;
                }

                if (maxCount > countPassedQuestion)
                {
                    FormSateliteTest4 form = new FormSateliteTest4(true);
                    form.Show();
                    this.Close();
                }
                else
                {
                    int mark = countCorrectAnswer * 5 / countPassedQuestion;
                    ResultForm form = new ResultForm(mark, Text, countCorrectAnswer, countPassedQuestion);
                    form.Show();
                    countPassedQuestion = 0;
                    countCorrectAnswer = 0;
                    this.Close();
                }
            }
            else
            {
                FormSateliteTest4 form = new FormSateliteTest4(false);
                form.Show();
                this.Close();
            }
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (result.Text == correctAnswer)
            {
                CheckingResultLabel.Text = "Правильно";
            }
            else
            {
                CheckingResultLabel.Text = "Не правильно";
            }
        }

        private void ShowAnswer_Click(object sender, EventArgs e)
        {
            result.Text = correctAnswer;
        }
    }
}
