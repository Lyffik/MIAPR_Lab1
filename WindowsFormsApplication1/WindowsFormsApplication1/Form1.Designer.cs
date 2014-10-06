namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.numericUpDownPointsCount = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownClassesCount = new System.Windows.Forms.NumericUpDown();
            this.btnRun = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPointsCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownClassesCount)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.Black;
            this.pictureBox.Location = new System.Drawing.Point(3, 1);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(933, 637);
            this.pictureBox.TabIndex = 1;
            this.pictureBox.TabStop = false;
            // 
            // numericUpDownPointsCount
            // 
            this.numericUpDownPointsCount.Location = new System.Drawing.Point(945, 24);
            this.numericUpDownPointsCount.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numericUpDownPointsCount.Minimum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numericUpDownPointsCount.Name = "numericUpDownPointsCount";
            this.numericUpDownPointsCount.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownPointsCount.TabIndex = 3;
            this.numericUpDownPointsCount.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // numericUpDownClassesCount
            // 
            this.numericUpDownClassesCount.Location = new System.Drawing.Point(945, 66);
            this.numericUpDownClassesCount.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numericUpDownClassesCount.Name = "numericUpDownClassesCount";
            this.numericUpDownClassesCount.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownClassesCount.TabIndex = 4;
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(945, 110);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(120, 23);
            this.btnRun.TabIndex = 5;
            this.btnRun.Text = "Выполнить";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(942, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Количество точек";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(942, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Количество классов";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 636);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.numericUpDownClassesCount);
            this.Controls.Add(this.numericUpDownPointsCount);
            this.Controls.Add(this.pictureBox);
            this.Name = "Form1";
            this.Text = "Алгоритм К-средних";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPointsCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownClassesCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.NumericUpDown numericUpDownPointsCount;
        private System.Windows.Forms.NumericUpDown numericUpDownClassesCount;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

