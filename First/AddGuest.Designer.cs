namespace First
{
    partial class AddGuest
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
            this.Add = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblNum = new System.Windows.Forms.Label();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.lblRType = new System.Windows.Forms.Label();
            this.lblRNo = new System.Windows.Forms.Label();
            this.txtPayment = new System.Windows.Forms.TextBox();
            this.cmbRType = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblPayment = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNID = new System.Windows.Forms.TextBox();
            this.cmbRNo = new System.Windows.Forms.ComboBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Add
            // 
            this.Add.AutoSize = true;
            this.Add.Font = new System.Drawing.Font("Arial Rounded MT Bold", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add.ForeColor = System.Drawing.Color.White;
            this.Add.Location = new System.Drawing.Point(272, 35);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(296, 43);
            this.Add.TabIndex = 0;
            this.Add.Text = "Add New Guest";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.ForeColor = System.Drawing.Color.White;
            this.lblId.Location = new System.Drawing.Point(100, 125);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(92, 21);
            this.lblId.TabIndex = 1;
            this.lblId.Text = "Guest ID:";
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(110)))), ((int)(((byte)(138)))));
            this.txtID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtID.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.ForeColor = System.Drawing.Color.White;
            this.txtID.Location = new System.Drawing.Point(280, 120);
            this.txtID.Multiline = true;
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(300, 34);
            this.txtID.TabIndex = 2;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.SystemColors.Control;
            this.lblName.Location = new System.Drawing.Point(100, 175);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(125, 21);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Guest Name:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(280, 170);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(300, 31);
            this.txtName.TabIndex = 4;
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNum.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNum.Location = new System.Drawing.Point(100, 225);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(150, 21);
            this.lblNum.TabIndex = 5;
            this.lblNum.Text = "Mobile Number:";
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(280, 220);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(300, 31);
            this.txtNum.TabIndex = 6;
            // 
            // cmbGender
            // 
            this.cmbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.cmbGender.Location = new System.Drawing.Point(280, 270);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(300, 33);
            this.cmbGender.TabIndex = 8;
            // 
            // lblRType
            // 
            this.lblRType.AutoSize = true;
            this.lblRType.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11F);
            this.lblRType.ForeColor = System.Drawing.SystemColors.Control;
            this.lblRType.Location = new System.Drawing.Point(100, 325);
            this.lblRType.Name = "lblRType";
            this.lblRType.Size = new System.Drawing.Size(119, 22);
            this.lblRType.TabIndex = 9;
            this.lblRType.Text = "Room Type:";
            // 
            // lblRNo
            // 
            this.lblRNo.AutoSize = true;
            this.lblRNo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11F);
            this.lblRNo.ForeColor = System.Drawing.SystemColors.Control;
            this.lblRNo.Location = new System.Drawing.Point(100, 375);
            this.lblRNo.Name = "lblRNo";
            this.lblRNo.Size = new System.Drawing.Size(99, 22);
            this.lblRNo.TabIndex = 10;
            this.lblRNo.Text = "Room No:";
            // 
            // txtPayment
            // 
            this.txtPayment.Location = new System.Drawing.Point(280, 420);
            this.txtPayment.Name = "txtPayment";
            this.txtPayment.Size = new System.Drawing.Size(300, 31);
            this.txtPayment.TabIndex = 13;
            // 
            // cmbRType
            // 
            this.cmbRType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRType.FormattingEnabled = true;
            this.cmbRType.Items.AddRange(new object[] {
            "Standard",
            "AC Single",
            "AC Double",
            "Non AC Single",
            "Non AC Double",
            "Delux",
            "Couple"});
            this.cmbRType.Location = new System.Drawing.Point(280, 320);
            this.cmbRType.Name = "cmbRType";
            this.cmbRType.Size = new System.Drawing.Size(300, 33);
            this.cmbRType.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(208, 550);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 45);
            this.button1.TabIndex = 15;
            this.button1.Text = "ADD";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnAdd);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.OrangeRed;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.Transparent;
            this.button2.Location = new System.Drawing.Point(559, 550);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 45);
            this.button2.TabIndex = 16;
            this.button2.Text = "BACK";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.btnBack);
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.ForeColor = System.Drawing.SystemColors.Control;
            this.lblGender.Location = new System.Drawing.Point(100, 275);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(87, 21);
            this.lblGender.TabIndex = 18;
            this.lblGender.Text = "Gender: ";
            // 
            // lblPayment
            // 
            this.lblPayment.AutoSize = true;
            this.lblPayment.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11F);
            this.lblPayment.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPayment.Location = new System.Drawing.Point(103, 420);
            this.lblPayment.Name = "lblPayment";
            this.lblPayment.Size = new System.Drawing.Size(96, 22);
            this.lblPayment.TabIndex = 12;
            this.lblPayment.Text = "Payment:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11F);
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(103, 470);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 22);
            this.label4.TabIndex = 19;
            this.label4.Text = "NID NO: ";
            // 
            // txtNID
            // 
            this.txtNID.Location = new System.Drawing.Point(280, 470);
            this.txtNID.Name = "txtNID";
            this.txtNID.Size = new System.Drawing.Size(300, 31);
            this.txtNID.TabIndex = 20;
            // 
            // cmbRNo
            // 
            this.cmbRNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            this.cmbRNo.Location = new System.Drawing.Point(280, 370);
            this.cmbRNo.Name = "cmbRNo";
            this.cmbRNo.Size = new System.Drawing.Size(300, 33);
            this.cmbRNo.TabIndex = 21;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.OrangeRed;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.ForeColor = System.Drawing.Color.Transparent;
            this.btnClear.Location = new System.Drawing.Point(386, 550);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(120, 45);
            this.btnClear.TabIndex = 22;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // AddGuest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(110)))), ((int)(((byte)(138)))));
            this.ClientSize = new System.Drawing.Size(882, 653);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.cmbRNo);
            this.Controls.Add(this.txtNID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
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
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.Add);
            this.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AddGuest";
            this.Text = "AddGuest";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Add;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.Label lblRType;
        private System.Windows.Forms.Label lblRNo;
        private System.Windows.Forms.TextBox txtPayment;
        private System.Windows.Forms.ComboBox cmbRType;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblPayment;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNID;
        private System.Windows.Forms.ComboBox cmbRNo;
        private System.Windows.Forms.Button btnClear;
    }
}