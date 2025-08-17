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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            btnBrowse = new Button();
            dataGridView1 = new DataGridView();
            pRTransactionMasterBindingSource = new BindingSource(components);
            label1 = new Label();
            cboSheet = new ComboBox();
            txtFilename = new TextBox();
            label2 = new Label();
            btnImport = new Button();
            Totals_Lbl = new Label();
            dataGridView2 = new DataGridView();
            grossTotalDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            netTotalDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            regularPayTotalDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            overtimePayTotalDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            timeOffPayTotalDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            regularHoursTotalDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            overtimeHoursTotalDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            timeOffHoursTotalDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            doNotPayHoursTotalDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            totalsBindingSource = new BindingSource(components);
            iDGLCompanyDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            cGLCompanyIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            iDPREEmployeeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            CEmployeeName = new DataGridViewTextBoxColumn();
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
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)totalsBindingSource).BeginInit();
            SuspendLayout();
            // 
            // btnBrowse
            // 
            btnBrowse.Location = new Point(750, 727);
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
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { iDGLCompanyDataGridViewTextBoxColumn, cGLCompanyIDDataGridViewTextBoxColumn, iDPREEmployeeDataGridViewTextBoxColumn, CEmployeeName, cCheckNumberDataGridViewTextBoxColumn, dCheckDateDataGridViewTextBoxColumn, dAccountingDateDataGridViewTextBoxColumn, dPayPeriodStartDataGridViewTextBoxColumn, dPayPeriodEndDataGridViewTextBoxColumn, nGrossAmountDataGridViewTextBoxColumn, nNetAmountDataGridViewTextBoxColumn, nRegularPayDataGridViewTextBoxColumn, nOvertimePayDataGridViewTextBoxColumn, nTimeOffPayDataGridViewTextBoxColumn, nRegularHoursDataGridViewTextBoxColumn, nOvertimeHoursDataGridViewTextBoxColumn, nTimeOffHoursDataGridViewTextBoxColumn, nDoNotPayHoursDataGridViewTextBoxColumn, bPRModuleDataGridViewCheckBoxColumn, cImportBatchIDDataGridViewTextBoxColumn });
            dataGridView1.DataSource = pRTransactionMasterBindingSource;
            dataGridView1.Location = new Point(82, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 35;
            dataGridView1.Size = new Size(2034, 694);
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
            label1.Location = new Point(123, 727);
            label1.Name = "label1";
            label1.Size = new Size(79, 20);
            label1.TabIndex = 2;
            label1.Text = "File Name:";
            // 
            // cboSheet
            // 
            cboSheet.FormattingEnabled = true;
            cboSheet.Location = new Point(208, 787);
            cboSheet.Name = "cboSheet";
            cboSheet.Size = new Size(536, 28);
            cboSheet.TabIndex = 3;
            cboSheet.SelectedIndexChanged += CboSheet_SelectedIndexChanged;
            // 
            // txtFilename
            // 
            txtFilename.Location = new Point(208, 724);
            txtFilename.Name = "txtFilename";
            txtFilename.ReadOnly = true;
            txtFilename.Size = new Size(536, 27);
            txtFilename.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(153, 790);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 5;
            label2.Text = "Sheet:";
            // 
            // btnImport
            // 
            btnImport.Location = new Point(750, 786);
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
            Totals_Lbl.Location = new Point(958, 761);
            Totals_Lbl.Name = "Totals_Lbl";
            Totals_Lbl.Size = new Size(51, 20);
            Totals_Lbl.TabIndex = 7;
            Totals_Lbl.Text = "Totals:";
            // 
            // dataGridView2
            // 
            dataGridView2.AutoGenerateColumns = false;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { grossTotalDataGridViewTextBoxColumn, netTotalDataGridViewTextBoxColumn, regularPayTotalDataGridViewTextBoxColumn, overtimePayTotalDataGridViewTextBoxColumn, timeOffPayTotalDataGridViewTextBoxColumn, regularHoursTotalDataGridViewTextBoxColumn, overtimeHoursTotalDataGridViewTextBoxColumn, timeOffHoursTotalDataGridViewTextBoxColumn, doNotPayHoursTotalDataGridViewTextBoxColumn });
            dataGridView2.DataSource = totalsBindingSource;
            dataGridView2.Location = new Point(1015, 740);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersVisible = false;
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(1034, 61);
            dataGridView2.TabIndex = 8;
            // 
            // grossTotalDataGridViewTextBoxColumn
            // 
            grossTotalDataGridViewTextBoxColumn.DataPropertyName = "grossTotal";
            grossTotalDataGridViewTextBoxColumn.HeaderText = "Gross";
            grossTotalDataGridViewTextBoxColumn.MinimumWidth = 6;
            grossTotalDataGridViewTextBoxColumn.Name = "grossTotalDataGridViewTextBoxColumn";
            grossTotalDataGridViewTextBoxColumn.ReadOnly = true;
            grossTotalDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.False;
            grossTotalDataGridViewTextBoxColumn.ToolTipText = "Gross Total";
            grossTotalDataGridViewTextBoxColumn.Width = 125;
            // 
            // netTotalDataGridViewTextBoxColumn
            // 
            netTotalDataGridViewTextBoxColumn.DataPropertyName = "netTotal";
            netTotalDataGridViewTextBoxColumn.HeaderText = "Net";
            netTotalDataGridViewTextBoxColumn.MinimumWidth = 6;
            netTotalDataGridViewTextBoxColumn.Name = "netTotalDataGridViewTextBoxColumn";
            netTotalDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.False;
            netTotalDataGridViewTextBoxColumn.ToolTipText = "Net Total";
            netTotalDataGridViewTextBoxColumn.Width = 125;
            // 
            // regularPayTotalDataGridViewTextBoxColumn
            // 
            regularPayTotalDataGridViewTextBoxColumn.DataPropertyName = "regularPayTotal";
            regularPayTotalDataGridViewTextBoxColumn.HeaderText = "Regular(P)";
            regularPayTotalDataGridViewTextBoxColumn.MinimumWidth = 6;
            regularPayTotalDataGridViewTextBoxColumn.Name = "regularPayTotalDataGridViewTextBoxColumn";
            regularPayTotalDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.False;
            regularPayTotalDataGridViewTextBoxColumn.ToolTipText = "Regular Pay";
            regularPayTotalDataGridViewTextBoxColumn.Width = 125;
            // 
            // overtimePayTotalDataGridViewTextBoxColumn
            // 
            overtimePayTotalDataGridViewTextBoxColumn.DataPropertyName = "overtimePayTotal";
            overtimePayTotalDataGridViewTextBoxColumn.HeaderText = "Overtime(P)";
            overtimePayTotalDataGridViewTextBoxColumn.MinimumWidth = 6;
            overtimePayTotalDataGridViewTextBoxColumn.Name = "overtimePayTotalDataGridViewTextBoxColumn";
            overtimePayTotalDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.False;
            overtimePayTotalDataGridViewTextBoxColumn.ToolTipText = "Overtime Pay";
            overtimePayTotalDataGridViewTextBoxColumn.Width = 125;
            // 
            // timeOffPayTotalDataGridViewTextBoxColumn
            // 
            timeOffPayTotalDataGridViewTextBoxColumn.DataPropertyName = "timeOffPayTotal";
            timeOffPayTotalDataGridViewTextBoxColumn.HeaderText = "Time Off(P)";
            timeOffPayTotalDataGridViewTextBoxColumn.MinimumWidth = 6;
            timeOffPayTotalDataGridViewTextBoxColumn.Name = "timeOffPayTotalDataGridViewTextBoxColumn";
            timeOffPayTotalDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.False;
            timeOffPayTotalDataGridViewTextBoxColumn.ToolTipText = "Time Off Pay";
            timeOffPayTotalDataGridViewTextBoxColumn.Width = 125;
            // 
            // regularHoursTotalDataGridViewTextBoxColumn
            // 
            regularHoursTotalDataGridViewTextBoxColumn.DataPropertyName = "regularHoursTotal";
            regularHoursTotalDataGridViewTextBoxColumn.HeaderText = "Regular(H)";
            regularHoursTotalDataGridViewTextBoxColumn.MinimumWidth = 6;
            regularHoursTotalDataGridViewTextBoxColumn.Name = "regularHoursTotalDataGridViewTextBoxColumn";
            regularHoursTotalDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.False;
            regularHoursTotalDataGridViewTextBoxColumn.ToolTipText = "Regular Hours";
            regularHoursTotalDataGridViewTextBoxColumn.Width = 125;
            // 
            // overtimeHoursTotalDataGridViewTextBoxColumn
            // 
            overtimeHoursTotalDataGridViewTextBoxColumn.DataPropertyName = "overtimeHoursTotal";
            overtimeHoursTotalDataGridViewTextBoxColumn.HeaderText = "Overtime(H)";
            overtimeHoursTotalDataGridViewTextBoxColumn.MinimumWidth = 6;
            overtimeHoursTotalDataGridViewTextBoxColumn.Name = "overtimeHoursTotalDataGridViewTextBoxColumn";
            overtimeHoursTotalDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.False;
            overtimeHoursTotalDataGridViewTextBoxColumn.ToolTipText = "Overtime Hours";
            overtimeHoursTotalDataGridViewTextBoxColumn.Width = 125;
            // 
            // timeOffHoursTotalDataGridViewTextBoxColumn
            // 
            timeOffHoursTotalDataGridViewTextBoxColumn.DataPropertyName = "timeOffHoursTotal";
            timeOffHoursTotalDataGridViewTextBoxColumn.HeaderText = "Time Off(H)";
            timeOffHoursTotalDataGridViewTextBoxColumn.MinimumWidth = 6;
            timeOffHoursTotalDataGridViewTextBoxColumn.Name = "timeOffHoursTotalDataGridViewTextBoxColumn";
            timeOffHoursTotalDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.False;
            timeOffHoursTotalDataGridViewTextBoxColumn.ToolTipText = "Time Off Hours";
            timeOffHoursTotalDataGridViewTextBoxColumn.Width = 125;
            // 
            // doNotPayHoursTotalDataGridViewTextBoxColumn
            // 
            doNotPayHoursTotalDataGridViewTextBoxColumn.DataPropertyName = "doNotPayHoursTotal";
            doNotPayHoursTotalDataGridViewTextBoxColumn.HeaderText = "Do Not Pay(H)";
            doNotPayHoursTotalDataGridViewTextBoxColumn.MinimumWidth = 6;
            doNotPayHoursTotalDataGridViewTextBoxColumn.Name = "doNotPayHoursTotalDataGridViewTextBoxColumn";
            doNotPayHoursTotalDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.False;
            doNotPayHoursTotalDataGridViewTextBoxColumn.ToolTipText = "Do Not Pay Hours";
            doNotPayHoursTotalDataGridViewTextBoxColumn.Width = 155;
            // 
            // totalsBindingSource
            // 
            totalsBindingSource.DataSource = typeof(Totals);
            // 
            // iDGLCompanyDataGridViewTextBoxColumn
            // 
            iDGLCompanyDataGridViewTextBoxColumn.DataPropertyName = "IDGLCompany";
            iDGLCompanyDataGridViewTextBoxColumn.HeaderText = "Company ID";
            iDGLCompanyDataGridViewTextBoxColumn.MinimumWidth = 6;
            iDGLCompanyDataGridViewTextBoxColumn.Name = "iDGLCompanyDataGridViewTextBoxColumn";
            iDGLCompanyDataGridViewTextBoxColumn.Width = 85;
            // 
            // cGLCompanyIDDataGridViewTextBoxColumn
            // 
            cGLCompanyIDDataGridViewTextBoxColumn.DataPropertyName = "CGLCompanyID";
            cGLCompanyIDDataGridViewTextBoxColumn.HeaderText = "CGLCompanyID";
            cGLCompanyIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            cGLCompanyIDDataGridViewTextBoxColumn.Name = "cGLCompanyIDDataGridViewTextBoxColumn";
            cGLCompanyIDDataGridViewTextBoxColumn.Visible = false;
            cGLCompanyIDDataGridViewTextBoxColumn.Width = 95;
            // 
            // iDPREEmployeeDataGridViewTextBoxColumn
            // 
            iDPREEmployeeDataGridViewTextBoxColumn.DataPropertyName = "IDPREEmployee";
            iDPREEmployeeDataGridViewTextBoxColumn.HeaderText = "Employee ID";
            iDPREEmployeeDataGridViewTextBoxColumn.MinimumWidth = 6;
            iDPREEmployeeDataGridViewTextBoxColumn.Name = "iDPREEmployeeDataGridViewTextBoxColumn";
            // 
            // CEmployeeName
            // 
            CEmployeeName.DataPropertyName = "CEmployeeName";
            CEmployeeName.HeaderText = "Employee Name";
            CEmployeeName.MinimumWidth = 6;
            CEmployeeName.Name = "CEmployeeName";
            CEmployeeName.Width = 200;
            // 
            // cCheckNumberDataGridViewTextBoxColumn
            // 
            cCheckNumberDataGridViewTextBoxColumn.DataPropertyName = "CCheckNumber";
            cCheckNumberDataGridViewTextBoxColumn.HeaderText = "Check Number";
            cCheckNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            cCheckNumberDataGridViewTextBoxColumn.Name = "cCheckNumberDataGridViewTextBoxColumn";
            cCheckNumberDataGridViewTextBoxColumn.Width = 120;
            // 
            // dCheckDateDataGridViewTextBoxColumn
            // 
            dCheckDateDataGridViewTextBoxColumn.DataPropertyName = "DCheckDate";
            dCheckDateDataGridViewTextBoxColumn.HeaderText = "Check Date";
            dCheckDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            dCheckDateDataGridViewTextBoxColumn.Name = "dCheckDateDataGridViewTextBoxColumn";
            dCheckDateDataGridViewTextBoxColumn.Width = 110;
            // 
            // dAccountingDateDataGridViewTextBoxColumn
            // 
            dAccountingDateDataGridViewTextBoxColumn.DataPropertyName = "DAccountingDate";
            dAccountingDateDataGridViewTextBoxColumn.HeaderText = "Accounting Date";
            dAccountingDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            dAccountingDateDataGridViewTextBoxColumn.Name = "dAccountingDateDataGridViewTextBoxColumn";
            dAccountingDateDataGridViewTextBoxColumn.Width = 110;
            // 
            // dPayPeriodStartDataGridViewTextBoxColumn
            // 
            dPayPeriodStartDataGridViewTextBoxColumn.DataPropertyName = "DPayPeriodStart";
            dPayPeriodStartDataGridViewTextBoxColumn.HeaderText = "Pay Period Start";
            dPayPeriodStartDataGridViewTextBoxColumn.MinimumWidth = 6;
            dPayPeriodStartDataGridViewTextBoxColumn.Name = "dPayPeriodStartDataGridViewTextBoxColumn";
            dPayPeriodStartDataGridViewTextBoxColumn.Width = 110;
            // 
            // dPayPeriodEndDataGridViewTextBoxColumn
            // 
            dPayPeriodEndDataGridViewTextBoxColumn.DataPropertyName = "DPayPeriodEnd";
            dPayPeriodEndDataGridViewTextBoxColumn.HeaderText = "Pay Period End";
            dPayPeriodEndDataGridViewTextBoxColumn.MinimumWidth = 6;
            dPayPeriodEndDataGridViewTextBoxColumn.Name = "dPayPeriodEndDataGridViewTextBoxColumn";
            dPayPeriodEndDataGridViewTextBoxColumn.Width = 110;
            // 
            // nGrossAmountDataGridViewTextBoxColumn
            // 
            nGrossAmountDataGridViewTextBoxColumn.DataPropertyName = "NGrossAmount";
            nGrossAmountDataGridViewTextBoxColumn.HeaderText = "Gross Amount";
            nGrossAmountDataGridViewTextBoxColumn.MinimumWidth = 6;
            nGrossAmountDataGridViewTextBoxColumn.Name = "nGrossAmountDataGridViewTextBoxColumn";
            nGrossAmountDataGridViewTextBoxColumn.Width = 125;
            // 
            // nNetAmountDataGridViewTextBoxColumn
            // 
            nNetAmountDataGridViewTextBoxColumn.DataPropertyName = "NNetAmount";
            nNetAmountDataGridViewTextBoxColumn.HeaderText = "Net Amount";
            nNetAmountDataGridViewTextBoxColumn.MinimumWidth = 6;
            nNetAmountDataGridViewTextBoxColumn.Name = "nNetAmountDataGridViewTextBoxColumn";
            nNetAmountDataGridViewTextBoxColumn.Width = 125;
            // 
            // nRegularPayDataGridViewTextBoxColumn
            // 
            nRegularPayDataGridViewTextBoxColumn.DataPropertyName = "NRegularPay";
            nRegularPayDataGridViewTextBoxColumn.HeaderText = "Regular Pay";
            nRegularPayDataGridViewTextBoxColumn.MinimumWidth = 6;
            nRegularPayDataGridViewTextBoxColumn.Name = "nRegularPayDataGridViewTextBoxColumn";
            nRegularPayDataGridViewTextBoxColumn.Width = 110;
            // 
            // nOvertimePayDataGridViewTextBoxColumn
            // 
            nOvertimePayDataGridViewTextBoxColumn.DataPropertyName = "NOvertimePay";
            nOvertimePayDataGridViewTextBoxColumn.HeaderText = "NOvertimePay";
            nOvertimePayDataGridViewTextBoxColumn.MinimumWidth = 6;
            nOvertimePayDataGridViewTextBoxColumn.Name = "nOvertimePayDataGridViewTextBoxColumn";
            nOvertimePayDataGridViewTextBoxColumn.Width = 110;
            // 
            // nTimeOffPayDataGridViewTextBoxColumn
            // 
            nTimeOffPayDataGridViewTextBoxColumn.DataPropertyName = "NTimeOffPay";
            nTimeOffPayDataGridViewTextBoxColumn.HeaderText = "Overtime Pay";
            nTimeOffPayDataGridViewTextBoxColumn.MinimumWidth = 6;
            nTimeOffPayDataGridViewTextBoxColumn.Name = "nTimeOffPayDataGridViewTextBoxColumn";
            nTimeOffPayDataGridViewTextBoxColumn.Width = 110;
            // 
            // nRegularHoursDataGridViewTextBoxColumn
            // 
            nRegularHoursDataGridViewTextBoxColumn.DataPropertyName = "NRegularHours";
            nRegularHoursDataGridViewTextBoxColumn.HeaderText = "Regular Hours";
            nRegularHoursDataGridViewTextBoxColumn.MinimumWidth = 6;
            nRegularHoursDataGridViewTextBoxColumn.Name = "nRegularHoursDataGridViewTextBoxColumn";
            nRegularHoursDataGridViewTextBoxColumn.Width = 115;
            // 
            // nOvertimeHoursDataGridViewTextBoxColumn
            // 
            nOvertimeHoursDataGridViewTextBoxColumn.DataPropertyName = "NOvertimeHours";
            nOvertimeHoursDataGridViewTextBoxColumn.HeaderText = "Overtime Hours";
            nOvertimeHoursDataGridViewTextBoxColumn.MinimumWidth = 6;
            nOvertimeHoursDataGridViewTextBoxColumn.Name = "nOvertimeHoursDataGridViewTextBoxColumn";
            nOvertimeHoursDataGridViewTextBoxColumn.Width = 115;
            // 
            // nTimeOffHoursDataGridViewTextBoxColumn
            // 
            nTimeOffHoursDataGridViewTextBoxColumn.DataPropertyName = "NTimeOffHours";
            nTimeOffHoursDataGridViewTextBoxColumn.HeaderText = "Time Off Hours";
            nTimeOffHoursDataGridViewTextBoxColumn.MinimumWidth = 6;
            nTimeOffHoursDataGridViewTextBoxColumn.Name = "nTimeOffHoursDataGridViewTextBoxColumn";
            nTimeOffHoursDataGridViewTextBoxColumn.Width = 115;
            // 
            // nDoNotPayHoursDataGridViewTextBoxColumn
            // 
            nDoNotPayHoursDataGridViewTextBoxColumn.DataPropertyName = "NDoNotPayHours";
            nDoNotPayHoursDataGridViewTextBoxColumn.HeaderText = "Do Not Pay Hours";
            nDoNotPayHoursDataGridViewTextBoxColumn.MinimumWidth = 6;
            nDoNotPayHoursDataGridViewTextBoxColumn.Name = "nDoNotPayHoursDataGridViewTextBoxColumn";
            nDoNotPayHoursDataGridViewTextBoxColumn.Width = 115;
            // 
            // bPRModuleDataGridViewCheckBoxColumn
            // 
            bPRModuleDataGridViewCheckBoxColumn.DataPropertyName = "BPRModule";
            bPRModuleDataGridViewCheckBoxColumn.HeaderText = "BPRModule";
            bPRModuleDataGridViewCheckBoxColumn.MinimumWidth = 6;
            bPRModuleDataGridViewCheckBoxColumn.Name = "bPRModuleDataGridViewCheckBoxColumn";
            bPRModuleDataGridViewCheckBoxColumn.Visible = false;
            bPRModuleDataGridViewCheckBoxColumn.Width = 125;
            // 
            // cImportBatchIDDataGridViewTextBoxColumn
            // 
            cImportBatchIDDataGridViewTextBoxColumn.DataPropertyName = "CImportBatchID";
            cImportBatchIDDataGridViewTextBoxColumn.HeaderText = "CImportBatchID";
            cImportBatchIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            cImportBatchIDDataGridViewTextBoxColumn.Name = "cImportBatchIDDataGridViewTextBoxColumn";
            cImportBatchIDDataGridViewTextBoxColumn.Visible = false;
            cImportBatchIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2199, 1107);
            Controls.Add(dataGridView2);
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
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)totalsBindingSource).EndInit();
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
        private DataGridView dataGridView2;
        private BindingSource totalsBindingSource;
        private DataGridViewTextBoxColumn grossTotalDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn netTotalDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn regularPayTotalDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn overtimePayTotalDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn timeOffPayTotalDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn regularHoursTotalDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn overtimeHoursTotalDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn timeOffHoursTotalDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn doNotPayHoursTotalDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn iDGLCompanyDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cGLCompanyIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn iDPREEmployeeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn CEmployeeName;
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
