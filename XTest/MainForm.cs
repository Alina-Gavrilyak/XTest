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
using XTest.CyclicCode.FairaCode;

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
            q.Nodes.Add("Код Хеминга 1").Tag = 14;

            w = a.Nodes.Add("Циклические коды");
            w.Tag = 20;
            w.Nodes.Add("Коды Абрамсона").Tag = 21;
            w.Nodes.Add("Коды Файра").Tag = 22;
            w.Nodes.Add("Код Хеминга 2").Tag = 23;
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

            FindForm(a);

            MenuItem[] menuItems = new MenuItem[]{
                            new MenuItem("Кодирование", btnCodecMenuItems),
                            new MenuItem("Декодирование", btnCodecMenuItems)
                        };

            ContextMenu buttonMenu = new ContextMenu(menuItems);
            buttonMenu.Show(ButtonTraining, new System.Drawing.Point(20, 20));
            //обучение
        }

        private void FindForm(TreeNode parentNode)
        {
            if (parentNode.IsSelected)
            {
                selectedNode = parentNode;
            }
            else
            {
                foreach (TreeNode subNode in parentNode.Nodes)
                {
                    FindForm(subNode);
                }
            }
        }


        private void OpenForm(string formName, bool isTest, bool codec = true)
        {
            if (formName.Equals("Код Элайеса"))
            {
                if (codec)
                {
                    SystematicCode.ElaesaCode.FormElaesaTest1 form = new SystematicCode.ElaesaCode.FormElaesaTest1(isTest);
                    form.Show();
                }
                else
                {
                    SystematicCode.ElaesaCode.FormElaesaTest5 form = new SystematicCode.ElaesaCode.FormElaesaTest5(isTest);
                    form.Show();
                }
            }
            else if (formName.Equals("Код Варшамова"))
            {

            }
            else if (formName.Equals("Коды Рида-Милеера"))
            {
                if (codec)
                {
                    SystematicCode.Rida_MilleraCode.FormRida_MilleraTest1 form = new SystematicCode.Rida_MilleraCode.FormRida_MilleraTest1(isTest);
                    form.Show();
                }
                else
                {
                    SystematicCode.Rida_MilleraCode.FormRida_MilleraTest2 form = new SystematicCode.Rida_MilleraCode.FormRida_MilleraTest2(isTest);
                    form.Show();
                }
            }
            else if (formName.Equals("Код Хеминга 1"))
            {

                SystematicCode.HemingaCode.FormHemingaTest1 form = new SystematicCode.HemingaCode.FormHemingaTest1(isTest, codec);
                form.Show();
            }
            // cyclic codes
            else if (formName.Equals("Коды Абрамсона"))
            {

                CyclicCode.AbramsonaCode.FormAbramsTest1 form = new CyclicCode.AbramsonaCode.FormAbramsTest1(isTest,codec);
                form.Show();
            }
            else if (formName.Equals("Коды Файра"))
            {
                    FormFairaTest1 form = new FormFairaTest1(isTest, codec);
                    form.Show();
            }
            else if (formName.Equals("Код Хеминга 2"))
            {
                CyclicCode.HemingaCode.FormHemingaTest1 form = new CyclicCode.HemingaCode.FormHemingaTest1(isTest, codec);
                form.Show();
            }
            else if (formName.Equals("Код БЧХ"))
            {
                CyclicCode.BChHCode.FormBChHTest1 form = new CyclicCode.BChHCode.FormBChHTest1(isTest,codec);
                form.Show();
            }

            //non binary codes
            else if (formName.Equals("Первичные недвоичные коды"))
            {
                if (codec)
                {
                    Non_binaryCode.PrimaryNon_binaryCode.FormPrimaryNon_binaryTest1 form = new Non_binaryCode.PrimaryNon_binaryCode.FormPrimaryNon_binaryTest1(isTest);
                    form.Show();
                }
                else
                {
                    Non_binaryCode.PrimaryNon_binaryCode.FormPrimaryNon_binaryTest2 form = new Non_binaryCode.PrimaryNon_binaryCode.FormPrimaryNon_binaryTest2(isTest);
                    form.Show();
                }
            }
            else if (formName.Equals("Код с проверкой по модулю q"))
            {
                if (codec)
                {
                    Non_binaryCode.CodeWithModuleTest.FormModuleTest1 form = new Non_binaryCode.CodeWithModuleTest.FormModuleTest1(isTest);
                    form.Show();
                }
                else
                {
                    Non_binaryCode.CodeWithModuleTest.FormModuleTest6 form = new Non_binaryCode.CodeWithModuleTest.FormModuleTest6(isTest);
                    form.Show();
                }
            }
            else if (formName.Equals("Код с простым повторением"))
            {
                Non_binaryCode.CodeWithaSimpleIteration.FormIterationTest1 form = new Non_binaryCode.CodeWithaSimpleIteration.FormIterationTest1(isTest, codec);
                form.Show();
            }
            else if (formName.Equals("Итеративный код"))
            {
                if (codec)
                {
                    Non_binaryCode.IterativityCode.FormIterativityTest1 form = new Non_binaryCode.IterativityCode.FormIterativityTest1(isTest);
                    form.Show();
                }
                else
                {
                    Non_binaryCode.IterativityCode.FormIterativityTest5 form = new Non_binaryCode.IterativityCode.FormIterativityTest5(isTest);
                    form.Show();
                }
            }

            //other codes
            else if (formName.Equals("Код Грея"))
            {
                ElseCodeAndLabs.GrayCode.FormGrayTest1 form = new ElseCodeAndLabs.GrayCode.FormGrayTest1(isTest,codec);
                form.Show();
            }
            else if (formName.Equals("Двоично-десятичный код"))
            {
                FormDDCTest1 form = new FormDDCTest1(isTest, codec);
                form.Show();
            }
            else if (formName.Equals("Код Бергера"))
            {
                ElseCodeAndLabs.BergerCode.FormBergerTest1 form = new ElseCodeAndLabs.BergerCode.FormBergerTest1(isTest,codec);
                form.Show();
            }
            else if (formName.Equals("Код Шенона-Фано"))
            {
                ElseCodeAndLabs.Shenona_FanoCode.FormShenona_FanoTest1 form = new ElseCodeAndLabs.Shenona_FanoCode.FormShenona_FanoTest1(isTest);
                form.Show();
            }
            else if (formName.Equals("Код Хаффмена"))
            {
                ElseCodeAndLabs.HaffmenaCode.FormHaffmenaTest1 form = new ElseCodeAndLabs.HaffmenaCode.FormHaffmenaTest1();
                form.Show();
            }
            else if (formName.Equals("Коды-спутники"))
            {
                if (codec)
                {
                    ElseCodeAndLabs.SateliteCode.FormSateliteTest1 form = new ElseCodeAndLabs.SateliteCode.FormSateliteTest1(isTest);
                    form.Show();
                }
                else
                {
                    ElseCodeAndLabs.SateliteCode.FormSateliteTest4 form = new ElseCodeAndLabs.SateliteCode.FormSateliteTest4(isTest);
                    form.Show();
                }
            }
            else if (formName.Equals("Количество информации и энтропия"))
            {
                ElseCodeAndLabs.Entropy.FormEntropyTest1 form = new ElseCodeAndLabs.Entropy.FormEntropyTest1();
                form.Show();
            }
            else if (formName.Equals("Рекурентный код"))
            {
                if (codec)
                {
                    ElseCodeAndLabs.RekyrentCode.FormRekyrentTest1 form = new ElseCodeAndLabs.RekyrentCode.FormRekyrentTest1(isTest);
                    form.Show();
                }
                else
                {
                    ElseCodeAndLabs.RekyrentCode.FormRekyrentTest4 form = new ElseCodeAndLabs.RekyrentCode.FormRekyrentTest4(isTest);
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

            bool codec = (n == "Кодирование");

            OpenForm(selectedNode.Text, false, codec);
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

        private void FindTheory(TreeNode parentNode, bool isTest)
        {
            if (parentNode.IsSelected)
            {
                selectedNode = parentNode;
                OpenTheory(parentNode.Text, isTest);
            }
            else
            {
                foreach (TreeNode subNode in parentNode.Nodes)
                {
                    FindTheory(subNode, isTest);
                }
            }
        }

        private void OpenTheory(string formName, bool isTest)
        {
            if (formName.Equals("Код Элайеса"))
            {
                Theory teory = new Theory();
                teory.axAcroPDF1.src = @"D:\Education\XTestV1\XTest\Код Элайеса.pdf";
                teory.Show();
            }
            else if (formName.Equals("Код Варшамова"))
            {
                Theory teory = new Theory();
                teory.axAcroPDF1.src = @"D:\Education\XTestV1\XTest\Код Варшамова.pdf";
                teory.Show();
            }
            else if (formName.Equals("Коды Рида-Милеера"))
            {
                Theory teory = new Theory();
                teory.axAcroPDF1.src = @"D:\Education\XTestV1\XTest\Код Рида-Маллера.pdf";
                teory.Show();
            }
            else if (formName.Equals("Код Хеминга 1"))
            {
                Theory teory = new Theory();
                teory.axAcroPDF1.src = @"D:\Education\XTestV1\XTest\Код Хемминга.pdf";
                teory.Show();
            }

            // cyclic codes
            else if (formName.Equals("Коды Абрамсона"))
            {
                Theory teory = new Theory();
                teory.axAcroPDF1.src = @"D:\Education\XTestV1\XTest\Коды Абрамсона.pdf";
                teory.Show();
            }
            else if (formName.Equals("Коды Файра"))
            {
                Theory teory = new Theory();
                teory.axAcroPDF1.src = @"D:\Education\XTestV1\XTest\Код Файера.pdf";
                teory.Show();
            }
            else if (formName.Equals("Код Хеминга 2"))
            {
                Theory teory = new Theory();
                teory.axAcroPDF1.src = @"D:\Education\XTestV1\XTest\Цыкличный код Хемминга.pdf";
                teory.Show();
            }
            else if (formName.Equals("Код БЧХ"))
            {
                Theory teory = new Theory();
                teory.axAcroPDF1.src = @"D:\Education\XTestV1\XTest\Код БЧХ.pdf";
                teory.Show();
            }

            //non binary codes
            else if (formName.Equals("Первичные недвоичные коды"))
            {
                Theory teory = new Theory();
                teory.axAcroPDF1.src = @"D:\Education\XTestV1\XTest\Первчиные недвоичные коды.pdf";
                teory.Show();
            }
            else if (formName.Equals("Код с проверкой по модулю q"))
            {
                Theory teory = new Theory();
                teory.axAcroPDF1.src = @"D:\Education\XTestV1\XTest\Коды с проверкой по модулю q.pdf";
                teory.Show();
            }
            else if (formName.Equals("Код с простым повторением"))
            {
                Theory teory = new Theory();
                teory.axAcroPDF1.src = @"D:\Education\XTestV1\XTest\Код с простым повторением.pdf";
                teory.Show();
            }
            else if (formName.Equals("Итеративный код"))
            {
                Theory teory = new Theory();
                teory.axAcroPDF1.src = @"D:\Education\XTestV1\XTest\Итеративный код.pdf";
                teory.Show();
            }

            //other codes
            else if (formName.Equals("Код Грея"))
            {
                Theory teory = new Theory();
                teory.axAcroPDF1.src = @"D:\Education\XTestV1\XTest\Код Грея.pdf";
                teory.Show();
            }
            else if (formName.Equals("Двоично-десятичный код"))
            {
                Theory teory = new Theory();
                teory.axAcroPDF1.src = @"D:\Education\XTestV1\XTest\Двоично-десятичный код.pdf";
                teory.Show();
            }
            else if (formName.Equals("Код Бергера"))
            {
                Theory teory = new Theory();
                teory.axAcroPDF1.src = @"D:\Education\XTestV1\XTest\Код Бергера.pdf";
                teory.Show();
            }
            else if (formName.Equals("Код Шенона-Фано"))
            {
                Theory teory = new Theory();
                teory.axAcroPDF1.src = @"D:\Education\XTestV1\XTest\Код Шеннона-Фано.pdf";
                teory.Show();
            }
            else if (formName.Equals("Код Хаффмена"))
            {
                Theory teory = new Theory();
                teory.axAcroPDF1.src = @"D:\Education\XTestV1\XTest\Код Хаффмана.pdf";
                teory.Show();
            }
            else if (formName.Equals("Коды-спутники"))
            {
                Theory teory = new Theory();
                teory.axAcroPDF1.src = @"D:\Education\XTestV1\XTest\Коды-спутники.pdf";
                teory.Show();
            }
            else if (formName.Equals("Количество информации и энтропия"))
            {
                Theory teory = new Theory();
                teory.axAcroPDF1.src = @"D:\Education\XTestV1\XTest\Количество информации и энтропия.pdf";
                teory.Show();
            }
            else if (formName.Equals("Рекурентный код"))
            {

                Theory teory = new Theory();
                teory.axAcroPDF1.src = @"D:\Education\XTestV1\XTest\Рекурентный код.pdf";
                teory.Show();
            }
            else if (formName.Equals("Канальные коды"))
            {
                Theory teory = new Theory();
                teory.axAcroPDF1.src = @"D:\Education\XTestV1\XTest\Канальные коды.pdf";
                teory.Show();
            }

        }

        private void ButtonTheory_Click(object sender, EventArgs e)
        {
            FindTheory(a, true);
        }

        private void ButtonReport_Click_1(object sender, EventArgs e)
        {
            Report r = new Report();
            r.Show();
        }

        private void ButtonTest_Click_1(object sender, EventArgs e)
        {
            FindForm(a);
            OpenForm(selectedNode.Text, true);
        }
    }
}
