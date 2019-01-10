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

namespace XTest.SystematicCode.ElaesaCode
{
    public partial class FormElaesaTest1 : MetroForm
    {
        private string correctAnswer;
        private static int countPassedQuestion;
        private static int countCorrectAnswer;
        private static int maxCount = 4;

        private bool _isTest;

        public FormElaesaTest1(bool isTest, int correctAnswers = 0)
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
            ElaesaData data = new ElaesaData();
            KeyValuePair<string[], string[]> item;
            if (_isTest)
            {
                int skipNumber = r.Next(0, 4);
                item = data.CodecData.Skip(skipNumber).First();

            }
            else
            {
                //19 is upsent
                int skipNumber = r.Next(4, 7);
                item = data.CodecData.Skip(skipNumber).First();
            }

            string[] keys = item.Key;
            matrixElement1.Text = keys[0];
            matrixElement2.Text = keys[1];
            matrixElement3.Text = keys[2];
            matrixElement4.Text = keys[3];
            matrixElement5.Text = keys[4];
            matrixElement6.Text = keys[5];
            matrixElement7.Text = keys[6];
            matrixElement8.Text = keys[7];
            matrixElement9.Text = keys[8];
            matrixElement10.Text = keys[9];
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
                    FormElaesaTest1 form = new FormElaesaTest1(true);
                    form.Show();
                    this.Close();
                }
                else
                {
                    FormElaesaTest5 form = new FormElaesaTest5(true, countCorrectAnswer);
                    form.Show();
                    countPassedQuestion = 0;
                    countCorrectAnswer = 0;
                    this.Close();
                }
            }
            else
            {
                FormElaesaTest1 form = new FormElaesaTest1(false);
                form.Show();
                this.Close();
            }
        }

        private void FormElaesaTest1_Load(object sender, EventArgs e)
        {

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
    }
}
