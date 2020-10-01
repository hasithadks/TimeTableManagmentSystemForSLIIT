namespace TimeTableManagementSystemApp.IT18063288.UserControllers
{
    partial class AddSessionsUC
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
            this.btnCreateSession = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxYear = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxSemester = new System.Windows.Forms.ComboBox();
            this.comboBoxLecturer = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxSubject = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxGroup = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxSubGroup = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxTag = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textNoFoStudent = new System.Windows.Forms.TextBox();
            this.txtSessionDuration = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.AddlecturerBtn = new System.Windows.Forms.Button();
            this.Lecturer01 = new System.Windows.Forms.Label();
            this.Lecturer02 = new System.Windows.Forms.Label();
            this.Lecturer03 = new System.Windows.Forms.Label();
            this.Lecturer04 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCreateSession
            // 
            this.btnCreateSession.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(104)))));
            this.btnCreateSession.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCreateSession.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreateSession.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateSession.ForeColor = System.Drawing.Color.White;
            this.btnCreateSession.Location = new System.Drawing.Point(489, 587);
            this.btnCreateSession.Margin = new System.Windows.Forms.Padding(0);
            this.btnCreateSession.Name = "btnCreateSession";
            this.btnCreateSession.Size = new System.Drawing.Size(217, 41);
            this.btnCreateSession.TabIndex = 30;
            this.btnCreateSession.Text = "Create Session";
            this.btnCreateSession.UseVisualStyleBackColor = false;
            this.btnCreateSession.Click += new System.EventHandler(this.btnCreateSession_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Location = new System.Drawing.Point(296, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 19);
            this.label1.TabIndex = 29;
            this.label1.Text = "Select Year : ";
            // 
            // comboBoxYear
            // 
            this.comboBoxYear.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxYear.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxYear.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxYear.FormattingEnabled = true;
            this.comboBoxYear.Items.AddRange(new object[] {
            "~Select Year~",
            "1st Year",
            "2nd Year",
            "3rd Year",
            "4th Yaer"});
            this.comboBoxYear.Location = new System.Drawing.Point(429, 76);
            this.comboBoxYear.Name = "comboBoxYear";
            this.comboBoxYear.Size = new System.Drawing.Size(277, 27);
            this.comboBoxYear.TabIndex = 28;
            this.comboBoxYear.SelectedIndexChanged += new System.EventHandler(this.comboBoxYear_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(370, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 19);
            this.label2.TabIndex = 31;
            this.label2.Text = "Create Sessions";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label3.Location = new System.Drawing.Point(263, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 19);
            this.label3.TabIndex = 32;
            this.label3.Text = "Select Semester : ";
            // 
            // comboBoxSemester
            // 
            this.comboBoxSemester.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxSemester.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxSemester.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSemester.FormattingEnabled = true;
            this.comboBoxSemester.Items.AddRange(new object[] {
            "~Select Semester~",
            "1st Semester",
            "2nd Semester"});
            this.comboBoxSemester.Location = new System.Drawing.Point(429, 128);
            this.comboBoxSemester.Name = "comboBoxSemester";
            this.comboBoxSemester.Size = new System.Drawing.Size(277, 27);
            this.comboBoxSemester.TabIndex = 33;
            this.comboBoxSemester.SelectedIndexChanged += new System.EventHandler(this.comboBoxSemester_SelectedIndexChanged);
            // 
            // comboBoxLecturer
            // 
            this.comboBoxLecturer.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxLecturer.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxLecturer.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxLecturer.FormattingEnabled = true;
            this.comboBoxLecturer.Location = new System.Drawing.Point(429, 179);
            this.comboBoxLecturer.Name = "comboBoxLecturer";
            this.comboBoxLecturer.Size = new System.Drawing.Size(277, 27);
            this.comboBoxLecturer.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label4.Location = new System.Drawing.Point(271, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 19);
            this.label4.TabIndex = 34;
            this.label4.Text = "Select Lecturer : ";
            // 
            // comboBoxSubject
            // 
            this.comboBoxSubject.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxSubject.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxSubject.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSubject.FormattingEnabled = true;
            this.comboBoxSubject.Location = new System.Drawing.Point(429, 293);
            this.comboBoxSubject.Name = "comboBoxSubject";
            this.comboBoxSubject.Size = new System.Drawing.Size(277, 27);
            this.comboBoxSubject.TabIndex = 37;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label5.Location = new System.Drawing.Point(276, 296);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 19);
            this.label5.TabIndex = 36;
            this.label5.Text = "Select Subject : ";
            // 
            // comboBoxGroup
            // 
            this.comboBoxGroup.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxGroup.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxGroup.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxGroup.FormattingEnabled = true;
            this.comboBoxGroup.Location = new System.Drawing.Point(429, 344);
            this.comboBoxGroup.Name = "comboBoxGroup";
            this.comboBoxGroup.Size = new System.Drawing.Size(277, 27);
            this.comboBoxGroup.TabIndex = 39;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label6.Location = new System.Drawing.Point(284, 347);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 19);
            this.label6.TabIndex = 38;
            this.label6.Text = "Select Group : ";
            // 
            // comboBoxSubGroup
            // 
            this.comboBoxSubGroup.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxSubGroup.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxSubGroup.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSubGroup.FormattingEnabled = true;
            this.comboBoxSubGroup.Items.AddRange(new object[] {
            "None",
            "01",
            "02"});
            this.comboBoxSubGroup.Location = new System.Drawing.Point(429, 394);
            this.comboBoxSubGroup.Name = "comboBoxSubGroup";
            this.comboBoxSubGroup.Size = new System.Drawing.Size(277, 27);
            this.comboBoxSubGroup.TabIndex = 41;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label7.Location = new System.Drawing.Point(252, 397);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(147, 19);
            this.label7.TabIndex = 40;
            this.label7.Text = "Select Sub Group : ";
            // 
            // comboBoxTag
            // 
            this.comboBoxTag.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxTag.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxTag.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxTag.FormattingEnabled = true;
            this.comboBoxTag.Location = new System.Drawing.Point(429, 440);
            this.comboBoxTag.Name = "comboBoxTag";
            this.comboBoxTag.Size = new System.Drawing.Size(277, 27);
            this.comboBoxTag.TabIndex = 43;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label8.Location = new System.Drawing.Point(301, 443);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 19);
            this.label8.TabIndex = 42;
            this.label8.Text = "Select Tag : ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label9.Location = new System.Drawing.Point(276, 491);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(118, 19);
            this.label9.TabIndex = 44;
            this.label9.Text = "No of Student :";
            // 
            // textNoFoStudent
            // 
            this.textNoFoStudent.BackColor = System.Drawing.Color.White;
            this.textNoFoStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNoFoStudent.Location = new System.Drawing.Point(429, 488);
            this.textNoFoStudent.Name = "textNoFoStudent";
            this.textNoFoStudent.Size = new System.Drawing.Size(277, 26);
            this.textNoFoStudent.TabIndex = 45;
            // 
            // txtSessionDuration
            // 
            this.txtSessionDuration.BackColor = System.Drawing.Color.White;
            this.txtSessionDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSessionDuration.Location = new System.Drawing.Point(429, 533);
            this.txtSessionDuration.Name = "txtSessionDuration";
            this.txtSessionDuration.Size = new System.Drawing.Size(277, 26);
            this.txtSessionDuration.TabIndex = 47;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label10.Location = new System.Drawing.Point(255, 536);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(139, 19);
            this.label10.TabIndex = 46;
            this.label10.Text = "Session Duration :";
            // 
            // AddlecturerBtn
            // 
            this.AddlecturerBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(104)))));
            this.AddlecturerBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.AddlecturerBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddlecturerBtn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddlecturerBtn.ForeColor = System.Drawing.Color.White;
            this.AddlecturerBtn.Location = new System.Drawing.Point(726, 173);
            this.AddlecturerBtn.Margin = new System.Windows.Forms.Padding(0);
            this.AddlecturerBtn.Name = "AddlecturerBtn";
            this.AddlecturerBtn.Size = new System.Drawing.Size(133, 36);
            this.AddlecturerBtn.TabIndex = 48;
            this.AddlecturerBtn.Text = "Add Lecturer";
            this.AddlecturerBtn.UseVisualStyleBackColor = false;
            this.AddlecturerBtn.Click += new System.EventHandler(this.AddlecturerBtn_Click);
            // 
            // Lecturer01
            // 
            this.Lecturer01.AutoSize = true;
            this.Lecturer01.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lecturer01.ForeColor = System.Drawing.Color.Black;
            this.Lecturer01.Location = new System.Drawing.Point(425, 224);
            this.Lecturer01.Name = "Lecturer01";
            this.Lecturer01.Size = new System.Drawing.Size(84, 19);
            this.Lecturer01.TabIndex = 49;
            this.Lecturer01.Text = "Lecturer01";
            // 
            // Lecturer02
            // 
            this.Lecturer02.AutoSize = true;
            this.Lecturer02.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lecturer02.ForeColor = System.Drawing.Color.Black;
            this.Lecturer02.Location = new System.Drawing.Point(591, 224);
            this.Lecturer02.Name = "Lecturer02";
            this.Lecturer02.Size = new System.Drawing.Size(84, 19);
            this.Lecturer02.TabIndex = 50;
            this.Lecturer02.Text = "Lecturer02";
            // 
            // Lecturer03
            // 
            this.Lecturer03.AutoSize = true;
            this.Lecturer03.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lecturer03.ForeColor = System.Drawing.Color.Black;
            this.Lecturer03.Location = new System.Drawing.Point(425, 257);
            this.Lecturer03.Name = "Lecturer03";
            this.Lecturer03.Size = new System.Drawing.Size(84, 19);
            this.Lecturer03.TabIndex = 52;
            this.Lecturer03.Text = "Lecturer03";
            // 
            // Lecturer04
            // 
            this.Lecturer04.AutoSize = true;
            this.Lecturer04.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lecturer04.ForeColor = System.Drawing.Color.Black;
            this.Lecturer04.Location = new System.Drawing.Point(591, 257);
            this.Lecturer04.Name = "Lecturer04";
            this.Lecturer04.Size = new System.Drawing.Size(84, 19);
            this.Lecturer04.TabIndex = 53;
            this.Lecturer04.Text = "Lecturer04";
            // 
            // AddSessionsUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.Lecturer04);
            this.Controls.Add(this.Lecturer03);
            this.Controls.Add(this.Lecturer02);
            this.Controls.Add(this.Lecturer01);
            this.Controls.Add(this.AddlecturerBtn);
            this.Controls.Add(this.txtSessionDuration);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textNoFoStudent);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.comboBoxTag);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboBoxSubGroup);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBoxGroup);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBoxSubject);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxLecturer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxSemester);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCreateSession);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxYear);
            this.Name = "AddSessionsUC";
            this.Size = new System.Drawing.Size(1040, 720);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreateSession;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxYear;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxSemester;
        private System.Windows.Forms.ComboBox comboBoxLecturer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxSubject;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxGroup;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxSubGroup;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxTag;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textNoFoStudent;
        private System.Windows.Forms.TextBox txtSessionDuration;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button AddlecturerBtn;
        private System.Windows.Forms.Label Lecturer01;
        private System.Windows.Forms.Label Lecturer02;
        private System.Windows.Forms.Label Lecturer03;
        private System.Windows.Forms.Label Lecturer04;
    }
}
