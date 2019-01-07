using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Components;
using MetroFramework.Forms;

namespace XTest
{
    public partial class MainForm : MetroForm
    {
        private TreeNode a; //all codes
        private TreeNode q; //systematic codes
        private TreeNode w; //cyclic codes
        private TreeNode t; //non-binary codes
        private TreeNode r; //other codes
        private TreeNode selectedNode;


        public MainForm()
        {
            InitializeComponent();
            //ButtonTest.Enabled = false;
            //ButtonTraining.Enabled = false;


            #region Дерево
            a = TreeOfMethods.Nodes.Add("Теория информации и кодирования");
            a.Tag = 100;

            q = a.Nodes.Add("Систематические коды");
            q.Tag = 10;
            q.Nodes.Add("Код Элайеса").Tag = 11;
            q.Nodes.Add("Код Варшамова").Tag = 12;
            q.Nodes.Add("Коды Рида-Милеера").Tag = 13;
            q.Nodes.Add("Код Хеминга").Tag = 14;

            w = a.Nodes.Add("Циклические коды");
            w.Tag = 20;
            w.Nodes.Add("Коды Абрамсона").Tag = 21;
            w.Nodes.Add("Коды Файра").Tag = 22;
            w.Nodes.Add("Код Хеминга").Tag = 23;
            w.Nodes.Add("Код БЧХ").Tag = 24;

            t = a.Nodes.Add("Недвоичные коды");
            t.Tag = 30;
            t.Nodes.Add("Первичные недвоичные коды").Tag = 31;
            t.Nodes.Add("Код с проверкой по модулю q").Tag = 32;
            t.Nodes.Add("Код с простым повторением").Tag = 33;
            t.Nodes.Add("Итеративный код").Tag = 34;

            r = a.Nodes.Add("Прочие коды и лабораторные работы");
            r.Tag = 40;
            r.Nodes.Add("Код Грея").Tag = 41;
            r.Nodes.Add("Двоично-десятичный код").Tag = 42;
            r.Nodes.Add("Код Бергера").Tag = 43;
            r.Nodes.Add("Код Шенона-Фано").Tag = 44;
            r.Nodes.Add("Код Хаффмена").Tag = 45;
            r.Nodes.Add("Коды-спутники").Tag = 46;
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

        private void btn_Dark_Click(object sender, EventArgs e)
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
            FindForm(a, false);
        }

        private void FindForm(TreeNode parentNode, bool isTest)
        {
            if (parentNode.IsSelected)
            {
                selectedNode = parentNode;
                OpenForm(parentNode.Text, isTest);
            }
            else
            {
                foreach (TreeNode subNode in parentNode.Nodes)
                {
                    FindForm(subNode, isTest);
                }
            }
        }

