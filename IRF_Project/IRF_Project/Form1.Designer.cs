namespace IRF_Project
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
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReleaseYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Duration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Country = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.export = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.Delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(571, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Import";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Import_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Title,
            this.Type,
            this.ReleaseYear,
            this.Duration,
            this.Country});
            this.dataGridView.Location = new System.Drawing.Point(12, 41);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(776, 205);
            this.dataGridView.TabIndex = 1;
            // 
            // Title
            // 
            this.Title.HeaderText = "Title";
            this.Title.Name = "Title";
            this.Title.Width = 300;
            // 
            // Type
            // 
            this.Type.HeaderText = "Type";
            this.Type.Name = "Type";
            // 
            // ReleaseYear
            // 
            this.ReleaseYear.HeaderText = "ReleaseYear";
            this.ReleaseYear.Name = "ReleaseYear";
            // 
            // Duration
            // 
            this.Duration.HeaderText = "Duration";
            this.Duration.Name = "Duration";
            // 
            // Country
            // 
            this.Country.HeaderText = "Country";
            this.Country.Name = "Country";
            // 
            // export
            // 
            this.export.Location = new System.Drawing.Point(669, 12);
            this.export.Name = "export";
            this.export.Size = new System.Drawing.Size(75, 23);
            this.export.TabIndex = 2;
            this.export.Text = "Export";
            this.export.UseVisualStyleBackColor = true;
            this.export.Click += new System.EventHandler(this.export_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(571, 252);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 3;
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(717, 252);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(75, 23);
            this.Delete.TabIndex = 4;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.export);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReleaseYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn Duration;
        private System.Windows.Forms.DataGridViewTextBoxColumn Country;
        private System.Windows.Forms.Button export;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button Delete;
    }
}

