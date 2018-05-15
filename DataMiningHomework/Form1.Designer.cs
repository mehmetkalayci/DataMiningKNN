namespace DataMiningHomework
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
            this.dgTraining = new System.Windows.Forms.DataGridView();
            this.txtTrainingFilePath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSelectTrainingFile = new System.Windows.Forms.Button();
            this.dgTest = new System.Windows.Forms.DataGridView();
            this.txtLog = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numKval = new System.Windows.Forms.NumericUpDown();
            this.btnSelectTestFile = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTestFilePath = new System.Windows.Forms.TextBox();
            this.btnApply = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgTraining)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgTest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numKval)).BeginInit();
            this.SuspendLayout();
            // 
            // dgTraining
            // 
            this.dgTraining.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgTraining.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgTraining.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgTraining.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgTraining.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTraining.Location = new System.Drawing.Point(12, 64);
            this.dgTraining.MultiSelect = false;
            this.dgTraining.Name = "dgTraining";
            this.dgTraining.ReadOnly = true;
            this.dgTraining.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgTraining.Size = new System.Drawing.Size(812, 100);
            this.dgTraining.TabIndex = 0;
            // 
            // txtTrainingFilePath
            // 
            this.txtTrainingFilePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTrainingFilePath.Location = new System.Drawing.Point(141, 12);
            this.txtTrainingFilePath.Name = "txtTrainingFilePath";
            this.txtTrainingFilePath.ReadOnly = true;
            this.txtTrainingFilePath.Size = new System.Drawing.Size(370, 20);
            this.txtTrainingFilePath.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Eğitim Veriseti Dosya Yolu";
            // 
            // btnSelectTrainingFile
            // 
            this.btnSelectTrainingFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelectTrainingFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSelectTrainingFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSelectTrainingFile.Location = new System.Drawing.Point(517, 10);
            this.btnSelectTrainingFile.Name = "btnSelectTrainingFile";
            this.btnSelectTrainingFile.Size = new System.Drawing.Size(48, 23);
            this.btnSelectTrainingFile.TabIndex = 3;
            this.btnSelectTrainingFile.Text = "Seç";
            this.btnSelectTrainingFile.UseVisualStyleBackColor = true;
            this.btnSelectTrainingFile.Click += new System.EventHandler(this.btnSelectFile_Click);
            // 
            // dgTest
            // 
            this.dgTest.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgTest.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgTest.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgTest.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgTest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTest.Location = new System.Drawing.Point(12, 170);
            this.dgTest.MultiSelect = false;
            this.dgTest.Name = "dgTest";
            this.dgTest.ReadOnly = true;
            this.dgTest.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgTest.Size = new System.Drawing.Size(812, 297);
            this.dgTest.TabIndex = 4;
            // 
            // txtLog
            // 
            this.txtLog.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtLog.Location = new System.Drawing.Point(12, 473);
            this.txtLog.Name = "txtLog";
            this.txtLog.Size = new System.Drawing.Size(812, 78);
            this.txtLog.TabIndex = 5;
            this.txtLog.Text = "";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(582, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "K =";
            // 
            // numKval
            // 
            this.numKval.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numKval.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numKval.Location = new System.Drawing.Point(608, 12);
            this.numKval.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.numKval.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numKval.Name = "numKval";
            this.numKval.Size = new System.Drawing.Size(44, 20);
            this.numKval.TabIndex = 7;
            this.numKval.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numKval.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numKval.ValueChanged += new System.EventHandler(this.numKval_ValueChanged);
            // 
            // btnSelectTestFile
            // 
            this.btnSelectTestFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelectTestFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSelectTestFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSelectTestFile.Location = new System.Drawing.Point(517, 36);
            this.btnSelectTestFile.Name = "btnSelectTestFile";
            this.btnSelectTestFile.Size = new System.Drawing.Size(48, 23);
            this.btnSelectTestFile.TabIndex = 10;
            this.btnSelectTestFile.Text = "Seç";
            this.btnSelectTestFile.UseVisualStyleBackColor = true;
            this.btnSelectTestFile.Click += new System.EventHandler(this.btnSelectTestFile_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Test Veriseti Dosya Yolu";
            // 
            // txtTestFilePath
            // 
            this.txtTestFilePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTestFilePath.Location = new System.Drawing.Point(141, 38);
            this.txtTestFilePath.Name = "txtTestFilePath";
            this.txtTestFilePath.ReadOnly = true;
            this.txtTestFilePath.Size = new System.Drawing.Size(370, 20);
            this.txtTestFilePath.TabIndex = 8;
            // 
            // btnApply
            // 
            this.btnApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnApply.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnApply.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnApply.Location = new System.Drawing.Point(585, 36);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(67, 23);
            this.btnApply.TabIndex = 10;
            this.btnApply.Text = "Çalıştır";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 555);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.btnSelectTestFile);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTestFilePath);
            this.Controls.Add(this.numKval);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.dgTest);
            this.Controls.Add(this.btnSelectTrainingFile);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTrainingFilePath);
            this.Controls.Add(this.dgTraining);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Data Mining Homework | KNN Algorithm Implementation";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgTraining)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgTest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numKval)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgTraining;
        private System.Windows.Forms.TextBox txtTrainingFilePath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSelectTrainingFile;
        private System.Windows.Forms.DataGridView dgTest;
        private System.Windows.Forms.RichTextBox txtLog;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numKval;
        private System.Windows.Forms.Button btnSelectTestFile;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTestFilePath;
        private System.Windows.Forms.Button btnApply;
    }
}

