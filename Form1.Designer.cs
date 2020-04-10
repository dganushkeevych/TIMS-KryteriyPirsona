namespace MathStatisticsPirsonWindowsForms
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dfTextBox = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.xCritTextBox = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.xEmpTextBox = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.pTextBox = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.alphaTextBox = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.randomButtom = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridView1.Location = new System.Drawing.Point(3, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(425, 354);
            this.dataGridView1.TabIndex = 8;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "xi";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "ni";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "pi";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // dfTextBox
            // 
            this.dfTextBox.Location = new System.Drawing.Point(579, 176);
            this.dfTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dfTextBox.Name = "dfTextBox";
            this.dfTextBox.ReadOnly = true;
            this.dfTextBox.Size = new System.Drawing.Size(100, 22);
            this.dfTextBox.TabIndex = 33;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(487, 169);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(37, 31);
            this.label22.TabIndex = 32;
            this.label22.Text = "df";
            // 
            // resultTextBox
            // 
            this.resultTextBox.Location = new System.Drawing.Point(561, 344);
            this.resultTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.ReadOnly = true;
            this.resultTextBox.Size = new System.Drawing.Size(142, 22);
            this.resultTextBox.TabIndex = 31;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("MV Boli", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(434, 337);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(112, 31);
            this.label21.TabIndex = 30;
            this.label21.Text = "RESULT";
            // 
            // xCritTextBox
            // 
            this.xCritTextBox.Location = new System.Drawing.Point(579, 216);
            this.xCritTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.xCritTextBox.Name = "xCritTextBox";
            this.xCritTextBox.ReadOnly = true;
            this.xCritTextBox.Size = new System.Drawing.Size(100, 22);
            this.xCritTextBox.TabIndex = 29;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(473, 209);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(70, 31);
            this.label20.TabIndex = 28;
            this.label20.Text = "Xcrit";
            // 
            // xEmpTextBox
            // 
            this.xEmpTextBox.Location = new System.Drawing.Point(579, 253);
            this.xEmpTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.xEmpTextBox.Name = "xEmpTextBox";
            this.xEmpTextBox.ReadOnly = true;
            this.xEmpTextBox.Size = new System.Drawing.Size(100, 22);
            this.xEmpTextBox.TabIndex = 27;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(465, 246);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(78, 31);
            this.label19.TabIndex = 26;
            this.label19.Text = "Xemp";
            // 
            // pTextBox
            // 
            this.pTextBox.Location = new System.Drawing.Point(579, 54);
            this.pTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pTextBox.Name = "pTextBox";
            this.pTextBox.Size = new System.Drawing.Size(100, 22);
            this.pTextBox.TabIndex = 25;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(487, 47);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(28, 31);
            this.label18.TabIndex = 24;
            this.label18.Text = "p";
            // 
            // alphaTextBox
            // 
            this.alphaTextBox.Location = new System.Drawing.Point(579, 21);
            this.alphaTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.alphaTextBox.Name = "alphaTextBox";
            this.alphaTextBox.Size = new System.Drawing.Size(100, 22);
            this.alphaTextBox.TabIndex = 23;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(472, 12);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(71, 31);
            this.label17.TabIndex = 22;
            this.label17.Text = "alpha";
            // 
            // randomButtom
            // 
            this.randomButtom.Location = new System.Drawing.Point(856, 398);
            this.randomButtom.Name = "randomButtom";
            this.randomButtom.Size = new System.Drawing.Size(145, 38);
            this.randomButtom.TabIndex = 10;
            this.randomButtom.Text = "Згенерувати ";
            this.randomButtom.UseVisualStyleBackColor = true;
            this.randomButtom.Click += new System.EventHandler(this.randomButtom_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4,
            this.Column5});
            this.dataGridView2.Location = new System.Drawing.Point(709, 12);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(310, 354);
            this.dataGridView2.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(450, 101);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 32;
            this.label1.Text = "Параметр";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(515, 299);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 20);
            this.label2.TabIndex = 35;
            this.label2.Text = "Xcrit   Xemp";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "n";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "p";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 461);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.alphaTextBox);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.pTextBox);
            this.Controls.Add(this.dfTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.xEmpTextBox);
            this.Controls.Add(this.xCritTextBox);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.randomButtom);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Критерій Пірсона";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox dfTextBox;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox resultTextBox;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox xCritTextBox;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox xEmpTextBox;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox pTextBox;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox alphaTextBox;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button randomButtom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}

