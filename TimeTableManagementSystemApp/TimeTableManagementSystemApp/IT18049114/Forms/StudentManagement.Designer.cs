namespace TimeTableManagementSystemApp.IT18049114.Forms
{
    partial class StudentManagement
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
            this.miniBtn = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.closeBtn = new System.Windows.Forms.PictureBox();
            this.sidePanel = new System.Windows.Forms.Panel();
            this.editStudentBtn = new System.Windows.Forms.Button();
            this.addtagBut = new System.Windows.Forms.Button();
            this.addStudentBut = new System.Windows.Forms.Button();
            this.viewBut = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.contentPanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.homeBtn = new System.Windows.Forms.Button();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.miniBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).BeginInit();
            this.sidePanel.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(104)))));
            this.topPanel.Controls.Add(this.maxBtn);
            this.topPanel.Controls.Add(this.miniBtn);
            this.topPanel.Controls.Add(this.label1);
            this.topPanel.Controls.Add(this.closeBtn);
            this.topPanel.Location = new System.Drawing.Point(224, -2);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1062, 40);
            this.topPanel.TabIndex = 0;
            this.topPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.topPanel_Paint);
            // 
            // maxBtn
            // 
            this.maxBtn.Image = global::TimeTableManagementSystemApp.Properties.Resources.Maxibtn;
            this.maxBtn.Location = new System.Drawing.Point(972, 8);
            this.maxBtn.Name = "maxBtn";
            this.maxBtn.Size = new System.Drawing.Size(35, 25);
            this.maxBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.maxBtn.TabIndex = 8;
            this.maxBtn.TabStop = false;
            this.maxBtn.Click += new System.EventHandler(this.maxBtn_Click);
            // 
            // miniBtn
            // 
            this.miniBtn.Image = global::TimeTableManagementSystemApp.Properties.Resources.minibtn;
            this.miniBtn.Location = new System.Drawing.Point(931, 7);
            this.miniBtn.Name = "miniBtn";
            this.miniBtn.Size = new System.Drawing.Size(35, 25);
            this.miniBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.miniBtn.TabIndex = 7;
            this.miniBtn.TabStop = false;
            this.miniBtn.Click += new System.EventHandler(this.miniBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Time Table Management";
            // 
            // closeBtn
            // 
            this.closeBtn.Image = global::TimeTableManagementSystemApp.Properties.Resources.closebtn;
            this.closeBtn.Location = new System.Drawing.Point(1013, 8);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(35, 25);
            this.closeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.closeBtn.TabIndex = 9;
            this.closeBtn.TabStop = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // sidePanel
            // 
            this.sidePanel.BackColor = System.Drawing.Color.Transparent;
            this.sidePanel.Controls.Add(this.homeBtn);
            this.sidePanel.Controls.Add(this.editStudentBtn);
            this.sidePanel.Controls.Add(this.addtagBut);
            this.sidePanel.Controls.Add(this.addStudentBut);
            this.sidePanel.Controls.Add(this.viewBut);
            this.sidePanel.Controls.Add(this.panel4);
            this.sidePanel.Location = new System.Drawing.Point(0, 0);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(224, 780);
            this.sidePanel.TabIndex = 1;
            // 
            // editStudentBtn
            // 
            this.editStudentBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(104)))));
            this.editStudentBtn.FlatAppearance.BorderSize = 0;
            this.editStudentBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editStudentBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editStudentBtn.ForeColor = System.Drawing.Color.White;
            this.editStudentBtn.Location = new System.Drawing.Point(3, 242);
            this.editStudentBtn.Margin = new System.Windows.Forms.Padding(2);
            this.editStudentBtn.Name = "editStudentBtn";
            this.editStudentBtn.Size = new System.Drawing.Size(220, 40);
            this.editStudentBtn.TabIndex = 9;
            this.editStudentBtn.Text = "Edit Student";
            this.editStudentBtn.UseVisualStyleBackColor = false;
            this.editStudentBtn.Click += new System.EventHandler(this.editStudentBtn_Click);
            // 
            // addtagBut
            // 
            this.addtagBut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(104)))));
            this.addtagBut.FlatAppearance.BorderSize = 0;
            this.addtagBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addtagBut.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addtagBut.ForeColor = System.Drawing.Color.White;
            this.addtagBut.Location = new System.Drawing.Point(4, 198);
            this.addtagBut.Margin = new System.Windows.Forms.Padding(2);
            this.addtagBut.Name = "addtagBut";
            this.addtagBut.Size = new System.Drawing.Size(220, 40);
            this.addtagBut.TabIndex = 3;
            this.addtagBut.Text = "Tags";
            this.addtagBut.UseVisualStyleBackColor = false;
            this.addtagBut.Click += new System.EventHandler(this.addtagBut_Click_1);
            // 
            // addStudentBut
            // 
            this.addStudentBut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(104)))));
            this.addStudentBut.FlatAppearance.BorderSize = 0;
            this.addStudentBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addStudentBut.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addStudentBut.ForeColor = System.Drawing.Color.White;
            this.addStudentBut.Location = new System.Drawing.Point(4, 110);
            this.addStudentBut.Margin = new System.Windows.Forms.Padding(2);
            this.addStudentBut.Name = "addStudentBut";
            this.addStudentBut.Size = new System.Drawing.Size(220, 40);
            this.addStudentBut.TabIndex = 1;
            this.addStudentBut.Text = "Add Student";
            this.addStudentBut.UseVisualStyleBackColor = false;
            this.addStudentBut.Click += new System.EventHandler(this.addStudentBut_Click_1);
            // 
            // viewBut
            // 
            this.viewBut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(104)))));
            this.viewBut.FlatAppearance.BorderSize = 0;
            this.viewBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewBut.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewBut.ForeColor = System.Drawing.Color.White;
            this.viewBut.Location = new System.Drawing.Point(4, 154);
            this.viewBut.Margin = new System.Windows.Forms.Padding(2);
            this.viewBut.Name = "viewBut";
            this.viewBut.Size = new System.Drawing.Size(220, 40);
            this.viewBut.TabIndex = 2;
            this.viewBut.Text = "View Students";
            this.viewBut.UseVisualStyleBackColor = false;
            this.viewBut.Click += new System.EventHandler(this.viewBut_Click_1);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(218, 100);
            this.panel4.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TimeTableManagementSystemApp.Properties.Resources.SLIIT;
            this.pictureBox1.Location = new System.Drawing.Point(17, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(189, 76);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // contentPanel
            // 
            this.contentPanel.BackColor = System.Drawing.Color.White;
            this.contentPanel.Location = new System.Drawing.Point(231, 43);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(1040, 720);
            this.contentPanel.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(165)))), ((int)(((byte)(0)))));
            this.panel2.Location = new System.Drawing.Point(0, -7);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(5, 780);
            this.panel2.TabIndex = 1;
            // 
            // homeBtn
            // 
            this.homeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.homeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(104)))));
            this.homeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.homeBtn.FlatAppearance.BorderSize = 0;
            this.homeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeBtn.ForeColor = System.Drawing.Color.White;
            this.homeBtn.Location = new System.Drawing.Point(3, 287);
            this.homeBtn.Name = "homeBtn";
            this.homeBtn.Size = new System.Drawing.Size(220, 40);
            this.homeBtn.TabIndex = 16;
            this.homeBtn.Text = "Home";
            this.homeBtn.UseVisualStyleBackColor = false;
            this.homeBtn.Click += new System.EventHandler(this.homeBtn_Click);
            // 
            // StudentManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 760);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.contentPanel);
            this.Controls.Add(this.sidePanel);
            this.Controls.Add(this.topPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StudentManagement";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.miniBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).EndInit();
            this.sidePanel.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Panel sidePanel;
        private System.Windows.Forms.Panel contentPanel;
        private System.Windows.Forms.Button addtagBut;
        private System.Windows.Forms.Button viewBut;
        private System.Windows.Forms.Button addStudentBut;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox maxBtn;
        private System.Windows.Forms.PictureBox miniBtn;
        private System.Windows.Forms.PictureBox closeBtn;
        private System.Windows.Forms.Button editStudentBtn;
        private System.Windows.Forms.Button homeBtn;
    }
}