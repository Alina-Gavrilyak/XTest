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
    public partial class FormHaffmenaTest1 : MetroForm
    {
        private string correctAnswer;
        private static int countPassedQuestion = 2;
        private static int countCorrectAnswer;
        private static int maxCount = 4;

        private bool _isTest;

        public FormHaffmenaTest1(bool isTest, int correctAnswers = 0)
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
                item = data.CodecData.Skip(skipNumber).First();
            }
            else
            {
                int skipNumber = r.Next(2, 4);
                item = data.CodecData.Skip(skipNumber).First();
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
            string result = matrixTextBox1.Text
                           + "," + matrixTextBox2.Text
                           + "," + matrixTextBox3.Text
                           + "," + matrixTextBox4.Text
                           + "," + matrixTextBox5.Text
                           + "," + matrixTextBox6.Text
                           + "," + matrixTextBox7.Text
                           + "," + matrixTextBox8.Text
                           + "," + matrixTextBox9.Text
                           + "," + matrixTextBox11.Text
                           + "," + matrixTextBox12.Text
                           + "," + matrixTextBox13.Text
                           + "," + matrixTextBox14.Text
                           + "," + matrixTextBox15.Text
                           + "," + matrixTextBox16.Text
                           + "," + matrixTextBox17.Text
                           + "," + matrixTextBox18.Text
                           + "," + matrixTextBox20.Text
                           + "," + matrixTextBox21.Text
                           + "," + matrixTextBox22.Text
                           + "," + matrixTextBox23.Text
                           + "," + matrixTextBox24.Text
                           + "," + matrixTextBox25.Text
                           + "," + matrixTextBox26.Text
                           + "," + matrixTextBox28.Text
                           + "," + matrixTextBox29.Text
                           + "," + matrixTextBox30.Text
                           + "," + matrixTextBox31.Text
                           + "," + matrixTextBox32.Text
                           + "," + matrixTextBox33.Text
                           + "," + matrixTextBox35.Text
                           + "," + matrixTextBox36.Text
                           + "," + matrixTextBox37.Text
                           + "," + matrixTextBox38.Text
                           + "," + matrixTextBox39.Text
                           + "," + matrixTextBox41.Text
                           + "," + matrixTextBox42.Text
                           + "," + matrixTextBox43.Text
                           + "," + matrixTextBox44.Text
                           + "," + matrixTextBox46.Text
                           + "," + matrixTextBox47.Text
                           + "," + matrixTextBox48.Text
                           + "," + matrixTextBox50.Text
                           + "," + matrixTextBox51.Text
                           + "," + matrixTextBox53.Text;
                           
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
                           + "," + matrixTextBox11.Text
                           + "," + matrixTextBox12.Text
                           + "," + matrixTextBox13.Text
                           + "," + matrixTextBox14.Text
                           + "," + matrixTextBox15.Text
                           + "," + matrixTextBox16.Text
                           + "," + matrixTextBox17.Text
                           + "," + matrixTextBox18.Text
                           + "," + matrixTextBox20.Text
                           + "," + matrixTextBox21.Text
                           + "," + matrixTextBox22.Text
                           + "," + matrixTextBox23.Text
                           + "," + matrixTextBox24.Text
                           + "," + matrixTextBox25.Text
                           + "," + matrixTextBox26.Text
                           + "," + matrixTextBox28.Text
                           + "," + matrixTextBox29.Text
                           + "," + matrixTextBox30.Text
                           + "," + matrixTextBox31.Text
                           + "," + matrixTextBox32.Text
                           + "," + matrixTextBox33.Text
                           + "," + matrixTextBox35.Text
                           + "," + matrixTextBox36.Text
                           + "," + matrixTextBox37.Text
                           + "," + matrixTextBox38.Text
                           + "," + matrixTextBox39.Text
                           + "," + matrixTextBox41.Text
                           + "," + matrixTextBox42.Text
                           + "," + matrixTextBox43.Text
                           + "," + matrixTextBox44.Text
                           + "," + matrixTextBox46.Text
                           + "," + matrixTextBox47.Text
                           + "," + matrixTextBox48.Text
                           + "," + matrixTextBox50.Text
                           + "," + matrixTextBox51.Text
                           + "," + matrixTextBox53.Text;



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
            matrixTextBox11.Text = values[9];
            matrixTextBox12.Text = values[10];
            matrixTextBox13.Text = values[11];
            matrixTextBox14.Text = values[12];
            matrixTextBox15.Text = values[13];
            matrixTextBox16.Text = values[14];
            matrixTextBox17.Text = values[15];
            matrixTextBox18.Text = values[16];
            matrixTextBox20.Text = values[17];
            matrixTextBox21.Text = values[18];
            matrixTextBox22.Text = values[19];
            matrixTextBox23.Text = values[20];
            matrixTextBox24.Text = values[21];
            matrixTextBox25.Text = values[22];
            matrixTextBox26.Text = values[23];
            matrixTextBox28.Text = values[24];
            matrixTextBox29.Text = values[25];
            matrixTextBox30.Text = values[26];
            matrixTextBox31.Text = values[27];
            matrixTextBox32.Text = values[28];
            matrixTextBox33.Text = values[29];
            matrixTextBox35.Text = values[30];
            matrixTextBox36.Text = values[31];
            matrixTextBox37.Text = values[32];
            matrixTextBox38.Text = values[33];
            matrixTextBox39.Text = values[34];
            matrixTextBox41.Text = values[35];
            matrixTextBox42.Text = values[36];
            matrixTextBox43.Text = values[37];
            matrixTextBox44.Text = values[38];
            matrixTextBox46.Text = values[39];
            matrixTextBox47.Text = values[40];
            matrixTextBox48.Text = values[41];
            matrixTextBox50.Text = values[42];
            matrixTextBox51.Text = values[43];
            matrixTextBox53.Text = values[44];
        }

        private void button1_Click(object sender, EventArgs e)
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
                           + "," + matrixTextBox11.Text
                           + "," + matrixTextBox12.Text
                           + "," + matrixTextBox13.Text
                           + "," + matrixTextBox14.Text
                           + "," + matrixTextBox15.Text
                           + "," + matrixTextBox16.Text
                           + "," + matrixTextBox17.Text
                           + "," + matrixTextBox18.Text
                           + "," + matrixTextBox20.Text
                           + "," + matrixTextBox21.Text
                           + "," + matrixTextBox22.Text
                           + "," + matrixTextBox23.Text
                           + "," + matrixTextBox24.Text
                           + "," + matrixTextBox25.Text
                           + "," + matrixTextBox26.Text
                           + "," + matrixTextBox28.Text
                           + "," + matrixTextBox29.Text
                           + "," + matrixTextBox30.Text
                           + "," + matrixTextBox31.Text
                           + "," + matrixTextBox32.Text
                           + "," + matrixTextBox33.Text
                           + "," + matrixTextBox35.Text
                           + "," + matrixTextBox36.Text
                           + "," + matrixTextBox37.Text
                           + "," + matrixTextBox38.Text
                           + "," + matrixTextBox39.Text
                           + "," + matrixTextBox41.Text
                           + "," + matrixTextBox42.Text
                           + "," + matrixTextBox43.Text
                           + "," + matrixTextBox44.Text
                           + "," + matrixTextBox46.Text
                           + "," + matrixTextBox47.Text
                           + "," + matrixTextBox48.Text
                           + "," + matrixTextBox50.Text
                           + "," + matrixTextBox51.Text
                           + "," + matrixTextBox53.Text;


            if (_isTest)
            {
                countPassedQuestion++;

                if (result == correctAnswer)
                {
                    countCorrectAnswer++;
                }

                if (maxCount > countPassedQuestion)
                {
                    FormHaffmenaTest1 form = new FormHaffmenaTest1(true);
                    form.Show();
                    this.Close();
                }
                else
                {
                    FormHaffmenaTest2 form = new FormHaffmenaTest2(true, countCorrectAnswer);
                    form.Show();
                    countPassedQuestion = 0;
                    countCorrectAnswer = 0;
                    this.Close();
                }
            }
            else
            {
                FormHaffmenaTest1 form = new FormHaffmenaTest1(false);
                form.Show();
                this.Close();
            }
        }
    }
}

