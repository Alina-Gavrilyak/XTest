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

namespace XTest.Non_binaryCode.IterativityCode
{
    public partial class FormIterativityTest5 : MetroForm
    {
        private string correctAnswer;
        private static int countPassedQuestion = 4;
        private static int countCorrectAnswer;
        private static int maxCount = 8;

        private bool _isTest;

        public FormIterativityTest5(bool isTest, int correctAnswers = 0)
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
            IterativityData data = new IterativityData();
            KeyValuePair<string[], string[]> item;
            if (_isTest)
            {
                int skipNumber = r.Next(0, 4);
                item = data.DeCodecData.Skip(skipNumber).First();
            }
            else
            {
                int skipNumber = r.Next(4, 7);
                item = data.DeCodecData.Skip(skipNumber).First();
            }


            string[] keys = item.Key;
            matrixLabel1.Text = keys[0];
            matrixTextBox1.Text = keys[1];
            matrixTextBox2.Text = keys[2];
            matrixTextBox3.Text = keys[3];
            matrixTextBox4.Text = keys[4];
            matrixTextBox5.Text = keys[5];
            matrixTextBox6.Text = keys[6];
            matrixTextBox7.Text = keys[7];
            matrixTextBox8.Text = keys[8];
            matrixTextBox9.Text = keys[9];
            matrixTextBox10.Text = keys[10];
            matrixTextBox11.Text = keys[11];
            matrixTextBox12.Text = keys[12];
            matrixTextBox13.Text = keys[13];
            matrixTextBox14.Text = keys[14];
            matrixTextBox15.Text = keys[15];
            matrixTextBox16.Text = keys[16];
            matrixTextBox17.Text = keys[17];
            matrixTextBox18.Text = keys[18];
            matrixTextBox19.Text = keys[19];
            matrixTextBox20.Text = keys[20];
            matrixTextBox21.Text = keys[21];
            matrixTextBox22.Text = keys[22];
            matrixTextBox23.Text = keys[23];
            matrixTextBox24.Text = keys[24];
            matrixTextBox25.Text = keys[25];
            matrixLabel2.Text = keys[26];
            matrixLabel3.Text = keys[27];
            matrixLabel4.Text = keys[28];
            matrixLabel5.Text = keys[29];
            matrixLabel6.Text = keys[30];
            matrixLabel7.Text = keys[31];
            matrixLabel8.Text = keys[32];
            matrixLabel9.Text = keys[33];
            matrixLabel10.Text = keys[34];

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

        private void BtnNext_Click(object sender, EventArgs e)
        {
            string result = matrixTextBox1.Text
                           + "," + matrixTextBox2.Text
                           + "," + matrixTextBox3.Text
                           + "," + matrixTextBox4.Text
                           + "," + matrixTextBox5.Text
                           + "," + matrixTextBox6.Text
                           + "," + matrixTextBox7.Text
                           + "," + matrixTextBox8.Text
                           + "," + matrixTextBox9.Text
                           + "," + matrixTextBox10.Text
                           + "," + matrixTextBox11.Text
                           + "," + matrixTextBox12.Text
                           + "," + matrixTextBox13.Text
                           + "," + matrixTextBox14.Text
                           + "," + matrixTextBox15.Text
                           + "," + matrixTextBox16.Text
                           + "," + matrixTextBox17.Text
                           + "," + matrixTextBox18.Text
                           + "," + matrixTextBox19.Text
                           + "," + matrixTextBox20.Text
                           + "," + matrixTextBox21.Text
                           + "," + matrixTextBox22.Text
                           + "," + matrixTextBox23.Text
                           + "," + matrixTextBox24.Text
                           + "," + matrixTextBox25.Text;
            if (_isTest)
            {
                countPassedQuestion++;

                if (result == correctAnswer)
                {
                    countCorrectAnswer++;
                }

                if (maxCount > countPassedQuestion)
                {
                    FormIterativityTest5 form = new FormIterativityTest5(true);
                    form.Show();
                    this.Close();
                }
                else
                {
                    int mark = countCorrectAnswer * 5 / countPassedQuestion;
                    ResultForm form = new ResultForm(mark, Text, countCorrectAnswer, countPassedQuestion);
                    form.Show();
                    countPassedQuestion = 4;
                    countCorrectAnswer = 0;
                    this.Close();
                }
            }
            else
            {
                FormIterativityTest5 form = new FormIterativityTest5(false);
                form.Show();
                this.Close();
            }
        }

