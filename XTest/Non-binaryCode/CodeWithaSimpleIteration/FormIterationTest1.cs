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
using XTest.SystematicCode.HemingaCode;

namespace XTest.Non_binaryCode.CodeWithaSimpleIteration
{
    public partial class FormIterationTest1 : MetroForm
    {
        private string correctAnswer;
        private static int countPassedQuestion;
        private static int countCorrectAnswer;
        private static int maxCount = 10;

        private bool _isTest;
        private bool _codec;


        public FormIterationTest1(bool isTest, bool codec)
        {
            InitializeComponent();

            _isTest = isTest;
            _codec = codec;

            FillFormData();
            ChangeForm();

            if (Settings.Theme == MyTheme.Black)
                BlackTheme();
        }

        private void FillFormData()
        {
            Random r = new Random();
            IterationData data = new IterationData();
            KeyValuePair<string, string> item;
            if (_isTest)
            {
                int skipNumber = r.Next(0, 15);

                if (countPassedQuestion < maxCount / 2)
                    item = data.CodecData.Skip(skipNumber).First();
                else
                {
                    item = data.DeCodecData.Skip(skipNumber).First();
                    _codec = false;
                }
            }
            else
            {
                int skipNumber = r.Next(15, 25);

                if (_codec)
                    item = data.CodecData.Skip(skipNumber).First();
                else
                    item = data.DeCodecData.Skip(skipNumber).First();
            }

            taskLabel.Text = item.Key;
            correctAnswer = item.Value;
        }
        private void ChangeForm()
        {
            if (_codec == false)
            {
                titleLabel.Text = "Декодирование";
                taskLabelTitle.Text = "Декодируйте сообщение";
            }

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
                    FormIterationTest1 form = new FormIterationTest1(true, _codec);
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
                FormIterationTest1 form = new FormIterationTest1(false, _codec);
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
