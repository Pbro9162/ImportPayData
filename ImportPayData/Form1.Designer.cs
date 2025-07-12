namespace ImportPayData
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnBrowse = new Button();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            cboSheet = new ComboBox();
            txtFilename = new TextBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnBrowse
            // 
            btnBrowse.Location = new Point(639, 365);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(38, 29);
            btnBrowse.TabIndex = 0;
            btnBrowse.Text = "...";
            btnBrowse.UseVisualStyleBackColor = true;
            btnBrowse.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(677, 359);
            dataGridView1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 371);
            label1.Name = "label1";
            label1.Size = new Size(79, 20);
            label1.TabIndex = 2;
            label1.Text = "File Name:";
            label1.Click += label1_Click;
            // 
            // cboSheet
            // 
            cboSheet.FormattingEnabled = true;
            cboSheet.Location = new Point(97, 406);
            cboSheet.Name = "cboSheet";
            cboSheet.Size = new Size(536, 28);
            cboSheet.TabIndex = 3;
            // 
            // txtFilename
            // 
            txtFilename.Location = new Point(97, 368);
            txtFilename.Name = "txtFilename";
            txtFilename.ReadOnly = true;
            txtFilename.Size = new Size(536, 27);
            txtFilename.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 409);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 5;
            label2.Text = "Sheet:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(txtFilename);
            Controls.Add(cboSheet);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(btnBrowse);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBrowse;
        private DataGridView dataGridView1;
        private Label label1;
        private ComboBox cboSheet;
        private TextBox txtFilename;
        private Label label2;
    }
}
