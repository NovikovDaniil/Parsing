namespace Easy_Parser
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
            this.RosBankLabel = new System.Windows.Forms.Label();
            this.SberBankLabel = new System.Windows.Forms.Label();
            this.VTBLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.RossTextBox = new System.Windows.Forms.TextBox();
            this.SberTextBox = new System.Windows.Forms.TextBox();
            this.VTBTextBox = new System.Windows.Forms.TextBox();
            this.getDataButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // RosBankLabel
            // 
            this.RosBankLabel.AutoSize = true;
            this.RosBankLabel.Location = new System.Drawing.Point(12, 52);
            this.RosBankLabel.Name = "RosBankLabel";
            this.RosBankLabel.Size = new System.Drawing.Size(163, 25);
            this.RosBankLabel.TabIndex = 0;
            this.RosBankLabel.Text = "РоссельхозБанк";
            // 
            // SberBankLabel
            // 
            this.SberBankLabel.AutoSize = true;
            this.SberBankLabel.Location = new System.Drawing.Point(12, 108);
            this.SberBankLabel.Name = "SberBankLabel";
            this.SberBankLabel.Size = new System.Drawing.Size(100, 25);
            this.SberBankLabel.TabIndex = 1;
            this.SberBankLabel.Text = "Сбербанк";
            // 
            // VTBLabel
            // 
            this.VTBLabel.AutoSize = true;
            this.VTBLabel.Location = new System.Drawing.Point(12, 166);
            this.VTBLabel.Name = "VTBLabel";
            this.VTBLabel.Size = new System.Drawing.Size(48, 25);
            this.VTBLabel.TabIndex = 2;
            this.VTBLabel.Text = "ВТБ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(211, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Покупка";
            // 
            // RossTextBox
            // 
            this.RossTextBox.Location = new System.Drawing.Point(193, 52);
            this.RossTextBox.Name = "RossTextBox";
            this.RossTextBox.Size = new System.Drawing.Size(147, 30);
            this.RossTextBox.TabIndex = 9;
            // 
            // SberTextBox
            // 
            this.SberTextBox.Location = new System.Drawing.Point(193, 105);
            this.SberTextBox.Name = "SberTextBox";
            this.SberTextBox.Size = new System.Drawing.Size(147, 30);
            this.SberTextBox.TabIndex = 10;
            // 
            // VTBTextBox
            // 
            this.VTBTextBox.Location = new System.Drawing.Point(193, 163);
            this.VTBTextBox.Name = "VTBTextBox";
            this.VTBTextBox.Size = new System.Drawing.Size(147, 30);
            this.VTBTextBox.TabIndex = 11;
            // 
            // getDataButton
            // 
            this.getDataButton.Location = new System.Drawing.Point(17, 210);
            this.getDataButton.Name = "getDataButton";
            this.getDataButton.Size = new System.Drawing.Size(323, 42);
            this.getDataButton.TabIndex = 12;
            this.getDataButton.Text = "Получить данные";
            this.getDataButton.UseVisualStyleBackColor = true;
            this.getDataButton.Click += new System.EventHandler(this.getDataButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(370, 19);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(347, 308);
            this.textBox1.TabIndex = 13;
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(729, 393);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.getDataButton);
            this.Controls.Add(this.VTBTextBox);
            this.Controls.Add(this.SberTextBox);
            this.Controls.Add(this.RossTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.VTBLabel);
            this.Controls.Add(this.SberBankLabel);
            this.Controls.Add(this.RosBankLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "MainForm";
            this.Text = "Курсы валют ($)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label RosBankLabel;
        private System.Windows.Forms.Label SberBankLabel;
        private System.Windows.Forms.Label VTBLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox RossTextBox;
        private System.Windows.Forms.TextBox SberTextBox;
        private System.Windows.Forms.TextBox VTBTextBox;
        private System.Windows.Forms.Button getDataButton;
        private System.Windows.Forms.TextBox textBox1;
    }
}

