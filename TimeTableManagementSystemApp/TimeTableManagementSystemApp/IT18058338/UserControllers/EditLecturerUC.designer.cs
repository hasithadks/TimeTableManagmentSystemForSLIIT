namespace TimeTableManagementSystemApp.IT18058338.UserControllers
{
    partial class EditLecturerUC
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
            this.editcheckedListBoxCenter = new System.Windows.Forms.CheckedListBox();
            this.editcomboBoxBuilding = new System.Windows.Forms.ComboBox();
            this.buttonaddlecturer = new System.Windows.Forms.Button();
            this.edittextBoxrank = new System.Windows.Forms.TextBox();
            this.labelrank = new System.Windows.Forms.Label();
            this.edittextBoxlevel = new System.Windows.Forms.TextBox();
            this.labellevel = new System.Windows.Forms.Label();
            this.labelbuilding = new System.Windows.Forms.Label();
            this.labelcenter = new System.Windows.Forms.Label();
            this.edittextBoxdepartment = new System.Windows.Forms.TextBox();
            this.labeldepartment = new System.Windows.Forms.Label();
            this.editcheckedListBoxfaculty = new System.Windows.Forms.CheckedListBox();
            this.labelfaculty = new System.Windows.Forms.Label();
            this.edittextBoxname = new System.Windows.Forms.TextBox();
            this.labelname = new System.Windows.Forms.Label();
            this.edittextBoxid = new System.Windows.Forms.TextBox();
            this.labelid = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonDeleteLecturer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // editcheckedListBoxCenter
            // 
            this.editcheckedListBoxCenter.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editcheckedListBoxCenter.FormattingEnabled = true;
            this.editcheckedListBoxCenter.Items.AddRange(new object[] {
            "Malabe",
            "Metro",
            "Matara",
            "Kandy",
            "Kurunegala",
            "Jaffna"});
            this.editcheckedListBoxCenter.Location = new System.Drawing.Point(473, 318);
            this.editcheckedListBoxCenter.Name = "editcheckedListBoxCenter";
            this.editcheckedListBoxCenter.Size = new System.Drawing.Size(120, 84);
            this.editcheckedListBoxCenter.TabIndex = 46;
            // 
            // editcomboBoxBuilding
            // 
            this.editcomboBoxBuilding.FormattingEnabled = true;
            this.editcomboBoxBuilding.Location = new System.Drawing.Point(473, 436);
            this.editcomboBoxBuilding.Name = "editcomboBoxBuilding";
            this.editcomboBoxBuilding.Size = new System.Drawing.Size(216, 21);
            this.editcomboBoxBuilding.TabIndex = 45;
            // 
            // buttonaddlecturer
            // 
            this.buttonaddlecturer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(104)))));
            this.buttonaddlecturer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonaddlecturer.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.buttonaddlecturer.ForeColor = System.Drawing.Color.White;
            this.buttonaddlecturer.Location = new System.Drawing.Point(606, 594);
            this.buttonaddlecturer.Name = "buttonaddlecturer";
            this.buttonaddlecturer.Size = new System.Drawing.Size(150, 30);
            this.buttonaddlecturer.TabIndex = 44;
            this.buttonaddlecturer.Text = "Update Lecturer";
            this.buttonaddlecturer.UseVisualStyleBackColor = false;
            this.buttonaddlecturer.Click += new System.EventHandler(this.buttonaddlecturer_Click);
            // 
            // edittextBoxrank
            // 
            this.edittextBoxrank.Location = new System.Drawing.Point(473, 536);
            this.edittextBoxrank.Name = "edittextBoxrank";
            this.edittextBoxrank.Size = new System.Drawing.Size(100, 20);
            this.edittextBoxrank.TabIndex = 43;
            // 
            // labelrank
            // 
            this.labelrank.AutoSize = true;
            this.labelrank.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.labelrank.Location = new System.Drawing.Point(239, 536);
            this.labelrank.Name = "labelrank";
            this.labelrank.Size = new System.Drawing.Size(49, 21);
            this.labelrank.TabIndex = 42;
            this.labelrank.Text = "Rank";
            // 
            // edittextBoxlevel
            // 
            this.edittextBoxlevel.Location = new System.Drawing.Point(473, 486);
            this.edittextBoxlevel.Name = "edittextBoxlevel";
            this.edittextBoxlevel.Size = new System.Drawing.Size(100, 20);
            this.edittextBoxlevel.TabIndex = 41;
            // 
            // labellevel
            // 
            this.labellevel.AutoSize = true;
            this.labellevel.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.labellevel.Location = new System.Drawing.Point(238, 486);
            this.labellevel.Name = "labellevel";
            this.labellevel.Size = new System.Drawing.Size(118, 21);
            this.labellevel.TabIndex = 40;
            this.labellevel.Text = "Lecturer Level";
            // 
            // labelbuilding
            // 
            this.labelbuilding.AutoSize = true;
            this.labelbuilding.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.labelbuilding.Location = new System.Drawing.Point(238, 436);
            this.labelbuilding.Name = "labelbuilding";
            this.labelbuilding.Size = new System.Drawing.Size(122, 21);
            this.labelbuilding.TabIndex = 39;
            this.labelbuilding.Text = "Select Building";
            // 
            // labelcenter
            // 
            this.labelcenter.AutoSize = true;
            this.labelcenter.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.labelcenter.Location = new System.Drawing.Point(239, 318);
            this.labelcenter.Name = "labelcenter";
            this.labelcenter.Size = new System.Drawing.Size(117, 21);
            this.labelcenter.TabIndex = 38;
            this.labelcenter.Text = "Select Center";
            // 
            // edittextBoxdepartment
            // 
            this.edittextBoxdepartment.Location = new System.Drawing.Point(473, 270);
            this.edittextBoxdepartment.Name = "edittextBoxdepartment";
            this.edittextBoxdepartment.Size = new System.Drawing.Size(282, 20);
            this.edittextBoxdepartment.TabIndex = 37;
            // 
            // labeldepartment
            // 
            this.labeldepartment.AutoSize = true;
            this.labeldepartment.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.labeldepartment.Location = new System.Drawing.Point(239, 270);
            this.labeldepartment.Name = "labeldepartment";
            this.labeldepartment.Size = new System.Drawing.Size(160, 21);
            this.labeldepartment.TabIndex = 36;
            this.labeldepartment.Text = "Select Department";
            // 
            // editcheckedListBoxfaculty
            // 
            this.editcheckedListBoxfaculty.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editcheckedListBoxfaculty.FormattingEnabled = true;
            this.editcheckedListBoxfaculty.Items.AddRange(new object[] {
            "Faculty Of Computing",
            "Faculty Of Engineering",
            "Faculty Of Business",
            "Faculty Of Humanities & Science",
            "School Of Architecture",
            "Other"});
            this.editcheckedListBoxfaculty.Location = new System.Drawing.Point(473, 159);
            this.editcheckedListBoxfaculty.Name = "editcheckedListBoxfaculty";
            this.editcheckedListBoxfaculty.Size = new System.Drawing.Size(216, 84);
            this.editcheckedListBoxfaculty.TabIndex = 35;
            // 
            // labelfaculty
            // 
            this.labelfaculty.AutoSize = true;
            this.labelfaculty.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.labelfaculty.Location = new System.Drawing.Point(238, 159);
            this.labelfaculty.Name = "labelfaculty";
            this.labelfaculty.Size = new System.Drawing.Size(119, 21);
            this.labelfaculty.TabIndex = 34;
            this.labelfaculty.Text = "Select Faculty";
            // 
            // edittextBoxname
            // 
            this.edittextBoxname.Location = new System.Drawing.Point(473, 111);
            this.edittextBoxname.Name = "edittextBoxname";
            this.edittextBoxname.Size = new System.Drawing.Size(282, 20);
            this.edittextBoxname.TabIndex = 33;
            // 
            // labelname
            // 
            this.labelname.AutoSize = true;
            this.labelname.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.labelname.Location = new System.Drawing.Point(238, 111);
            this.labelname.Name = "labelname";
            this.labelname.Size = new System.Drawing.Size(126, 21);
            this.labelname.TabIndex = 32;
            this.labelname.Text = "Lecturer Name";
            // 
            // edittextBoxid
            // 
            this.edittextBoxid.Location = new System.Drawing.Point(473, 63);
            this.edittextBoxid.Name = "edittextBoxid";
            this.edittextBoxid.Size = new System.Drawing.Size(100, 20);
            this.edittextBoxid.TabIndex = 31;
            // 
            // labelid
            // 
            this.labelid.AutoSize = true;
            this.labelid.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.labelid.Location = new System.Drawing.Point(239, 63);
            this.labelid.Name = "labelid";
            this.labelid.Size = new System.Drawing.Size(95, 21);
            this.labelid.TabIndex = 30;
            this.labelid.Text = "Lecturer ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(469, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 19);
            this.label1.TabIndex = 29;
            this.label1.Text = "Edit Lecturer";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // buttonDeleteLecturer
            // 
            this.buttonDeleteLecturer.BackColor = System.Drawing.Color.Red;
            this.buttonDeleteLecturer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDeleteLecturer.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.buttonDeleteLecturer.ForeColor = System.Drawing.Color.White;
            this.buttonDeleteLecturer.Location = new System.Drawing.Point(450, 594);
            this.buttonDeleteLecturer.Name = "buttonDeleteLecturer";
            this.buttonDeleteLecturer.Size = new System.Drawing.Size(150, 30);
            this.buttonDeleteLecturer.TabIndex = 47;
            this.buttonDeleteLecturer.Text = "Delete Lecturer";
            this.buttonDeleteLecturer.UseVisualStyleBackColor = false;
            this.buttonDeleteLecturer.Click += new System.EventHandler(this.buttonDeleteLecturer_Click);
            // 
            // EditLecturerUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonDeleteLecturer);
            this.Controls.Add(this.editcheckedListBoxCenter);
            this.Controls.Add(this.editcomboBoxBuilding);
            this.Controls.Add(this.buttonaddlecturer);
            this.Controls.Add(this.edittextBoxrank);
            this.Controls.Add(this.labelrank);
            this.Controls.Add(this.edittextBoxlevel);
            this.Controls.Add(this.labellevel);
            this.Controls.Add(this.labelbuilding);
            this.Controls.Add(this.labelcenter);
            this.Controls.Add(this.edittextBoxdepartment);
            this.Controls.Add(this.labeldepartment);
            this.Controls.Add(this.editcheckedListBoxfaculty);
            this.Controls.Add(this.labelfaculty);
            this.Controls.Add(this.edittextBoxname);
            this.Controls.Add(this.labelname);
            this.Controls.Add(this.edittextBoxid);
            this.Controls.Add(this.labelid);
            this.Controls.Add(this.label1);
            this.Name = "EditLecturerUC";
            this.Size = new System.Drawing.Size(1025, 700);
            this.Load += new System.EventHandler(this.EditLecturerUC_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox editcheckedListBoxCenter;
        private System.Windows.Forms.ComboBox editcomboBoxBuilding;
        private System.Windows.Forms.Button buttonaddlecturer;
        private System.Windows.Forms.TextBox edittextBoxrank;
        private System.Windows.Forms.Label labelrank;
        private System.Windows.Forms.TextBox edittextBoxlevel;
        private System.Windows.Forms.Label labellevel;
        private System.Windows.Forms.Label labelbuilding;
        private System.Windows.Forms.Label labelcenter;
        private System.Windows.Forms.TextBox edittextBoxdepartment;
        private System.Windows.Forms.Label labeldepartment;
        private System.Windows.Forms.CheckedListBox editcheckedListBoxfaculty;
        private System.Windows.Forms.Label labelfaculty;
        private System.Windows.Forms.TextBox edittextBoxname;
        private System.Windows.Forms.Label labelname;
        private System.Windows.Forms.TextBox edittextBoxid;
        private System.Windows.Forms.Label labelid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonDeleteLecturer;
    }
}
