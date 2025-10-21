namespace First
{
    partial class checkOut
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
            this.cmbRNo = new System.Windows.Forms.ComboBox();
            this.txtNID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnCheckOut = new System.Windows.Forms.Button();
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
            this.txtID = new System.Windows.Forms.TextBox();
            this.lbl = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.panelCheck.SuspendLayout();
            this.panelCheckOut.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCheck
            // 
            this.panelCheck.BackColor = System.Drawing.Color.White;
            this.panelCheck.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelCheck.Controls.Add(this.panelCheckOut);
            this.panelCheck.Location = new System.Drawing.Point(299, 23);
            this.panelCheck.Name = "panelCheck";
            this.panelCheck.Size = new System.Drawing.Size(341, 80);
            this.panelCheck.TabIndex = 61;
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
            this.Add.Size = new System.Drawing.Size(202, 27);
            this.Add.TabIndex = 22;
            this.Add.Text = "Check Out Guest";
            this.Add.UseWaitCursor = true;
            // 
            // cmbRNo
            // 
            this.cmbRNo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbRNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
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
            this.cmbRNo.Location = new System.Drawing.Point(362, 404);
            this.cmbRNo.Name = "cmbRNo";
            this.cmbRNo.Size = new System.Drawing.Size(337, 24);
            this.cmbRNo.TabIndex = 60;
            // 
            // txtNID
            // 
            this.txtNID.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtNID.Location = new System.Drawing.Point(360, 510);
            this.txtNID.Name = "txtNID";
            this.txtNID.ReadOnly = true;
            this.txtNID.Size = new System.Drawing.Size(338, 22);
            this.txtNID.TabIndex = 59;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(187, 508);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 27);
            this.label4.TabIndex = 58;
            this.label4.Text = "NID No:";
            // 
            // lblGender
            // 
            this.lblGender.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.ForeColor = System.Drawing.Color.White;
            this.lblGender.Location = new System.Drawing.Point(187, 301);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(169, 27);
            this.lblGender.TabIndex = 57;
            this.lblGender.Text = "Gender: ";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.OrangeRed;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.Transparent;
            this.btnBack.Location = new System.Drawing.Point(564, 574);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(135, 48);
            this.btnBack.TabIndex = 56;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCheckOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckOut.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckOut.ForeColor = System.Drawing.Color.Transparent;
            this.btnCheckOut.Location = new System.Drawing.Point(230, 574);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(135, 48);
            this.btnCheckOut.TabIndex = 55;
            this.btnCheckOut.Text = "Check Out";
            this.btnCheckOut.UseVisualStyleBackColor = false;
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // cmbRType
            // 
            this.cmbRType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbRType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbRType.FormattingEnabled = true;
            this.cmbRType.Items.AddRange(new object[] {
            "Standard",
            "AC Single",
            "AC Double",
            "Non AC Single",
            "Non AC Double",
            "Delux",
            "Couple"});
            this.cmbRType.Location = new System.Drawing.Point(361, 355);
            this.cmbRType.Name = "cmbRType";
            this.cmbRType.Size = new System.Drawing.Size(337, 24);
            this.cmbRType.TabIndex = 54;
            // 
            // txtPayment
            // 
            this.txtPayment.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPayment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtPayment.ForeColor = System.Drawing.Color.White;
            this.txtPayment.Location = new System.Drawing.Point(361, 458);
            this.txtPayment.Name = "txtPayment";
            this.txtPayment.ReadOnly = true;
            this.txtPayment.Size = new System.Drawing.Size(338, 22);
            this.txtPayment.TabIndex = 53;
            // 
            // lblPayment
            // 
            this.lblPayment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(110)))), ((int)(((byte)(138)))));
            this.lblPayment.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayment.ForeColor = System.Drawing.Color.White;
            this.lblPayment.Location = new System.Drawing.Point(187, 456);
            this.lblPayment.Name = "lblPayment";
            this.lblPayment.Size = new System.Drawing.Size(169, 27);
            this.lblPayment.TabIndex = 52;
            this.lblPayment.Text = "Payment:";
            // 
            // lblRNo
            // 
            this.lblRNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(110)))), ((int)(((byte)(138)))));
            this.lblRNo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRNo.ForeColor = System.Drawing.Color.White;
            this.lblRNo.Location = new System.Drawing.Point(187, 407);
            this.lblRNo.Name = "lblRNo";
            this.lblRNo.Size = new System.Drawing.Size(169, 27);
            this.lblRNo.TabIndex = 51;
            this.lblRNo.Text = "Room No:";
            // 
            // lblRType
            // 
            this.lblRType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(110)))), ((int)(((byte)(138)))));
            this.lblRType.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRType.ForeColor = System.Drawing.Color.White;
            this.lblRType.Location = new System.Drawing.Point(187, 355);
            this.lblRType.Name = "lblRType";
            this.lblRType.Size = new System.Drawing.Size(169, 27);
            this.lblRType.TabIndex = 50;
            this.lblRType.Text = "Room Type:";
            // 
            // cmbGender
            // 
            this.cmbGender.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.cmbGender.Location = new System.Drawing.Point(362, 300);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(337, 24);
            this.cmbGender.TabIndex = 49;
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(362, 247);
            this.txtNum.Name = "txtNum";
            this.txtNum.ReadOnly = true;
            this.txtNum.Size = new System.Drawing.Size(337, 22);
            this.txtNum.TabIndex = 48;
            // 
            // lblNum
            // 
            this.lblNum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(110)))), ((int)(((byte)(138)))));
            this.lblNum.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNum.ForeColor = System.Drawing.Color.White;
            this.lblNum.Location = new System.Drawing.Point(187, 245);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(169, 27);
            this.lblNum.TabIndex = 47;
            this.lblNum.Text = "Mobile Number:";
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtName.Location = new System.Drawing.Point(361, 194);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(228, 22);
            this.txtName.TabIndex = 46;
            // 
            // lblName
            // 
            this.lblName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(110)))), ((int)(((byte)(138)))));
            this.lblName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(187, 192);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(169, 27);
            this.lblName.TabIndex = 45;
            this.lblName.Text = "Guest Name:";
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtID.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.ForeColor = System.Drawing.Color.Black;
            this.txtID.Location = new System.Drawing.Point(362, 130);
            this.txtID.Multiline = true;
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(137, 36);
            this.txtID.TabIndex = 44;
            // 
            // lbl
            // 
            this.lbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(110)))), ((int)(((byte)(138)))));
            this.lbl.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.ForeColor = System.Drawing.Color.White;
            this.lbl.Location = new System.Drawing.Point(187, 139);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(169, 27);
            this.lbl.TabIndex = 43;
            this.lbl.Text = "Search by ID:";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.Transparent;
            this.btnSearch.Location = new System.Drawing.Point(548, 130);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(111, 36);
            this.btnSearch.TabIndex = 63;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.OrangeRed;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.Transparent;
            this.btnClear.Location = new System.Drawing.Point(400, 574);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(135, 48);
            this.btnClear.TabIndex = 64;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // checkOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(110)))), ((int)(((byte)(138)))));
            this.ClientSize = new System.Drawing.Size(882, 653);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.panelCheck);
            this.Controls.Add(this.cmbRNo);
            this.Controls.Add(this.txtNID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnCheckOut);
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
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lbl);
            this.Name = "checkOut";
            this.Text = "checkOut";
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
        private System.Windows.Forms.ComboBox cmbRNo;
        private System.Windows.Forms.TextBox txtNID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnCheckOut;
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
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnClear;
    }
}