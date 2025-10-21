namespace First
{
    partial class updateGuest
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
            this.panelCheck = new System.Windows.Forms.Panel();
            this.panelCheckOut = new System.Windows.Forms.Panel();
            this.Add = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.cmbRNo = new System.Windows.Forms.ComboBox();
            this.txtNID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.cmbRType = new System.Windows.Forms.ComboBox();
            this.txtPayment = new System.Windows.Forms.TextBox();
            this.lblPayment = new System.Windows.Forms.Label();
            this.lblRNo = new System.Windows.Forms.Label();
            this.lblRType = new System.Windows.Forms.Label();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.lblNum = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lbl = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.panelCheck.SuspendLayout();
            this.panelCheckOut.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCheck
            // 
            this.panelCheck.BackColor = System.Drawing.Color.White;
            this.panelCheck.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelCheck.Controls.Add(this.panelCheckOut);
            this.panelCheck.Location = new System.Drawing.Point(297, 27);
            this.panelCheck.Name = "panelCheck";
            this.panelCheck.Size = new System.Drawing.Size(341, 80);
            this.panelCheck.TabIndex = 82;
            // 
            // panelCheckOut
            // 
            this.panelCheckOut.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panelCheckOut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCheckOut.Controls.Add(this.Add);
            this.panelCheckOut.Location = new System.Drawing.Point(13, -7);
            this.panelCheckOut.Name = "panelCheckOut";
            this.panelCheckOut.Size = new System.Drawing.Size(316, 73);
            this.panelCheckOut.TabIndex = 41;
            this.panelCheckOut.UseWaitCursor = true;
            // 
            // Add
            // 
            this.Add.AutoSize = true;
            this.Add.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add.ForeColor = System.Drawing.Color.Black;
            this.Add.Location = new System.Drawing.Point(47, 24);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(214, 27);
            this.Add.TabIndex = 22;
            this.Add.Text = "Update Guest Info";
            this.Add.UseWaitCursor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.OrangeRed;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.Transparent;
            this.btnBack.Location = new System.Drawing.Point(503, 578);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(135, 48);
            this.btnBack.TabIndex = 77;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // cmbRNo
            // 
            this.cmbRNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.cmbRNo.FormattingEnabled = true;
            this.cmbRNo.Items.AddRange(new object[] {
            "L1-101-S",
            "L1-102-S",
            "L1-103-S",
            "L1-104-S",
            "L2-205-N",
            "L2-206-N",
            "L2-207-N",
            "L2-208-N",
            "L3-309-N",
            "L3-310-N",
            "L3-311-N",
            "L3-312-N"});
            this.cmbRNo.Location = new System.Drawing.Point(381, 390);
            this.cmbRNo.Name = "cmbRNo";
            this.cmbRNo.Size = new System.Drawing.Size(300, 24);
            this.cmbRNo.TabIndex = 98;
            // 
            // txtNID
            // 
            this.txtNID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtNID.Location = new System.Drawing.Point(381, 490);
            this.txtNID.Multiline = true;
            this.txtNID.Name = "txtNID";
            this.txtNID.Size = new System.Drawing.Size(300, 31);
            this.txtNID.TabIndex = 97;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11F);
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(204, 490);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 22);
            this.label4.TabIndex = 96;
            this.label4.Text = "NID NO: ";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.ForeColor = System.Drawing.SystemColors.Control;
            this.lblGender.Location = new System.Drawing.Point(201, 295);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(87, 21);
            this.lblGender.TabIndex = 95;
            this.lblGender.Text = "Gender: ";
            // 
            // cmbRType
            // 
            this.cmbRType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.cmbRType.FormattingEnabled = true;
            this.cmbRType.Items.AddRange(new object[] {
            "Standard",
            "AC Single",
            "AC Double",
            "Non AC Single",
            "Non AC Double",
            "Delux",
            "Couple"});
            this.cmbRType.Location = new System.Drawing.Point(381, 340);
            this.cmbRType.Name = "cmbRType";
            this.cmbRType.Size = new System.Drawing.Size(300, 24);
            this.cmbRType.TabIndex = 94;
            // 
            // txtPayment
            // 
            this.txtPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtPayment.Location = new System.Drawing.Point(381, 440);
            this.txtPayment.Multiline = true;
            this.txtPayment.Name = "txtPayment";
            this.txtPayment.Size = new System.Drawing.Size(300, 31);
            this.txtPayment.TabIndex = 93;
            // 
            // lblPayment
            // 
            this.lblPayment.AutoSize = true;
            this.lblPayment.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11F);
            this.lblPayment.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPayment.Location = new System.Drawing.Point(204, 440);
            this.lblPayment.Name = "lblPayment";
            this.lblPayment.Size = new System.Drawing.Size(96, 22);
            this.lblPayment.TabIndex = 92;
            this.lblPayment.Text = "Payment:";
            // 
            // lblRNo
            // 
            this.lblRNo.AutoSize = true;
            this.lblRNo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11F);
            this.lblRNo.ForeColor = System.Drawing.SystemColors.Control;
            this.lblRNo.Location = new System.Drawing.Point(201, 395);
            this.lblRNo.Name = "lblRNo";
            this.lblRNo.Size = new System.Drawing.Size(99, 22);
            this.lblRNo.TabIndex = 91;
            this.lblRNo.Text = "Room No:";
            // 
            // lblRType
            // 
            this.lblRType.AutoSize = true;
            this.lblRType.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11F);
            this.lblRType.ForeColor = System.Drawing.SystemColors.Control;
            this.lblRType.Location = new System.Drawing.Point(201, 345);
            this.lblRType.Name = "lblRType";
            this.lblRType.Size = new System.Drawing.Size(119, 22);
            this.lblRType.TabIndex = 90;
            this.lblRType.Text = "Room Type:";
            // 
            // cmbGender
            // 
            this.cmbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.cmbGender.Location = new System.Drawing.Point(381, 290);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(300, 24);
            this.cmbGender.TabIndex = 89;
            // 
            // txtNum
            // 
            this.txtNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.txtNum.Location = new System.Drawing.Point(381, 240);
            this.txtNum.Multiline = true;
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(300, 26);
            this.txtNum.TabIndex = 88;
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNum.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNum.Location = new System.Drawing.Point(201, 245);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(150, 21);
            this.lblNum.TabIndex = 87;
            this.lblNum.Text = "Mobile Number:";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtName.Location = new System.Drawing.Point(381, 190);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(300, 26);
            this.txtName.TabIndex = 86;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.SystemColors.Control;
            this.lblName.Location = new System.Drawing.Point(201, 195);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(125, 21);
            this.lblName.TabIndex = 85;
            this.lblName.Text = "Guest Name:";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.Transparent;
            this.btnSearch.Location = new System.Drawing.Point(561, 130);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(111, 36);
            this.btnSearch.TabIndex = 101;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtID.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.ForeColor = System.Drawing.Color.Black;
            this.txtID.Location = new System.Drawing.Point(380, 130);
            this.txtID.Multiline = true;
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(137, 36);
            this.txtID.TabIndex = 100;
            // 
            // lbl
            // 
            this.lbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(110)))), ((int)(((byte)(138)))));
            this.lbl.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.ForeColor = System.Drawing.Color.White;
            this.lbl.Location = new System.Drawing.Point(200, 139);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(169, 27);
            this.lbl.TabIndex = 99;
            this.lbl.Text = "Search by ID:";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.Transparent;
            this.btnUpdate.Location = new System.Drawing.Point(312, 578);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(135, 48);
            this.btnUpdate.TabIndex = 102;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // updateGuest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(110)))), ((int)(((byte)(138)))));
            this.ClientSize = new System.Drawing.Size(882, 653);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.cmbRNo);
            this.Controls.Add(this.txtNID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.cmbRType);
            this.Controls.Add(this.txtPayment);
            this.Controls.Add(this.lblPayment);
            this.Controls.Add(this.lblRNo);
            this.Controls.Add(this.lblRType);
            this.Controls.Add(this.cmbGender);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.lblNum);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.panelCheck);
            this.Controls.Add(this.btnBack);
            this.Name = "updateGuest";
            this.Text = "updateGuest";
            this.panelCheck.ResumeLayout(false);
            this.panelCheckOut.ResumeLayout(false);
            this.panelCheckOut.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panelCheck;
        private System.Windows.Forms.Panel panelCheckOut;
        private System.Windows.Forms.Label Add;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ComboBox cmbRNo;
        private System.Windows.Forms.TextBox txtNID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.ComboBox cmbRType;
        private System.Windows.Forms.TextBox txtPayment;
        private System.Windows.Forms.Label lblPayment;
        private System.Windows.Forms.Label lblRNo;
        private System.Windows.Forms.Label lblRType;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Button btnUpdate;
    }
}