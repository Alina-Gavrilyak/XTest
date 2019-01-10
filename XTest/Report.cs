using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Components;
using MetroFramework.Forms;

namespace XTest
{
    public partial class Report : MetroForm
    {
        static byte[] key = { 3, 1, 3, 3, 6, 3, 2, 9 };
        static byte[] iv = { 7, 4, 9, 1, 5, 3, 1, 4 };

        public Report()
        {
            InitializeComponent();
            if (Settings.Theme == MyTheme.Black)
                BlackTheme();

            DeserializeData();
        }

        private void DeserializeData()
        {
            DESCryptoServiceProvider des = new DESCryptoServiceProvider();
            BinaryFormatter formatter = new BinaryFormatter();
            List<string> reportData = new List<string>();

            using (FileStream fs = new FileStream("report.dat", FileMode.OpenOrCreate))
                if (fs.Length != 0)
                    using (var cs = new CryptoStream(fs, des.CreateDecryptor(key, iv), CryptoStreamMode.Read))
                        reportData = (List<string>)formatter.Deserialize(cs);

            foreach (string s in reportData)
                dataGridView1.Rows.Add(s.Split(','));
        }

        public static void AddReportRow(string userName, string codeName, int mark, int correctAnswers, int countQuestions)
        {
            DESCryptoServiceProvider des = new DESCryptoServiceProvider();
            BinaryFormatter formatter = new BinaryFormatter();
            List<string> report = new List<string>();

            using (FileStream fs = new FileStream("report.dat", FileMode.OpenOrCreate))
                if (fs.Length != 0)
                    using (var cs = new CryptoStream(fs, des.CreateDecryptor(key, iv), CryptoStreamMode.Read))
                        report = (List<string>)formatter.Deserialize(cs);

            report.Add(userName + "," + codeName + "," + mark + "," + correctAnswers + "," + countQuestions);

            using (FileStream fs = new FileStream("report.dat", FileMode.OpenOrCreate))
            using (var cs = new CryptoStream(fs, des.CreateEncryptor(key, iv), CryptoStreamMode.Write))
                formatter.Serialize(cs, report);
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
    }
}
