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

namespace XTest.ElseCodeAndLabs.HaffmenaCode
{
    public partial class FormHaffmenaTest2 : MetroForm
    {
        private string correctAnswer;
        private static int countPassedQuestion = 2;
        private static int countCorrectAnswer;
        private static int maxCount = 4;

        private bool _isTest;

        public FormHaffmenaTest2(bool isTest, int correctAnswers = 0)
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
            HaffmenaData data = new HaffmenaData();
            KeyValuePair<string[], string[]> item;
            if (_isTest)
            {
                int skipNumber = r.Next(0, 2);
                item = data.DeCodecData.Skip(skipNumber).First();
            }
            else
            {
                int skipNumber = r.Next(2, 4);
                item = data.DeCodecData.Skip(skipNumber).First();
            }


            string[] keys = item.Key;
            matrixLabel1.Text = keys[0];
            matrixLabel2.Text = keys[1];
            matrixLabel3.Text = keys[2];
            matrixLabel4.Text = keys[3];
            matrixLabel5.Text = keys[4];
            matrixLabel6.Text = keys[5];
            matrixLabel7.Text = keys[6];
            matrixLabel8.Text = keys[7];
            matrixLabel9.Text = keys[8];
            matrixLabel10.Text = keys[9];
            matrixLabel11.Text = keys[10];
            matrixLabel12.Text = keys[11];
            matrixLabel13.Text = keys[12];
            matrixLabel14.Text = keys[13];
            matrixLabel15.Text = keys[14];
            matrixLabel16.Text = keys[15];
            matrixLabel17.Text = keys[16];
            matrixLabel18.Text = keys[17];
            matrixLabel19.Text = keys[18];
            matrixLabel20.Text = keys[19];
            matrixLabel21.Text = keys[20];
            matrixLabel22.Text = keys[21];
            matrixLabel23.Text = keys[22];
            matrixLabel24.Text = keys[23];
            matrixLabel25.Text = keys[24];
            matrixLabel26.Text = keys[25];
            matrixLabel27.Text = keys[26];
            matrixLabel28.Text = keys[27];
            matrixLabel29.Text = keys[28];
            matrixLabel30.Text = keys[29];
            matrixLabel31.Text = keys[30];
            matrixLabel32.Text = keys[31];
            matrixLabel33.Text = keys[32];
            matrixLabel34.Text = keys[33];
            matrixLabel35.Text = keys[34];
            matrixLabel36.Text = keys[35];
            matrixLabel37.Text = keys[36];
            matrixLabel38.Text = keys[37];
            matrixLabel39.Text = keys[38];
            matrixLabel40.Text = keys[39];
            matrixLabel41.Text = keys[40];
            matrixLabel42.Text = keys[41];
            matrixLabel43.Text = keys[42];
            matrixLabel44.Text = keys[43];
            matrixLabel45.Text = keys[44];
            matrixLabel46.Text = keys[45];
            matrixLabel47.Text = keys[46];
            matrixLabel48.Text = keys[47];
            matrixLabel49.Text = keys[48];
            matrixLabel50.Text = keys[49];
            matrixLabel51.Text = keys[50];
            matrixLabel52.Text = keys[51];
            matrixLabel53.Text = keys[52];
            matrixLabel54.Text = keys[53];
            matrixLabel55.Text = keys[54];

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

        private void Check_Click(object sender, EventArgs e)
        {
            string result = textBox1.Text
                           + "," + textBox2.Text
                           + "," + textBox3.Text
                           + "," + textBox4.Text
                           + "," + textBox5.Text
                           + "," + textBox6.Text
                           + "," + textBox7.Text
                           + "," + textBox8.Text
                           + "," + textBox9.Text
                           + "," + textBox10.Text;
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
            string result = textBox1.Text
                           + "," + textBox2.Text
                           + "," + textBox3.Text
                           + "," + textBox4.Text
                           + "," + textBox5.Text
                           + "," + textBox6.Text
                           + "," + textBox7.Text
                           + "," + textBox8.Text
                           + "," + textBox9.Text
                           + "," + textBox10.Text;

            string[] values = correctAnswer.Split(',');

            textBox1.Text = values[0];
            textBox2.Text = values[1];
            textBox3.Text = values[2];
            textBox4.Text = values[3];
            textBox5.Text = values[4];
            textBox6.Text = values[5];
            textBox7.Text = values[6];
            textBox8.Text = values[7];
            textBox9.Text = values[8];
            textBox10.Text = values[9];
           
        }


        private void BtnNext_Click(object sender, EventArgs e)
        {
            string result = textBox1.Text
                            + "," + textBox2.Text
                            + "," + textBox3.Text
                            + "," + textBox4.Text
                            + "," + textBox5.Text
                            + "," + textBox6.Text
                            + "," + textBox7.Text
                            + "," + textBox8.Text
                            + "," + textBox9.Text
                            + "," + textBox10.Text;
            if (_isTest)
            {
                countPassedQuestion++;

                if (result == correctAnswer)
                {
                    countCorrectAnswer++;
                }

                if (maxCount > countPassedQuestion)
                {
                    FormHaffmenaTest2 form = new FormHaffmenaTest2(true);
                    form.Show();
                    this.Close();
                }
                else
                {
                    int mark = countCorrectAnswer * 5 / countPassedQuestion;
                    ResultForm form = new ResultForm(mark, Text, countCorrectAnswer, countPassedQuestion);
                    form.Show();
                    countPassedQuestion = 2;
                    countCorrectAnswer = 0;
                    this.Close();
                }
            }
            else
            {
                FormHaffmenaTest2 form = new FormHaffmenaTest2(false);
                form.Show();
                this.Close();
            }
        }

        private void FormHaffmenaTest2_Load(object sender, EventArgs e)
        {

        }
    }
}
