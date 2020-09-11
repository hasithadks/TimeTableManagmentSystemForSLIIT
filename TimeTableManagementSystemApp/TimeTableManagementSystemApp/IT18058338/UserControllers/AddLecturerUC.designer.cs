namespace TimeTableManagementSystemApp.IT18058338.UserControllers
{
    partial class AddLecturerUC
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
            this.label1 = new System.Windows.Forms.Label();
            this.labelid = new System.Windows.Forms.Label();
            this.textBoxid = new System.Windows.Forms.TextBox();
            this.labelname = new System.Windows.Forms.Label();
            this.textBoxname = new System.Windows.Forms.TextBox();
            this.labelfaculty = new System.Windows.Forms.Label();
            this.checkedListBoxfaculty = new System.Windows.Forms.CheckedListBox();
            this.labeldepartment = new System.Windows.Forms.Label();
            this.textBoxdepartment = new System.Windows.Forms.TextBox();
            this.labelcenter = new System.Windows.Forms.Label();
            this.labelbuilding = new System.Windows.Forms.Label();
            this.labellevel = new System.Windows.Forms.Label();
            this.textBoxlevel = new System.Windows.Forms.TextBox();
            this.labelrank = new System.Windows.Forms.Label();
            this.textBoxrank = new System.Windows.Forms.TextBox();
            this.buttonaddlecturer = new System.Windows.Forms.Button();
            this.comboBoxBuilding = new System.Windows.Forms.ComboBox();
            this.checkedListBoxCenter = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(465, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Lecturer";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelid
            // 
            this.labelid.AutoSize = true;
            this.labelid.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.labelid.Location = new System.Drawing.Point(235, 65);
            this.labelid.Name = "labelid";
            this.labelid.Size = new System.Drawing.Size(95, 21);
            this.labelid.TabIndex = 1;
            this.labelid.Text = "Lecturer ID";
            // 
            // textBoxid
            // 
            this.textBoxid.Location = new System.Drawing.Point(469, 65);
            this.textBoxid.Name = "textBoxid";
            this.textBoxid.Size = new System.Drawing.Size(100, 20);
            this.textBoxid.TabIndex = 2;
            // 
            // labelname
            // 
            this.labelname.AutoSize = true;
            this.labelname.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.labelname.Location = new System.Drawing.Point(234, 113);
            this.labelname.Name = "labelname";
            this.labelname.Size = new System.Drawing.Size(126, 21);
            this.labelname.TabIndex = 3;
            this.labelname.Text = "Lecturer Name";
            // 
            // textBoxname
            // 
            this.textBoxname.Location = new System.Drawing.Point(469, 113);
            this.textBoxname.Name = "textBoxname";
            this.textBoxname.Size = new System.Drawing.Size(282, 20);
            this.textBoxname.TabIndex = 4;
            // 
            // labelfaculty
            // 
            this.labelfaculty.AutoSize = true;
            this.labelfaculty.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.labelfaculty.Location = new System.Drawing.Point(234, 161);
            this.labelfaculty.Name = "labelfaculty";
            this.labelfaculty.Size = new System.Drawing.Size(119, 21);
            this.labelfaculty.TabIndex = 5;
            this.labelfaculty.Text = "Select Faculty";
            // 
            // checkedListBoxfaculty
            // 
            this.checkedListBoxfaculty.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBoxfaculty.FormattingEnabled = true;
            this.checkedListBoxfaculty.Items.AddRange(new object[] {
            "Faculty Of Computing",
            "Faculty Of Engineering",
            "Faculty Of Business",
            "Faculty Of Humanities & Science",
            "School Of Architecture",
            "Other"});
            this.checkedListBoxfaculty.Location = new System.Drawing.Point(469, 161);
            this.checkedListBoxfaculty.Name = "checkedListBoxfaculty";
            this.checkedListBoxfaculty.Size = new System.Drawing.Size(216, 84);
            this.checkedListBoxfaculty.TabIndex = 7;
            // 
            // labeldepartment
            // 
            this.labeldepartment.AutoSize = true;
            this.labeldepartment.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.labeldepartment.Location = new System.Drawing.Point(235, 272);
            this.labeldepartment.Name = "labeldepartment";
            this.labeldepartment.Size = new System.Drawing.Size(160, 21);
            this.labeldepartment.TabIndex = 8;
            this.labeldepartment.Text = "Select Department";
            this.labeldepartment.Click += new System.EventHandler(this.labeldepartment_Click);
            // 
            // textBoxdepartment
            // 
            this.textBoxdepartment.Location = new System.Drawing.Point(469, 272);
            this.textBoxdepartment.Name = "textBoxdepartment";
            this.textBoxdepartment.Size = new System.Drawing.Size(282, 20);
            this.textBoxdepartment.TabIndex = 9;
            this.textBoxdepartment.TextChanged += new System.EventHandler(this.textBoxdepartment_TextChanged);
            // 
            // labelcenter
            // 
            this.labelcenter.AutoSize = true;
            this.labelcenter.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.labelcenter.Location = new System.Drawing.Point(235, 320);
            this.labelcenter.Name = "labelcenter";
            this.labelcenter.Size = new System.Drawing.Size(117, 21);
            this.labelcenter.TabIndex = 10;
            this.labelcenter.Text = "Select Center";
            // 
            // labelbuilding
            // 
            this.labelbuilding.AutoSize = true;
            this.labelbuilding.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.labelbuilding.Location = new System.Drawing.Point(234, 438);
            this.labelbuilding.Name = "labelbuilding";
            this.labelbuilding.Size = new System.Drawing.Size(122, 21);
            this.labelbuilding.TabIndex = 17;
            this.labelbuilding.Text = "Select Building";
            // 
            // labellevel
            // 
            this.labellevel.AutoSize = true;
            this.labellevel.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.labellevel.Location = new System.Drawing.Point(234, 488);
            this.labellevel.Name = "labellevel";
            this.labellevel.Size = new System.Drawing.Size(118, 21);
            this.labellevel.TabIndex = 19;
            this.labellevel.Text = "Lecturer Level";
            // 
            // textBoxlevel
            // 
            this.textBoxlevel.Location = new System.Drawing.Point(469, 488);
            this.textBoxlevel.Name = "textBoxlevel";
            this.textBoxlevel.Size = new System.Drawing.Size(100, 20);
            this.textBoxlevel.TabIndex = 20;
            // 
            // labelrank
            // 
            this.labelrank.AutoSize = true;
            this.labelrank.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.labelrank.Location = new System.Drawing.Point(235, 538);
            this.labelrank.Name = "labelrank";
            this.labelrank.Size = new System.Drawing.Size(49, 21);
            this.labelrank.TabIndex = 21;
            this.labelrank.Text = "Rank";
            // 
            // textBoxrank
            // 
            this.textBoxrank.Location = new System.Drawing.Point(469, 538);
            this.textBoxrank.Name = "textBoxrank";
            this.textBoxrank.Size = new System.Drawing.Size(100, 20);
            this.textBoxrank.TabIndex = 22;
            // 
            // buttonaddlecturer
            // 
            this.buttonaddlecturer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(104)))));
            this.buttonaddlecturer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonaddlecturer.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.buttonaddlecturer.ForeColor = System.Drawing.Color.White;
            this.buttonaddlecturer.Location = new System.Drawing.Point(602, 596);
            this.buttonaddlecturer.Name = "buttonaddlecturer";
            this.buttonaddlecturer.Size = new System.Drawing.Size(150, 30);
            this.buttonaddlecturer.TabIndex = 26;
            this.buttonaddlecturer.Text = "Add Lecturer";
            this.buttonaddlecturer.UseVisualStyleBackColor = false;
            this.buttonaddlecturer.Click += new System.EventHandler(this.buttonaddlecturer_Click);
            // 
            // comboBoxBuilding
            // 
            this.comboBoxBuilding.FormattingEnabled = true;
            this.comboBoxBuilding.Location = new System.Drawing.Point(469, 438);
            this.comboBoxBuilding.Name = "comboBoxBuilding";
            this.comboBoxBuilding.Size = new System.Drawing.Size(216, 21);
            this.comboBoxBuilding.TabIndex = 27;
            this.comboBoxBuilding.SelectedIndexChanged += new System.EventHandler(this.comboBoxBuilding_SelectedIndexChanged);
            // 
            // checkedListBoxCenter
            // 
            this.checkedListBoxCenter.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBoxCenter.FormattingEnabled = true;
            this.checkedListBoxCenter.Items.AddRange(new object[] {
            "Malabe",
            "Metro",
            "Matara",
            "Kandy",
            "Kurunegala",
            "Jaffna"});
            this.checkedListBoxCenter.Location = new System.Drawing.Point(469, 320);
            this.checkedListBoxCenter.Name = "checkedListBoxCenter";
            this.checkedListBoxCenter.Size = new System.Drawing.Size(120, 84);
            this.checkedListBoxCenter.TabIndex = 28;
            // 
            // AddLecturerUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.checkedListBoxCenter);
            this.Controls.Add(this.comboBoxBuilding);
            this.Controls.Add(this.buttonaddlecturer);
            this.Controls.Add(this.textBoxrank);
            this.Controls.Add(this.labelrank);
            this.Controls.Add(this.textBoxlevel);
            this.Controls.Add(this.labellevel);
            this.Controls.Add(this.labelbuilding);
            this.Controls.Add(this.labelcenter);
            this.Controls.Add(this.textBoxdepartment);
            this.Controls.Add(this.labeldepartment);
            this.Controls.Add(this.checkedListBoxfaculty);
            this.Controls.Add(this.labelfaculty);
            this.Controls.Add(this.textBoxname);
            this.Controls.Add(this.labelname);
            this.Controls.Add(this.textBoxid);
            this.Controls.Add(this.labelid);
            this.Controls.Add(this.label1);
            this.Name = "AddLecturerUC";
            this.Size = new System.Drawing.Size(1025, 700);
            this.Load += new System.EventHandler(this.AddLecturerUC_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelid;
        private System.Windows.Forms.TextBox textBoxid;
        private System.Windows.Forms.Label labelname;
        private System.Windows.Forms.TextBox textBoxname;
        private System.Windows.Forms.Label labelfaculty;
        private System.Windows.Forms.CheckedListBox checkedListBoxfaculty;
        private System.Windows.Forms.Label labeldepartment;
        private System.Windows.Forms.TextBox textBoxdepartment;
        private System.Windows.Forms.Label labelcenter;
        private System.Windows.Forms.Label labelbuilding;
        private System.Windows.Forms.Label labellevel;
        private System.Windows.Forms.TextBox textBoxlevel;
        private System.Windows.Forms.Label labelrank;
        private System.Windows.Forms.TextBox textBoxrank;
        private System.Windows.Forms.Button buttonaddlecturer;
        private System.Windows.Forms.ComboBox comboBoxBuilding;
        private System.Windows.Forms.CheckedListBox checkedListBoxCenter;
    }
}
