namespace XTest.CyclicCode.AbramsonaCode
{
    partial class FormAbramsTest1
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
            this.BtnNext = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.taskLabel = new System.Windows.Forms.Label();
            this.taskLabelTitle = new System.Windows.Forms.Label();
            this.titleName = new MetroFramework.Controls.MetroLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.polynomLabel = new System.Windows.Forms.Label();
            this.ShowAnswer = new System.Windows.Forms.Button();
            this.btnCheck = new System.Windows.Forms.Button();
            this.CheckingResultLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnNext
            // 
            this.BtnNext.Location = new System.Drawing.Point(372, 562);
            this.BtnNext.Margin = new System.Windows.Forms.Padding(4);
            this.BtnNext.Name = "BtnNext";
            this.BtnNext.Size = new System.Drawing.Size(154, 71);
            this.BtnNext.TabIndex = 9;
            this.BtnNext.Text = "Далее";
            this.BtnNext.UseVisualStyleBackColor = true;
            this.BtnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(50, 456);
            this.result.Margin = new System.Windows.Forms.Padding(4);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(388, 31);
            this.result.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 388);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Результат:";
            // 
            // taskLabel
            // 
            this.taskLabel.AutoSize = true;
            this.taskLabel.Location = new System.Drawing.Point(44, 275);
            this.taskLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.taskLabel.Name = "taskLabel";
            this.taskLabel.Size = new System.Drawing.Size(144, 25);
            this.taskLabel.TabIndex = 6;
            this.taskLabel.Text = "11010010000";
            // 
            // taskLabelTitle
            // 
            this.taskLabelTitle.AutoSize = true;
            this.taskLabelTitle.Location = new System.Drawing.Point(44, 215);
            this.taskLabelTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.taskLabelTitle.Name = "taskLabelTitle";
            this.taskLabelTitle.Size = new System.Drawing.Size(265, 25);
            this.taskLabelTitle.TabIndex = 5;
            this.taskLabelTitle.Text = "Закодируйте сообщение:";
            // 
            // titleName
            // 
            this.titleName.AutoSize = true;
            this.titleName.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.titleName.Location = new System.Drawing.Point(46, 135);
            this.titleName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.titleName.Name = "titleName";
            this.titleName.Size = new System.Drawing.Size(117, 25);
            this.titleName.TabIndex = 42;
            this.titleName.Text = "Кодирование";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(414, 342);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 25);
            this.label5.TabIndex = 46;
            this.label5.Text = "P1: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 342);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(354, 25);
            this.label4.TabIndex = 45;
            this.label4.Text = "Известен неприводимый полином";
            // 
            // polynomLabel
            // 
            this.polynomLabel.AutoSize = true;
            this.polynomLabel.Location = new System.Drawing.Point(461, 342);
            this.polynomLabel.Name = "polynomLabel";
            this.polynomLabel.Size = new System.Drawing.Size(19, 25);
            this.polynomLabel.TabIndex = 47;
            this.polynomLabel.Text = "-";
            // 
            // ShowAnswer
            // 
            this.ShowAnswer.Location = new System.Drawing.Point(52, 560);
            this.ShowAnswer.Margin = new System.Windows.Forms.Padding(4);
            this.ShowAnswer.Name = "ShowAnswer";
            this.ShowAnswer.Size = new System.Drawing.Size(152, 71);
            this.ShowAnswer.TabIndex = 49;
            this.ShowAnswer.Text = "Ответ";
            this.ShowAnswer.UseVisualStyleBackColor = true;
            this.ShowAnswer.Click += new System.EventHandler(this.ShowAnswer_Click);
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(212, 562);
            this.btnCheck.Margin = new System.Windows.Forms.Padding(4);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(152, 71);
            this.btnCheck.TabIndex = 48;
            this.btnCheck.Text = "Проверка";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // CheckingResultLabel
            // 
            this.CheckingResultLabel.AutoSize = true;
            this.CheckingResultLabel.Location = new System.Drawing.Point(52, 510);
            this.CheckingResultLabel.Name = "CheckingResultLabel";
            this.CheckingResultLabel.Size = new System.Drawing.Size(0, 25);
            this.CheckingResultLabel.TabIndex = 50;
            // 
            // FormAbramsTest1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 675);
            this.Controls.Add(this.CheckingResultLabel);
            this.Controls.Add(this.ShowAnswer);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.polynomLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.titleName);
            this.Controls.Add(this.BtnNext);
            this.Controls.Add(this.result);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.taskLabel);
            this.Controls.Add(this.taskLabelTitle);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormAbramsTest1";
            this.Padding = new System.Windows.Forms.Padding(40, 115, 40, 38);
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.Text = "Код Абрамсона";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnNext;
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label taskLabel;
        private System.Windows.Forms.Label taskLabelTitle;
        private MetroFramework.Controls.MetroLabel titleName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label polynomLabel;
        private System.Windows.Forms.Button ShowAnswer;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Label CheckingResultLabel;
    }
}