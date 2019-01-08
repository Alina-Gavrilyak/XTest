namespace XTest
{
    partial class FormDDCTest1
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
            this.taskLabelTitle = new System.Windows.Forms.Label();
            this.taskLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.TextBox();
            this.labelResult = new System.Windows.Forms.Label();
            this.titleLabel = new MetroFramework.Controls.MetroLabel();
            this.ShowAnswer = new System.Windows.Forms.Button();
            this.btnCheck = new System.Windows.Forms.Button();
            this.BtnNext = new System.Windows.Forms.Button();
            this.CheckingResultLabel = new System.Windows.Forms.Label();
            this.codeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // taskLabelTitle
            // 
            this.taskLabelTitle.AutoSize = true;
            this.taskLabelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.taskLabelTitle.Location = new System.Drawing.Point(64, 223);
            this.taskLabelTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.taskLabelTitle.Name = "taskLabelTitle";
            this.taskLabelTitle.Size = new System.Drawing.Size(373, 37);
            this.taskLabelTitle.TabIndex = 0;
            this.taskLabelTitle.Text = "Закодируйте сообщение:";
            // 
            // taskLabel
            // 
            this.taskLabel.AutoSize = true;
            this.taskLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.taskLabel.Location = new System.Drawing.Point(65, 279);
            this.taskLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.taskLabel.Name = "taskLabel";
            this.taskLabel.Size = new System.Drawing.Size(89, 37);
            this.taskLabel.TabIndex = 1;
            this.taskLabel.Text = "0284";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(65, 338);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 37);
            this.label3.TabIndex = 2;
            this.label3.Text = "Код:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(64, 433);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 37);
            this.label4.TabIndex = 3;
            this.label4.Text = "Результат:";
            // 
            // result
            // 
            this.result.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.result.Location = new System.Drawing.Point(72, 502);
            this.result.Margin = new System.Windows.Forms.Padding(4);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(510, 44);
            this.result.TabIndex = 4;
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelResult.Location = new System.Drawing.Point(102, 650);
            this.labelResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(0, 52);
            this.labelResult.TabIndex = 6;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.titleLabel.Location = new System.Drawing.Point(46, 140);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(117, 25);
            this.titleLabel.TabIndex = 37;
            this.titleLabel.Text = "Кодирование";
            // 
            // ShowAnswer
            // 
            this.ShowAnswer.Location = new System.Drawing.Point(108, 648);
            this.ShowAnswer.Margin = new System.Windows.Forms.Padding(4);
            this.ShowAnswer.Name = "ShowAnswer";
            this.ShowAnswer.Size = new System.Drawing.Size(152, 71);
            this.ShowAnswer.TabIndex = 51;
            this.ShowAnswer.Text = "Ответ";
            this.ShowAnswer.UseVisualStyleBackColor = true;
            this.ShowAnswer.Click += new System.EventHandler(this.ShowAnswer_Click);
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(268, 646);
            this.btnCheck.Margin = new System.Windows.Forms.Padding(4);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(152, 71);
            this.btnCheck.TabIndex = 50;
            this.btnCheck.Text = "Проверка";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // BtnNext
            // 
            this.BtnNext.Location = new System.Drawing.Point(428, 646);
            this.BtnNext.Margin = new System.Windows.Forms.Padding(4);
            this.BtnNext.Name = "BtnNext";
            this.BtnNext.Size = new System.Drawing.Size(154, 71);
            this.BtnNext.TabIndex = 52;
            this.BtnNext.Text = "Далее";
            this.BtnNext.UseVisualStyleBackColor = true;
            this.BtnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // CheckingResultLabel
            // 
            this.CheckingResultLabel.AutoSize = true;
            this.CheckingResultLabel.Location = new System.Drawing.Point(76, 579);
            this.CheckingResultLabel.Name = "CheckingResultLabel";
            this.CheckingResultLabel.Size = new System.Drawing.Size(0, 25);
            this.CheckingResultLabel.TabIndex = 53;
            // 
            // codeLabel
            // 
            this.codeLabel.AutoSize = true;
            this.codeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.codeLabel.Location = new System.Drawing.Point(163, 338);
            this.codeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.codeLabel.Name = "codeLabel";
            this.codeLabel.Size = new System.Drawing.Size(73, 37);
            this.codeLabel.TabIndex = 54;
            this.codeLabel.Text = "Код";
            this.codeLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // FormDDCTest1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 754);
            this.Controls.Add(this.codeLabel);
            this.Controls.Add(this.CheckingResultLabel);
            this.Controls.Add(this.BtnNext);
            this.Controls.Add(this.ShowAnswer);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.result);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.taskLabel);
            this.Controls.Add(this.taskLabelTitle);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormDDCTest1";
            this.Padding = new System.Windows.Forms.Padding(40, 115, 40, 38);
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.Text = "Двоично-десятичный код";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label taskLabelTitle;
        private System.Windows.Forms.Label taskLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.Label labelResult;
        private MetroFramework.Controls.MetroLabel titleLabel;
        private System.Windows.Forms.Button ShowAnswer;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Button BtnNext;
        private System.Windows.Forms.Label CheckingResultLabel;
        private System.Windows.Forms.Label codeLabel;
    }
}