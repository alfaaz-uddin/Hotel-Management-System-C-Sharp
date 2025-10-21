namespace First
{
    partial class staffDashboardMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(staffDashboardMenu));
            this.btnManageTask = new System.Windows.Forms.Button();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureCheckTask = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureManageTask = new System.Windows.Forms.PictureBox();
            this.panelMiddle = new System.Windows.Forms.Panel();
            this.btnCompleteTask = new System.Windows.Forms.Button();
            this.pictureComplete = new System.Windows.Forms.PictureBox();
            this.panelTopStaff = new System.Windows.Forms.Panel();
            this.panelInsideStaff = new System.Windows.Forms.Panel();
            this.lblStaff = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnCheckTask = new System.Windows.Forms.Button();
            this.panelMain.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCheckTask)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureManageTask)).BeginInit();
            this.panelMiddle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureComplete)).BeginInit();
            this.panelTopStaff.SuspendLayout();
            this.panelInsideStaff.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnManageTask
            // 
            this.btnManageTask.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(110)))), ((int)(((byte)(138)))));
            this.btnManageTask.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageTask.ForeColor = System.Drawing.Color.White;
            this.btnManageTask.Location = new System.Drawing.Point(96, -1);
            this.btnManageTask.Name = "btnManageTask";
            this.btnManageTask.Size = new System.Drawing.Size(129, 101);
            this.btnManageTask.TabIndex = 3;
            this.btnManageTask.Text = "Manage Task";
            this.btnManageTask.UseVisualStyleBackColor = false;
            this.btnManageTask.Click += new System.EventHandler(this.btnManageTask_Click);
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panelMain.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelMain.Controls.Add(this.panel2);
            this.panelMain.Controls.Add(this.panel3);
            this.panelMain.Controls.Add(this.panelMiddle);
            this.panelMain.Location = new System.Drawing.Point(34, 190);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(814, 288);
            this.panelMain.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnCheckTask);
            this.panel2.Controls.Add(this.pictureCheckTask);
            this.panel2.Location = new System.Drawing.Point(45, 96);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(226, 100);
            this.panel2.TabIndex = 3;
            // 
            // pictureCheckTask
            // 
            this.pictureCheckTask.BackColor = System.Drawing.SystemColors.Control;
            this.pictureCheckTask.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureCheckTask.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureCheckTask.Image = ((System.Drawing.Image)(resources.GetObject("pictureCheckTask.Image")));
            this.pictureCheckTask.Location = new System.Drawing.Point(3, 0);
            this.pictureCheckTask.Name = "pictureCheckTask";
            this.pictureCheckTask.Size = new System.Drawing.Size(100, 97);
            this.pictureCheckTask.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureCheckTask.TabIndex = 1;
            this.pictureCheckTask.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btnManageTask);
            this.panel3.Controls.Add(this.pictureManageTask);
            this.panel3.Location = new System.Drawing.Point(558, 95);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(226, 100);
            this.panel3.TabIndex = 2;
            // 
            // pictureManageTask
            // 
            this.pictureManageTask.BackColor = System.Drawing.SystemColors.Control;
            this.pictureManageTask.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureManageTask.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureManageTask.Image = ((System.Drawing.Image)(resources.GetObject("pictureManageTask.Image")));
            this.pictureManageTask.Location = new System.Drawing.Point(3, 0);
            this.pictureManageTask.Name = "pictureManageTask";
            this.pictureManageTask.Size = new System.Drawing.Size(100, 97);
            this.pictureManageTask.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureManageTask.TabIndex = 1;
            this.pictureManageTask.TabStop = false;
            this.pictureManageTask.Click += new System.EventHandler(this.pictureManageTask_Click);
            // 
            // panelMiddle
            // 
            this.panelMiddle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMiddle.Controls.Add(this.btnCompleteTask);
            this.panelMiddle.Controls.Add(this.pictureComplete);
            this.panelMiddle.Location = new System.Drawing.Point(294, 95);
            this.panelMiddle.Name = "panelMiddle";
            this.panelMiddle.Size = new System.Drawing.Size(226, 100);
            this.panelMiddle.TabIndex = 1;
            // 
            // btnCompleteTask
            // 
            this.btnCompleteTask.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(110)))), ((int)(((byte)(138)))));
            this.btnCompleteTask.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompleteTask.ForeColor = System.Drawing.Color.White;
            this.btnCompleteTask.Location = new System.Drawing.Point(100, -1);
            this.btnCompleteTask.Name = "btnCompleteTask";
            this.btnCompleteTask.Size = new System.Drawing.Size(125, 99);
            this.btnCompleteTask.TabIndex = 2;
            this.btnCompleteTask.Text = "Complete Task";
            this.btnCompleteTask.UseVisualStyleBackColor = false;
            // 
            // pictureComplete
            // 
            this.pictureComplete.BackColor = System.Drawing.SystemColors.Control;
            this.pictureComplete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureComplete.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureComplete.Image = ((System.Drawing.Image)(resources.GetObject("pictureComplete.Image")));
            this.pictureComplete.Location = new System.Drawing.Point(3, 0);
            this.pictureComplete.Name = "pictureComplete";
            this.pictureComplete.Size = new System.Drawing.Size(100, 97);
            this.pictureComplete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureComplete.TabIndex = 1;
            this.pictureComplete.TabStop = false;
            // 
            // panelTopStaff
            // 
            this.panelTopStaff.BackColor = System.Drawing.Color.White;
            this.panelTopStaff.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTopStaff.Controls.Add(this.panelInsideStaff);
            this.panelTopStaff.Location = new System.Drawing.Point(289, 56);
            this.panelTopStaff.Name = "panelTopStaff";
            this.panelTopStaff.Size = new System.Drawing.Size(283, 115);
            this.panelTopStaff.TabIndex = 9;
            // 
            // panelInsideStaff
            // 
            this.panelInsideStaff.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panelInsideStaff.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelInsideStaff.Controls.Add(this.lblStaff);
            this.panelInsideStaff.Location = new System.Drawing.Point(16, 16);
            this.panelInsideStaff.Name = "panelInsideStaff";
            this.panelInsideStaff.Size = new System.Drawing.Size(249, 83);
            this.panelInsideStaff.TabIndex = 0;
            // 
            // lblStaff
            // 
            this.lblStaff.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblStaff.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaff.ForeColor = System.Drawing.Color.Black;
            this.lblStaff.Location = new System.Drawing.Point(38, 30);
            this.lblStaff.Name = "lblStaff";
            this.lblStaff.Size = new System.Drawing.Size(185, 30);
            this.lblStaff.TabIndex = 0;
            this.lblStaff.Text = "Staff Dashboard";
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(110)))), ((int)(((byte)(138)))));
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(360, 536);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(171, 60);
            this.btnLogout.TabIndex = 10;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnCheckTask
            // 
            this.btnCheckTask.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(110)))), ((int)(((byte)(138)))));
            this.btnCheckTask.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckTask.ForeColor = System.Drawing.Color.White;
            this.btnCheckTask.Location = new System.Drawing.Point(100, -2);
            this.btnCheckTask.Name = "btnCheckTask";
            this.btnCheckTask.Size = new System.Drawing.Size(125, 100);
            this.btnCheckTask.TabIndex = 2;
            this.btnCheckTask.Text = "Check Task";
            this.btnCheckTask.UseVisualStyleBackColor = false;
            // 
            // staffDashboardMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(110)))), ((int)(((byte)(138)))));
            this.ClientSize = new System.Drawing.Size(882, 653);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelTopStaff);
            this.Controls.Add(this.btnLogout);
            this.Name = "staffDashboardMenu";
            this.Text = "staffDashboardMenu";
            this.panelMain.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureCheckTask)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureManageTask)).EndInit();
            this.panelMiddle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureComplete)).EndInit();
            this.panelTopStaff.ResumeLayout(false);
            this.panelInsideStaff.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnManageTask;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureCheckTask;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureManageTask;
        private System.Windows.Forms.Panel panelMiddle;
        private System.Windows.Forms.Button btnCompleteTask;
        private System.Windows.Forms.PictureBox pictureComplete;
        private System.Windows.Forms.Panel panelTopStaff;
        private System.Windows.Forms.Panel panelInsideStaff;
        private System.Windows.Forms.Label lblStaff;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnCheckTask;
    }
}