namespace First
{
    partial class adminDashbord
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adminDashbord));
            this.btnLogOut = new System.Windows.Forms.Button();
            this.lblAdmin = new System.Windows.Forms.Label();
            this.btnManageStaff = new System.Windows.Forms.Button();
            this.panelTopAdmin = new System.Windows.Forms.Panel();
            this.panelAdmin = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnManageTask = new System.Windows.Forms.Button();
            this.panelRight = new System.Windows.Forms.Panel();
            this.pictureUser = new System.Windows.Forms.PictureBox();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.panelUser = new System.Windows.Forms.Panel();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.btnCheckIn = new System.Windows.Forms.Button();
            this.panelTopAdmin.SuspendLayout();
            this.panelAdmin.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureUser)).BeginInit();
            this.panelUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(110)))), ((int)(((byte)(138)))));
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.ForeColor = System.Drawing.Color.White;
            this.btnLogOut.Location = new System.Drawing.Point(506, 543);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(171, 60);
            this.btnLogOut.TabIndex = 10;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // lblAdmin
            // 
            this.lblAdmin.AutoSize = true;
            this.lblAdmin.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdmin.Location = new System.Drawing.Point(82, 17);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(149, 23);
            this.lblAdmin.TabIndex = 4;
            this.lblAdmin.Text = "Admin Control";
            // 
            // btnManageStaff
            // 
            this.btnManageStaff.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnManageStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageStaff.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageStaff.Location = new System.Drawing.Point(13, 19);
            this.btnManageStaff.Name = "btnManageStaff";
            this.btnManageStaff.Size = new System.Drawing.Size(126, 45);
            this.btnManageStaff.TabIndex = 0;
            this.btnManageStaff.Text = "Manage Staff";
            this.btnManageStaff.UseVisualStyleBackColor = false;
            this.btnManageStaff.Click += new System.EventHandler(this.btnManageStaff_Click);
            // 
            // panelTopAdmin
            // 
            this.panelTopAdmin.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panelTopAdmin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTopAdmin.Controls.Add(this.lblAdmin);
            this.panelTopAdmin.Location = new System.Drawing.Point(448, 56);
            this.panelTopAdmin.Name = "panelTopAdmin";
            this.panelTopAdmin.Size = new System.Drawing.Size(309, 61);
            this.panelTopAdmin.TabIndex = 9;
            // 
            // panelAdmin
            // 
            this.panelAdmin.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panelAdmin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelAdmin.Controls.Add(this.panel1);
            this.panelAdmin.Controls.Add(this.panelRight);
            this.panelAdmin.Location = new System.Drawing.Point(332, 193);
            this.panelAdmin.Name = "panelAdmin";
            this.panelAdmin.Size = new System.Drawing.Size(528, 303);
            this.panelAdmin.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(110)))), ((int)(((byte)(138)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnManageTask);
            this.panel1.Location = new System.Drawing.Point(300, 101);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(154, 78);
            this.panel1.TabIndex = 3;
            // 
            // btnManageTask
            // 
            this.btnManageTask.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnManageTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageTask.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageTask.Location = new System.Drawing.Point(13, 19);
            this.btnManageTask.Name = "btnManageTask";
            this.btnManageTask.Size = new System.Drawing.Size(126, 45);
            this.btnManageTask.TabIndex = 0;
            this.btnManageTask.Text = "Manage Task";
            this.btnManageTask.UseVisualStyleBackColor = false;
            this.btnManageTask.Click += new System.EventHandler(this.btnManageTask_Click);
            // 
            // panelRight
            // 
            this.panelRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(110)))), ((int)(((byte)(138)))));
            this.panelRight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelRight.Controls.Add(this.btnManageStaff);
            this.panelRight.Location = new System.Drawing.Point(77, 101);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(154, 78);
            this.panelRight.TabIndex = 2;
            // 
            // pictureUser
            // 
            this.pictureUser.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureUser.BackgroundImage")));
            this.pictureUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureUser.Location = new System.Drawing.Point(98, 67);
            this.pictureUser.Name = "pictureUser";
            this.pictureUser.Size = new System.Drawing.Size(100, 50);
            this.pictureUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureUser.TabIndex = 6;
            this.pictureUser.TabStop = false;
            // 
            // lblWelcome
            // 
            this.lblWelcome.BackColor = System.Drawing.Color.White;
            this.lblWelcome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblWelcome.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.Color.Black;
            this.lblWelcome.Location = new System.Drawing.Point(56, 223);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(179, 33);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Manage Guest";
            // 
            // panelUser
            // 
            this.panelUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(110)))), ((int)(((byte)(138)))));
            this.panelUser.Controls.Add(this.pictureUser);
            this.panelUser.Controls.Add(this.btnCheckOut);
            this.panelUser.Controls.Add(this.btnCheckIn);
            this.panelUser.Controls.Add(this.lblWelcome);
            this.panelUser.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelUser.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelUser.Location = new System.Drawing.Point(0, 0);
            this.panelUser.Name = "panelUser";
            this.panelUser.Size = new System.Drawing.Size(309, 653);
            this.panelUser.TabIndex = 7;
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.FlatAppearance.BorderSize = 0;
            this.btnCheckOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckOut.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckOut.ForeColor = System.Drawing.Color.White;
            this.btnCheckOut.Location = new System.Drawing.Point(61, 336);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(171, 60);
            this.btnCheckOut.TabIndex = 2;
            this.btnCheckOut.Text = "Check Out";
            this.btnCheckOut.UseVisualStyleBackColor = true;
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // btnCheckIn
            // 
            this.btnCheckIn.FlatAppearance.BorderSize = 0;
            this.btnCheckIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckIn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckIn.ForeColor = System.Drawing.Color.White;
            this.btnCheckIn.Location = new System.Drawing.Point(61, 259);
            this.btnCheckIn.Name = "btnCheckIn";
            this.btnCheckIn.Size = new System.Drawing.Size(171, 85);
            this.btnCheckIn.TabIndex = 1;
            this.btnCheckIn.Text = "Check In";
            this.btnCheckIn.UseVisualStyleBackColor = true;
            this.btnCheckIn.Click += new System.EventHandler(this.btnCheckIn_Click);
            // 
            // adminDashbord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 653);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.panelTopAdmin);
            this.Controls.Add(this.panelAdmin);
            this.Controls.Add(this.panelUser);
            this.Name = "adminDashbord";
            this.Text = "adminDashbord";
            this.panelTopAdmin.ResumeLayout(false);
            this.panelTopAdmin.PerformLayout();
            this.panelAdmin.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panelRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureUser)).EndInit();
            this.panelUser.ResumeLayout(false);
            this.panelUser.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Label lblAdmin;
        private System.Windows.Forms.Button btnManageStaff;
        private System.Windows.Forms.Panel panelTopAdmin;
        private System.Windows.Forms.Panel panelAdmin;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.PictureBox pictureUser;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Panel panelUser;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnManageTask;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.Button btnCheckIn;
    }
}