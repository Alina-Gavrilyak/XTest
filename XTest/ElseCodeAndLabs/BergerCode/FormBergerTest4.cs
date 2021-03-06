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

namespace XTest.ElseCodeAndLabs.BergerCode
{
    public partial class FormBergerTest1 : MetroForm
    {
        public FormBergerTest1()
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
                
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
