namespace TimeTableManagementSystemApp.IT18049114.UserControllers
{
    partial class EditStudent
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
            this.editIDtext = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.editstdbut = new System.Windows.Forms.Button();
            this.deletebut = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.EditSet = new System.Windows.Forms.Button();
            this.editYearSemView = new System.Windows.Forms.TextBox();
            this.editProgrammeText = new System.Windows.Forms.ComboBox();
            this.editSemeserText = new System.Windows.Forms.ComboBox();
            this.editYearText = new System.Windows.Forms.ComboBox();
            this.editSubGroupIdView = new System.Windows.Forms.TextBox();
            this.editSubGroupNo = new System.Windows.Forms.NumericUpDown();
            this.editGroupIdView = new System.Windows.Forms.TextBox();
            this.editGroupNoText = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.editSubGroupNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editGroupNoText)).BeginInit();
            this.SuspendLayout();
            // 
            // editIDtext
            // 
            this.editIDtext.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editIDtext.Location = new System.Drawing.Point(495, 112);
            this.editIDtext.Name = "editIDtext";
            this.editIDtext.ReadOnly = true;
            this.editIDtext.Size = new System.Drawing.Size(229, 27);
            this.editIDtext.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(189, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 21);
            this.label2.TabIndex = 18;
            this.label2.Text = "Student ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(502, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 21);
            this.label1.TabIndex = 17;
            this.label1.Text = "Edit Student";
            // 
            // editstdbut
            // 
            this.editstdbut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(104)))));
            this.editstdbut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editstdbut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editstdbut.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editstdbut.ForeColor = System.Drawing.Color.White;
            this.editstdbut.Location = new System.Drawing.Point(495, 579);
            this.editstdbut.Name = "editstdbut";
            this.editstdbut.Size = new System.Drawing.Size(102, 31);
            this.editstdbut.TabIndex = 34;
            this.editstdbut.Text = "Update";
            this.editstdbut.UseVisualStyleBackColor = false;
            this.editstdbut.Click += new System.EventHandler(this.editstdbut_Click);
            // 
            // deletebut
            // 
            this.deletebut.BackColor = System.Drawing.Color.Red;
            this.deletebut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deletebut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deletebut.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletebut.ForeColor = System.Drawing.Color.White;
            this.deletebut.Location = new System.Drawing.Point(636, 579);
            this.deletebut.Name = "deletebut";
            this.deletebut.Size = new System.Drawing.Size(102, 31);
            this.deletebut.TabIndex = 35;
            this.deletebut.Text = "Delete";
            this.deletebut.UseVisualStyleBackColor = false;
            this.deletebut.Click += new System.EventHandler(this.deletebut_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(189, 430);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(245, 21);
            this.label10.TabIndex = 52;
            this.label10.Text = "Academic Year and Semester";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(189, 195);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(168, 21);
            this.label9.TabIndex = 51;
            this.label9.Text = "Academic Semester";
            // 
            // EditSet
            // 
            this.EditSet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(104)))));
            this.EditSet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditSet.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.EditSet.Location = new System.Drawing.Point(561, 382);
            this.EditSet.Name = "EditSet";
            this.EditSet.Size = new System.Drawing.Size(81, 32);
            this.EditSet.TabIndex = 50;
            this.EditSet.Text = "Set";
            this.EditSet.UseVisualStyleBackColor = false;
            this.EditSet.Click += new System.EventHandler(this.EditSet_Click);
            // 
            // editYearSemView
            // 
            this.editYearSemView.BackColor = System.Drawing.Color.DarkGray;
            this.editYearSemView.Location = new System.Drawing.Point(495, 430);
            this.editYearSemView.Name = "editYearSemView";
            this.editYearSemView.ReadOnly = true;
            this.editYearSemView.Size = new System.Drawing.Size(229, 20);
            this.editYearSemView.TabIndex = 49;
            // 
            // editProgrammeText
            // 
            this.editProgrammeText.FormattingEnabled = true;
            this.editProgrammeText.Items.AddRange(new object[] {
            "IT",
            "SE",
            "IM",
            "CS",
            "DS",
            "ISE",
            "CSNE"});
            this.editProgrammeText.Location = new System.Drawing.Point(495, 246);
            this.editProgrammeText.Name = "editProgrammeText";
            this.editProgrammeText.Size = new System.Drawing.Size(229, 21);
            this.editProgrammeText.TabIndex = 48;
            // 
            // editSemeserText
            // 
            this.editSemeserText.FormattingEnabled = true;
            this.editSemeserText.Items.AddRange(new object[] {
            "1",
            "2"});
            this.editSemeserText.Location = new System.Drawing.Point(495, 198);
            this.editSemeserText.Name = "editSemeserText";
            this.editSemeserText.Size = new System.Drawing.Size(229, 21);
            this.editSemeserText.TabIndex = 47;
            // 
            // editYearText
            // 
            this.editYearText.FormattingEnabled = true;
            this.editYearText.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.editYearText.Location = new System.Drawing.Point(495, 159);
            this.editYearText.Name = "editYearText";
            this.editYearText.Size = new System.Drawing.Size(229, 21);
            this.editYearText.TabIndex = 46;
            // 
            // editSubGroupIdView
            // 
            this.editSubGroupIdView.BackColor = System.Drawing.Color.DarkGray;
            this.editSubGroupIdView.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editSubGroupIdView.Location = new System.Drawing.Point(495, 514);
            this.editSubGroupIdView.Name = "editSubGroupIdView";
            this.editSubGroupIdView.ReadOnly = true;
            this.editSubGroupIdView.Size = new System.Drawing.Size(229, 27);
            this.editSubGroupIdView.TabIndex = 45;
            // 
            // editSubGroupNo
            // 
            this.editSubGroupNo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editSubGroupNo.Location = new System.Drawing.Point(495, 342);
            this.editSubGroupNo.Name = "editSubGroupNo";
            this.editSubGroupNo.Size = new System.Drawing.Size(229, 27);
            this.editSubGroupNo.TabIndex = 44;
            // 
            // editGroupIdView
            // 
            this.editGroupIdView.BackColor = System.Drawing.Color.DarkGray;
            this.editGroupIdView.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editGroupIdView.Location = new System.Drawing.Point(495, 468);
            this.editGroupIdView.Name = "editGroupIdView";
            this.editGroupIdView.ReadOnly = true;
            this.editGroupIdView.Size = new System.Drawing.Size(229, 27);
            this.editGroupIdView.TabIndex = 43;
            // 
            // editGroupNoText
            // 
            this.editGroupNoText.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editGroupNoText.Location = new System.Drawing.Point(495, 292);
            this.editGroupNoText.Name = "editGroupNoText";
            this.editGroupNoText.Size = new System.Drawing.Size(229, 27);
            this.editGroupNoText.TabIndex = 42;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(189, 342);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(161, 21);
            this.label11.TabIndex = 41;
            this.label11.Text = "Sub-Group Number";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(189, 514);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(115, 21);
            this.label12.TabIndex = 40;
            this.label12.Text = "Sub-Group ID";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(189, 468);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(81, 21);
            this.label13.TabIndex = 39;
            this.label13.Text = "Group ID";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(189, 292);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(127, 21);
            this.label14.TabIndex = 38;
            this.label14.Text = "Group Number";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(189, 246);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(101, 21);
            this.label15.TabIndex = 37;
            this.label15.Text = "Programme";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(189, 156);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(134, 21);
            this.label16.TabIndex = 36;
            this.label16.Text = "Academic Year";
            // 
            // EditStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.EditSet);
            this.Controls.Add(this.editYearSemView);
            this.Controls.Add(this.editProgrammeText);
            this.Controls.Add(this.editSemeserText);
            this.Controls.Add(this.editYearText);
            this.Controls.Add(this.editSubGroupIdView);
            this.Controls.Add(this.editSubGroupNo);
            this.Controls.Add(this.editGroupIdView);
            this.Controls.Add(this.editGroupNoText);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.deletebut);
            this.Controls.Add(this.editstdbut);
            this.Controls.Add(this.editIDtext);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EditStudent";
            this.Size = new System.Drawing.Size(1025, 700);
            this.Load += new System.EventHandler(this.EditStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.editSubGroupNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editGroupNoText)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox editIDtext;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button editstdbut;
        private System.Windows.Forms.Button deletebut;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button EditSet;
        private System.Windows.Forms.TextBox editYearSemView;
        private System.Windows.Forms.ComboBox editProgrammeText;
        private System.Windows.Forms.ComboBox editSemeserText;
        private System.Windows.Forms.ComboBox editYearText;
        private System.Windows.Forms.TextBox editSubGroupIdView;
        private System.Windows.Forms.NumericUpDown editSubGroupNo;
        private System.Windows.Forms.NumericUpDown editGroupNoText;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox editGroupIdView;
    }
}
