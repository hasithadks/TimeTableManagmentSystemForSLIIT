namespace TimeTableManagementSystemApp.IT18058338.Forms
{
    partial class LecturerForm
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
            this.navigationpanel = new System.Windows.Forms.Panel();
            this.viewlecturerbtn = new System.Windows.Forms.Button();
            this.editlecturerbtn = new System.Windows.Forms.Button();
            this.addlecturerbtn = new System.Windows.Forms.Button();
            this.headerpanel = new System.Windows.Forms.Panel();
            this.mainpanel = new System.Windows.Forms.Panel();
            this.navigationpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // navigationpanel
            // 
            this.navigationpanel.Controls.Add(this.viewlecturerbtn);
            this.navigationpanel.Controls.Add(this.editlecturerbtn);
            this.navigationpanel.Controls.Add(this.addlecturerbtn);
            this.navigationpanel.Location = new System.Drawing.Point(1, 65);
            this.navigationpanel.Name = "navigationpanel";
            this.navigationpanel.Size = new System.Drawing.Size(250, 700);
            this.navigationpanel.TabIndex = 0;
            // 
            // viewlecturerbtn
            // 
            this.viewlecturerbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(104)))));
            this.viewlecturerbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.viewlecturerbtn.FlatAppearance.BorderSize = 0;
            this.viewlecturerbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewlecturerbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewlecturerbtn.ForeColor = System.Drawing.Color.White;
            this.viewlecturerbtn.Location = new System.Drawing.Point(0, 9);
            this.viewlecturerbtn.Margin = new System.Windows.Forms.Padding(0);
            this.viewlecturerbtn.Name = "viewlecturerbtn";
            this.viewlecturerbtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.viewlecturerbtn.Size = new System.Drawing.Size(250, 54);
            this.viewlecturerbtn.TabIndex = 5;
            this.viewlecturerbtn.Text = "View Lecturer";
            this.viewlecturerbtn.UseVisualStyleBackColor = false;
            this.viewlecturerbtn.Click += new System.EventHandler(this.viewlecturerbtn_Click);
            // 
            // editlecturerbtn
            // 
            this.editlecturerbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(104)))));
            this.editlecturerbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editlecturerbtn.FlatAppearance.BorderSize = 0;
            this.editlecturerbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editlecturerbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editlecturerbtn.ForeColor = System.Drawing.Color.White;
            this.editlecturerbtn.Location = new System.Drawing.Point(0, 136);
            this.editlecturerbtn.Margin = new System.Windows.Forms.Padding(0);
            this.editlecturerbtn.Name = "editlecturerbtn";
            this.editlecturerbtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.editlecturerbtn.Size = new System.Drawing.Size(250, 54);
            this.editlecturerbtn.TabIndex = 4;
            this.editlecturerbtn.Text = "Edit Lecturer";
            this.editlecturerbtn.UseVisualStyleBackColor = false;
            this.editlecturerbtn.Click += new System.EventHandler(this.editlecturerbtn_Click);
            // 
            // addlecturerbtn
            // 
            this.addlecturerbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(104)))));
            this.addlecturerbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addlecturerbtn.FlatAppearance.BorderSize = 0;
            this.addlecturerbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addlecturerbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addlecturerbtn.ForeColor = System.Drawing.Color.White;
            this.addlecturerbtn.Location = new System.Drawing.Point(0, 72);
            this.addlecturerbtn.Margin = new System.Windows.Forms.Padding(0);
            this.addlecturerbtn.Name = "addlecturerbtn";
            this.addlecturerbtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.addlecturerbtn.Size = new System.Drawing.Size(250, 54);
            this.addlecturerbtn.TabIndex = 3;
            this.addlecturerbtn.Text = "Add Lecturer";
            this.addlecturerbtn.UseVisualStyleBackColor = false;
            this.addlecturerbtn.Click += new System.EventHandler(this.addlecturerbtn_Click);
            // 
            // headerpanel
            // 
            this.headerpanel.Location = new System.Drawing.Point(2, -1);
            this.headerpanel.Name = "headerpanel";
            this.headerpanel.Size = new System.Drawing.Size(1280, 60);
            this.headerpanel.TabIndex = 1;
            // 
            // mainpanel
            // 
            this.mainpanel.Location = new System.Drawing.Point(257, 65);
            this.mainpanel.Name = "mainpanel";
            this.mainpanel.Size = new System.Drawing.Size(1025, 700);
            this.mainpanel.TabIndex = 2;
            // 
            // LecturerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1280, 768);
            this.Controls.Add(this.mainpanel);
            this.Controls.Add(this.headerpanel);
            this.Controls.Add(this.navigationpanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LecturerForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.navigationpanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel navigationpanel;
        private System.Windows.Forms.Panel headerpanel;
        private System.Windows.Forms.Panel mainpanel;
        private System.Windows.Forms.Button addlecturerbtn;
        private System.Windows.Forms.Button editlecturerbtn;
        private System.Windows.Forms.Button viewlecturerbtn;
    }
}