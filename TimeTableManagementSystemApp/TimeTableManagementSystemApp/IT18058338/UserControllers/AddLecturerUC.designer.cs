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
            this.radioButtonmalabe = new System.Windows.Forms.RadioButton();
            this.radioButtonmetro = new System.Windows.Forms.RadioButton();
            this.radioButtonmathara = new System.Windows.Forms.RadioButton();
            this.radioButtonkandy = new System.Windows.Forms.RadioButton();
            this.radioButtonkurunegala = new System.Windows.Forms.RadioButton();
            this.radioButtonjaffna = new System.Windows.Forms.RadioButton();
            this.labelbuilding = new System.Windows.Forms.Label();
            this.textBoxbuilding = new System.Windows.Forms.TextBox();
            this.labellevel = new System.Windows.Forms.Label();
            this.textBoxlevel = new System.Windows.Forms.TextBox();
            this.labelrank = new System.Windows.Forms.Label();
            this.textBoxrank = new System.Windows.Forms.TextBox();
            this.labelstatus = new System.Windows.Forms.Label();
            this.radioButtontrue = new System.Windows.Forms.RadioButton();
            this.radioButtonfalse = new System.Windows.Forms.RadioButton();
            this.buttonaddlecturer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(465, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Lecturer";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelid
            // 
            this.labelid.AutoSize = true;
            this.labelid.Location = new System.Drawing.Point(235, 65);
            this.labelid.Name = "labelid";
            this.labelid.Size = new System.Drawing.Size(60, 13);
            this.labelid.TabIndex = 1;
            this.labelid.Text = "Lecturer ID";
            // 
            // textBoxid
            // 
            this.textBoxid.Location = new System.Drawing.Point(470, 58);
            this.textBoxid.Name = "textBoxid";
            this.textBoxid.Size = new System.Drawing.Size(100, 20);
            this.textBoxid.TabIndex = 2;
            // 
            // labelname
            // 
            this.labelname.AutoSize = true;
            this.labelname.Location = new System.Drawing.Point(235, 106);
            this.labelname.Name = "labelname";
            this.labelname.Size = new System.Drawing.Size(77, 13);
            this.labelname.TabIndex = 3;
            this.labelname.Text = "Lecturer Name";
            // 
            // textBoxname
            // 
            this.textBoxname.Location = new System.Drawing.Point(470, 99);
            this.textBoxname.Name = "textBoxname";
            this.textBoxname.Size = new System.Drawing.Size(282, 20);
            this.textBoxname.TabIndex = 4;
            // 
            // labelfaculty
            // 
            this.labelfaculty.AutoSize = true;
            this.labelfaculty.Location = new System.Drawing.Point(235, 150);
            this.labelfaculty.Name = "labelfaculty";
            this.labelfaculty.Size = new System.Drawing.Size(74, 13);
            this.labelfaculty.TabIndex = 5;
            this.labelfaculty.Text = "Select Faculty";
            // 
            // checkedListBoxfaculty
            // 
            this.checkedListBoxfaculty.FormattingEnabled = true;
            this.checkedListBoxfaculty.Items.AddRange(new object[] {
            "Faculty Of Computing",
            "Faculty Of Engineering",
            "Faculty Of Business",
            "Faculty Of Humanities & Science",
            "School Of Architecture",
            "Other"});
            this.checkedListBoxfaculty.Location = new System.Drawing.Point(470, 150);
            this.checkedListBoxfaculty.Name = "checkedListBoxfaculty";
            this.checkedListBoxfaculty.Size = new System.Drawing.Size(182, 94);
            this.checkedListBoxfaculty.TabIndex = 7;
            // 
            // labeldepartment
            // 
            this.labeldepartment.AutoSize = true;
            this.labeldepartment.Location = new System.Drawing.Point(235, 278);
            this.labeldepartment.Name = "labeldepartment";
            this.labeldepartment.Size = new System.Drawing.Size(95, 13);
            this.labeldepartment.TabIndex = 8;
            this.labeldepartment.Text = "Select Department";
            this.labeldepartment.Click += new System.EventHandler(this.labeldepartment_Click);
            // 
            // textBoxdepartment
            // 
            this.textBoxdepartment.Location = new System.Drawing.Point(470, 271);
            this.textBoxdepartment.Name = "textBoxdepartment";
            this.textBoxdepartment.Size = new System.Drawing.Size(282, 20);
            this.textBoxdepartment.TabIndex = 9;
            this.textBoxdepartment.TextChanged += new System.EventHandler(this.textBoxdepartment_TextChanged);
            // 
            // labelcenter
            // 
            this.labelcenter.AutoSize = true;
            this.labelcenter.Location = new System.Drawing.Point(235, 324);
            this.labelcenter.Name = "labelcenter";
            this.labelcenter.Size = new System.Drawing.Size(71, 13);
            this.labelcenter.TabIndex = 10;
            this.labelcenter.Text = "Select Center";
            // 
            // radioButtonmalabe
            // 
            this.radioButtonmalabe.AutoSize = true;
            this.radioButtonmalabe.Location = new System.Drawing.Point(470, 320);
            this.radioButtonmalabe.Name = "radioButtonmalabe";
            this.radioButtonmalabe.Size = new System.Drawing.Size(60, 17);
            this.radioButtonmalabe.TabIndex = 11;
            this.radioButtonmalabe.TabStop = true;
            this.radioButtonmalabe.Text = "Malabe";
            this.radioButtonmalabe.UseVisualStyleBackColor = true;
            // 
            // radioButtonmetro
            // 
            this.radioButtonmetro.AutoSize = true;
            this.radioButtonmetro.Location = new System.Drawing.Point(470, 343);
            this.radioButtonmetro.Name = "radioButtonmetro";
            this.radioButtonmetro.Size = new System.Drawing.Size(52, 17);
            this.radioButtonmetro.TabIndex = 12;
            this.radioButtonmetro.TabStop = true;
            this.radioButtonmetro.Text = "Metro";
            this.radioButtonmetro.UseVisualStyleBackColor = true;
            // 
            // radioButtonmathara
            // 
            this.radioButtonmathara.AutoSize = true;
            this.radioButtonmathara.Location = new System.Drawing.Point(536, 320);
            this.radioButtonmathara.Name = "radioButtonmathara";
            this.radioButtonmathara.Size = new System.Drawing.Size(64, 17);
            this.radioButtonmathara.TabIndex = 13;
            this.radioButtonmathara.TabStop = true;
            this.radioButtonmathara.Text = "Mathara";
            this.radioButtonmathara.UseVisualStyleBackColor = true;
            // 
            // radioButtonkandy
            // 
            this.radioButtonkandy.AutoSize = true;
            this.radioButtonkandy.Location = new System.Drawing.Point(536, 343);
            this.radioButtonkandy.Name = "radioButtonkandy";
            this.radioButtonkandy.Size = new System.Drawing.Size(55, 17);
            this.radioButtonkandy.TabIndex = 14;
            this.radioButtonkandy.TabStop = true;
            this.radioButtonkandy.Text = "Kandy";
            this.radioButtonkandy.UseVisualStyleBackColor = true;
            // 
            // radioButtonkurunegala
            // 
            this.radioButtonkurunegala.AutoSize = true;
            this.radioButtonkurunegala.Location = new System.Drawing.Point(606, 320);
            this.radioButtonkurunegala.Name = "radioButtonkurunegala";
            this.radioButtonkurunegala.Size = new System.Drawing.Size(79, 17);
            this.radioButtonkurunegala.TabIndex = 15;
            this.radioButtonkurunegala.TabStop = true;
            this.radioButtonkurunegala.Text = "Kurunegala";
            this.radioButtonkurunegala.UseVisualStyleBackColor = true;
            // 
            // radioButtonjaffna
            // 
            this.radioButtonjaffna.AutoSize = true;
            this.radioButtonjaffna.Location = new System.Drawing.Point(606, 343);
            this.radioButtonjaffna.Name = "radioButtonjaffna";
            this.radioButtonjaffna.Size = new System.Drawing.Size(54, 17);
            this.radioButtonjaffna.TabIndex = 16;
            this.radioButtonjaffna.TabStop = true;
            this.radioButtonjaffna.Text = "Jaffna";
            this.radioButtonjaffna.UseVisualStyleBackColor = true;
            // 
            // labelbuilding
            // 
            this.labelbuilding.AutoSize = true;
            this.labelbuilding.Location = new System.Drawing.Point(235, 387);
            this.labelbuilding.Name = "labelbuilding";
            this.labelbuilding.Size = new System.Drawing.Size(77, 13);
            this.labelbuilding.TabIndex = 17;
            this.labelbuilding.Text = "Select Building";
            // 
            // textBoxbuilding
            // 
            this.textBoxbuilding.Location = new System.Drawing.Point(470, 384);
            this.textBoxbuilding.Name = "textBoxbuilding";
            this.textBoxbuilding.Size = new System.Drawing.Size(282, 20);
            this.textBoxbuilding.TabIndex = 18;
            // 
            // labellevel
            // 
            this.labellevel.AutoSize = true;
            this.labellevel.Location = new System.Drawing.Point(235, 431);
            this.labellevel.Name = "labellevel";
            this.labellevel.Size = new System.Drawing.Size(75, 13);
            this.labellevel.TabIndex = 19;
            this.labellevel.Text = "Lecturer Level";
            // 
            // textBoxlevel
            // 
            this.textBoxlevel.Location = new System.Drawing.Point(470, 424);
            this.textBoxlevel.Name = "textBoxlevel";
            this.textBoxlevel.Size = new System.Drawing.Size(100, 20);
            this.textBoxlevel.TabIndex = 20;
            // 
            // labelrank
            // 
            this.labelrank.AutoSize = true;
            this.labelrank.Location = new System.Drawing.Point(235, 473);
            this.labelrank.Name = "labelrank";
            this.labelrank.Size = new System.Drawing.Size(33, 13);
            this.labelrank.TabIndex = 21;
            this.labelrank.Text = "Rank";
            // 
            // textBoxrank
            // 
            this.textBoxrank.Location = new System.Drawing.Point(470, 466);
            this.textBoxrank.Name = "textBoxrank";
            this.textBoxrank.Size = new System.Drawing.Size(100, 20);
            this.textBoxrank.TabIndex = 22;
            // 
            // labelstatus
            // 
            this.labelstatus.AutoSize = true;
            this.labelstatus.Location = new System.Drawing.Point(235, 519);
            this.labelstatus.Name = "labelstatus";
            this.labelstatus.Size = new System.Drawing.Size(37, 13);
            this.labelstatus.TabIndex = 23;
            this.labelstatus.Text = "Status";
            // 
            // radioButtontrue
            // 
            this.radioButtontrue.AutoSize = true;
            this.radioButtontrue.Location = new System.Drawing.Point(470, 519);
            this.radioButtontrue.Name = "radioButtontrue";
            this.radioButtontrue.Size = new System.Drawing.Size(47, 17);
            this.radioButtontrue.TabIndex = 24;
            this.radioButtontrue.TabStop = true;
            this.radioButtontrue.Text = "True";
            this.radioButtontrue.UseVisualStyleBackColor = true;
            // 
            // radioButtonfalse
            // 
            this.radioButtonfalse.AutoSize = true;
            this.radioButtonfalse.Location = new System.Drawing.Point(520, 519);
            this.radioButtonfalse.Name = "radioButtonfalse";
            this.radioButtonfalse.Size = new System.Drawing.Size(50, 17);
            this.radioButtonfalse.TabIndex = 25;
            this.radioButtonfalse.TabStop = true;
            this.radioButtonfalse.Text = "False";
            this.radioButtonfalse.UseVisualStyleBackColor = true;
            // 
            // buttonaddlecturer
            // 
            this.buttonaddlecturer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(104)))));
            this.buttonaddlecturer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonaddlecturer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonaddlecturer.ForeColor = System.Drawing.Color.White;
            this.buttonaddlecturer.Location = new System.Drawing.Point(602, 590);
            this.buttonaddlecturer.Name = "buttonaddlecturer";
            this.buttonaddlecturer.Size = new System.Drawing.Size(150, 30);
            this.buttonaddlecturer.TabIndex = 26;
            this.buttonaddlecturer.Text = "Add Lecturer";
            this.buttonaddlecturer.UseVisualStyleBackColor = false;
            // 
            // AddLecturerUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonaddlecturer);
            this.Controls.Add(this.radioButtonfalse);
            this.Controls.Add(this.radioButtontrue);
            this.Controls.Add(this.labelstatus);
            this.Controls.Add(this.textBoxrank);
            this.Controls.Add(this.labelrank);
            this.Controls.Add(this.textBoxlevel);
            this.Controls.Add(this.labellevel);
            this.Controls.Add(this.textBoxbuilding);
            this.Controls.Add(this.labelbuilding);
            this.Controls.Add(this.radioButtonjaffna);
            this.Controls.Add(this.radioButtonkurunegala);
            this.Controls.Add(this.radioButtonkandy);
            this.Controls.Add(this.radioButtonmathara);
            this.Controls.Add(this.radioButtonmetro);
            this.Controls.Add(this.radioButtonmalabe);
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
        private System.Windows.Forms.RadioButton radioButtonmalabe;
        private System.Windows.Forms.RadioButton radioButtonmetro;
        private System.Windows.Forms.RadioButton radioButtonmathara;
        private System.Windows.Forms.RadioButton radioButtonkandy;
        private System.Windows.Forms.RadioButton radioButtonkurunegala;
        private System.Windows.Forms.RadioButton radioButtonjaffna;
        private System.Windows.Forms.Label labelbuilding;
        private System.Windows.Forms.TextBox textBoxbuilding;
        private System.Windows.Forms.Label labellevel;
        private System.Windows.Forms.TextBox textBoxlevel;
        private System.Windows.Forms.Label labelrank;
        private System.Windows.Forms.TextBox textBoxrank;
        private System.Windows.Forms.Label labelstatus;
        private System.Windows.Forms.RadioButton radioButtontrue;
        private System.Windows.Forms.RadioButton radioButtonfalse;
        private System.Windows.Forms.Button buttonaddlecturer;
    }
}
