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
    public partial class FormSateliteTest1 : MetroForm
    {

        private string correctAnswer;
        private static int countPassedQuestion;
        private static int countCorrectAnswer;
        private static int maxCount = 5;

        private bool _isTest;

        public FormSateliteTest1(bool isTest)
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
            SateliteData data = new SateliteData();
            KeyValuePair<string, string[]> item;
            if (_isTest)
            {
                int skipNumber = r.Next(0, 3);
                item = data.CodecData.Skip(skipNumber).First();
            }
            else
            {
                int skipNumber = r.Next(3, 6);
                item = data.CodecData.Skip(skipNumber).First();
            }
            string[] values = item.Value;


            taskLabel.Text = item.Key;

            correctAnswer = string.Join(",", item.Value);

            //textBox1.Text = values[0];
            //textBox2.Text = values[1];
            //textBox3.Text = values[2];
            //textBox4.Text = values[3];
            //textBox5.Text = values[4];
            //textBox6.Text = values[5];
            //textBox7.Text = values[6];
            //textBox8.Text = values[7];
            //textBox9.Text = values[8];
            //textBox10.Text = values[9];
            //textBox11.Text = values[10];
            //textBox12.Text = values[11];
            //textBox13.Text = values[12];
            //textBox14.Text = values[13];
            //textBox15.Text = values[14];
            //textBox16.Text = values[15];
            //textBox17.Text = values[16];
            //textBox18.Text = values[17];
            //textBox19.Text = values[18];
            //textBox20.Text = values[19];
            //textBox21.Text = values[20];
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
                string result = textBox1.Text
                               + "," + textBox2.Text
                               + "," + textBox3.Text
                               + "," + textBox4.Text
                               + "," + textBox5.Text
                               + "," + textBox6.Text
                               + "," + textBox7.Text
                               + "," + textBox8.Text
                               + "," + textBox9.Text
                               + "," + textBox10.Text
                               + "," + textBox11.Text
                               + "," + textBox12.Text
                               + "," + textBox13.Text
                               + "," + textBox14.Text
                               + "," + textBox15.Text
                               + "," + textBox16.Text
                               + "," + textBox17.Text
                               + "," + textBox18.Text
                               + "," + textBox19.Text
                               + "," + textBox20.Text
                               + "," + textBox21.Text;

                if (result == correctAnswer)
                {
                    countCorrectAnswer++;
                }

                if (maxCount > countPassedQuestion)
                {
                    FormSateliteTest1 form = new FormSateliteTest1(true);
                    form.Show();
                    this.Close();
                }
                else
                {
                    FormSateliteTest4 form = new FormSateliteTest4(true, countCorrectAnswer);
                    form.Show();
                    countPassedQuestion = 0;
                    countCorrectAnswer = 0;
                    this.Close();
                }
            }
            else
            {
                FormSateliteTest1 form = new FormSateliteTest1(false);
                form.Show();
                this.Close();
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
                           + "," + textBox10.Text
                           + "," + textBox11.Text
                           + "," + textBox12.Text
                           + "," + textBox13.Text
                           + "," + textBox14.Text
                           + "," + textBox15.Text
                           + "," + textBox16.Text
                           + "," + textBox17.Text
                           + "," + textBox18.Text
                           + "," + textBox19.Text
                           + "," + textBox20.Text
                           + "," + textBox21.Text;

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
                            + "," + textBox10.Text
                            + "," + textBox11.Text
                            + "," + textBox12.Text
                            + "," + textBox13.Text
                            + "," + textBox14.Text
                            + "," + textBox15.Text
                            + "," + textBox16.Text
                            + "," + textBox17.Text
                            + "," + textBox18.Text
                            + "," + textBox19.Text
                            + "," + textBox20.Text
                            + "," + textBox21.Text;

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
            textBox11.Text = values[10];
            textBox12.Text = values[11];
            textBox13.Text = values[12];
            textBox14.Text = values[13];
            textBox15.Text = values[14];
            textBox16.Text = values[15];
            textBox17.Text = values[16];
            textBox18.Text = values[17];
            textBox19.Text = values[18];
            textBox20.Text = values[19];
            textBox21.Text = values[20];
        }
    }
}
