namespace XTest.CyclicCode.BChHCode
{
    partial class FormBChHTest1
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.ShowAnswer = new System.Windows.Forms.Button();
            this.Check = new System.Windows.Forms.Button();
            this.BtnNext = new System.Windows.Forms.Button();
            this.CheckingResultLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(22, 232);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(209, 20);
            this.textBox1.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 194);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Результат:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 136);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "10001110";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 113);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Закодируйте сообщение:";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(22, 69);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(117, 25);
            this.metroLabel1.TabIndex = 41;
            this.metroLabel1.Text = "Кодирование";
            // 
            // ShowAnswer
            // 
            this.ShowAnswer.Location = new System.Drawing.Point(8, 320);
            this.ShowAnswer.Margin = new System.Windows.Forms.Padding(2);
            this.ShowAnswer.Name = "ShowAnswer";
            this.ShowAnswer.Size = new System.Drawing.Size(76, 37);
            this.ShowAnswer.TabIndex = 44;
            this.ShowAnswer.Text = "Ответ";
            this.ShowAnswer.UseVisualStyleBackColor = true;
            // 
            // Check
            // 
            this.Check.Location = new System.Drawing.Point(88, 321);
            this.Check.Margin = new System.Windows.Forms.Padding(2);
            this.Check.Name = "Check";
            this.Check.Size = new System.Drawing.Size(76, 37);
            this.Check.TabIndex = 43;
            this.Check.Text = "Проверка";
            this.Check.UseVisualStyleBackColor = true;
            // 
            // BtnNext
            // 
            this.BtnNext.Location = new System.Drawing.Point(169, 321);
            this.BtnNext.Margin = new System.Windows.Forms.Padding(2);
            this.BtnNext.Name = "BtnNext";
            this.BtnNext.Size = new System.Drawing.Size(77, 37);
            this.BtnNext.TabIndex = 42;
            this.BtnNext.Text = "Далее";
            this.BtnNext.UseVisualStyleBackColor = true;
            // 
            // CheckingResultLabel
            // 
            this.CheckingResultLabel.AutoSize = true;
            this.CheckingResultLabel.Location = new System.Drawing.Point(32, 266);
            this.CheckingResultLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CheckingResultLabel.Name = "CheckingResultLabel";
            this.CheckingResultLabel.Size = new System.Drawing.Size(0, 13);
            this.CheckingResultLabel.TabIndex = 45;
            this.CheckingResultLabel.UseMnemonic = false;
            // 
            // FormBChHTest1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 366);
            this.Controls.Add(this.CheckingResultLabel);
            this.Controls.Add(this.ShowAnswer);
            this.Controls.Add(this.Check);
            this.Controls.Add(this.BtnNext);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormBChHTest1";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.Text = "Код БЧХ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.Button ShowAnswer;
        private System.Windows.Forms.Button Check;
        private System.Windows.Forms.Button BtnNext;
        private System.Windows.Forms.Label CheckingResultLabel;
    }
}