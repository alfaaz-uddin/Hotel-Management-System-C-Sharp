namespace First
{
    partial class GuestList
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
            this.dvgGuestList = new System.Windows.Forms.DataGridView();
            this.lblHotel = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.payment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nidNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dvgGuestList)).BeginInit();
            this.SuspendLayout();
            // 
            // dvgGuestList
            // 
            this.dvgGuestList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvgGuestList.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dvgGuestList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgGuestList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.mobNum,
            this.gender,
            this.roomType,
            this.roomNo,
            this.payment,
            this.nidNo});
            this.dvgGuestList.Location = new System.Drawing.Point(12, 212);
            this.dvgGuestList.Name = "dvgGuestList";
            this.dvgGuestList.ReadOnly = true;
            this.dvgGuestList.RowHeadersWidth = 51;
            this.dvgGuestList.RowTemplate.Height = 24;
            this.dvgGuestList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvgGuestList.Size = new System.Drawing.Size(858, 419);
            this.dvgGuestList.TabIndex = 13;
            this.dvgGuestList.RowHeadersVisible = false;
            this.dvgGuestList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgGuestList_CellContentClick);
            // 
            // lblHotel
            // 
            this.lblHotel.AutoSize = true;
            this.lblHotel.Font = new System.Drawing.Font("Lucida Calligraphy", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHotel.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblHotel.Location = new System.Drawing.Point(276, 9);
            this.lblHotel.Name = "lblHotel";
            this.lblHotel.Size = new System.Drawing.Size(380, 36);
            this.lblHotel.TabIndex = 12;
            this.lblHotel.Text = "HOTEL BLACK MOON";
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(462, 129);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(117, 55);
            this.btnBack.TabIndex = 11;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnShow
            // 
            this.btnShow.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.Location = new System.Drawing.Point(312, 129);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(113, 55);
            this.btnShow.TabIndex = 10;
            this.btnShow.Text = "SHOW ALL GUEST";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(110)))), ((int)(((byte)(138)))));
            this.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnSearch.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSearch.Location = new System.Drawing.Point(613, 64);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(98, 43);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "SEARCH";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(410, 71);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(169, 30);
            this.txtId.TabIndex = 8;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.ForeColor = System.Drawing.Color.White;
            this.lblId.Location = new System.Drawing.Point(239, 75);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(165, 20);
            this.lblId.TabIndex = 7;
            this.lblId.Text = "Search by Guest ID:";
            // 
            // id
            // 
            this.id.HeaderText = "Guest ID";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.DataPropertyName = "id";
            this.id.ReadOnly = true;
            // 
            // name
            // 
            this.name.HeaderText = "Guest Name";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.DataPropertyName = "name";
            this.name.ReadOnly = true;
            // 
            // mobNum
            // 
            this.mobNum.HeaderText = "Mobile Number";
            this.mobNum.MinimumWidth = 6;
           // this.mobNum.Name = "mobNum";
            this.mobNum.DataPropertyName = "mobNum";
            this.mobNum.ReadOnly = true;
            // 
            // gender
            // 
            this.gender.HeaderText = "Gender";
            this.gender.MinimumWidth = 6;
            //this.gender.Name = "gender";
            this.gender.DataPropertyName = "gender";
            this.gender.ReadOnly = true;
            // 
            // roomType
            // 
            this.roomType.HeaderText = "Room Type";
            this.roomType.MinimumWidth = 6;
            //this.roomType.Name = "roomType";
            this.roomType.DataPropertyName = "roomType";
            this.roomType.ReadOnly = true;
            // 
            // roomNo
            // 
            this.roomNo.HeaderText = "Room Number";
            this.roomNo.MinimumWidth = 6;
           // this.roomNo.Name = "roomNo";
            this.roomNo.DataPropertyName = "roomNo";
            this.roomNo.ReadOnly = true;
            // 
            // payment
            // 
            this.payment.HeaderText = "Payment";
            this.payment.MinimumWidth = 6;
           // this.payment.Name = "payment";
            this.payment.DataPropertyName = "payment";
            this.payment.ReadOnly = true;
            // 
            // nidNo
            // 
            this.nidNo.HeaderText = "NID Number";
            this.nidNo.MinimumWidth = 6;
           // this.nidNo.Name = "nidNo";
            this.nidNo.DataPropertyName = "nidNo";
            this.nidNo.ReadOnly = true;
            // 
            // GuestList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(110)))), ((int)(((byte)(138)))));
            this.ClientSize = new System.Drawing.Size(882, 653);
            this.Controls.Add(this.dvgGuestList);
            this.Controls.Add(this.lblHotel);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblId);
            this.Name = "GuestList";
            this.Text = "GuestList";
            this.Load += new System.EventHandler(this.GuestList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgGuestList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dvgGuestList;
        private System.Windows.Forms.Label lblHotel;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomType;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn payment;
        private System.Windows.Forms.DataGridViewTextBoxColumn nidNo;
    }
}