        private void OpenForm(string formName, bool isTest)
        {
            Random random = new Random();
            int rand = random.Next(1, 2);
            // systematic codes
            if (formName.Equals("Код Элайеса"))
            {
                if (rand == 1)
                {
                    SystematicCode.ElaesaCode.FormElaesaTest1 form = new SystematicCode.ElaesaCode.FormElaesaTest1();
                    form.Show();
                }
                if (rand == 2)
                {
                    SystematicCode.ElaesaCode.FormElaesaTest2 form = new SystematicCode.ElaesaCode.FormElaesaTest2();
                    form.Show();
                }
                if (rand == 3)
                {
                    SystematicCode.ElaesaCode.FormElaesaTest3 form = new SystematicCode.ElaesaCode.FormElaesaTest3();
                    form.Show();
                }
                if (rand == 4)
                {
                    SystematicCode.ElaesaCode.FormElaesaTest4 form = new SystematicCode.ElaesaCode.FormElaesaTest4();
                    form.Show();
                }
                if (rand == 5)
                {
                    SystematicCode.ElaesaCode.FormElaesaTest5 form = new SystematicCode.ElaesaCode.FormElaesaTest5();
                    form.Show();
                }

            }
            else if (formName.Equals("Код Варшамова"))
            {

            }
            else if (formName.Equals("Коды Рида-Милеера"))
            {

            }
            else if (formName.Equals("Код Хеминга"))
            {
                if (rand == 1)
                {
                    if (isTest)
                    {
                        SystematicCode.HemingaCode.FormHemingaTest1 form = new SystematicCode.HemingaCode.FormHemingaTest1(true, null);
                        form.Show();
                    }
                    else
                    {
                        MenuItem[] menuItems = new MenuItem[]{
                            new MenuItem("Кодирование", btnCodecMenuItems),
                            new MenuItem("Декодирование", btnCodecMenuItems)
                        };

                        ContextMenu buttonMenu = new ContextMenu(menuItems);
                        buttonMenu.Show(ButtonTraining, new System.Drawing.Point(20, 20));
                    }


                }
                if (rand == 2)
                {
                    SystematicCode.HemingaCode.FormHemingaTest2 form = new SystematicCode.HemingaCode.FormHemingaTest2();
                    form.Show();
                }
                if (rand == 3)
                {
                    SystematicCode.HemingaCode.FormHemingaTest3 form = new SystematicCode.HemingaCode.FormHemingaTest3();
                    form.Show();
                }
                if (rand == 4)
                {
                    SystematicCode.HemingaCode.FormHemingaTest4 form = new SystematicCode.HemingaCode.FormHemingaTest4();
                    form.Show();
                }
                if (rand == 5)
                {
                    SystematicCode.HemingaCode.FormHemingaTest5 form = new SystematicCode.HemingaCode.FormHemingaTest5();
                    form.Show();
                }
                if (rand == 6)
                {
                    SystematicCode.HemingaCode.FormHemingaTest6 form = new SystematicCode.HemingaCode.FormHemingaTest6();
                    form.Show();
                }
            }

            // cyclic codes
            else if (formName.Equals("Код Абрамса"))
            {
                if (rand == 1)
                {
                    CyclicCode.AbramsonaCode.FormAbramsTest1 form = new CyclicCode.AbramsonaCode.FormAbramsTest1();
                    form.Show();
                }

                if (rand == 2)
                {
                    CyclicCode.AbramsonaCode.FormAbramsTest6 form = new CyclicCode.AbramsonaCode.FormAbramsTest6();
                    form.Show();
                }
            }
            else if (formName.Equals("Код Файра"))
            {
                if (rand == 1)
                {
                    CyclicCode.FairaCode.FormFairaTest1 form = new CyclicCode.FairaCode.FormFairaTest1();
                    form.Show();
                }
                if (rand == 2)
                {
                    CyclicCode.FairaCode.FormFairaTest6 form = new CyclicCode.FairaCode.FormFairaTest6();
                    form.Show();
                }
            }
            else if (formName.Equals("Код Хеминга"))
            {
                if (rand == 1)
                {
                    CyclicCode.HemingaCode.FormHemingaTest1 form = new CyclicCode.HemingaCode.FormHemingaTest1();
                    form.Show();
                }
                if (rand == 2)
                {

                    CyclicCode.HemingaCode.FormHemingaTest6 form = new CyclicCode.HemingaCode.FormHemingaTest6();
                    form.Show();
                }
            }
            else if (formName.Equals("Код БЧХ"))
            {
                if (rand == 1)
                {
                    CyclicCode.BChHCode.FormBChHTest1 form = new CyclicCode.BChHCode.FormBChHTest1();
                    form.Show();
                }
                if (rand == 2)
                {
                    CyclicCode.BChHCode.FormBChHTest6 form = new CyclicCode.BChHCode.FormBChHTest6();
                    form.Show();
                }
            }

            //non binary codes
            else if (formName.Equals("Первичные недвоичные коды"))
            {

            }
            else if (formName.Equals("Код с проверкой по модулю q"))
            {
                if (rand == 1)
                {
                    Non_binaryCode.CodeWithModuleTest.FormModuleTest1 form = new Non_binaryCode.CodeWithModuleTest.FormModuleTest1();
                    form.Show();
                }
                if (rand == 2)
                {
                    Non_binaryCode.CodeWithModuleTest.FormModuleTest6 form = new Non_binaryCode.CodeWithModuleTest.FormModuleTest6();
                    form.Show();
                }
            }
            else if (formName.Equals("Код с простым повторением"))
            {
                if (rand == 1)
                {
                    Non_binaryCode.CodeWithaSimpleIteration.FormIterationTest1 form = new Non_binaryCode.CodeWithaSimpleIteration.FormIterationTest1();
                    form.Show();
                }
                if (rand == 2)
                {
                    Non_binaryCode.CodeWithaSimpleIteration.FormIterationTest6 form = new Non_binaryCode.CodeWithaSimpleIteration.FormIterationTest6();
                    form.Show();
                }
            }
            else if (formName.Equals("Итеративный код"))
            {
                if (rand == 1)
                {
                    Non_binaryCode.IterativityCode.FormIterativityTest5 form = new Non_binaryCode.IterativityCode.FormIterativityTest5();
                    form.Show();
                }

            }

            //other codes
            else if (formName.Equals("Код Грея"))
            {
                if (rand == 1)
                {
                    ElseCodeAndLabs.GrayCode.FormGrayTest1 form = new ElseCodeAndLabs.GrayCode.FormGrayTest1();
                    form.Show();
                }
                if (rand == 2)
                {
                    ElseCodeAndLabs.GrayCode.FormGrayTest6 form = new ElseCodeAndLabs.GrayCode.FormGrayTest6();
                    form.Show();
                }
            }
            else if (formName.Equals("Двоично-десятичный код"))
            {
                if (rand == 1)
                {

                }
            }
            else if (formName.Equals("Код Бергера"))
            {
                if (rand == 1)
                {
                    ElseCodeAndLabs.BergerCode.FormBergerTest1 form = new ElseCodeAndLabs.BergerCode.FormBergerTest1();
                    form.Show();
                }
                if (rand == 2)
                {
                    ElseCodeAndLabs.BergerCode.FormBergerTest6 form = new ElseCodeAndLabs.BergerCode.FormBergerTest6();
                    form.Show();
                }
            }
            else if (formName.Equals("Код Шенона-Фано"))
            {
                if (rand == 1)
                {
                    ElseCodeAndLabs.Shenona_FanoCode.FormShenona_FanoTest1 form = new ElseCodeAndLabs.Shenona_FanoCode.FormShenona_FanoTest1();
                    form.Show();
                }
                if (rand == 2)
                {
                    ElseCodeAndLabs.Shenona_FanoCode.FormShenona_FanoTest3 form = new ElseCodeAndLabs.Shenona_FanoCode.FormShenona_FanoTest3();
                    form.Show();
                }
            }
            else if (formName.Equals("Код Хаффмена"))
            {
                if (rand == 1)
                {
                    ElseCodeAndLabs.HaffmenaCode.FormHaffmenaTest1 form = new ElseCodeAndLabs.HaffmenaCode.FormHaffmenaTest1();
                    form.Show();
                }
                if (rand == 2)
                {
                }
            }
            else if (formName.Equals("Коды-спутники"))
            {
                if (rand == 1)
                {
                    ElseCodeAndLabs.SateliteCode.FormSateliteTest1 form = new ElseCodeAndLabs.SateliteCode.FormSateliteTest1();
                    form.Show();
                }
                if (rand == 2)
                {
                    ElseCodeAndLabs.SateliteCode.FormSateliteTest4 form = new ElseCodeAndLabs.SateliteCode.FormSateliteTest4();
                    form.Show();
                }

            }
            else if (formName.Equals("Количество информации и энтропия"))
            {
                if (rand == 1)
                {
                    ElseCodeAndLabs.Entropy.FormEntropyTest1 form = new ElseCodeAndLabs.Entropy.FormEntropyTest1();
                    form.Show();
                }
                if (rand == 2)
                {
                    ElseCodeAndLabs.Entropy.FormEntropyTest4 form = new ElseCodeAndLabs.Entropy.FormEntropyTest4();
                    form.Show();
                }

            }
            else if (formName.Equals("Рекурентный код"))
            {
                if (rand == 1)
                {
                    ElseCodeAndLabs.RekyrentCode.FormRekyrentTest1 form = new ElseCodeAndLabs.RekyrentCode.FormRekyrentTest1();
                    form.Show();
                }
                if (rand == 2)
                {
                    ElseCodeAndLabs.RekyrentCode.FormRekyrentTest4 form = new ElseCodeAndLabs.RekyrentCode.FormRekyrentTest4();
                    form.Show();
                }

            }
            else if (formName.Equals("Канальные коды"))
            {

            }

        }
        private void btnCodecMenuItems(object sender, EventArgs e)
        {
            string n = ((MenuItem)sender).Text;

            bool codec = false;
            if (n == "Кодирование")
                codec = true;

            SystematicCode.HemingaCode.FormHemingaTest1 form = new SystematicCode.HemingaCode.FormHemingaTest1(false, codec);
            form.Show();

        }


        private string getHashCode(string name, string[] answers)
        {
            string encodedName = stringToMD5(name);
            string encodedAnswers = arrayToString(answers, selectedNode.Text);
            string result = stringToMD5(encodedName + encodedAnswers);
            string revertedResult = reverse(result);
            return revertedResult;
        }

        private string arrayToString(string[] answers, string formName)
        {
            string result = formName;
            foreach (var b in answers)
            {
                result += b;
            }
            return result;
        }

        private string reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        private string stringToMD5(string input)
        {
            byte[] hash = Encoding.ASCII.GetBytes(input);
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] hashenc = md5.ComputeHash(hash);
            string result = "";
            foreach (var b in hashenc)
            {
                result += b.ToString("x2");
            }
            return result;
        }

        private void ButtonTheory_Click(object sender, EventArgs e)
        {

        }

        private void ButtonReport_Click_1(object sender, EventArgs e)
        {

        }

        private void ButtonTest_Click_1(object sender, EventArgs e)
        {
            FindForm(a, true);
        }
    }
}
