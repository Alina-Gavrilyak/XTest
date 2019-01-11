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

namespace XTest.SystematicCode.Rida_MilleraCode
{
    public partial class FormRida_MilleraTest2 : MetroForm
    {
        private string correctAnswer;
        private static int countPassedQuestion = 3;
        private static int countCorrectAnswer;
        private static int maxCount = 6;
        private bool _isTest;


        public FormRida_MilleraTest2(bool isTest, int correctAnswers = 0)
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
            RidaMilleraData data = new RidaMilleraData();
            KeyValuePair<string[], string[]> item;
            if (_isTest)
            {
                int skipNumber = r.Next(0, 6);
                item = data.CoDecData.Skip(skipNumber).First();
            }
            else
            {
                int skipNumber = r.Next(6, 9);
                item = data.CoDecData.Skip(skipNumber).First();
            }
            string[] values = item.Value;


            label177.Text = item.Value[0];
            label178.Text = item.Value[1];
            label179.Text = item.Value[2];
            label180.Text = item.Value[3];
            label181.Text = item.Value[4];
            label182.Text = item.Value[5];
            label183.Text = item.Value[6];
            label184.Text = item.Value[7];
            label185.Text = item.Value[8];
            label186.Text = item.Value[9];
            label187.Text = item.Value[10];
            label188.Text = item.Value[11];
            label189.Text = item.Value[12];
            label190.Text = item.Value[13];
            label191.Text = item.Value[14];
            label192.Text = item.Value[15];



            correctAnswer = string.Join(",", item.Key);

