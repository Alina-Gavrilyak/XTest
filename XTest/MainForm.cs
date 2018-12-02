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

namespace XTest
{
    public partial class MainForm : MetroForm
    {
        

        public MainForm()
        {
            InitializeComponent();
            //ButtonTest.Enabled = false;
            //ButtonTraining.Enabled = false;

            #region Дерево
            TreeNode a = TreeOfMethods.Nodes.Add("Теория информации и кодирования");
            a.Tag = 100;
            TreeNode q = a.Nodes.Add("Систематические коды");
            q.Tag = 10;
            q.Nodes.Add("Код Элайеса").Tag = 11;
            q.Nodes.Add("Код Варшамова").Tag = 12;
            q.Nodes.Add("Коды Рида-Милеера").Tag = 13;
            q.Nodes.Add("Код Хеминга").Tag = 14;
            TreeNode w = a.Nodes.Add("Циклические коды");
            w.Tag = 20;
            w.Nodes.Add("Коды Абрамсона").Tag = 21;
            w.Nodes.Add("Коды Файра").Tag = 22;
            w.Nodes.Add("Код Хеминга").Tag = 23;
            w.Nodes.Add("Код БЧХ").Tag = 24;
            TreeNode t = a.Nodes.Add("Недвоичные коды");
            t.Tag = 30;
            t.Nodes.Add("Первичные недвоичные коды").Tag = 31;
            t.Nodes.Add("Код с проверкой по модулю q").Tag = 32;
            t.Nodes.Add("Код с простым повторением").Tag = 33;
            t.Nodes.Add("Итеративный код").Tag = 34;
            TreeNode r = a.Nodes.Add("Прочие коды и лабораторные работы");
            r.Tag = 40;
            r.Nodes.Add("Код Грея").Tag = 41;
            r.Nodes.Add("Двоично-десятичный код").Tag = 42;
            r.Nodes.Add("Код Бергера").Tag = 43;
            r.Nodes.Add("Код Шенона-Фано").Tag = 44;
            r.Nodes.Add("Код Хаффмена").Tag = 45;
            r.Nodes.Add("Коды-спутныкы").Tag = 46;
            r.Nodes.Add("Количество информации и энтропия").Tag = 47;
            r.Nodes.Add("Рекурентный код").Tag = 48;
            r.Nodes.Add("Канальные коды").Tag = 49;
            #endregion

        }
        private void TheoryForms(TreeNodeCollection Nodes)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            ButtonTraining.Theme = MetroFramework.MetroThemeStyle.Dark;
            ButtonReport.Theme = MetroFramework.MetroThemeStyle.Dark;
            ButtonTest.Theme = MetroFramework.MetroThemeStyle.Dark;
            ButtonTheory.Theme = MetroFramework.MetroThemeStyle.Dark;
            TreeOfMethods.BackColor = Color.FromArgb(34, 34, 34);
            TreeOfMethods.ForeColor = Color.White;
            Settings.Theme = MyTheme.Black;
        }

        private void btn_White_Click(object sender, EventArgs e)
        {
            this.Theme = MetroFramework.MetroThemeStyle.Light;
            ButtonTraining.Theme = MetroFramework.MetroThemeStyle.Light;
            ButtonReport.Theme = MetroFramework.MetroThemeStyle.Light;
            ButtonTest.Theme = MetroFramework.MetroThemeStyle.Light;
            ButtonTheory.Theme = MetroFramework.MetroThemeStyle.Light;
            TreeOfMethods.BackColor = Color.White;
            TreeOfMethods.ForeColor = Color.Black;
            Settings.Theme = MyTheme.White;
        }

        private void ButtonTraining_Click_1(object sender, EventArgs e)
        {

        }

        private void ButtonTheory_Click(object sender, EventArgs e)
        {
            SystematicCode.ElaesaCode.FormElaesaTest1 form2 = new SystematicCode.ElaesaCode.FormElaesaTest1();

            form2.Show();
        }

        private void ButtonReport_Click_1(object sender, EventArgs e)
        {

        }

        private void ButtonTest_Click_1(object sender, EventArgs e)
        {

        }
    }
}
