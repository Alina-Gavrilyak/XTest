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
            this.ButtonReport = new System.Windows.Forms.Button();
            this.ButtonTest = new System.Windows.Forms.Button();
            this.ButtonTрeory = new System.Windows.Forms.Button();
            this.ButtonTraining = new System.Windows.Forms.Button();
            this.TreeOfMethods = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // ButtonReport
            // 
            this.ButtonReport.Location = new System.Drawing.Point(13, 487);
            this.ButtonReport.Name = "ButtonReport";
            this.ButtonReport.Size = new System.Drawing.Size(188, 53);
            this.ButtonReport.TabIndex = 0;
            this.ButtonReport.Text = "Отчёт";
            this.ButtonReport.UseVisualStyleBackColor = true;
            this.ButtonReport.Click += new System.EventHandler(this.ButtonReport_Click);
            // 
            // ButtonTest
            // 
            this.ButtonTest.Location = new System.Drawing.Point(207, 487);
            this.ButtonTest.Name = "ButtonTest";
            this.ButtonTest.Size = new System.Drawing.Size(178, 53);
            this.ButtonTest.TabIndex = 1;
            this.ButtonTest.Text = "Тест";
            this.ButtonTest.UseVisualStyleBackColor = true;
            this.ButtonTest.Click += new System.EventHandler(this.ButtonTest_Click);
            // 
            // ButtonTрeory
            // 
            this.ButtonTрeory.Location = new System.Drawing.Point(13, 423);
            this.ButtonTрeory.Name = "ButtonTрeory";
            this.ButtonTрeory.Size = new System.Drawing.Size(188, 58);
            this.ButtonTрeory.TabIndex = 2;
            this.ButtonTрeory.Text = "Теория";
            this.ButtonTрeory.UseVisualStyleBackColor = true;
            this.ButtonTрeory.Click += new System.EventHandler(this.ButtonTрeory_Click);
            // 
            // ButtonTraining
            // 
            this.ButtonTraining.Location = new System.Drawing.Point(207, 423);
            this.ButtonTraining.Name = "ButtonTraining";
            this.ButtonTraining.Size = new System.Drawing.Size(178, 58);
            this.ButtonTraining.TabIndex = 3;
            this.ButtonTraining.Text = "Обучение";
            this.ButtonTraining.UseVisualStyleBackColor = true;
            this.ButtonTraining.Click += new System.EventHandler(this.ButtonTraining_Click);
            // 
            // TreeOfMethods
            // 
            this.TreeOfMethods.CheckBoxes = true;
            this.TreeOfMethods.Location = new System.Drawing.Point(13, 13);
            this.TreeOfMethods.Name = "TreeOfMethods";
            this.TreeOfMethods.Size = new System.Drawing.Size(372, 404);
            this.TreeOfMethods.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 552);
            this.Controls.Add(this.TreeOfMethods);
            this.Controls.Add(this.ButtonTraining);
            this.Controls.Add(this.ButtonTрeory);
            this.Controls.Add(this.ButtonTest);
            this.Controls.Add(this.ButtonReport);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "XTest++";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonReport;
        private System.Windows.Forms.Button ButtonTest;
        private System.Windows.Forms.Button ButtonTрeory;
        private System.Windows.Forms.Button ButtonTraining;
        private System.Windows.Forms.TreeView TreeOfMethods;
    }
}

