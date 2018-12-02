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

namespace XTest.Non_binaryCode.CodeWithModuleTest
{
    public partial class FormModuleTest6 : MetroForm
    {
        public FormModuleTest6()
        {
            InitializeComponent();
            if (Settings.Theme == MyTheme.Black)
                BlackTheme();
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
                if (c.GetType() == typeof(RadioButton))
                {
                    ((RadioButton)c).BackColor = Color.FromArgb(34, 34, 34);
                    ((RadioButton)c).ForeColor = Color.White;
                }
                
            }
        }
    }
}
