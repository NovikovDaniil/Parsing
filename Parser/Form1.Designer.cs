namespace Parser
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.startNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.endNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.parsingButton = new System.Windows.Forms.Button();
            this.abortButton = new System.Windows.Forms.Button();
            this.resultListBox = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.startNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.endNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(510, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Начальная страница";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(510, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Конечная страница";
            // 
            // startNumericUpDown
            // 
            this.startNumericUpDown.Location = new System.Drawing.Point(513, 46);
            this.startNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.startNumericUpDown.Name = "startNumericUpDown";
            this.startNumericUpDown.Size = new System.Drawing.Size(144, 22);
            this.startNumericUpDown.TabIndex = 3;
            this.startNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // endNumericUpDown
            // 
            this.endNumericUpDown.Location = new System.Drawing.Point(513, 110);
            this.endNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.endNumericUpDown.Name = "endNumericUpDown";
            this.endNumericUpDown.Size = new System.Drawing.Size(144, 22);
            this.endNumericUpDown.TabIndex = 4;
            this.endNumericUpDown.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // parsingButton
            // 
            this.parsingButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.parsingButton.Location = new System.Drawing.Point(513, 367);
            this.parsingButton.Name = "parsingButton";
            this.parsingButton.Size = new System.Drawing.Size(144, 52);
            this.parsingButton.TabIndex = 5;
            this.parsingButton.Text = "Start";
            this.parsingButton.UseVisualStyleBackColor = true;
            this.parsingButton.Click += new System.EventHandler(this.parsingButton_Click);
            // 
            // abortButton
            // 
            this.abortButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.abortButton.Location = new System.Drawing.Point(513, 435);
            this.abortButton.Name = "abortButton";
            this.abortButton.Size = new System.Drawing.Size(144, 49);
            this.abortButton.TabIndex = 6;
            this.abortButton.Text = "Abort";
            this.abortButton.UseVisualStyleBackColor = true;
            this.abortButton.Click += new System.EventHandler(this.abortButton_Click);
            // 
            // resultListBox
            // 
            this.resultListBox.FormattingEnabled = true;
            this.resultListBox.ItemHeight = 16;
            this.resultListBox.Location = new System.Drawing.Point(13, 23);
            this.resultListBox.Name = "resultListBox";
            this.resultListBox.Size = new System.Drawing.Size(491, 468);
            this.resultListBox.TabIndex = 7;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 496);
            this.Controls.Add(this.resultListBox);
            this.Controls.Add(this.abortButton);
            this.Controls.Add(this.parsingButton);
            this.Controls.Add(this.endNumericUpDown);
            this.Controls.Add(this.startNumericUpDown);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "Парсер";
            ((System.ComponentModel.ISupportInitialize)(this.startNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.endNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown startNumericUpDown;
        private System.Windows.Forms.NumericUpDown endNumericUpDown;
        private System.Windows.Forms.Button parsingButton;
        private System.Windows.Forms.Button abortButton;
        private System.Windows.Forms.ListBox resultListBox;
    }
}

