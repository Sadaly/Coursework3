namespace ConsoleApp1
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
            this.buttonInitialize = new System.Windows.Forms.Button();
            this.buttonBubbleSort = new System.Windows.Forms.Button();
            this.buttonQuickSort = new System.Windows.Forms.Button();
            this.buttonCombSort = new System.Windows.Forms.Button();
            this.timeBubbleSort = new System.Windows.Forms.TextBox();
            this.permutationBubbleSort = new System.Windows.Forms.TextBox();
            this.timeQuickSort = new System.Windows.Forms.TextBox();
            this.permutationQuickSort = new System.Windows.Forms.TextBox();
            this.timeCombSort = new System.Windows.Forms.TextBox();
            this.permutationCombSort = new System.Windows.Forms.TextBox();
            this.textBoxMin = new System.Windows.Forms.TextBox();
            this.textBoxMax = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxLength = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.richTextBox4 = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonInitialize
            // 
            this.buttonInitialize.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonInitialize.Location = new System.Drawing.Point(12, 324);
            this.buttonInitialize.Name = "buttonInitialize";
            this.buttonInitialize.Size = new System.Drawing.Size(168, 58);
            this.buttonInitialize.TabIndex = 1;
            this.buttonInitialize.Text = "Инициализировать";
            this.buttonInitialize.UseVisualStyleBackColor = true;
            this.buttonInitialize.Click += new System.EventHandler(this.buttonInitialize_Click);
            // 
            // buttonBubbleSort
            // 
            this.buttonBubbleSort.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBubbleSort.Location = new System.Drawing.Point(187, 324);
            this.buttonBubbleSort.Name = "buttonBubbleSort";
            this.buttonBubbleSort.Size = new System.Drawing.Size(174, 58);
            this.buttonBubbleSort.TabIndex = 1;
            this.buttonBubbleSort.Text = "Сортировать (BubbleSort)";
            this.buttonBubbleSort.UseVisualStyleBackColor = true;
            this.buttonBubbleSort.Click += new System.EventHandler(this.buttonBubbleSort_Click);
            // 
            // buttonQuickSort
            // 
            this.buttonQuickSort.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonQuickSort.Location = new System.Drawing.Point(367, 324);
            this.buttonQuickSort.Name = "buttonQuickSort";
            this.buttonQuickSort.Size = new System.Drawing.Size(172, 61);
            this.buttonQuickSort.TabIndex = 1;
            this.buttonQuickSort.Text = "Сортировать (QuickSort)";
            this.buttonQuickSort.UseVisualStyleBackColor = true;
            this.buttonQuickSort.Click += new System.EventHandler(this.buttonQuickSort_Click);
            // 
            // buttonCombSort
            // 
            this.buttonCombSort.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCombSort.Location = new System.Drawing.Point(545, 324);
            this.buttonCombSort.Name = "buttonCombSort";
            this.buttonCombSort.Size = new System.Drawing.Size(169, 61);
            this.buttonCombSort.TabIndex = 1;
            this.buttonCombSort.Text = "Сортировать (CombSort)";
            this.buttonCombSort.UseVisualStyleBackColor = true;
            this.buttonCombSort.Click += new System.EventHandler(this.buttonCombSort_Click);
            // 
            // timeBubbleSort
            // 
            this.timeBubbleSort.Location = new System.Drawing.Point(188, 417);
            this.timeBubbleSort.Name = "timeBubbleSort";
            this.timeBubbleSort.Size = new System.Drawing.Size(84, 20);
            this.timeBubbleSort.TabIndex = 2;
            // 
            // permutationBubbleSort
            // 
            this.permutationBubbleSort.Location = new System.Drawing.Point(278, 417);
            this.permutationBubbleSort.Name = "permutationBubbleSort";
            this.permutationBubbleSort.Size = new System.Drawing.Size(83, 20);
            this.permutationBubbleSort.TabIndex = 2;
            // 
            // timeQuickSort
            // 
            this.timeQuickSort.Location = new System.Drawing.Point(366, 417);
            this.timeQuickSort.Name = "timeQuickSort";
            this.timeQuickSort.Size = new System.Drawing.Size(82, 20);
            this.timeQuickSort.TabIndex = 2;
            // 
            // permutationQuickSort
            // 
            this.permutationQuickSort.Location = new System.Drawing.Point(454, 417);
            this.permutationQuickSort.Name = "permutationQuickSort";
            this.permutationQuickSort.Size = new System.Drawing.Size(84, 20);
            this.permutationQuickSort.TabIndex = 2;
            // 
            // timeCombSort
            // 
            this.timeCombSort.Location = new System.Drawing.Point(544, 417);
            this.timeCombSort.Name = "timeCombSort";
            this.timeCombSort.Size = new System.Drawing.Size(80, 20);
            this.timeCombSort.TabIndex = 2;
            // 
            // permutationCombSort
            // 
            this.permutationCombSort.Location = new System.Drawing.Point(630, 417);
            this.permutationCombSort.Name = "permutationCombSort";
            this.permutationCombSort.Size = new System.Drawing.Size(84, 20);
            this.permutationCombSort.TabIndex = 2;
            // 
            // textBoxMin
            // 
            this.textBoxMin.Location = new System.Drawing.Point(71, 417);
            this.textBoxMin.Name = "textBoxMin";
            this.textBoxMin.Size = new System.Drawing.Size(54, 20);
            this.textBoxMin.TabIndex = 2;
            this.textBoxMin.Text = "-10000";
            // 
            // textBoxMax
            // 
            this.textBoxMax.Location = new System.Drawing.Point(127, 417);
            this.textBoxMax.Name = "textBoxMax";
            this.textBoxMax.Size = new System.Drawing.Size(53, 20);
            this.textBoxMax.TabIndex = 2;
            this.textBoxMax.Text = "10000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 388);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "Минима-\r\nльное:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(124, 388);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "Максима-\r\nльное:";
            // 
            // textBoxLength
            // 
            this.textBoxLength.Location = new System.Drawing.Point(13, 417);
            this.textBoxLength.Name = "textBoxLength";
            this.textBoxLength.Size = new System.Drawing.Size(55, 20);
            this.textBoxLength.TabIndex = 2;
            this.textBoxLength.Text = "100";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 388);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 26);
            this.label3.TabIndex = 3;
            this.label3.Text = "Длина\r\nмассива:";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.Info;
            this.richTextBox1.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(12, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(168, 306);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            this.richTextBox2.BackColor = System.Drawing.SystemColors.Info;
            this.richTextBox2.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox2.Location = new System.Drawing.Point(187, 12);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(174, 306);
            this.richTextBox2.TabIndex = 4;
            this.richTextBox2.Text = "";
            // 
            // richTextBox3
            // 
            this.richTextBox3.BackColor = System.Drawing.SystemColors.Info;
            this.richTextBox3.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox3.Location = new System.Drawing.Point(366, 12);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.Size = new System.Drawing.Size(172, 306);
            this.richTextBox3.TabIndex = 4;
            this.richTextBox3.Text = "";
            // 
            // richTextBox4
            // 
            this.richTextBox4.BackColor = System.Drawing.SystemColors.Info;
            this.richTextBox4.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox4.Location = new System.Drawing.Point(545, 12);
            this.richTextBox4.Name = "richTextBox4";
            this.richTextBox4.Size = new System.Drawing.Size(169, 306);
            this.richTextBox4.TabIndex = 4;
            this.richTextBox4.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(187, 388);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 26);
            this.label4.TabIndex = 3;
            this.label4.Text = "Время в \r\nтиках:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(279, 388);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 26);
            this.label5.TabIndex = 3;
            this.label5.Text = "Количество\r\nперестановок:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(366, 388);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 26);
            this.label6.TabIndex = 3;
            this.label6.Text = "Время в \r\nтиках:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(454, 388);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 26);
            this.label7.TabIndex = 3;
            this.label7.Text = "Количество\r\nперестановок:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(545, 388);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 26);
            this.label8.TabIndex = 3;
            this.label8.Text = "Время в \r\nтиках:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(633, 388);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 26);
            this.label9.TabIndex = 3;
            this.label9.Text = "Количество\r\nперестановок:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(735, 449);
            this.Controls.Add(this.richTextBox4);
            this.Controls.Add(this.richTextBox3);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.permutationCombSort);
            this.Controls.Add(this.permutationQuickSort);
            this.Controls.Add(this.timeCombSort);
            this.Controls.Add(this.timeQuickSort);
            this.Controls.Add(this.permutationBubbleSort);
            this.Controls.Add(this.textBoxMax);
            this.Controls.Add(this.textBoxLength);
            this.Controls.Add(this.textBoxMin);
            this.Controls.Add(this.timeBubbleSort);
            this.Controls.Add(this.buttonCombSort);
            this.Controls.Add(this.buttonQuickSort);
            this.Controls.Add(this.buttonBubbleSort);
            this.Controls.Add(this.buttonInitialize);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "Методы сортировки обменом";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonInitialize;
        private System.Windows.Forms.Button buttonBubbleSort;
        private System.Windows.Forms.Button buttonQuickSort;
        private System.Windows.Forms.Button buttonCombSort;
        private System.Windows.Forms.TextBox timeBubbleSort;
        private System.Windows.Forms.TextBox permutationBubbleSort;
        private System.Windows.Forms.TextBox timeQuickSort;
        private System.Windows.Forms.TextBox permutationQuickSort;
        private System.Windows.Forms.TextBox timeCombSort;
        private System.Windows.Forms.TextBox permutationCombSort;
        private System.Windows.Forms.TextBox textBoxMin;
        private System.Windows.Forms.TextBox textBoxMax;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxLength;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.RichTextBox richTextBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}