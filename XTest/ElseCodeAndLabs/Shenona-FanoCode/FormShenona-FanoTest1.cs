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

namespace XTest.ElseCodeAndLabs.Shenona_FanoCode
{
    public partial class FormShenona_FanoTest1 : MetroForm
    {
        private string correctAnswer;
        private static int countPassedQuestion;
        private static int countCorrectAnswer;
        private static int maxCount = 4;

        private bool _isTest;

        public FormShenona_FanoTest1(bool isTest)
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
            ShenonaFanoData data = new ShenonaFanoData();
            KeyValuePair<string[], string[]> item;
            if (_isTest)
            {
                int skipNumber = r.Next(0, 15);
                item = data.CoDecData.Skip(skipNumber).First();

            }
            else
            {
                int skipNumber = r.Next(15, 24);
                item = data.CoDecData.Skip(skipNumber).First();
            }

            for (int i=0; i < item.Key.Length; i++)
            {
                matrixGridView.Rows.Add("P" + i, item.Key[i], "");
            }

            correctAnswer = string.Join(",",item.Value);
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

        private void btnCheck_Click(object sender, EventArgs e)
        {
            string result = "";
            foreach (DataGridViewRow row in matrixGridView.Rows)
                result += row.Cells[2].Value.ToString() + ",";
            result = result.Remove(result.Length-1);

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

                string result = "";
                foreach (DataGridViewRow row in matrixGridView.Rows)
                    result += row.Cells[2].Value.ToString() + ",";
                result = result.Remove(result.Length - 1);

                if (result == correctAnswer)
                {
                    countCorrectAnswer++;
                }

                if (maxCount > countPassedQuestion)
                {
                    FormShenona_FanoTest1 form = new FormShenona_FanoTest1(true);
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
                FormShenona_FanoTest1 form = new FormShenona_FanoTest1(false);
                form.Show();
                this.Close();
            }
        }

        private void ShowAnswer_Click(object sender, EventArgs e)
        {
            string[] answers = correctAnswer.Split(',');
            for (int i = 0; i < answers.Length; i++)
                matrixGridView.Rows[i].Cells[2].Value = answers[i];
        }
    }
}
