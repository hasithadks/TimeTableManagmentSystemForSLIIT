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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.sidePanel = new System.Windows.Forms.Panel();
            this.addtagBut = new System.Windows.Forms.Button();
            this.viewBut = new System.Windows.Forms.Button();
            this.addStudentBut = new System.Windows.Forms.Button();
            this.contentPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.sidePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.White;
            this.topPanel.Location = new System.Drawing.Point(255, 1);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1026, 60);
            this.topPanel.TabIndex = 0;
            this.topPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.topPanel_Paint);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Image = global::TimeTableManagementSystemApp.Properties.Resources.SLIIT;
            this.pictureBox2.Location = new System.Drawing.Point(10, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(237, 53);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(8, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(240, 55);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // sidePanel
            // 
            this.sidePanel.BackColor = System.Drawing.Color.Transparent;
            this.sidePanel.Controls.Add(this.addtagBut);
            this.sidePanel.Controls.Add(this.viewBut);
            this.sidePanel.Controls.Add(this.addStudentBut);
            this.sidePanel.Location = new System.Drawing.Point(1, 60);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(253, 700);
            this.sidePanel.TabIndex = 1;
            // 
            // addtagBut
            // 
            this.addtagBut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(104)))));
            this.addtagBut.FlatAppearance.BorderSize = 0;
            this.addtagBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addtagBut.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addtagBut.ForeColor = System.Drawing.Color.White;
            this.addtagBut.Location = new System.Drawing.Point(0, 160);
            this.addtagBut.Margin = new System.Windows.Forms.Padding(2);
            this.addtagBut.Name = "addtagBut";
            this.addtagBut.Size = new System.Drawing.Size(251, 40);
            this.addtagBut.TabIndex = 3;
            this.addtagBut.Text = "Tags";
            this.addtagBut.UseVisualStyleBackColor = false;
            this.addtagBut.Click += new System.EventHandler(this.addtagBut_Click_1);
            // 
            // viewBut
            // 
            this.viewBut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(104)))));
            this.viewBut.FlatAppearance.BorderSize = 0;
            this.viewBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewBut.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewBut.ForeColor = System.Drawing.Color.White;
            this.viewBut.Location = new System.Drawing.Point(1, 101);
            this.viewBut.Margin = new System.Windows.Forms.Padding(2);
            this.viewBut.Name = "viewBut";
            this.viewBut.Size = new System.Drawing.Size(251, 40);
            this.viewBut.TabIndex = 2;
            this.viewBut.Text = "View Students";
            this.viewBut.UseVisualStyleBackColor = false;
            this.viewBut.Click += new System.EventHandler(this.viewBut_Click_1);
            // 
            // addStudentBut
            // 
            this.addStudentBut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(104)))));
            this.addStudentBut.FlatAppearance.BorderSize = 0;
            this.addStudentBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addStudentBut.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addStudentBut.ForeColor = System.Drawing.Color.White;
            this.addStudentBut.Location = new System.Drawing.Point(2, 44);
            this.addStudentBut.Margin = new System.Windows.Forms.Padding(2);
            this.addStudentBut.Name = "addStudentBut";
            this.addStudentBut.Size = new System.Drawing.Size(251, 40);
            this.addStudentBut.TabIndex = 1;
            this.addStudentBut.Text = "Add Student";
            this.addStudentBut.UseVisualStyleBackColor = false;
            this.addStudentBut.Click += new System.EventHandler(this.addStudentBut_Click_1);
            // 
            // contentPanel
            // 
            this.contentPanel.BackColor = System.Drawing.Color.White;
            this.contentPanel.Location = new System.Drawing.Point(255, 61);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(1025, 700);
            this.contentPanel.TabIndex = 2;
            // 
            // StudentManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 760);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.contentPanel);
            this.Controls.Add(this.sidePanel);
            this.Controls.Add(this.topPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StudentManagement";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.sidePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Panel sidePanel;
        private System.Windows.Forms.Panel contentPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button addtagBut;
        private System.Windows.Forms.Button viewBut;
        private System.Windows.Forms.Button addStudentBut;
    }
}