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

namespace XTest.ElseCodeAndLabs.RekyrentCode
{
    public partial class FormRekyrentTest1 : MetroForm
    {
        private string correctAnswer;
        private static int countPassedQuestion;
        private static int countCorrectAnswer;
        private static int maxCount = 3;

        private bool _isTest;

        public FormRekyrentTest1(bool isTest)
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
            RecurrentData data = new RecurrentData();
            KeyValuePair<string, string> item;
            if (_isTest)
            {
                int skipNumber = r.Next(0, 15);
                item = data.CodecData.Skip(skipNumber).First();
            }
            else
            {
                int skipNumber = r.Next(15, data.CodecData.Count);
                item = data.CodecData.Skip(skipNumber).First();
            }
            string[] keys = item.Key.Split(',');


            label2.Text = keys[0];
            label5.Text = keys[1];
            correctAnswer = item.Value;
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
                    FormRekyrentTest1 form = new FormRekyrentTest1(true);
                    form.Show();
                    this.Close();
                }
                else
                {
                    FormRekyrentTest4 form = new FormRekyrentTest4(true, countCorrectAnswer);
                    form.Show();
                    countPassedQuestion = 0;
                    countCorrectAnswer = 0;
                    this.Close();
                }
            }
            else
            {
                FormRekyrentTest1 form = new FormRekyrentTest1(false);
                form.Show();
                this.Close();
            }
        }

        private void Check_Click(object sender, EventArgs e)
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
