namespace LAB11
{
    partial class Form1
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
            this.RValueTB = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.LValueTB = new System.Windows.Forms.NumericUpDown();
            this.CipherButton = new System.Windows.Forms.Button();
            this.AnswerTB = new System.Windows.Forms.RichTextBox();
            this.DecipherButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.RValueTB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LValueTB)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите R";
            // 
            // RValueTB
            // 
            this.RValueTB.Location = new System.Drawing.Point(93, 8);
            this.RValueTB.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.RValueTB.Name = "RValueTB";
            this.RValueTB.Size = new System.Drawing.Size(301, 23);
            this.RValueTB.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Введите L";
            // 
            // LValueTB
            // 
            this.LValueTB.Location = new System.Drawing.Point(93, 42);
            this.LValueTB.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.LValueTB.Name = "LValueTB";
            this.LValueTB.Size = new System.Drawing.Size(302, 23);
            this.LValueTB.TabIndex = 3;
            // 
            // CipherButton
            // 
            this.CipherButton.Location = new System.Drawing.Point(12, 73);
            this.CipherButton.Name = "CipherButton";
            this.CipherButton.Size = new System.Drawing.Size(168, 34);
            this.CipherButton.TabIndex = 4;
            this.CipherButton.Text = "Зашифровать";
            this.CipherButton.UseVisualStyleBackColor = true;
            this.CipherButton.Click += new System.EventHandler(this.CipherButton_Click);
            // 
            // AnswerTB
            // 
            this.AnswerTB.Location = new System.Drawing.Point(12, 113);
            this.AnswerTB.Name = "AnswerTB";
            this.AnswerTB.Size = new System.Drawing.Size(384, 255);
            this.AnswerTB.TabIndex = 5;
            this.AnswerTB.Text = "";
            // 
            // DecipherButton
            // 
            this.DecipherButton.Location = new System.Drawing.Point(226, 73);
            this.DecipherButton.Name = "DecipherButton";
            this.DecipherButton.Size = new System.Drawing.Size(168, 34);
            this.DecipherButton.TabIndex = 4;
            this.DecipherButton.Text = "Расшифровать";
            this.DecipherButton.UseVisualStyleBackColor = true;
            this.DecipherButton.Click += new System.EventHandler(this.DecipherButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 377);
            this.Controls.Add(this.AnswerTB);
            this.Controls.Add(this.DecipherButton);
            this.Controls.Add(this.CipherButton);
            this.Controls.Add(this.LValueTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RValueTB);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Заплаткин Юрий, Лаб 11";
            ((System.ComponentModel.ISupportInitialize)(this.RValueTB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LValueTB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown RValueTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown LValueTB;
        private System.Windows.Forms.Button CipherButton;
        private System.Windows.Forms.RichTextBox AnswerTB;
        private System.Windows.Forms.Button DecipherButton;
    }
}