        private void Check_Click(object sender, EventArgs e)
        {
            string result = matrixTextBox1.Text
                           + "," + matrixTextBox2.Text
                           + "," + matrixTextBox3.Text
                           + "," + matrixTextBox4.Text
                           + "," + matrixTextBox5.Text
                           + "," + matrixTextBox6.Text
                           + "," + matrixTextBox7.Text
                           + "," + matrixTextBox8.Text
                           + "," + matrixTextBox9.Text
                           + "," + matrixTextBox10.Text
                           + "," + matrixTextBox11.Text
                           + "," + matrixTextBox12.Text
                           + "," + matrixTextBox13.Text
                           + "," + matrixTextBox14.Text
                           + "," + matrixTextBox15.Text
                           + "," + matrixTextBox16.Text
                           + "," + matrixTextBox17.Text
                           + "," + matrixTextBox18.Text
                           + "," + matrixTextBox19.Text
                           + "," + matrixTextBox20.Text
                           + "," + matrixTextBox21.Text
                           + "," + matrixTextBox22.Text
                           + "," + matrixTextBox23.Text
                           + "," + matrixTextBox24.Text
                           + "," + matrixTextBox25.Text;
            if (result == correctAnswer)
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
            string result = matrixTextBox1.Text
                           + "," + matrixTextBox2.Text
                           + "," + matrixTextBox3.Text
                           + "," + matrixTextBox4.Text
                           + "," + matrixTextBox5.Text
                           + "," + matrixTextBox6.Text
                           + "," + matrixTextBox7.Text
                           + "," + matrixTextBox8.Text
                           + "," + matrixTextBox9.Text
                           + "," + matrixTextBox10.Text
                           + "," + matrixTextBox11.Text
                           + "," + matrixTextBox12.Text
                           + "," + matrixTextBox13.Text
                           + "," + matrixTextBox14.Text
                           + "," + matrixTextBox15.Text
                           + "," + matrixTextBox16.Text
                           + "," + matrixTextBox17.Text
                           + "," + matrixTextBox18.Text
                           + "," + matrixTextBox19.Text
                           + "," + matrixTextBox20.Text
                           + "," + matrixTextBox21.Text
                           + "," + matrixTextBox22.Text
                           + "," + matrixTextBox23.Text
                           + "," + matrixTextBox24.Text
                           + "," + matrixTextBox25.Text;

            string[] values = correctAnswer.Split(',');

            matrixTextBox1.Text = values[0];
            matrixTextBox2.Text = values[1];
            matrixTextBox3.Text = values[2];
            matrixTextBox4.Text = values[3];
            matrixTextBox5.Text = values[4];
            matrixTextBox6.Text = values[5];
            matrixTextBox7.Text = values[6];
            matrixTextBox8.Text = values[7];
            matrixTextBox9.Text = values[8];
            matrixTextBox10.Text = values[9];
            matrixTextBox11.Text = values[10];
            matrixTextBox12.Text = values[11];
            matrixTextBox13.Text = values[12];
            matrixTextBox14.Text = values[13];
            matrixTextBox15.Text = values[14];
            matrixTextBox16.Text = values[15];
            matrixTextBox17.Text = values[16];
            matrixTextBox18.Text = values[17];
            matrixTextBox19.Text = values[18];
            matrixTextBox20.Text = values[19];
            matrixTextBox21.Text = values[20];
            matrixTextBox22.Text = values[21];
            matrixTextBox23.Text = values[22];
            matrixTextBox24.Text = values[23];
            matrixTextBox25.Text = values[24];
        }
    }
}
