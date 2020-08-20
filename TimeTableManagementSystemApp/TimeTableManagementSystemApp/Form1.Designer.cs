namespace TimeTableManagementSystemApp
{
    partial class Form1
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
            this.topPanel = new System.Windows.Forms.Panel();
            this.maxBtn = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.miniBtn = new System.Windows.Forms.PictureBox();
            this.closeBtn = new System.Windows.Forms.PictureBox();
            this.tagbtn = new System.Windows.Forms.Button();
            this.addStudentBut = new System.Windows.Forms.Button();
            this.daysBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SubjectBtn = new System.Windows.Forms.Button();
            this.locationManagementBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.studentBtn = new System.Windows.Forms.Button();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.miniBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(104)))));
            this.topPanel.Controls.Add(this.maxBtn);
            this.topPanel.Controls.Add(this.label1);
            this.topPanel.Controls.Add(this.miniBtn);
            this.topPanel.Controls.Add(this.closeBtn);
            this.topPanel.Location = new System.Drawing.Point(-4, -4);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1286, 40);
            this.topPanel.TabIndex = 3;
            // 
            // maxBtn
            // 
            this.maxBtn.Image = global::TimeTableManagementSystemApp.Properties.Resources.Maxibtn;
            this.maxBtn.Location = new System.Drawing.Point(1204, 10);
            this.maxBtn.Name = "maxBtn";
            this.maxBtn.Size = new System.Drawing.Size(35, 25);
            this.maxBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.maxBtn.TabIndex = 8;
            this.maxBtn.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(16, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Time Table Management";
            // 
            // miniBtn
            // 
            this.miniBtn.Image = global::TimeTableManagementSystemApp.Properties.Resources.minibtn;
            this.miniBtn.Location = new System.Drawing.Point(1163, 9);
            this.miniBtn.Name = "miniBtn";
            this.miniBtn.Size = new System.Drawing.Size(35, 25);
            this.miniBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.miniBtn.TabIndex = 7;
            this.miniBtn.TabStop = false;
            // 
            // closeBtn
            // 
            this.closeBtn.Image = global::TimeTableManagementSystemApp.Properties.Resources.closebtn;
            this.closeBtn.Location = new System.Drawing.Point(1245, 10);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(35, 25);
            this.closeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.closeBtn.TabIndex = 9;
            this.closeBtn.TabStop = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // tagbtn
            // 
            this.tagbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(104)))));
            this.tagbtn.FlatAppearance.BorderSize = 0;
            this.tagbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tagbtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tagbtn.ForeColor = System.Drawing.Color.White;
            this.tagbtn.Location = new System.Drawing.Point(539, 349);
            this.tagbtn.Margin = new System.Windows.Forms.Padding(2);
            this.tagbtn.Name = "tagbtn";
            this.tagbtn.Size = new System.Drawing.Size(220, 40);
            this.tagbtn.TabIndex = 3;
            this.tagbtn.Text = "Tags Management";
            this.tagbtn.UseVisualStyleBackColor = false;
            this.tagbtn.Click += new System.EventHandler(this.tagbtn_Click);
            // 
            // addStudentBut
            // 
            this.addStudentBut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(104)))));
            this.addStudentBut.FlatAppearance.BorderSize = 0;
            this.addStudentBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addStudentBut.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addStudentBut.ForeColor = System.Drawing.Color.White;
            this.addStudentBut.Location = new System.Drawing.Point(565, 194);
            this.addStudentBut.Margin = new System.Windows.Forms.Padding(2);
            this.addStudentBut.Name = "addStudentBut";
            this.addStudentBut.Size = new System.Drawing.Size(220, 40);
            this.addStudentBut.TabIndex = 1;
            this.addStudentBut.Text = "Student Management";
            this.addStudentBut.UseVisualStyleBackColor = false;
            this.addStudentBut.Click += new System.EventHandler(this.addStudentBut_Click);
            // 
            // daysBtn
            // 
            this.daysBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(104)))));
            this.daysBtn.FlatAppearance.BorderSize = 0;
            this.daysBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.daysBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.daysBtn.ForeColor = System.Drawing.Color.White;
            this.daysBtn.Location = new System.Drawing.Point(786, 478);
            this.daysBtn.Margin = new System.Windows.Forms.Padding(2);
            this.daysBtn.Name = "daysBtn";
            this.daysBtn.Size = new System.Drawing.Size(220, 40);
            this.daysBtn.TabIndex = 2;
            this.daysBtn.Text = "Days Management";
            this.daysBtn.UseVisualStyleBackColor = false;
            this.daysBtn.Click += new System.EventHandler(this.daysBtn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(165)))), ((int)(((byte)(0)))));
            this.panel2.Location = new System.Drawing.Point(-11, -29);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(5, 780);
            this.panel2.TabIndex = 4;
            // 
            // SubjectBtn
            // 
            this.SubjectBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(104)))));
            this.SubjectBtn.FlatAppearance.BorderSize = 0;
            this.SubjectBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SubjectBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubjectBtn.ForeColor = System.Drawing.Color.White;
            this.SubjectBtn.Location = new System.Drawing.Point(323, 478);
            this.SubjectBtn.Margin = new System.Windows.Forms.Padding(2);
            this.SubjectBtn.Name = "SubjectBtn";
            this.SubjectBtn.Size = new System.Drawing.Size(220, 40);
            this.SubjectBtn.TabIndex = 11;
            this.SubjectBtn.Text = "Subject Management";
            this.SubjectBtn.UseVisualStyleBackColor = false;
            this.SubjectBtn.Click += new System.EventHandler(this.SubjectBtn_Click);
            // 
            // locationManagementBtn
            // 
            this.locationManagementBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(104)))));
            this.locationManagementBtn.FlatAppearance.BorderSize = 0;
            this.locationManagementBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.locationManagementBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locationManagementBtn.ForeColor = System.Drawing.Color.White;
            this.locationManagementBtn.Location = new System.Drawing.Point(225, 259);
            this.locationManagementBtn.Margin = new System.Windows.Forms.Padding(2);
            this.locationManagementBtn.Name = "locationManagementBtn";
            this.locationManagementBtn.Size = new System.Drawing.Size(220, 40);
            this.locationManagementBtn.TabIndex = 9;
            this.locationManagementBtn.Text = "Location Management";
            this.locationManagementBtn.UseVisualStyleBackColor = false;
            this.locationManagementBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TimeTableManagementSystemApp.Properties.Resources.SLIIT;
            this.pictureBox1.Location = new System.Drawing.Point(1084, 683);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(189, 76);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 693);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 17);
            this.label3.TabIndex = 68;
            this.label3.Text = "Version 1.0 ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 716);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(314, 17);
            this.label2.TabIndex = 69;
            this.label2.Text = "Powered by Gaweshakayo Delevopment Team";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 739);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 17);
            this.label4.TabIndex = 70;
            this.label4.Text = "2020";
            // 
            // studentBtn
            // 
            this.studentBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(104)))));
            this.studentBtn.FlatAppearance.BorderSize = 0;
            this.studentBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.studentBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentBtn.ForeColor = System.Drawing.Color.White;
            this.studentBtn.Location = new System.Drawing.Point(922, 328);
            this.studentBtn.Margin = new System.Windows.Forms.Padding(2);
            this.studentBtn.Name = "studentBtn";
            this.studentBtn.Size = new System.Drawing.Size(220, 40);
            this.studentBtn.TabIndex = 10;
            this.studentBtn.Text = "Statistics";
            this.studentBtn.UseVisualStyleBackColor = false;
            this.studentBtn.Click += new System.EventHandler(this.studentBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 768);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.studentBtn);
            this.Controls.Add(this.SubjectBtn);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.locationManagementBtn);
            this.Controls.Add(this.addStudentBut);
            this.Controls.Add(this.tagbtn);
            this.Controls.Add(this.daysBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.miniBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.PictureBox maxBtn;
        private System.Windows.Forms.PictureBox miniBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox closeBtn;
        private System.Windows.Forms.Button tagbtn;
        private System.Windows.Forms.Button addStudentBut;
        private System.Windows.Forms.Button daysBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button SubjectBtn;
        private System.Windows.Forms.Button locationManagementBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button studentBtn;
    }
}

