﻿using System;
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

namespace XTest.Non_binaryCode.CodeWithModuleTest
{
    public partial class FormModuleTest6 : MetroForm
    {
        private bool correctAnswer;
        private static int countPassedQuestion = 5;
        private static int countCorrectAnswer;
        private static int maxCount = 10;
        private bool _isTest;

        public FormModuleTest6(bool isTest, int correctAnswers = 0)
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
            ModuleTestData data = new ModuleTestData();
            KeyValuePair<string, bool> item;
            if (_isTest)
            {
                int skipNumber = r.Next(0, 15);
                item = data.DeCodecData.Skip(skipNumber).First();
            }
            else
            {
                int skipNumber = r.Next(15, 25);
                item = data.DeCodecData.Skip(skipNumber).First();
            }
            string[] keys = item.Key.Split(',');


            label4.Text = keys[0];
            label2.Text = keys[1];
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

                if (radioButton1.Checked == correctAnswer && radioButton2.Checked != correctAnswer)
                {
                    countCorrectAnswer++;
                }

                if (maxCount > countPassedQuestion)
                {
                    FormModuleTest6 form = new FormModuleTest6(true);
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
                FormModuleTest6 form = new FormModuleTest6(false);
                form.Show();
                this.Close();
            }
        }

        private void Check_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == correctAnswer && radioButton2.Checked != correctAnswer)
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
            radioButton1.Checked = correctAnswer;
            radioButton2.Checked = !correctAnswer;
        }
    }
}
