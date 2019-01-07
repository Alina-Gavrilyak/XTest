namespace XTest.SystematicCode.HemingaCode
{
    partial class FormHemingaTest1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TitleTask = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.TextBox();
            this.BtnNext = new System.Windows.Forms.Button();
            this.CheckingResultLabel = new System.Windows.Forms.Label();
            this.Check = new System.Windows.Forms.Button();
            this.ShowAnswer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TitleTask
            // 
            this.TitleTask.AutoSize = true;
            this.TitleTask.Location = new System.Drawing.Point(21, 102);
            this.TitleTask.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TitleTask.Name = "TitleTask";
            this.TitleTask.Size = new System.Drawing.Size(135, 13);
            this.TitleTask.TabIndex = 0;
            this.TitleTask.Text = "Закодируйте сообщение:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 128);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "11010010000";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 163);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Результат:";
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(27, 188);
            this.result.Margin = new System.Windows.Forms.Padding(2);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(177, 20);
            this.result.TabIndex = 3;
            // 
            // BtnNext
            // 
            this.BtnNext.Location = new System.Drawing.Point(185, 342);
            this.BtnNext.Margin = new System.Windows.Forms.Padding(2);
            this.BtnNext.Name = "BtnNext";
            this.BtnNext.Size = new System.Drawing.Size(77, 37);
            this.BtnNext.TabIndex = 4;
            this.BtnNext.Text = "Далее";
            this.BtnNext.UseVisualStyleBackColor = true;
            this.BtnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // CheckingResultLabel
            // 
            this.CheckingResultLabel.AutoSize = true;
            this.CheckingResultLabel.Location = new System.Drawing.Point(59, 295);
            this.CheckingResultLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CheckingResultLabel.Name = "CheckingResultLabel";
            this.CheckingResultLabel.Size = new System.Drawing.Size(0, 13);
            this.CheckingResultLabel.TabIndex = 5;
            this.CheckingResultLabel.UseMnemonic = false;
            // 
            // Check
            // 
            this.Check.Location = new System.Drawing.Point(104, 342);
            this.Check.Margin = new System.Windows.Forms.Padding(2);
            this.Check.Name = "Check";
            this.Check.Size = new System.Drawing.Size(76, 37);
            this.Check.TabIndex = 6;
            this.Check.Text = "Проверка";
            this.Check.UseVisualStyleBackColor = true;
            this.Check.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // ShowAnswer
            // 
            this.ShowAnswer.Location = new System.Drawing.Point(24, 342);
            this.ShowAnswer.Margin = new System.Windows.Forms.Padding(2);
            this.ShowAnswer.Name = "ShowAnswer";
            this.ShowAnswer.Size = new System.Drawing.Size(76, 37);
            this.ShowAnswer.TabIndex = 7;
            this.ShowAnswer.Text = "Ответ";
            this.ShowAnswer.UseVisualStyleBackColor = true;
            this.ShowAnswer.Click += new System.EventHandler(this.ShowAnswer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(24, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Кодирование";
            // 
            // FormHemingaTest1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 397);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ShowAnswer);
            this.Controls.Add(this.Check);
            this.Controls.Add(this.CheckingResultLabel);
            this.Controls.Add(this.BtnNext);
            this.Controls.Add(this.result);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TitleTask);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormHemingaTest1";
            this.Padding = new System.Windows.Forms.Padding(15, 60, 15, 16);
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.Text = "Код Хемминга";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleTask;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.Button BtnNext;
        private System.Windows.Forms.Label CheckingResultLabel;
        private System.Windows.Forms.Button Check;
        private System.Windows.Forms.Button ShowAnswer;
        private System.Windows.Forms.Label label1;
    }
}