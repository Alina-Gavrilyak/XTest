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
            this.SuspendLayout();
            // 
            // TitleTask
            // 
            this.TitleTask.AutoSize = true;
            this.TitleTask.Location = new System.Drawing.Point(58, 127);
            this.TitleTask.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TitleTask.Name = "TitleTask";
            this.TitleTask.Size = new System.Drawing.Size(265, 25);
            this.TitleTask.TabIndex = 0;
            this.TitleTask.Text = "Закодируйте сообщение:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 177);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "11010010000";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 244);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Результат:";
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(70, 292);
            this.result.Margin = new System.Windows.Forms.Padding(4);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(350, 31);
            this.result.TabIndex = 3;
            // 
            // BtnNext
            // 
            this.BtnNext.Location = new System.Drawing.Point(370, 657);
            this.BtnNext.Margin = new System.Windows.Forms.Padding(4);
            this.BtnNext.Name = "BtnNext";
            this.BtnNext.Size = new System.Drawing.Size(154, 71);
            this.BtnNext.TabIndex = 4;
            this.BtnNext.Text = "Далее";
            this.BtnNext.UseVisualStyleBackColor = true;
            this.BtnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // CheckingResultLabel
            // 
            this.CheckingResultLabel.AutoSize = true;
            this.CheckingResultLabel.Location = new System.Drawing.Point(118, 567);
            this.CheckingResultLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CheckingResultLabel.Name = "CheckingResultLabel";
            this.CheckingResultLabel.Size = new System.Drawing.Size(0, 25);
            this.CheckingResultLabel.TabIndex = 5;
            this.CheckingResultLabel.UseMnemonic = false;
            // 
            // Check
            // 
            this.Check.Location = new System.Drawing.Point(208, 657);
            this.Check.Margin = new System.Windows.Forms.Padding(4);
            this.Check.Name = "Check";
            this.Check.Size = new System.Drawing.Size(152, 71);
            this.Check.TabIndex = 6;
            this.Check.Text = "Проверка";
            this.Check.UseVisualStyleBackColor = true;
            this.Check.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // ShowAnswer
            // 
            this.ShowAnswer.Location = new System.Drawing.Point(48, 656);
            this.ShowAnswer.Margin = new System.Windows.Forms.Padding(4);
            this.ShowAnswer.Name = "ShowAnswer";
            this.ShowAnswer.Size = new System.Drawing.Size(152, 71);
            this.ShowAnswer.TabIndex = 7;
            this.ShowAnswer.Text = "Ответ";
            this.ShowAnswer.UseVisualStyleBackColor = true;
            this.ShowAnswer.Click += new System.EventHandler(this.ShowAnswer_Click);
            // 
            // FormHemingaTest1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 763);
            this.Controls.Add(this.ShowAnswer);
            this.Controls.Add(this.Check);
            this.Controls.Add(this.CheckingResultLabel);
            this.Controls.Add(this.BtnNext);
            this.Controls.Add(this.result);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TitleTask);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormHemingaTest1";
            this.Padding = new System.Windows.Forms.Padding(30, 115, 30, 31);
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.Text = "Кодирование";
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
    }
}