            #region Matrix
            label1.Text = data.MatrixData[0];
            label2.Text = data.MatrixData[1];
            label3.Text = data.MatrixData[2];
            label4.Text = data.MatrixData[3];
            label5.Text = data.MatrixData[4];
            label6.Text = data.MatrixData[5];
            label7.Text = data.MatrixData[6];
            label8.Text = data.MatrixData[7];
            label9.Text = data.MatrixData[8];
            label10.Text = data.MatrixData[9];
            label11.Text = data.MatrixData[10];
            label12.Text = data.MatrixData[11];
            label13.Text = data.MatrixData[12];
            label14.Text = data.MatrixData[13];
            label15.Text = data.MatrixData[14];
            label16.Text = data.MatrixData[15];
            label17.Text = data.MatrixData[16];
            label18.Text = data.MatrixData[17];
            label19.Text = data.MatrixData[18];
            label20.Text = data.MatrixData[19];
            label21.Text = data.MatrixData[20];
            label22.Text = data.MatrixData[21];
            label23.Text = data.MatrixData[22];
            label24.Text = data.MatrixData[23];
            label25.Text = data.MatrixData[24];
            label26.Text = data.MatrixData[25];
            label27.Text = data.MatrixData[26];
            label28.Text = data.MatrixData[27];
            label29.Text = data.MatrixData[28];
            label30.Text = data.MatrixData[29];
            label31.Text = data.MatrixData[30];
            label32.Text = data.MatrixData[31];
            label33.Text = data.MatrixData[32];
            label34.Text = data.MatrixData[33];
            label35.Text = data.MatrixData[34];
            label36.Text = data.MatrixData[35];
            label37.Text = data.MatrixData[36];
            label38.Text = data.MatrixData[37];
            label39.Text = data.MatrixData[38];
            label40.Text = data.MatrixData[39];
            label41.Text = data.MatrixData[40];
            label42.Text = data.MatrixData[41];
            label43.Text = data.MatrixData[42];
            label44.Text = data.MatrixData[43];
            label45.Text = data.MatrixData[44];
            label46.Text = data.MatrixData[45];
            label47.Text = data.MatrixData[46];
            label48.Text = data.MatrixData[47];
            label49.Text = data.MatrixData[48];
            label50.Text = data.MatrixData[49];
            label51.Text = data.MatrixData[50];
            label52.Text = data.MatrixData[51];
            label53.Text = data.MatrixData[52];
            label54.Text = data.MatrixData[53];
            label55.Text = data.MatrixData[54];
            label56.Text = data.MatrixData[55];
            label57.Text = data.MatrixData[56];
            label58.Text = data.MatrixData[57];
            label59.Text = data.MatrixData[58];
            label60.Text = data.MatrixData[59];
            label61.Text = data.MatrixData[60];
            label62.Text = data.MatrixData[61];
            label63.Text = data.MatrixData[62];
            label64.Text = data.MatrixData[63];
            label65.Text = data.MatrixData[64];
            label66.Text = data.MatrixData[65];
            label67.Text = data.MatrixData[66];
            label68.Text = data.MatrixData[67];
            label69.Text = data.MatrixData[68];
            label70.Text = data.MatrixData[69];
            label71.Text = data.MatrixData[70];
            label72.Text = data.MatrixData[71];
            label73.Text = data.MatrixData[72];
            label74.Text = data.MatrixData[73];
            label75.Text = data.MatrixData[74];
            label76.Text = data.MatrixData[75];
            label77.Text = data.MatrixData[76];
            label78.Text = data.MatrixData[77];
            label79.Text = data.MatrixData[78];
            label80.Text = data.MatrixData[79];
            label81.Text = data.MatrixData[80];
            label82.Text = data.MatrixData[81];
            label83.Text = data.MatrixData[82];
            label84.Text = data.MatrixData[83];
            label85.Text = data.MatrixData[84];
            label86.Text = data.MatrixData[85];
            label87.Text = data.MatrixData[86];
            label88.Text = data.MatrixData[87];
            label89.Text = data.MatrixData[88];
            label90.Text = data.MatrixData[89];
            label91.Text = data.MatrixData[90];
            label92.Text = data.MatrixData[91];
            label93.Text = data.MatrixData[92];
            label94.Text = data.MatrixData[93];
            label95.Text = data.MatrixData[94];
            label96.Text = data.MatrixData[95];
            label97.Text = data.MatrixData[96];
            label98.Text = data.MatrixData[97];
            label99.Text = data.MatrixData[98];
            label100.Text = data.MatrixData[99];
            label101.Text = data.MatrixData[100];
            label102.Text = data.MatrixData[101];
            label103.Text = data.MatrixData[102];
            label104.Text = data.MatrixData[103];
            label105.Text = data.MatrixData[104];
            label106.Text = data.MatrixData[105];
            label107.Text = data.MatrixData[106];
            label108.Text = data.MatrixData[107];
            label109.Text = data.MatrixData[108];
            label110.Text = data.MatrixData[109];
            label111.Text = data.MatrixData[110];
            label112.Text = data.MatrixData[111];
            label113.Text = data.MatrixData[112];
            label114.Text = data.MatrixData[113];
            label115.Text = data.MatrixData[114];
            label116.Text = data.MatrixData[115];
            label117.Text = data.MatrixData[116];
            label118.Text = data.MatrixData[117];
            label119.Text = data.MatrixData[118];
            label120.Text = data.MatrixData[119];
            label121.Text = data.MatrixData[120];
            label122.Text = data.MatrixData[121];
            label123.Text = data.MatrixData[122];
            label124.Text = data.MatrixData[123];
            label125.Text = data.MatrixData[124];
            label126.Text = data.MatrixData[125];
            label127.Text = data.MatrixData[126];
            label128.Text = data.MatrixData[127];
            label129.Text = data.MatrixData[128];
            label130.Text = data.MatrixData[129];
            label131.Text = data.MatrixData[130];
            label132.Text = data.MatrixData[131];
            label133.Text = data.MatrixData[132];
            label134.Text = data.MatrixData[133];
            label135.Text = data.MatrixData[134];
            label136.Text = data.MatrixData[135];
            label137.Text = data.MatrixData[136];
            label138.Text = data.MatrixData[137];
            label139.Text = data.MatrixData[138];
            label140.Text = data.MatrixData[139];
            label141.Text = data.MatrixData[140];
            label142.Text = data.MatrixData[141];
            label143.Text = data.MatrixData[142];
            label144.Text = data.MatrixData[143];
            label145.Text = data.MatrixData[144];
            label146.Text = data.MatrixData[145];
            label147.Text = data.MatrixData[146];
            label148.Text = data.MatrixData[147];
            label149.Text = data.MatrixData[148];
            label150.Text = data.MatrixData[149];
            label151.Text = data.MatrixData[150];
            label152.Text = data.MatrixData[151];
            label153.Text = data.MatrixData[152];
            label154.Text = data.MatrixData[153];
            label155.Text = data.MatrixData[154];
            label156.Text = data.MatrixData[155];
            label157.Text = data.MatrixData[156];
            label158.Text = data.MatrixData[157];
            label159.Text = data.MatrixData[158];
            label160.Text = data.MatrixData[159];
            label161.Text = data.MatrixData[160];
            label162.Text = data.MatrixData[161];
            label163.Text = data.MatrixData[162];
            label164.Text = data.MatrixData[163];
            label165.Text = data.MatrixData[164];
            label166.Text = data.MatrixData[165];
            label167.Text = data.MatrixData[166];
            label168.Text = data.MatrixData[167];
            label169.Text = data.MatrixData[168];
            label170.Text = data.MatrixData[169];
            label171.Text = data.MatrixData[170];
            label172.Text = data.MatrixData[171];
            label173.Text = data.MatrixData[172];
            label174.Text = data.MatrixData[173];
            label175.Text = data.MatrixData[174];
            label176.Text = data.MatrixData[175];
            #endregion
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
                               + "," + textBox11.Text;

                if (result == correctAnswer)
                {
                    countCorrectAnswer++;
                }

                if (maxCount > countPassedQuestion)
                {
                    FormRida_MilleraTest2 form = new FormRida_MilleraTest2(true);
                    form.Show();
                    this.Close();
                }
                else
                {
                    int mark = countCorrectAnswer * 5 / countPassedQuestion;
                    ResultForm form = new ResultForm(mark, Text, countCorrectAnswer, countPassedQuestion);
                    form.Show();
                    countPassedQuestion = 3;
                    countCorrectAnswer = 0;
                    this.Close();
                }
            }
            else
            {
                FormRida_MilleraTest2 form = new FormRida_MilleraTest2(false);
                form.Show();
                this.Close();
            }
        }

        private void btnCheck_Click(object sender, EventArgs e)
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
                           + "," + textBox11.Text;

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
        }
    }
}
