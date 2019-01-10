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
    public partial class FormVarshamovaTest2 : MetroForm
    {

        private string correctAnswer;
        private static int countPassedQuestion = 1;
        private static int countCorrectAnswer;
        private static int maxCount = 2;

        private bool _isTest;

        public FormVarshamovaTest2(bool isTest, int correctAnswers = 0)
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
            VarshamoveData data = new VarshamoveData();
            KeyValuePair<string[], string[]> item;
            if (_isTest)
            {
                item = data.Form2CodecData.First();
            }
            else
            {
                item = data.Form2CodecData.First();
            }

            string[] keys = item.Key;
            string[] values = item.Value;

            tuLabel.Text = keys[0];
            dLabel.Text = keys[0];

            //text1.Text = values[0];
            //text2.Text = values[1];
            //text3.Text = values[2];
            //text4.Text = values[3];
            //text5.Text = values[4];
            //text6.Text = values[5];
            //text7.Text = values[6];
            //text8.Text = values[7];
            //text9.Text = values[8];
            //text10.Text = values[9];
            //text11.Text = values[10];
            //text12.Text = values[11];
            //text13.Text = values[12];
            //text14.Text = values[13];
            //text15.Text = values[14];
            //text16.Text = values[15];
            //text17.Text = values[16];
            //text18.Text = values[17];
            //text19.Text = values[18];
            //text20.Text = values[19];
            //text21.Text = values[20];
            //text22.Text = values[21];
            //text23.Text = values[22];
            //text24.Text = values[23];
            //text25.Text = values[24];
            //text26.Text = values[25];
            //text27.Text = values[26];
            //text28.Text = values[27];
            //text29.Text = values[28];
            //text30.Text = values[29];
            //text31.Text = values[30];
            //text32.Text = values[31];
            //text33.Text = values[32];
            //text34.Text = values[33];
            //text35.Text = values[34];
            //text36.Text = values[35];
            //text37.Text = values[36];
            //text38.Text = values[37];
            //text39.Text = values[38];
            //text40.Text = values[39];
            //text41.Text = values[40];
            //text42.Text = values[41];
            //text43.Text = values[42];
            //text44.Text = values[43];
            //text45.Text = values[44];
            //text46.Text = values[45];
            //text47.Text = values[46];
            //text48.Text = values[47];
            //text49.Text = values[48];
            //text51.Text = values[49];
            //text52.Text = values[50];
            //text53.Text = values[51];
            //text54.Text = values[52];

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

        private void ShowAnswer_Click(object sender, EventArgs e)
        {
            string[] values = correctAnswer.Split(',');

            text1.Text = values[0];
            text2.Text = values[1];
            text3.Text = values[2];
            text4.Text = values[3];
            text5.Text = values[4];
            text6.Text = values[5];
            text7.Text = values[6];
            text8.Text = values[7];
            text9.Text = values[8];
            text10.Text = values[9];
            text11.Text = values[10];
            text12.Text = values[11];
            text13.Text = values[12];
            text14.Text = values[13];
            text15.Text = values[14];
            text16.Text = values[15];
            text17.Text = values[16];
            text18.Text = values[17];
            text19.Text = values[18];
            text20.Text = values[19];
            text21.Text = values[20];
            text22.Text = values[21];
            text23.Text = values[22];
            text24.Text = values[23];
            text25.Text = values[24];
            text26.Text = values[25];
            text27.Text = values[26];
            text28.Text = values[27];
            text29.Text = values[28];
            text30.Text = values[29];
            text31.Text = values[30];
            text32.Text = values[31];
            text33.Text = values[32];
            text34.Text = values[33];
            text35.Text = values[34];
            text36.Text = values[35];
            text37.Text = values[36];
            text38.Text = values[37];
            text39.Text = values[38];
            text40.Text = values[39];
            text41.Text = values[40];
            text42.Text = values[41];
            text43.Text = values[42];
            text44.Text = values[43];
            text45.Text = values[44];
            text46.Text = values[45];
            text47.Text = values[46];
            text48.Text = values[47];
            text49.Text = values[48];
            text50.Text = values[49];
            text51.Text = values[50];
            text52.Text = values[51];
            text53.Text = values[52];
            text54.Text = values[53];
            text55.Text = values[54];
            text56.Text = values[55];
            text57.Text = values[56];
            text58.Text = values[57];
            text59.Text = values[58];
            text60.Text = values[59];


        }

        private void Check_Click(object sender, EventArgs e)
        {
            string result = text1.Text
                          + "," + text2.Text
                          + "," + text3.Text
                          + "," + text4.Text
                          + "," + text5.Text
                          + "," + text6.Text
                          + "," + text7.Text
                          + "," + text8.Text
                          + "," + text9.Text
                          + "," + text10.Text
                          + "," + text11.Text
                          + "," + text12.Text
                          + "," + text13.Text
                          + "," + text14.Text
                          + "," + text15.Text
                          + "," + text16.Text
                          + "," + text17.Text
                          + "," + text18.Text
                          + "," + text19.Text
                          + "," + text20.Text
                          + "," + text21.Text
                          + "," + text22.Text
                          + "," + text23.Text
                          + "," + text24.Text
                          + "," + text25.Text
                          + "," + text26.Text
                          + "," + text27.Text
                          + "," + text28.Text
                          + "," + text29.Text
                          + "," + text30.Text
                          + "," + text31.Text
                          + "," + text32.Text
                          + "," + text33.Text
                          + "," + text34.Text
                          + "," + text35.Text
                          + "," + text36.Text
                          + "," + text37.Text
                          + "," + text38.Text
                          + "," + text39.Text
                          + "," + text40.Text
                          + "," + text41.Text
                          + "," + text42.Text
                          + "," + text43.Text
                          + "," + text44.Text
                          + "," + text45.Text
                          + "," + text46.Text
                          + "," + text47.Text
                          + "," + text48.Text
                          + "," + text49.Text
                          + "," + text50.Text
                          + "," + text51.Text
                          + "," + text52.Text
                          + "," + text53.Text
                          + "," + text54.Text
                          + "," + text55.Text
                          + "," + text56.Text
                          + "," + text57.Text
                          + "," + text58.Text
                          + "," + text59.Text
                          + "," + text60.Text;


            if (result == correctAnswer)
            {
                CheckingResultLabel.Text = "Правильно";
            }
            else
            {
                CheckingResultLabel.Text = "Не правильно";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string result = text1.Text
                      + "," + text2.Text
                      + "," + text3.Text
                      + "," + text4.Text
                      + "," + text5.Text
                      + "," + text6.Text
                      + "," + text7.Text
                      + "," + text8.Text
                      + "," + text9.Text
                      + "," + text10.Text
                      + "," + text11.Text
                      + "," + text12.Text
                      + "," + text13.Text
                      + "," + text14.Text
                      + "," + text15.Text
                      + "," + text16.Text
                      + "," + text17.Text
                      + "," + text18.Text
                      + "," + text19.Text
                      + "," + text20.Text
                      + "," + text31.Text
                      + "," + text32.Text
                      + "," + text33.Text
                      + "," + text34.Text
                      + "," + text35.Text
                      + "," + text36.Text
                      + "," + text37.Text
                      + "," + text38.Text
                      + "," + text39.Text
                      + "," + text40.Text
                      + "," + text41.Text
                      + "," + text42.Text
                      + "," + text43.Text
                      + "," + text44.Text
                      + "," + text45.Text
                      + "," + text46.Text
                      + "," + text47.Text
                      + "," + text48.Text
                      + "," + text49.Text
                      + "," + text50.Text
                      + "," + text51.Text
                      + "," + text52.Text
                      + "," + text53.Text
                      + "," + text54.Text;

            if (_isTest)
            {
                countPassedQuestion++;

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
                    int mark = countCorrectAnswer * 5 / countPassedQuestion;
                    ResultForm form = new ResultForm(mark, Text, countCorrectAnswer, countPassedQuestion);
                    form.Show();
                    countPassedQuestion = 1;
                    countCorrectAnswer = 0;
                    this.Close();
                }
            }
            else
            {
                FormVarshamovaTest1 form = new FormVarshamovaTest1(false);
                form.Show();
                this.Close();
            }

        }
    }
}
