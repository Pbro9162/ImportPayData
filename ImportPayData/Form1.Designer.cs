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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            btnBrowse = new Button();
            dataGridView1 = new DataGridView();
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
            Ccomments = new DataGridViewTextBoxColumn();
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
            label3 = new Label();
            batchid_txt = new TextBox();
            delete_record_btn = new Button();
            toolTip1 = new ToolTip(components);
            exit_btn = new Button();
            clearAll_btn = new Button();
            comments_txtbox = new TextBox();
            Comments_label = new Label();
            comments_editsave_btn = new Button();
            comments_clear_btn = new Button();
            parent_panel = new Panel();
            panel5 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel2 = new Panel();
            panel4 = new Panel();
            panel3 = new Panel();
            panel1 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            gridview_tablelayoutpanel = new TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pRTransactionMasterBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)totalsBindingSource).BeginInit();
            parent_panel.SuspendLayout();
            panel5.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            gridview_tablelayoutpanel.SuspendLayout();
            SuspendLayout();
            // 
            // btnBrowse
            // 
            btnBrowse.Anchor = AnchorStyles.Left;
            btnBrowse.Location = new Point(713, 3);
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
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 7F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { iDGLCompanyDataGridViewTextBoxColumn, cGLCompanyIDDataGridViewTextBoxColumn, iDPREEmployeeDataGridViewTextBoxColumn, CEmployeeName, cCheckNumberDataGridViewTextBoxColumn, dCheckDateDataGridViewTextBoxColumn, dAccountingDateDataGridViewTextBoxColumn, dPayPeriodStartDataGridViewTextBoxColumn, dPayPeriodEndDataGridViewTextBoxColumn, nGrossAmountDataGridViewTextBoxColumn, nNetAmountDataGridViewTextBoxColumn, nRegularPayDataGridViewTextBoxColumn, nOvertimePayDataGridViewTextBoxColumn, nTimeOffPayDataGridViewTextBoxColumn, nRegularHoursDataGridViewTextBoxColumn, nOvertimeHoursDataGridViewTextBoxColumn, nTimeOffHoursDataGridViewTextBoxColumn, nDoNotPayHoursDataGridViewTextBoxColumn, bPRModuleDataGridViewCheckBoxColumn, cImportBatchIDDataGridViewTextBoxColumn, Ccomments });
            dataGridView1.DataSource = pRTransactionMasterBindingSource;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(75, 13);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 35;
            dataGridView1.Size = new Size(1796, 641);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellValueChanged += DataGridView1_CellValueChanged;
            // 
            // iDGLCompanyDataGridViewTextBoxColumn
            // 
            iDGLCompanyDataGridViewTextBoxColumn.DataPropertyName = "IDGLCompany";
            iDGLCompanyDataGridViewTextBoxColumn.HeaderText = "Company ID";
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
            cGLCompanyIDDataGridViewTextBoxColumn.Visible = false;
            cGLCompanyIDDataGridViewTextBoxColumn.Width = 95;
            // 
            // iDPREEmployeeDataGridViewTextBoxColumn
            // 
            iDPREEmployeeDataGridViewTextBoxColumn.DataPropertyName = "IDPREEmployee";
            iDPREEmployeeDataGridViewTextBoxColumn.HeaderText = "Employee ID";
            iDPREEmployeeDataGridViewTextBoxColumn.MinimumWidth = 6;
            iDPREEmployeeDataGridViewTextBoxColumn.Name = "iDPREEmployeeDataGridViewTextBoxColumn";
            iDPREEmployeeDataGridViewTextBoxColumn.Width = 99;
            // 
            // CEmployeeName
            // 
            CEmployeeName.DataPropertyName = "CEmployeeName";
            CEmployeeName.HeaderText = "Employee Name";
            CEmployeeName.MinimumWidth = 6;
            CEmployeeName.Name = "CEmployeeName";
            CEmployeeName.Width = 125;
            // 
            // cCheckNumberDataGridViewTextBoxColumn
            // 
            cCheckNumberDataGridViewTextBoxColumn.DataPropertyName = "CCheckNumber";
            cCheckNumberDataGridViewTextBoxColumn.HeaderText = "Check Number";
            cCheckNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            cCheckNumberDataGridViewTextBoxColumn.Name = "cCheckNumberDataGridViewTextBoxColumn";
            cCheckNumberDataGridViewTextBoxColumn.Width = 99;
            // 
            // dCheckDateDataGridViewTextBoxColumn
            // 
            dCheckDateDataGridViewTextBoxColumn.DataPropertyName = "DCheckDate";
            dCheckDateDataGridViewTextBoxColumn.HeaderText = "Check Date";
            dCheckDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            dCheckDateDataGridViewTextBoxColumn.Name = "dCheckDateDataGridViewTextBoxColumn";
            dCheckDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // dAccountingDateDataGridViewTextBoxColumn
            // 
            dAccountingDateDataGridViewTextBoxColumn.DataPropertyName = "DAccountingDate";
            dAccountingDateDataGridViewTextBoxColumn.HeaderText = "Accounting Date";
            dAccountingDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            dAccountingDateDataGridViewTextBoxColumn.Name = "dAccountingDateDataGridViewTextBoxColumn";
            dAccountingDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // dPayPeriodStartDataGridViewTextBoxColumn
            // 
            dPayPeriodStartDataGridViewTextBoxColumn.DataPropertyName = "DPayPeriodStart";
            dPayPeriodStartDataGridViewTextBoxColumn.HeaderText = "Pay Period Start";
            dPayPeriodStartDataGridViewTextBoxColumn.MinimumWidth = 6;
            dPayPeriodStartDataGridViewTextBoxColumn.Name = "dPayPeriodStartDataGridViewTextBoxColumn";
            dPayPeriodStartDataGridViewTextBoxColumn.Width = 99;
            // 
            // dPayPeriodEndDataGridViewTextBoxColumn
            // 
            dPayPeriodEndDataGridViewTextBoxColumn.DataPropertyName = "DPayPeriodEnd";
            dPayPeriodEndDataGridViewTextBoxColumn.HeaderText = "Pay Period End";
            dPayPeriodEndDataGridViewTextBoxColumn.MinimumWidth = 6;
            dPayPeriodEndDataGridViewTextBoxColumn.Name = "dPayPeriodEndDataGridViewTextBoxColumn";
            dPayPeriodEndDataGridViewTextBoxColumn.Width = 125;
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
            nNetAmountDataGridViewTextBoxColumn.Width = 99;
            // 
            // nRegularPayDataGridViewTextBoxColumn
            // 
            nRegularPayDataGridViewTextBoxColumn.DataPropertyName = "NRegularPay";
            nRegularPayDataGridViewTextBoxColumn.HeaderText = "Regular Pay";
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
            nOvertimePayDataGridViewTextBoxColumn.Width = 99;
            // 
            // nTimeOffPayDataGridViewTextBoxColumn
            // 
            nTimeOffPayDataGridViewTextBoxColumn.DataPropertyName = "NTimeOffPay";
            nTimeOffPayDataGridViewTextBoxColumn.HeaderText = "Overtime Pay";
            nTimeOffPayDataGridViewTextBoxColumn.MinimumWidth = 6;
            nTimeOffPayDataGridViewTextBoxColumn.Name = "nTimeOffPayDataGridViewTextBoxColumn";
            nTimeOffPayDataGridViewTextBoxColumn.Width = 125;
            // 
            // nRegularHoursDataGridViewTextBoxColumn
            // 
            nRegularHoursDataGridViewTextBoxColumn.DataPropertyName = "NRegularHours";
            nRegularHoursDataGridViewTextBoxColumn.HeaderText = "Regular Hours";
            nRegularHoursDataGridViewTextBoxColumn.MinimumWidth = 6;
            nRegularHoursDataGridViewTextBoxColumn.Name = "nRegularHoursDataGridViewTextBoxColumn";
            nRegularHoursDataGridViewTextBoxColumn.Width = 125;
            // 
            // nOvertimeHoursDataGridViewTextBoxColumn
            // 
            nOvertimeHoursDataGridViewTextBoxColumn.DataPropertyName = "NOvertimeHours";
            nOvertimeHoursDataGridViewTextBoxColumn.HeaderText = "Overtime Hours";
            nOvertimeHoursDataGridViewTextBoxColumn.MinimumWidth = 6;
            nOvertimeHoursDataGridViewTextBoxColumn.Name = "nOvertimeHoursDataGridViewTextBoxColumn";
            nOvertimeHoursDataGridViewTextBoxColumn.Width = 99;
            // 
            // nTimeOffHoursDataGridViewTextBoxColumn
            // 
            nTimeOffHoursDataGridViewTextBoxColumn.DataPropertyName = "NTimeOffHours";
            nTimeOffHoursDataGridViewTextBoxColumn.HeaderText = "Time Off Hours";
            nTimeOffHoursDataGridViewTextBoxColumn.MinimumWidth = 6;
            nTimeOffHoursDataGridViewTextBoxColumn.Name = "nTimeOffHoursDataGridViewTextBoxColumn";
            nTimeOffHoursDataGridViewTextBoxColumn.Width = 125;
            // 
            // nDoNotPayHoursDataGridViewTextBoxColumn
            // 
            nDoNotPayHoursDataGridViewTextBoxColumn.DataPropertyName = "NDoNotPayHours";
            nDoNotPayHoursDataGridViewTextBoxColumn.HeaderText = "Do Not Pay Hours";
            nDoNotPayHoursDataGridViewTextBoxColumn.MinimumWidth = 6;
            nDoNotPayHoursDataGridViewTextBoxColumn.Name = "nDoNotPayHoursDataGridViewTextBoxColumn";
            nDoNotPayHoursDataGridViewTextBoxColumn.Width = 99;
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
            // Ccomments
            // 
            Ccomments.DataPropertyName = "Ccomments";
            Ccomments.HeaderText = "Comments";
            Ccomments.MinimumWidth = 6;
            Ccomments.Name = "Ccomments";
            Ccomments.ReadOnly = true;
            Ccomments.Width = 125;
            // 
            // pRTransactionMasterBindingSource
            // 
            pRTransactionMasterBindingSource.DataSource = typeof(PRTransactionMaster);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(79, 20);
            label1.TabIndex = 2;
            label1.Text = "File Name:";
            // 
            // cboSheet
            // 
            cboSheet.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cboSheet.FormattingEnabled = true;
            cboSheet.Location = new Point(114, 38);
            cboSheet.Name = "cboSheet";
            cboSheet.Size = new Size(593, 28);
            cboSheet.TabIndex = 3;
            cboSheet.SelectedIndexChanged += CboSheet_SelectedIndexChanged;
            // 
            // txtFilename
            // 
            txtFilename.Location = new Point(114, 3);
            txtFilename.Name = "txtFilename";
            txtFilename.ReadOnly = true;
            txtFilename.Size = new Size(591, 27);
            txtFilename.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 35);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 5;
            label2.Text = "Sheet:";
            // 
            // btnImport
            // 
            btnImport.Anchor = AnchorStyles.Left;
            btnImport.Location = new Point(713, 38);
            btnImport.Name = "btnImport";
            btnImport.Size = new Size(115, 29);
            btnImport.TabIndex = 6;
            btnImport.Text = "&Import";
            btnImport.UseVisualStyleBackColor = true;
            btnImport.Click += BtnImport_Click;
            // 
            // Totals_Lbl
            // 
            Totals_Lbl.AutoSize = true;
            Totals_Lbl.Dock = DockStyle.Left;
            Totals_Lbl.Location = new Point(0, 0);
            Totals_Lbl.Name = "Totals_Lbl";
            Totals_Lbl.Size = new Size(51, 20);
            Totals_Lbl.TabIndex = 7;
            Totals_Lbl.Text = "Totals:";
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.AllowUserToResizeColumns = false;
            dataGridView2.AllowUserToResizeRows = false;
            dataGridView2.AutoGenerateColumns = false;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView2.ColumnHeadersHeight = 30;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { grossTotalDataGridViewTextBoxColumn, netTotalDataGridViewTextBoxColumn, regularPayTotalDataGridViewTextBoxColumn, overtimePayTotalDataGridViewTextBoxColumn, timeOffPayTotalDataGridViewTextBoxColumn, regularHoursTotalDataGridViewTextBoxColumn, overtimeHoursTotalDataGridViewTextBoxColumn, timeOffHoursTotalDataGridViewTextBoxColumn, doNotPayHoursTotalDataGridViewTextBoxColumn });
            dataGridView2.DataSource = totalsBindingSource;
            dataGridView2.Dock = DockStyle.Left;
            dataGridView2.Location = new Point(51, 0);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.RowHeadersVisible = false;
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridView2.Size = new Size(1049, 59);
            dataGridView2.TabIndex = 8;
            // 
            // grossTotalDataGridViewTextBoxColumn
            // 
            grossTotalDataGridViewTextBoxColumn.DataPropertyName = "grossTotal";
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 6F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grossTotalDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
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
            dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 6F, FontStyle.Bold, GraphicsUnit.Point, 0);
            netTotalDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            netTotalDataGridViewTextBoxColumn.HeaderText = "Net";
            netTotalDataGridViewTextBoxColumn.MinimumWidth = 6;
            netTotalDataGridViewTextBoxColumn.Name = "netTotalDataGridViewTextBoxColumn";
            netTotalDataGridViewTextBoxColumn.ReadOnly = true;
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
            regularPayTotalDataGridViewTextBoxColumn.ReadOnly = true;
            regularPayTotalDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.False;
            regularPayTotalDataGridViewTextBoxColumn.ToolTipText = "Regular Pay";
            regularPayTotalDataGridViewTextBoxColumn.Width = 110;
            // 
            // overtimePayTotalDataGridViewTextBoxColumn
            // 
            overtimePayTotalDataGridViewTextBoxColumn.DataPropertyName = "overtimePayTotal";
            overtimePayTotalDataGridViewTextBoxColumn.HeaderText = "Overtime(P)";
            overtimePayTotalDataGridViewTextBoxColumn.MinimumWidth = 6;
            overtimePayTotalDataGridViewTextBoxColumn.Name = "overtimePayTotalDataGridViewTextBoxColumn";
            overtimePayTotalDataGridViewTextBoxColumn.ReadOnly = true;
            overtimePayTotalDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.False;
            overtimePayTotalDataGridViewTextBoxColumn.ToolTipText = "Overtime Pay";
            overtimePayTotalDataGridViewTextBoxColumn.Width = 110;
            // 
            // timeOffPayTotalDataGridViewTextBoxColumn
            // 
            timeOffPayTotalDataGridViewTextBoxColumn.DataPropertyName = "timeOffPayTotal";
            timeOffPayTotalDataGridViewTextBoxColumn.HeaderText = "Time Off(P)";
            timeOffPayTotalDataGridViewTextBoxColumn.MinimumWidth = 6;
            timeOffPayTotalDataGridViewTextBoxColumn.Name = "timeOffPayTotalDataGridViewTextBoxColumn";
            timeOffPayTotalDataGridViewTextBoxColumn.ReadOnly = true;
            timeOffPayTotalDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.False;
            timeOffPayTotalDataGridViewTextBoxColumn.ToolTipText = "Time Off Pay";
            timeOffPayTotalDataGridViewTextBoxColumn.Width = 115;
            // 
            // regularHoursTotalDataGridViewTextBoxColumn
            // 
            regularHoursTotalDataGridViewTextBoxColumn.DataPropertyName = "regularHoursTotal";
            regularHoursTotalDataGridViewTextBoxColumn.HeaderText = "Regular(H)";
            regularHoursTotalDataGridViewTextBoxColumn.MinimumWidth = 6;
            regularHoursTotalDataGridViewTextBoxColumn.Name = "regularHoursTotalDataGridViewTextBoxColumn";
            regularHoursTotalDataGridViewTextBoxColumn.ReadOnly = true;
            regularHoursTotalDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.False;
            regularHoursTotalDataGridViewTextBoxColumn.ToolTipText = "Regular Hours";
            regularHoursTotalDataGridViewTextBoxColumn.Width = 115;
            // 
            // overtimeHoursTotalDataGridViewTextBoxColumn
            // 
            overtimeHoursTotalDataGridViewTextBoxColumn.DataPropertyName = "overtimeHoursTotal";
            overtimeHoursTotalDataGridViewTextBoxColumn.HeaderText = "Overtime(H)";
            overtimeHoursTotalDataGridViewTextBoxColumn.MinimumWidth = 6;
            overtimeHoursTotalDataGridViewTextBoxColumn.Name = "overtimeHoursTotalDataGridViewTextBoxColumn";
            overtimeHoursTotalDataGridViewTextBoxColumn.ReadOnly = true;
            overtimeHoursTotalDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.False;
            overtimeHoursTotalDataGridViewTextBoxColumn.ToolTipText = "Overtime Hours";
            overtimeHoursTotalDataGridViewTextBoxColumn.Width = 115;
            // 
            // timeOffHoursTotalDataGridViewTextBoxColumn
            // 
            timeOffHoursTotalDataGridViewTextBoxColumn.DataPropertyName = "timeOffHoursTotal";
            timeOffHoursTotalDataGridViewTextBoxColumn.HeaderText = "Time Off(H)";
            timeOffHoursTotalDataGridViewTextBoxColumn.MinimumWidth = 6;
            timeOffHoursTotalDataGridViewTextBoxColumn.Name = "timeOffHoursTotalDataGridViewTextBoxColumn";
            timeOffHoursTotalDataGridViewTextBoxColumn.ReadOnly = true;
            timeOffHoursTotalDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.False;
            timeOffHoursTotalDataGridViewTextBoxColumn.ToolTipText = "Time Off Hours";
            timeOffHoursTotalDataGridViewTextBoxColumn.Width = 115;
            // 
            // doNotPayHoursTotalDataGridViewTextBoxColumn
            // 
            doNotPayHoursTotalDataGridViewTextBoxColumn.DataPropertyName = "doNotPayHoursTotal";
            doNotPayHoursTotalDataGridViewTextBoxColumn.HeaderText = "Do Not Pay(H)";
            doNotPayHoursTotalDataGridViewTextBoxColumn.MinimumWidth = 6;
            doNotPayHoursTotalDataGridViewTextBoxColumn.Name = "doNotPayHoursTotalDataGridViewTextBoxColumn";
            doNotPayHoursTotalDataGridViewTextBoxColumn.ReadOnly = true;
            doNotPayHoursTotalDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.False;
            doNotPayHoursTotalDataGridViewTextBoxColumn.ToolTipText = "Do Not Pay Hours";
            doNotPayHoursTotalDataGridViewTextBoxColumn.Width = 115;
            // 
            // totalsBindingSource
            // 
            totalsBindingSource.DataSource = typeof(Totals);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Right;
            label3.Location = new Point(5, 0);
            label3.Name = "label3";
            label3.Size = new Size(68, 20);
            label3.TabIndex = 9;
            label3.Text = "Batch ID:";
            // 
            // batchid_txt
            // 
            batchid_txt.BackColor = SystemColors.ButtonHighlight;
            batchid_txt.BorderStyle = BorderStyle.FixedSingle;
            batchid_txt.Dock = DockStyle.Right;
            batchid_txt.Location = new Point(73, 0);
            batchid_txt.Name = "batchid_txt";
            batchid_txt.ReadOnly = true;
            batchid_txt.Size = new Size(226, 27);
            batchid_txt.TabIndex = 10;
            // 
            // delete_record_btn
            // 
            delete_record_btn.Anchor = AnchorStyles.None;
            delete_record_btn.Image = Properties.Resources.Microsoft_VisualStudio_Services_Icons;
            delete_record_btn.Location = new Point(20, 312);
            delete_record_btn.Name = "delete_record_btn";
            delete_record_btn.Size = new Size(42, 42);
            delete_record_btn.TabIndex = 11;
            toolTip1.SetToolTip(delete_record_btn, "Delete Row\r\n");
            delete_record_btn.UseVisualStyleBackColor = true;
            delete_record_btn.Click += delete_record_btn_Click;
            // 
            // toolTip1
            // 
            toolTip1.BackColor = SystemColors.ButtonFace;
            toolTip1.Tag = "Delete Row";
            // 
            // exit_btn
            // 
            exit_btn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            exit_btn.Location = new Point(118, 5);
            exit_btn.Name = "exit_btn";
            exit_btn.Size = new Size(94, 29);
            exit_btn.TabIndex = 21;
            exit_btn.Text = "Exit";
            toolTip1.SetToolTip(exit_btn, "Close software");
            exit_btn.UseVisualStyleBackColor = true;
            exit_btn.Click += exit_btn_Click;
            // 
            // clearAll_btn
            // 
            clearAll_btn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            clearAll_btn.Location = new Point(18, 5);
            clearAll_btn.Name = "clearAll_btn";
            clearAll_btn.Size = new Size(94, 29);
            clearAll_btn.TabIndex = 22;
            clearAll_btn.Text = "Clear All";
            toolTip1.SetToolTip(clearAll_btn, "Erases all data in the current grid view");
            clearAll_btn.UseVisualStyleBackColor = true;
            clearAll_btn.Click += clearAll_btn_Click;
            // 
            // comments_txtbox
            // 
            comments_txtbox.Anchor = AnchorStyles.None;
            comments_txtbox.BorderStyle = BorderStyle.FixedSingle;
            comments_txtbox.Location = new Point(114, 18);
            comments_txtbox.Multiline = true;
            comments_txtbox.Name = "comments_txtbox";
            comments_txtbox.ReadOnly = true;
            comments_txtbox.Size = new Size(408, 197);
            comments_txtbox.TabIndex = 16;
            // 
            // Comments_label
            // 
            Comments_label.Anchor = AnchorStyles.None;
            Comments_label.AutoSize = true;
            Comments_label.Location = new Point(19, 20);
            Comments_label.Name = "Comments_label";
            Comments_label.Size = new Size(83, 20);
            Comments_label.TabIndex = 17;
            Comments_label.Text = "Comments:";
            // 
            // comments_editsave_btn
            // 
            comments_editsave_btn.Anchor = AnchorStyles.None;
            comments_editsave_btn.Location = new Point(8, 43);
            comments_editsave_btn.Name = "comments_editsave_btn";
            comments_editsave_btn.Size = new Size(94, 29);
            comments_editsave_btn.TabIndex = 18;
            comments_editsave_btn.Text = "Edit";
            comments_editsave_btn.UseVisualStyleBackColor = true;
            comments_editsave_btn.Click += comments_editsave_btn_Click;
            // 
            // comments_clear_btn
            // 
            comments_clear_btn.Anchor = AnchorStyles.None;
            comments_clear_btn.Location = new Point(8, 78);
            comments_clear_btn.Name = "comments_clear_btn";
            comments_clear_btn.Size = new Size(94, 29);
            comments_clear_btn.TabIndex = 19;
            comments_clear_btn.Text = "Clear All";
            comments_clear_btn.UseVisualStyleBackColor = true;
            comments_clear_btn.Click += comments_clear_btn_Click;
            // 
            // parent_panel
            // 
            parent_panel.Controls.Add(panel5);
            parent_panel.Controls.Add(flowLayoutPanel1);
            parent_panel.Dock = DockStyle.Top;
            parent_panel.Location = new Point(0, 0);
            parent_panel.Name = "parent_panel";
            parent_panel.Size = new Size(1902, 1033);
            parent_panel.TabIndex = 23;
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.None;
            panel5.Controls.Add(tableLayoutPanel1);
            panel5.Controls.Add(panel2);
            panel5.Controls.Add(panel4);
            panel5.Controls.Add(panel3);
            panel5.Controls.Add(panel1);
            panel5.Location = new Point(0, 673);
            panel5.Name = "panel5";
            panel5.Size = new Size(1890, 340);
            panel5.TabIndex = 6;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15.6716413F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 84.32836F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 121F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 59F));
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(txtFilename, 1, 0);
            tableLayoutPanel1.Controls.Add(cboSheet, 1, 1);
            tableLayoutPanel1.Controls.Add(btnBrowse, 2, 0);
            tableLayoutPanel1.Controls.Add(btnImport, 2, 1);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Location = new Point(66, 98);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 51.31579F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 48.68421F));
            tableLayoutPanel1.Size = new Size(891, 70);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(label3);
            panel2.Controls.Add(batchid_txt);
            panel2.Location = new Point(1562, 113);
            panel2.Name = "panel2";
            panel2.Size = new Size(299, 51);
            panel2.TabIndex = 3;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            panel4.Controls.Add(exit_btn);
            panel4.Controls.Add(clearAll_btn);
            panel4.Location = new Point(1665, 300);
            panel4.Name = "panel4";
            panel4.Size = new Size(222, 37);
            panel4.TabIndex = 5;
            // 
            // panel3
            // 
            panel3.Controls.Add(comments_editsave_btn);
            panel3.Controls.Add(Comments_label);
            panel3.Controls.Add(comments_clear_btn);
            panel3.Controls.Add(comments_txtbox);
            panel3.Location = new Point(981, 98);
            panel3.Name = "panel3";
            panel3.Size = new Size(554, 234);
            panel3.TabIndex = 4;
            // 
            // panel1
            // 
            panel1.Controls.Add(dataGridView2);
            panel1.Controls.Add(Totals_Lbl);
            panel1.Location = new Point(761, 20);
            panel1.Name = "panel1";
            panel1.Size = new Size(1114, 59);
            panel1.TabIndex = 2;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.None;
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.Controls.Add(gridview_tablelayoutpanel);
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1902, 673);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // gridview_tablelayoutpanel
            // 
            gridview_tablelayoutpanel.AutoSize = true;
            gridview_tablelayoutpanel.BackColor = SystemColors.ButtonFace;
            gridview_tablelayoutpanel.ColumnCount = 2;
            gridview_tablelayoutpanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 3.329753F));
            gridview_tablelayoutpanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 96.67025F));
            gridview_tablelayoutpanel.Controls.Add(dataGridView1, 1, 0);
            gridview_tablelayoutpanel.Controls.Add(delete_record_btn, 0, 0);
            gridview_tablelayoutpanel.Dock = DockStyle.Fill;
            gridview_tablelayoutpanel.Location = new Point(3, 3);
            gridview_tablelayoutpanel.Name = "gridview_tablelayoutpanel";
            gridview_tablelayoutpanel.Padding = new Padding(10);
            gridview_tablelayoutpanel.RowCount = 1;
            gridview_tablelayoutpanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            gridview_tablelayoutpanel.Size = new Size(1884, 667);
            gridview_tablelayoutpanel.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 1033);
            Controls.Add(parent_panel);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Import Payroll Transactions";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pRTransactionMasterBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)totalsBindingSource).EndInit();
            parent_panel.ResumeLayout(false);
            parent_panel.PerformLayout();
            panel5.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            gridview_tablelayoutpanel.ResumeLayout(false);
            ResumeLayout(false);
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
        private Label label3;
        private TextBox batchid_txt;
        private Button delete_record_btn;
        private ToolTip toolTip1;
        private TextBox comments_txtbox;
        private Label Comments_label;
        private Button comments_editsave_btn;
        private Button comments_clear_btn;
        private Button exit_btn;
        private Button clearAll_btn;
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
        private DataGridViewTextBoxColumn Ccomments;
        private Panel parent_panel;
        private TableLayoutPanel gridview_tablelayoutpanel;
        private FlowLayoutPanel flowLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private DataGridViewTextBoxColumn grossTotalDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn netTotalDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn regularPayTotalDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn overtimePayTotalDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn timeOffPayTotalDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn regularHoursTotalDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn overtimeHoursTotalDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn timeOffHoursTotalDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn doNotPayHoursTotalDataGridViewTextBoxColumn;
    }
}
