namespace TestProject1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label2 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.button8 = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button10 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.button13 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.button14 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.backgroundWorker3 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker4 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker5 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker6 = new System.ComponentModel.BackgroundWorker();
            this.button1 = new System.Windows.Forms.Button();
            this.backgroundWorker7 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(45, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(255, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Работа с рейтингом паролей";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 370);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(879, 36);
            this.progressBar1.TabIndex = 18;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(662, 185);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(229, 47);
            this.button8.TabIndex = 20;
            this.button8.Text = "Мутировать рейтинг";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(764, 130);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            25000000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 26);
            this.numericUpDown1.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(658, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(215, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "Использование мутаций";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.WorkerReportsProgress = true;
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
            this.backgroundWorker2.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker2_ProgressChanged);
            this.backgroundWorker2.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker2_RunWorkerCompleted);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(474, 418);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 20);
            this.label4.TabIndex = 23;
            this.label4.Text = "0 / 0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(347, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 20);
            this.label5.TabIndex = 25;
            this.label5.Text = "Словари";
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(351, 112);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(185, 34);
            this.button10.TabIndex = 26;
            this.button10.Text = "Добавить словари...";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(308, 272);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(228, 20);
            this.label6.TabIndex = 27;
            this.label6.Text = "Паролей в общем словаре: 0";
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(49, 112);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(189, 34);
            this.button11.TabIndex = 28;
            this.button11.Text = "Добавить рейтинг...";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button12
            // 
            this.button12.Enabled = false;
            this.button12.Location = new System.Drawing.Point(351, 171);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(185, 72);
            this.button12.TabIndex = 29;
            this.button12.Text = "Проверить общий словарь на мутации";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(658, 132);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 20);
            this.label7.TabIndex = 30;
            this.label7.Text = "Количество";
            // 
            // button13
            // 
            this.button13.Enabled = false;
            this.button13.Location = new System.Drawing.Point(662, 238);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(229, 56);
            this.button13.TabIndex = 31;
            this.button13.Text = "Мутировать словарь и рейтинг";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(60, 428);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(245, 20);
            this.label8.TabIndex = 32;
            this.label8.Text = "Мутаций в рейтинге мутаций: 0";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(49, 152);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(189, 37);
            this.button14.TabIndex = 33;
            this.button14.Text = "Сменить рейтинг...";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(907, 112);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(393, 428);
            this.dataGridView1.TabIndex = 34;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(959, 84);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(153, 20);
            this.label9.TabIndex = 35;
            this.label9.Text = "Рейтинг мутаций";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(1118, 71);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(182, 35);
            this.button5.TabIndex = 36;
            this.button5.Text = "Сбросить мутации";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // backgroundWorker3
            // 
            this.backgroundWorker3.WorkerReportsProgress = true;
            this.backgroundWorker3.WorkerSupportsCancellation = true;
            this.backgroundWorker3.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker3_DoWork);
            this.backgroundWorker3.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker3_ProgressChanged);
            this.backgroundWorker3.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker3_RunWorkerCompleted);
            // 
            // backgroundWorker4
            // 
            this.backgroundWorker4.WorkerReportsProgress = true;
            this.backgroundWorker4.WorkerSupportsCancellation = true;
            this.backgroundWorker4.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker4_DoWork);
            this.backgroundWorker4.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker4_ProgressChanged);
            // 
            // backgroundWorker5
            // 
            this.backgroundWorker5.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker5_DoWork);
            // 
            // backgroundWorker6
            // 
            this.backgroundWorker6.WorkerReportsProgress = true;
            this.backgroundWorker6.WorkerSupportsCancellation = true;
            this.backgroundWorker6.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker6_DoWork);
            this.backgroundWorker6.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker6_ProgressChanged);
            this.backgroundWorker6.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker6_RunWorkerCompleted);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(662, 300);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(229, 41);
            this.button1.TabIndex = 37;
            this.button1.Text = "Мутировать файл...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // backgroundWorker7
            // 
            this.backgroundWorker7.WorkerReportsProgress = true;
            this.backgroundWorker7.WorkerSupportsCancellation = true;
            this.backgroundWorker7.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker7_DoWork);
            this.backgroundWorker7.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker7_ProgressChanged);
            this.backgroundWorker7.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker7_RunWorkerCompleted);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1528, 567);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mutatuion checker";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.ProgressBar progressBar1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label3;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button5;
        private System.ComponentModel.BackgroundWorker backgroundWorker3;
        private System.ComponentModel.BackgroundWorker backgroundWorker4;
        private System.ComponentModel.BackgroundWorker backgroundWorker5;
        private System.ComponentModel.BackgroundWorker backgroundWorker6;
        private System.Windows.Forms.Button button1;
        private System.ComponentModel.BackgroundWorker backgroundWorker7;
    }
}

