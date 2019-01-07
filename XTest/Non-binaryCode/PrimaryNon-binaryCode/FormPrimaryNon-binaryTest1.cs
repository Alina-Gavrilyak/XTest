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
using XTest.CyclicCode.AbramsonaCode;

namespace XTest.Non_binaryCode.PrimaryNon_binaryCode
{
    public partial class FormPrimaryNon_binaryTest1 : MetroForm
    {

        private string correctAnswer;
        private static int countPassedQuestion;
        private static int countCorrectAnswer;
        private static int maxCount = 10;

        private bool _isTest;

        public FormPrimaryNon_binaryTest1(bool isTest)
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
            PrimaryNonBinaryData data = new PrimaryNonBinaryData();
            KeyValuePair<string, string> item;
            if (_isTest)
            {
                int skipNumber = r.Next(0, 15);
                item = data.CodecData.Skip(skipNumber).First();

            }
            else
            {
                int skipNumber = r.Next(15, 25);
                item = data.CodecData.Skip(skipNumber).First();
            }

            string[] keys = item.Key.Split(',');
            qLabel.Text = keys[0];
            nLabel.Text = keys[1];
            alphavitLabel.Text = keys[2];
            typeLabel.Text = keys[3];
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
                    FormPrimaryNon_binaryTest1 form = new FormPrimaryNon_binaryTest1(true);
                    form.Show();
                    this.Close();
                }
                else
                {
                    int mark = countCorrectAnswer * 5 / countPassedQuestion;
                    ResultForm form = new ResultForm(mark, this.Text, countCorrectAnswer, countPassedQuestion);
                    form.Show();
                    countPassedQuestion = 0;
                    countCorrectAnswer = 0;
                    this.Close();
                }
            }
            else
            {
                FormPrimaryNon_binaryTest1 form = new FormPrimaryNon_binaryTest1(false);
                form.Show();
                this.Close();
            }
        }

        private void ShowAnswer_Click(object sender, EventArgs e)
        {
            result.Text = correctAnswer;
        }
    }
}
