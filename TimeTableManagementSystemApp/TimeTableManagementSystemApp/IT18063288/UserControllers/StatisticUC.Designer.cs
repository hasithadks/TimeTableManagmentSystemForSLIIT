namespace TimeTableManagementSystemApp.IT18063288.UserControllers
{
    partial class StatisticUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel = new System.Windows.Forms.Panel();
            this.statisticInnerPanel = new System.Windows.Forms.Panel();
            this.btnViewlecturers = new System.Windows.Forms.Button();
            this.btnViewStudents = new System.Windows.Forms.Button();
            this.btnViewSubjects = new System.Windows.Forms.Button();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.btnViewSubjects);
            this.panel.Controls.Add(this.btnViewStudents);
            this.panel.Controls.Add(this.btnViewlecturers);
            this.panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1012, 59);
            this.panel.TabIndex = 0;
            // 
            // statisticInnerPanel
            // 
            this.statisticInnerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.statisticInnerPanel.Location = new System.Drawing.Point(0, 59);
            this.statisticInnerPanel.Name = "statisticInnerPanel";
            this.statisticInnerPanel.Size = new System.Drawing.Size(1012, 641);
            this.statisticInnerPanel.TabIndex = 1;
            // 
            // btnViewlecturers
            // 
            this.btnViewlecturers.BackColor = System.Drawing.Color.SlateBlue;
            this.btnViewlecturers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewlecturers.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnViewlecturers.FlatAppearance.BorderSize = 0;
            this.btnViewlecturers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewlecturers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewlecturers.ForeColor = System.Drawing.Color.White;
            this.btnViewlecturers.Location = new System.Drawing.Point(0, 0);
            this.btnViewlecturers.Margin = new System.Windows.Forms.Padding(0);
            this.btnViewlecturers.Name = "btnViewlecturers";
            this.btnViewlecturers.Size = new System.Drawing.Size(339, 59);
            this.btnViewlecturers.TabIndex = 2;
            this.btnViewlecturers.Text = "Lecturers";
            this.btnViewlecturers.UseVisualStyleBackColor = false;
            // 
            // btnViewStudents
            // 
            this.btnViewStudents.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnViewStudents.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewStudents.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnViewStudents.FlatAppearance.BorderSize = 0;
            this.btnViewStudents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewStudents.ForeColor = System.Drawing.Color.White;
            this.btnViewStudents.Location = new System.Drawing.Point(339, 0);
            this.btnViewStudents.Margin = new System.Windows.Forms.Padding(0);
            this.btnViewStudents.Name = "btnViewStudents";
            this.btnViewStudents.Size = new System.Drawing.Size(339, 59);
            this.btnViewStudents.TabIndex = 3;
            this.btnViewStudents.Text = "Students";
            this.btnViewStudents.UseVisualStyleBackColor = false;
            // 
            // btnViewSubjects
            // 
            this.btnViewSubjects.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnViewSubjects.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewSubjects.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnViewSubjects.FlatAppearance.BorderSize = 0;
            this.btnViewSubjects.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewSubjects.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewSubjects.ForeColor = System.Drawing.Color.White;
            this.btnViewSubjects.Location = new System.Drawing.Point(678, 0);
            this.btnViewSubjects.Margin = new System.Windows.Forms.Padding(0);
            this.btnViewSubjects.Name = "btnViewSubjects";
            this.btnViewSubjects.Size = new System.Drawing.Size(339, 59);
            this.btnViewSubjects.TabIndex = 4;
            this.btnViewSubjects.Text = "Subjects";
            this.btnViewSubjects.UseVisualStyleBackColor = false;
            // 
            // StatisticUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.Controls.Add(this.statisticInnerPanel);
            this.Controls.Add(this.panel);
            this.Name = "StatisticUC";
            this.Size = new System.Drawing.Size(1012, 700);
            this.panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Panel statisticInnerPanel;
        private System.Windows.Forms.Button btnViewSubjects;
        private System.Windows.Forms.Button btnViewStudents;
        private System.Windows.Forms.Button btnViewlecturers;
    }
}
