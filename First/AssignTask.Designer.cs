namespace First
{
    partial class AssignTask
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvStaffTask = new System.Windows.Forms.DataGridView();
            this.SNAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TNAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TDESCRIPTION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STATUS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.lblTaskDescription = new System.Windows.Forms.Label();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.txtTaskName = new System.Windows.Forms.TextBox();
            this.txtTaskDescription = new System.Windows.Forms.TextBox();
            this.lblTaskName = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.txtTaskID = new System.Windows.Forms.TextBox();
            this.lblTaskID = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblReportTime = new System.Windows.Forms.Label();
            this.txtReportTime = new System.Windows.Forms.TextBox();
            this.cmbStaffName = new System.Windows.Forms.ComboBox();
            this.lblSelectID = new System.Windows.Forms.Label();
            this.btnShowDetails = new System.Windows.Forms.Button();
            this.btnClearTask = new System.Windows.Forms.Button();
            this.btnUpdateTask = new System.Windows.Forms.Button();
            this.btnRemoveTask = new System.Windows.Forms.Button();
            this.btnAddTask = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.panelRight = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaffTask)).BeginInit();
            this.panelBottom.SuspendLayout();
            this.panelRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvStaffTask
            // 
            this.dgvStaffTask.AllowUserToAddRows = false;
            this.dgvStaffTask.AllowUserToDeleteRows = false;
            this.dgvStaffTask.AllowUserToResizeColumns = false;
            this.dgvStaffTask.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.InfoText;
            this.dgvStaffTask.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvStaffTask.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStaffTask.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvStaffTask.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStaffTask.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvStaffTask.ColumnHeadersHeight = 35;
            this.dgvStaffTask.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SNAME,
            this.TID,
            this.TNAME,
            this.TDESCRIPTION,
            this.TIME,
            this.STATUS});
            this.dgvStaffTask.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStaffTask.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvStaffTask.GridColor = System.Drawing.Color.Black;
            this.dgvStaffTask.Location = new System.Drawing.Point(14, 4);
            this.dgvStaffTask.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvStaffTask.Name = "dgvStaffTask";
            this.dgvStaffTask.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStaffTask.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvStaffTask.RowHeadersVisible = false;
            this.dgvStaffTask.RowHeadersWidth = 62;
            this.dgvStaffTask.RowTemplate.Height = 28;
            this.dgvStaffTask.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStaffTask.Size = new System.Drawing.Size(768, 271);
            this.dgvStaffTask.TabIndex = 50;
            this.dgvStaffTask.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStaffTask_CellContentClick);
            this.dgvStaffTask.DoubleClick += new System.EventHandler(this.dgvStaffTask_DoubleClick);
            // 
            // SNAME
            // 
            this.SNAME.DataPropertyName = "SNAME";
            this.SNAME.HeaderText = "Staff Name";
            this.SNAME.MinimumWidth = 8;
            this.SNAME.Name = "SNAME";
            this.SNAME.ReadOnly = true;
            // 
            // TID
            // 
            this.TID.DataPropertyName = "TID";
            this.TID.HeaderText = "Task ID";
            this.TID.MinimumWidth = 8;
            this.TID.Name = "TID";
            this.TID.ReadOnly = true;
            // 
            // TNAME
            // 
            this.TNAME.DataPropertyName = "TNAME";
            this.TNAME.HeaderText = "Task Name";
            this.TNAME.MinimumWidth = 8;
            this.TNAME.Name = "TNAME";
            this.TNAME.ReadOnly = true;
            // 
            // TDESCRIPTION
            // 
            this.TDESCRIPTION.DataPropertyName = "TDESCRIPTION";
            this.TDESCRIPTION.HeaderText = "Task Desription";
            this.TDESCRIPTION.MinimumWidth = 8;
            this.TDESCRIPTION.Name = "TDESCRIPTION";
            this.TDESCRIPTION.ReadOnly = true;
            // 
            // TIME
            // 
            this.TIME.DataPropertyName = "TIME";
            this.TIME.HeaderText = "Reporting Time";
            this.TIME.MinimumWidth = 6;
            this.TIME.Name = "TIME";
            this.TIME.ReadOnly = true;
            // 
            // STATUS
            // 
            this.STATUS.DataPropertyName = "STATUS";
            this.STATUS.HeaderText = "STATUS";
            this.STATUS.MinimumWidth = 6;
            this.STATUS.Name = "STATUS";
            this.STATUS.ReadOnly = true;
            // 
            // panelBottom
            // 
            this.panelBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelBottom.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelBottom.Controls.Add(this.dgvStaffTask);
            this.panelBottom.Location = new System.Drawing.Point(52, 309);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(789, 271);
            this.panelBottom.TabIndex = 94;
            this.panelBottom.Paint += new System.Windows.Forms.PaintEventHandler(this.panelBottom_Paint);
            // 
            // lblTaskDescription
            // 
            this.lblTaskDescription.AutoSize = true;
            this.lblTaskDescription.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaskDescription.ForeColor = System.Drawing.Color.White;
            this.lblTaskDescription.Location = new System.Drawing.Point(15, 153);
            this.lblTaskDescription.Name = "lblTaskDescription";
            this.lblTaskDescription.Size = new System.Drawing.Size(165, 21);
            this.lblTaskDescription.TabIndex = 82;
            this.lblTaskDescription.Text = "Task Description:";
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartment.Location = new System.Drawing.Point(30, 186);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(0, 20);
            this.lblDepartment.TabIndex = 85;
            // 
            // txtTaskName
            // 
            this.txtTaskName.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTaskName.Location = new System.Drawing.Point(204, 110);
            this.txtTaskName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTaskName.Name = "txtTaskName";
            this.txtTaskName.Size = new System.Drawing.Size(215, 27);
            this.txtTaskName.TabIndex = 83;
            // 
            // txtTaskDescription
            // 
            this.txtTaskDescription.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTaskDescription.Location = new System.Drawing.Point(204, 151);
            this.txtTaskDescription.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTaskDescription.Multiline = true;
            this.txtTaskDescription.Name = "txtTaskDescription";
            this.txtTaskDescription.Size = new System.Drawing.Size(215, 31);
            this.txtTaskDescription.TabIndex = 84;
            this.txtTaskDescription.TextChanged += new System.EventHandler(this.txtTaskDescription_TextChanged);
            // 
            // lblTaskName
            // 
            this.lblTaskName.AutoSize = true;
            this.lblTaskName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaskName.ForeColor = System.Drawing.Color.White;
            this.lblTaskName.Location = new System.Drawing.Point(60, 110);
            this.lblTaskName.Name = "lblTaskName";
            this.lblTaskName.Size = new System.Drawing.Size(120, 21);
            this.lblTaskName.TabIndex = 81;
            this.lblTaskName.Text = "Task Name :";
            // 
            // cmbStatus
            // 
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "Assigned",
            "On hold",
            "Completed"});
            this.cmbStatus.Location = new System.Drawing.Point(204, 246);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(215, 24);
            this.cmbStatus.TabIndex = 87;
            // 
            // txtTaskID
            // 
            this.txtTaskID.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTaskID.Location = new System.Drawing.Point(204, 60);
            this.txtTaskID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTaskID.Name = "txtTaskID";
            this.txtTaskID.ReadOnly = true;
            this.txtTaskID.Size = new System.Drawing.Size(89, 27);
            this.txtTaskID.TabIndex = 90;
            // 
            // lblTaskID
            // 
            this.lblTaskID.AutoSize = true;
            this.lblTaskID.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaskID.ForeColor = System.Drawing.Color.White;
            this.lblTaskID.Location = new System.Drawing.Point(93, 66);
            this.lblTaskID.Name = "lblTaskID";
            this.lblTaskID.Size = new System.Drawing.Size(87, 21);
            this.lblTaskID.TabIndex = 89;
            this.lblTaskID.Text = "Task ID :";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.White;
            this.lblStatus.Location = new System.Drawing.Point(103, 249);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(77, 21);
            this.lblStatus.TabIndex = 86;
            this.lblStatus.Text = "Status :";
            // 
            // lblReportTime
            // 
            this.lblReportTime.AutoSize = true;
            this.lblReportTime.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReportTime.ForeColor = System.Drawing.Color.White;
            this.lblReportTime.Location = new System.Drawing.Point(24, 201);
            this.lblReportTime.Name = "lblReportTime";
            this.lblReportTime.Size = new System.Drawing.Size(156, 21);
            this.lblReportTime.TabIndex = 95;
            this.lblReportTime.Text = "Reporting Time :";
            // 
            // txtReportTime
            // 
            this.txtReportTime.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReportTime.Location = new System.Drawing.Point(204, 199);
            this.txtReportTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtReportTime.Name = "txtReportTime";
            this.txtReportTime.Size = new System.Drawing.Size(148, 27);
            this.txtReportTime.TabIndex = 96;
            this.txtReportTime.TextChanged += new System.EventHandler(this.txtReportTime_TextChanged);
            // 
            // cmbStaffName
            // 
            this.cmbStaffName.FormattingEnabled = true;
            this.cmbStaffName.Location = new System.Drawing.Point(204, 23);
            this.cmbStaffName.Name = "cmbStaffName";
            this.cmbStaffName.Size = new System.Drawing.Size(215, 24);
            this.cmbStaffName.TabIndex = 97;
            this.cmbStaffName.SelectedIndexChanged += new System.EventHandler(this.cmbStaffName_SelectedIndexChanged);
            // 
            // lblSelectID
            // 
            this.lblSelectID.AutoSize = true;
            this.lblSelectID.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectID.ForeColor = System.Drawing.Color.White;
            this.lblSelectID.Location = new System.Drawing.Point(56, 23);
            this.lblSelectID.Name = "lblSelectID";
            this.lblSelectID.Size = new System.Drawing.Size(124, 21);
            this.lblSelectID.TabIndex = 98;
            this.lblSelectID.Text = "Staff  Name :";
            // 
            // btnShowDetails
            // 
            this.btnShowDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(110)))), ((int)(((byte)(138)))));
            this.btnShowDetails.FlatAppearance.BorderSize = 0;
            this.btnShowDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowDetails.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowDetails.ForeColor = System.Drawing.Color.White;
            this.btnShowDetails.Location = new System.Drawing.Point(30, 173);
            this.btnShowDetails.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnShowDetails.Name = "btnShowDetails";
            this.btnShowDetails.Size = new System.Drawing.Size(156, 40);
            this.btnShowDetails.TabIndex = 53;
            this.btnShowDetails.Text = "Show Details ";
            this.btnShowDetails.UseVisualStyleBackColor = false;
            this.btnShowDetails.Click += new System.EventHandler(this.btnShowDetails_Click);
            // 
            // btnClearTask
            // 
            this.btnClearTask.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(110)))), ((int)(((byte)(138)))));
            this.btnClearTask.FlatAppearance.BorderSize = 0;
            this.btnClearTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearTask.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearTask.ForeColor = System.Drawing.Color.White;
            this.btnClearTask.Location = new System.Drawing.Point(255, 105);
            this.btnClearTask.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClearTask.Name = "btnClearTask";
            this.btnClearTask.Size = new System.Drawing.Size(135, 40);
            this.btnClearTask.TabIndex = 52;
            this.btnClearTask.Text = "Clear Task";
            this.btnClearTask.UseVisualStyleBackColor = false;
            this.btnClearTask.Click += new System.EventHandler(this.btnClearTask_Click);
            // 
            // btnUpdateTask
            // 
            this.btnUpdateTask.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(110)))), ((int)(((byte)(138)))));
            this.btnUpdateTask.FlatAppearance.BorderSize = 0;
            this.btnUpdateTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateTask.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateTask.ForeColor = System.Drawing.Color.White;
            this.btnUpdateTask.Location = new System.Drawing.Point(255, 39);
            this.btnUpdateTask.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdateTask.Name = "btnUpdateTask";
            this.btnUpdateTask.Size = new System.Drawing.Size(135, 40);
            this.btnUpdateTask.TabIndex = 50;
            this.btnUpdateTask.Text = "Update Task";
            this.btnUpdateTask.UseVisualStyleBackColor = false;
            this.btnUpdateTask.Click += new System.EventHandler(this.btnUpdateTask_Click);
            // 
            // btnRemoveTask
            // 
            this.btnRemoveTask.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(110)))), ((int)(((byte)(138)))));
            this.btnRemoveTask.FlatAppearance.BorderSize = 0;
            this.btnRemoveTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveTask.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveTask.ForeColor = System.Drawing.Color.White;
            this.btnRemoveTask.Location = new System.Drawing.Point(30, 105);
            this.btnRemoveTask.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRemoveTask.Name = "btnRemoveTask";
            this.btnRemoveTask.Size = new System.Drawing.Size(156, 40);
            this.btnRemoveTask.TabIndex = 56;
            this.btnRemoveTask.Text = "Remove Task";
            this.btnRemoveTask.UseVisualStyleBackColor = false;
            this.btnRemoveTask.Click += new System.EventHandler(this.btnRemoveTask_Click);
            // 
            // btnAddTask
            // 
            this.btnAddTask.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(110)))), ((int)(((byte)(138)))));
            this.btnAddTask.FlatAppearance.BorderSize = 0;
            this.btnAddTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTask.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTask.ForeColor = System.Drawing.Color.White;
            this.btnAddTask.Location = new System.Drawing.Point(30, 39);
            this.btnAddTask.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddTask.Name = "btnAddTask";
            this.btnAddTask.Size = new System.Drawing.Size(156, 40);
            this.btnAddTask.TabIndex = 51;
            this.btnAddTask.Text = "Add Task";
            this.btnAddTask.UseVisualStyleBackColor = false;
            this.btnAddTask.Click += new System.EventHandler(this.btnAddTask_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(110)))), ((int)(((byte)(138)))));
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(255, 173);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(135, 40);
            this.btnBack.TabIndex = 57;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // panelRight
            // 
            this.panelRight.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panelRight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelRight.Controls.Add(this.btnBack);
            this.panelRight.Controls.Add(this.btnAddTask);
            this.panelRight.Controls.Add(this.btnRemoveTask);
            this.panelRight.Controls.Add(this.btnUpdateTask);
            this.panelRight.Controls.Add(this.btnClearTask);
            this.panelRight.Controls.Add(this.btnShowDetails);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelRight.Location = new System.Drawing.Point(431, 0);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(451, 653);
            this.panelRight.TabIndex = 93;
            // 
            // AssignTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(110)))), ((int)(((byte)(138)))));
            this.ClientSize = new System.Drawing.Size(882, 653);
            this.Controls.Add(this.lblSelectID);
            this.Controls.Add(this.cmbStaffName);
            this.Controls.Add(this.txtReportTime);
            this.Controls.Add(this.lblReportTime);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.lblTaskDescription);
            this.Controls.Add(this.lblDepartment);
            this.Controls.Add(this.txtTaskName);
            this.Controls.Add(this.txtTaskDescription);
            this.Controls.Add(this.lblTaskName);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.txtTaskID);
            this.Controls.Add(this.lblTaskID);
            this.Controls.Add(this.lblStatus);
            this.Name = "AssignTask";
            this.Text = "AssignTask";
            this.Load += new System.EventHandler(this.ManageTask_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaffTask)).EndInit();
            this.panelBottom.ResumeLayout(false);
            this.panelRight.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvStaffTask;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Label lblTaskDescription;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.TextBox txtTaskName;
        private System.Windows.Forms.TextBox txtTaskDescription;
        private System.Windows.Forms.Label lblTaskName;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.TextBox txtTaskID;
        private System.Windows.Forms.Label lblTaskID;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblReportTime;
        private System.Windows.Forms.TextBox txtReportTime;
        private System.Windows.Forms.ComboBox cmbStaffName;
        private System.Windows.Forms.Label lblSelectID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SNAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn TID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TNAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn TDESCRIPTION;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIME;
        private System.Windows.Forms.DataGridViewTextBoxColumn STATUS;
        private System.Windows.Forms.Button btnShowDetails;
        private System.Windows.Forms.Button btnClearTask;
        private System.Windows.Forms.Button btnUpdateTask;
        private System.Windows.Forms.Button btnRemoveTask;
        private System.Windows.Forms.Button btnAddTask;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel panelRight;
    }
}