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
            components = new System.ComponentModel.Container();
            btnBrowse = new Button();
            dataGridView1 = new DataGridView();
            pRTransactionMasterBindingSource = new BindingSource(components);
            label1 = new Label();
            cboSheet = new ComboBox();
            txtFilename = new TextBox();
            label2 = new Label();
            btnImport = new Button();
            Totals_Lbl = new Label();
            totalsGridView = new DataGridView();
            iDGLCompanyDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            cGLCompanyIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            iDPREEmployeeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            cCheckNumberDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dCheckDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dAccountingDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dPayPeriodStartDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dPayPeriodEndDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nGrossAmountDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nNetAmountDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nRegularPayDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nOvertimePayDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nTimeOffPayDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nRegularHoursDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nOvertimeHoursDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nTimeOffHoursDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nDoNotPayHoursDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            bPRModuleDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            cImportBatchIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pRTransactionMasterBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)totalsGridView).BeginInit();
            SuspendLayout();
            // 
            // btnBrowse
            // 
            btnBrowse.Location = new Point(750, 781);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(38, 29);
            btnBrowse.TabIndex = 0;
            btnBrowse.Text = "...";
            btnBrowse.UseVisualStyleBackColor = true;
            btnBrowse.Click += BtnBrowse_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { iDGLCompanyDataGridViewTextBoxColumn, cGLCompanyIDDataGridViewTextBoxColumn, iDPREEmployeeDataGridViewTextBoxColumn, cCheckNumberDataGridViewTextBoxColumn, dCheckDateDataGridViewTextBoxColumn, dAccountingDateDataGridViewTextBoxColumn, dPayPeriodStartDataGridViewTextBoxColumn, dPayPeriodEndDataGridViewTextBoxColumn, nGrossAmountDataGridViewTextBoxColumn, nNetAmountDataGridViewTextBoxColumn, nRegularPayDataGridViewTextBoxColumn, nOvertimePayDataGridViewTextBoxColumn, nTimeOffPayDataGridViewTextBoxColumn, nRegularHoursDataGridViewTextBoxColumn, nOvertimeHoursDataGridViewTextBoxColumn, nTimeOffHoursDataGridViewTextBoxColumn, nDoNotPayHoursDataGridViewTextBoxColumn, bPRModuleDataGridViewCheckBoxColumn, cImportBatchIDDataGridViewTextBoxColumn });
            dataGridView1.DataSource = pRTransactionMasterBindingSource;
            dataGridView1.Location = new Point(123, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1631, 694);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellValueChanged += DataGridView1_CellValueChanged;
            // 
            // pRTransactionMasterBindingSource
            // 
            pRTransactionMasterBindingSource.DataSource = typeof(PRTransactionMaster);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(123, 781);
            label1.Name = "label1";
            label1.Size = new Size(79, 20);
            label1.TabIndex = 2;
            label1.Text = "File Name:";
            // 
            // cboSheet
            // 
            cboSheet.FormattingEnabled = true;
            cboSheet.Location = new Point(208, 841);
            cboSheet.Name = "cboSheet";
            cboSheet.Size = new Size(536, 28);
            cboSheet.TabIndex = 3;
            cboSheet.SelectedIndexChanged += CboSheet_SelectedIndexChanged;
            // 
            // txtFilename
            // 
            txtFilename.Location = new Point(208, 778);
            txtFilename.Name = "txtFilename";
            txtFilename.ReadOnly = true;
            txtFilename.Size = new Size(536, 27);
            txtFilename.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(153, 844);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 5;
            label2.Text = "Sheet:";
            // 
            // btnImport
            // 
            btnImport.Location = new Point(750, 840);
            btnImport.Name = "btnImport";
            btnImport.Size = new Size(94, 29);
            btnImport.TabIndex = 6;
            btnImport.Text = "&Import";
            btnImport.UseVisualStyleBackColor = true;
            btnImport.Click += BtnImport_Click;
            // 
            // Totals_Lbl
            // 
            Totals_Lbl.AutoSize = true;
            Totals_Lbl.Location = new Point(1001, 738);
            Totals_Lbl.Name = "Totals_Lbl";
            Totals_Lbl.Size = new Size(51, 20);
            Totals_Lbl.TabIndex = 7;
            Totals_Lbl.Text = "Totals:";
            // 
            // totalsGridView
            // 
            totalsGridView.AllowUserToAddRows = false;
            totalsGridView.AllowUserToDeleteRows = false;
            totalsGridView.AllowUserToResizeColumns = false;
            totalsGridView.AllowUserToResizeRows = false;
            totalsGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            totalsGridView.Location = new Point(1058, 728);
            totalsGridView.Name = "totalsGridView";
            totalsGridView.ReadOnly = true;
            totalsGridView.RowHeadersWidth = 51;
            totalsGridView.Size = new Size(696, 30);
            totalsGridView.TabIndex = 8;
            // 
            // iDGLCompanyDataGridViewTextBoxColumn
            // 
            iDGLCompanyDataGridViewTextBoxColumn.DataPropertyName = "IDGLCompany";
            iDGLCompanyDataGridViewTextBoxColumn.HeaderText = "Company";
            iDGLCompanyDataGridViewTextBoxColumn.MinimumWidth = 6;
            iDGLCompanyDataGridViewTextBoxColumn.Name = "iDGLCompanyDataGridViewTextBoxColumn";
            iDGLCompanyDataGridViewTextBoxColumn.Width = 125;
            // 
            // cGLCompanyIDDataGridViewTextBoxColumn
            // 
            cGLCompanyIDDataGridViewTextBoxColumn.DataPropertyName = "CGLCompanyID";
            cGLCompanyIDDataGridViewTextBoxColumn.HeaderText = "CGLCompanyID";
            cGLCompanyIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            cGLCompanyIDDataGridViewTextBoxColumn.Name = "cGLCompanyIDDataGridViewTextBoxColumn";
            cGLCompanyIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // iDPREEmployeeDataGridViewTextBoxColumn
            // 
            iDPREEmployeeDataGridViewTextBoxColumn.DataPropertyName = "IDPREEmployee";
            iDPREEmployeeDataGridViewTextBoxColumn.HeaderText = "IDPREEmployee";
            iDPREEmployeeDataGridViewTextBoxColumn.MinimumWidth = 6;
            iDPREEmployeeDataGridViewTextBoxColumn.Name = "iDPREEmployeeDataGridViewTextBoxColumn";
            iDPREEmployeeDataGridViewTextBoxColumn.Width = 125;
            // 
            // cCheckNumberDataGridViewTextBoxColumn
            // 
            cCheckNumberDataGridViewTextBoxColumn.DataPropertyName = "CCheckNumber";
            cCheckNumberDataGridViewTextBoxColumn.HeaderText = "CCheckNumber";
            cCheckNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            cCheckNumberDataGridViewTextBoxColumn.Name = "cCheckNumberDataGridViewTextBoxColumn";
            cCheckNumberDataGridViewTextBoxColumn.Width = 125;
            // 
            // dCheckDateDataGridViewTextBoxColumn
            // 
            dCheckDateDataGridViewTextBoxColumn.DataPropertyName = "DCheckDate";
            dCheckDateDataGridViewTextBoxColumn.HeaderText = "DCheckDate";
            dCheckDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            dCheckDateDataGridViewTextBoxColumn.Name = "dCheckDateDataGridViewTextBoxColumn";
            dCheckDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // dAccountingDateDataGridViewTextBoxColumn
            // 
            dAccountingDateDataGridViewTextBoxColumn.DataPropertyName = "DAccountingDate";
            dAccountingDateDataGridViewTextBoxColumn.HeaderText = "DAccountingDate";
            dAccountingDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            dAccountingDateDataGridViewTextBoxColumn.Name = "dAccountingDateDataGridViewTextBoxColumn";
            dAccountingDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // dPayPeriodStartDataGridViewTextBoxColumn
            // 
            dPayPeriodStartDataGridViewTextBoxColumn.DataPropertyName = "DPayPeriodStart";
            dPayPeriodStartDataGridViewTextBoxColumn.HeaderText = "DPayPeriodStart";
            dPayPeriodStartDataGridViewTextBoxColumn.MinimumWidth = 6;
            dPayPeriodStartDataGridViewTextBoxColumn.Name = "dPayPeriodStartDataGridViewTextBoxColumn";
            dPayPeriodStartDataGridViewTextBoxColumn.Width = 125;
            // 
            // dPayPeriodEndDataGridViewTextBoxColumn
            // 
            dPayPeriodEndDataGridViewTextBoxColumn.DataPropertyName = "DPayPeriodEnd";
            dPayPeriodEndDataGridViewTextBoxColumn.HeaderText = "DPayPeriodEnd";
            dPayPeriodEndDataGridViewTextBoxColumn.MinimumWidth = 6;
            dPayPeriodEndDataGridViewTextBoxColumn.Name = "dPayPeriodEndDataGridViewTextBoxColumn";
            dPayPeriodEndDataGridViewTextBoxColumn.Width = 125;
            // 
            // nGrossAmountDataGridViewTextBoxColumn
            // 
            nGrossAmountDataGridViewTextBoxColumn.DataPropertyName = "NGrossAmount";
            nGrossAmountDataGridViewTextBoxColumn.HeaderText = "NGrossAmount";
            nGrossAmountDataGridViewTextBoxColumn.MinimumWidth = 6;
            nGrossAmountDataGridViewTextBoxColumn.Name = "nGrossAmountDataGridViewTextBoxColumn";
            nGrossAmountDataGridViewTextBoxColumn.Width = 125;
            // 
            // nNetAmountDataGridViewTextBoxColumn
            // 
            nNetAmountDataGridViewTextBoxColumn.DataPropertyName = "NNetAmount";
            nNetAmountDataGridViewTextBoxColumn.HeaderText = "NNetAmount";
            nNetAmountDataGridViewTextBoxColumn.MinimumWidth = 6;
            nNetAmountDataGridViewTextBoxColumn.Name = "nNetAmountDataGridViewTextBoxColumn";
            nNetAmountDataGridViewTextBoxColumn.Width = 125;
            // 
            // nRegularPayDataGridViewTextBoxColumn
            // 
            nRegularPayDataGridViewTextBoxColumn.DataPropertyName = "NRegularPay";
            nRegularPayDataGridViewTextBoxColumn.HeaderText = "NRegularPay";
            nRegularPayDataGridViewTextBoxColumn.MinimumWidth = 6;
            nRegularPayDataGridViewTextBoxColumn.Name = "nRegularPayDataGridViewTextBoxColumn";
            nRegularPayDataGridViewTextBoxColumn.Width = 125;
            // 
            // nOvertimePayDataGridViewTextBoxColumn
            // 
            nOvertimePayDataGridViewTextBoxColumn.DataPropertyName = "NOvertimePay";
            nOvertimePayDataGridViewTextBoxColumn.HeaderText = "NOvertimePay";
            nOvertimePayDataGridViewTextBoxColumn.MinimumWidth = 6;
            nOvertimePayDataGridViewTextBoxColumn.Name = "nOvertimePayDataGridViewTextBoxColumn";
            nOvertimePayDataGridViewTextBoxColumn.Width = 125;
            // 
            // nTimeOffPayDataGridViewTextBoxColumn
            // 
            nTimeOffPayDataGridViewTextBoxColumn.DataPropertyName = "NTimeOffPay";
            nTimeOffPayDataGridViewTextBoxColumn.HeaderText = "NTimeOffPay";
            nTimeOffPayDataGridViewTextBoxColumn.MinimumWidth = 6;
            nTimeOffPayDataGridViewTextBoxColumn.Name = "nTimeOffPayDataGridViewTextBoxColumn";
            nTimeOffPayDataGridViewTextBoxColumn.Width = 125;
            // 
            // nRegularHoursDataGridViewTextBoxColumn
            // 
            nRegularHoursDataGridViewTextBoxColumn.DataPropertyName = "NRegularHours";
            nRegularHoursDataGridViewTextBoxColumn.HeaderText = "NRegularHours";
            nRegularHoursDataGridViewTextBoxColumn.MinimumWidth = 6;
            nRegularHoursDataGridViewTextBoxColumn.Name = "nRegularHoursDataGridViewTextBoxColumn";
            nRegularHoursDataGridViewTextBoxColumn.Width = 125;
            // 
            // nOvertimeHoursDataGridViewTextBoxColumn
            // 
            nOvertimeHoursDataGridViewTextBoxColumn.DataPropertyName = "NOvertimeHours";
            nOvertimeHoursDataGridViewTextBoxColumn.HeaderText = "NOvertimeHours";
            nOvertimeHoursDataGridViewTextBoxColumn.MinimumWidth = 6;
            nOvertimeHoursDataGridViewTextBoxColumn.Name = "nOvertimeHoursDataGridViewTextBoxColumn";
            nOvertimeHoursDataGridViewTextBoxColumn.Width = 125;
            // 
            // nTimeOffHoursDataGridViewTextBoxColumn
            // 
            nTimeOffHoursDataGridViewTextBoxColumn.DataPropertyName = "NTimeOffHours";
            nTimeOffHoursDataGridViewTextBoxColumn.HeaderText = "NTimeOffHours";
            nTimeOffHoursDataGridViewTextBoxColumn.MinimumWidth = 6;
            nTimeOffHoursDataGridViewTextBoxColumn.Name = "nTimeOffHoursDataGridViewTextBoxColumn";
            nTimeOffHoursDataGridViewTextBoxColumn.Width = 125;
            // 
            // nDoNotPayHoursDataGridViewTextBoxColumn
            // 
            nDoNotPayHoursDataGridViewTextBoxColumn.DataPropertyName = "NDoNotPayHours";
            nDoNotPayHoursDataGridViewTextBoxColumn.HeaderText = "NDoNotPayHours";
            nDoNotPayHoursDataGridViewTextBoxColumn.MinimumWidth = 6;
            nDoNotPayHoursDataGridViewTextBoxColumn.Name = "nDoNotPayHoursDataGridViewTextBoxColumn";
            nDoNotPayHoursDataGridViewTextBoxColumn.Width = 125;
            // 
            // bPRModuleDataGridViewCheckBoxColumn
            // 
            bPRModuleDataGridViewCheckBoxColumn.DataPropertyName = "BPRModule";
            bPRModuleDataGridViewCheckBoxColumn.HeaderText = "BPRModule";
            bPRModuleDataGridViewCheckBoxColumn.MinimumWidth = 6;
            bPRModuleDataGridViewCheckBoxColumn.Name = "bPRModuleDataGridViewCheckBoxColumn";
            bPRModuleDataGridViewCheckBoxColumn.Width = 125;
            // 
            // cImportBatchIDDataGridViewTextBoxColumn
            // 
            cImportBatchIDDataGridViewTextBoxColumn.DataPropertyName = "CImportBatchID";
            cImportBatchIDDataGridViewTextBoxColumn.HeaderText = "CImportBatchID";
            cImportBatchIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            cImportBatchIDDataGridViewTextBoxColumn.Name = "cImportBatchIDDataGridViewTextBoxColumn";
            cImportBatchIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 911);
            Controls.Add(totalsGridView);
            Controls.Add(Totals_Lbl);
            Controls.Add(btnImport);
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
            ((System.ComponentModel.ISupportInitialize)pRTransactionMasterBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)totalsGridView).EndInit();
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
        private Button btnImport;
        private BindingSource pRTransactionMasterBindingSource;
        private Label Totals_Lbl;
        private DataGridView totalsGridView;
        private DataGridViewTextBoxColumn iDGLCompanyDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cGLCompanyIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn iDPREEmployeeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cCheckNumberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dCheckDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dAccountingDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dPayPeriodStartDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dPayPeriodEndDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nGrossAmountDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nNetAmountDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nRegularPayDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nOvertimePayDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nTimeOffPayDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nRegularHoursDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nOvertimeHoursDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nTimeOffHoursDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nDoNotPayHoursDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn bPRModuleDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn cImportBatchIDDataGridViewTextBoxColumn;
    }
}
