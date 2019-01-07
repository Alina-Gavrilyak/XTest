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

namespace XTest.SystematicCode.HemingaCode
{
    public partial class FormHemingaTest1 : MetroForm
    {
        private string correctAnswer;
        private static int countQuestion;
        private static int countCorrectAnswer;
        private static int maxCount = 10;

        private static bool _isTest;
        private static bool? _codec;

        public FormHemingaTest1(bool isTest, bool? codec)
        {
            InitializeComponent();
            FillFormData(codec);
            ChangeForm(isTest, codec);

            _isTest = isTest;
            _codec = codec;

            if (Settings.Theme == MyTheme.Black)
                BlackTheme();
        }



        private void FillFormData(bool? codec)
        {
            Random r = new Random();
            HemingaData data = new HemingaData();
            KeyValuePair<string, string> item;
            if (codec != null)
                if (codec == true)
                {
                    int skipNumber = r.Next(0, data.CodecData.Count);
                    item = data.CodecData.Skip(skipNumber).First();
                }
                else
                {
                    int skipNumber = r.Next(0, data.DeCodecData.Count);
                    item = data.CodecData.Skip(skipNumber).First();
                }
            else
            {
                if (countQuestion < 5)
                {
                    int skipNumber = r.Next(0, data.CodecData.Count);
                    item = data.CodecData.Skip(skipNumber).First();
                    codec = true;
                }
                else
                {
                    int skipNumber = r.Next(0, data.DeCodecData.Count);
                    item = data.DeCodecData.Skip(skipNumber).First();
                    codec = false;
                }
            }

            label2.Text = item.Key;
            correctAnswer = item.Value;
        }
        private void ChangeForm(bool isTest, bool? codec)
        {
            if (codec != null && codec == false)
                TitleTask.Text = "Декодируйте сообщение";

            if (isTest)
                Check.Enabled = false;
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
            countQuestion++;

            if (result.Text == correctAnswer)
            {
                countCorrectAnswer++;
            }
            
            if(maxCount > countQuestion)
            {
                SystematicCode.HemingaCode.FormHemingaTest1 form = new SystematicCode.HemingaCode.FormHemingaTest1(_isTest, _codec);
                form.Show();
                this.Close();
            }
            else
            {
                this.Close();
                //result form show
            }

        }
    }
}
