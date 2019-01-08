namespace XTest.Non_binaryCode.CodeWithaSimpleIteration
{
    partial class FormIterationTest1
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
            this.result = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.taskLabel = new System.Windows.Forms.Label();
            this.taskLabelTitle = new System.Windows.Forms.Label();
            this.titleLabel = new MetroFramework.Controls.MetroLabel();
            this.ShowAnswer = new System.Windows.Forms.Button();
            this.Check = new System.Windows.Forms.Button();
            this.CheckingResultLabel = new System.Windows.Forms.Label();
            this.BtnNext = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(71, 422);
            this.result.Margin = new System.Windows.Forms.Padding(4);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(350, 31);
            this.result.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 374);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 25);
            this.label3.TabIndex = 13;
            this.label3.Text = "Результат:";
            // 
            // taskLabel
            // 
            this.taskLabel.AutoSize = true;
            this.taskLabel.Location = new System.Drawing.Point(70, 281);
            this.taskLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.taskLabel.Name = "taskLabel";
            this.taskLabel.Size = new System.Drawing.Size(204, 25);
            this.taskLabel.TabIndex = 12;
            this.taskLabel.Text = "4556135484621654";
            // 
            // taskLabelTitle
            // 
            this.taskLabelTitle.AutoSize = true;
            this.taskLabelTitle.Location = new System.Drawing.Point(66, 231);
            this.taskLabelTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.taskLabelTitle.Name = "taskLabelTitle";
            this.taskLabelTitle.Size = new System.Drawing.Size(265, 25);
            this.taskLabelTitle.TabIndex = 11;
            this.taskLabelTitle.Text = "Закодируйте сообщение:";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.titleLabel.Location = new System.Drawing.Point(56, 133);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(108, 25);
            this.titleLabel.TabIndex = 16;
            this.titleLabel.Text = "Кодировние";
            // 
            // ShowAnswer
            // 
            this.ShowAnswer.Location = new System.Drawing.Point(152, 546);
            this.ShowAnswer.Margin = new System.Windows.Forms.Padding(4);
            this.ShowAnswer.Name = "ShowAnswer";
            this.ShowAnswer.Size = new System.Drawing.Size(152, 71);
            this.ShowAnswer.TabIndex = 49;
            this.ShowAnswer.Text = "Ответ";
            this.ShowAnswer.UseVisualStyleBackColor = true;
            this.ShowAnswer.Click += new System.EventHandler(this.ShowAnswer_Click);
            // 
            // Check
            // 
            this.Check.Location = new System.Drawing.Point(312, 546);
            this.Check.Margin = new System.Windows.Forms.Padding(4);
            this.Check.Name = "Check";
            this.Check.Size = new System.Drawing.Size(152, 71);
            this.Check.TabIndex = 48;
            this.Check.Text = "Проверка";
            this.Check.UseVisualStyleBackColor = true;
            this.Check.Click += new System.EventHandler(this.Check_Click);
            // 
            // CheckingResultLabel
            // 
            this.CheckingResultLabel.AutoSize = true;
            this.CheckingResultLabel.Location = new System.Drawing.Point(80, 482);
            this.CheckingResultLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CheckingResultLabel.Name = "CheckingResultLabel";
            this.CheckingResultLabel.Size = new System.Drawing.Size(0, 25);
            this.CheckingResultLabel.TabIndex = 50;
            // 
            // BtnNext
            // 
            this.BtnNext.Location = new System.Drawing.Point(472, 546);
            this.BtnNext.Margin = new System.Windows.Forms.Padding(4);
            this.BtnNext.Name = "BtnNext";
            this.BtnNext.Size = new System.Drawing.Size(154, 71);
            this.BtnNext.TabIndex = 51;
            this.BtnNext.Text = "Далее";
            this.BtnNext.UseVisualStyleBackColor = true;
            this.BtnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // FormIterationTest1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 660);
            this.Controls.Add(this.BtnNext);
            this.Controls.Add(this.CheckingResultLabel);
            this.Controls.Add(this.ShowAnswer);
            this.Controls.Add(this.Check);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.result);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.taskLabel);
            this.Controls.Add(this.taskLabelTitle);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormIterationTest1";
            this.Padding = new System.Windows.Forms.Padding(30, 115, 30, 31);
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.Text = "Код с простым повторением";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label taskLabel;
        private System.Windows.Forms.Label taskLabelTitle;
        private MetroFramework.Controls.MetroLabel titleLabel;
        private System.Windows.Forms.Button ShowAnswer;
        private System.Windows.Forms.Button Check;
        private System.Windows.Forms.Label CheckingResultLabel;
        private System.Windows.Forms.Button BtnNext;
    }
}