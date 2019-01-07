namespace XTest
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.TreeOfMethods = new System.Windows.Forms.TreeView();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btn_White = new MetroFramework.Controls.MetroButton();
            this.btn_Black = new MetroFramework.Controls.MetroButton();
            this.ButtonTraining = new MetroFramework.Controls.MetroButton();
            this.ButtonTheory = new MetroFramework.Controls.MetroButton();
            this.ButtonReport = new MetroFramework.Controls.MetroButton();
            this.ButtonTest = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // TreeOfMethods
            // 
            this.TreeOfMethods.BackColor = System.Drawing.Color.White;
            this.TreeOfMethods.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TreeOfMethods.Location = new System.Drawing.Point(12, 39);
            this.TreeOfMethods.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TreeOfMethods.Name = "TreeOfMethods";
            this.TreeOfMethods.Size = new System.Drawing.Size(459, 379);
            this.TreeOfMethods.TabIndex = 4;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.metroLabel1.Location = new System.Drawing.Point(3, 6);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(0, 0);
            this.metroLabel1.TabIndex = 5;
            // 
            // btn_White
            // 
            this.btn_White.Location = new System.Drawing.Point(289, 6);
            this.btn_White.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_White.Name = "btn_White";
            this.btn_White.Size = new System.Drawing.Size(25, 27);
            this.btn_White.Style = MetroFramework.MetroColorStyle.White;
            this.btn_White.TabIndex = 6;
            this.btn_White.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btn_White.Click += new System.EventHandler(this.btn_White_Click);
            // 
            // btn_Black
            // 
            this.btn_Black.Location = new System.Drawing.Point(323, 6);
            this.btn_Black.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Black.Name = "btn_Black";
            this.btn_Black.Size = new System.Drawing.Size(27, 27);
            this.btn_Black.Style = MetroFramework.MetroColorStyle.Black;
            this.btn_Black.TabIndex = 7;
            this.btn_Black.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btn_Black.Click += new System.EventHandler(this.btn_Dark_Click);
            // 
            // ButtonTraining
            // 
            this.ButtonTraining.Location = new System.Drawing.Point(240, 426);
            this.ButtonTraining.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ButtonTraining.Name = "ButtonTraining";
            this.ButtonTraining.Size = new System.Drawing.Size(188, 54);
            this.ButtonTraining.TabIndex = 8;
            this.ButtonTraining.Text = "Обучение";
            this.ButtonTraining.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ButtonTraining.Click += new System.EventHandler(this.ButtonTraining_Click_1);
            // 
            // ButtonTheory
            // 
            this.ButtonTheory.Location = new System.Drawing.Point(12, 426);
            this.ButtonTheory.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ButtonTheory.Name = "ButtonTheory";
            this.ButtonTheory.Size = new System.Drawing.Size(216, 55);
            this.ButtonTheory.TabIndex = 9;
            this.ButtonTheory.Text = "Теория";
            this.ButtonTheory.Click += new System.EventHandler(this.ButtonTheory_Click);
            // 
            // ButtonReport
            // 
            this.ButtonReport.Location = new System.Drawing.Point(12, 492);
            this.ButtonReport.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ButtonReport.Name = "ButtonReport";
            this.ButtonReport.Size = new System.Drawing.Size(216, 46);
            this.ButtonReport.TabIndex = 10;
            this.ButtonReport.Text = "Отчет";
            this.ButtonReport.Click += new System.EventHandler(this.ButtonReport_Click_1);
            // 
            // ButtonTest
            // 
            this.ButtonTest.Location = new System.Drawing.Point(240, 491);
            this.ButtonTest.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ButtonTest.Name = "ButtonTest";
            this.ButtonTest.Size = new System.Drawing.Size(188, 46);
            this.ButtonTest.TabIndex = 11;
            this.ButtonTest.Text = "Тест";
            this.ButtonTest.Click += new System.EventHandler(this.ButtonTest_Click_1);
            // 
            // MainForm
            // 
            this.AccessibleName = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(440, 551);
            this.Controls.Add(this.ButtonTest);
            this.Controls.Add(this.ButtonReport);
            this.Controls.Add(this.ButtonTheory);
            this.Controls.Add(this.ButtonTraining);
            this.Controls.Add(this.btn_Black);
            this.Controls.Add(this.btn_White);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.TreeOfMethods);
            this.DisplayHeader = false;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(27, 37, 27, 25);
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroForm.MetroFormShadowType.Flat;
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TreeView TreeOfMethods;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton btn_White;
        private MetroFramework.Controls.MetroButton btn_Black;
        private MetroFramework.Controls.MetroButton ButtonTraining;
        private MetroFramework.Controls.MetroButton ButtonTheory;
        private MetroFramework.Controls.MetroButton ButtonReport;
        private MetroFramework.Controls.MetroButton ButtonTest;
    }
}

