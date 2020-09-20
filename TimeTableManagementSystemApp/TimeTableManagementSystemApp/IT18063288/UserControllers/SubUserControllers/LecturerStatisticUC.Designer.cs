namespace TimeTableManagementSystemApp.IT18063288.UserControllers.SubUserControllers
{
    partial class LecturerStatisticUC
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
            this.comboBoxFaculty = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxCenter = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxLevel = new System.Windows.Forms.ComboBox();
            this.textId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSearchNameID = new System.Windows.Forms.Button();
            this.dataGridLecStatistic = new System.Windows.Forms.DataGridView();
            this.btnLecStatSearch01 = new System.Windows.Forms.Button();
            this.lblLecCount = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBoxLecName = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridLecStatistic)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxFaculty
            // 
            this.comboBoxFaculty.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxFaculty.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxFaculty.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxFaculty.FormattingEnabled = true;
            this.comboBoxFaculty.Items.AddRange(new object[] {
            "Faculty Of Computing",
            "Faculty Of Engineering",
            "Faculty Of Business",
            "Faculty Of Humanities & Science",
            "School Of Architecture",
            "Other"});
            this.comboBoxFaculty.Location = new System.Drawing.Point(125, 26);
            this.comboBoxFaculty.Name = "comboBoxFaculty";
            this.comboBoxFaculty.Size = new System.Drawing.Size(217, 27);
            this.comboBoxFaculty.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(45, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 19);
            this.label1.TabIndex = 12;
            this.label1.Text = "Faculty : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(45, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 19);
            this.label2.TabIndex = 13;
            this.label2.Text = "Center : ";
            // 
            // comboBoxCenter
            // 
            this.comboBoxCenter.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCenter.FormattingEnabled = true;
            this.comboBoxCenter.Items.AddRange(new object[] {
            "Malabe Center",
            "Metro Center",
            "Matara Center",
            "Kurunegala Center",
            "Jaffna Center"});
            this.comboBoxCenter.Location = new System.Drawing.Point(125, 102);
            this.comboBoxCenter.Name = "comboBoxCenter";
            this.comboBoxCenter.Size = new System.Drawing.Size(217, 27);
            this.comboBoxCenter.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(54, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 19);
            this.label3.TabIndex = 15;
            this.label3.Text = "Level :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // comboBoxLevel
            // 
            this.comboBoxLevel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxLevel.FormattingEnabled = true;
            this.comboBoxLevel.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.comboBoxLevel.Location = new System.Drawing.Point(125, 63);
            this.comboBoxLevel.Name = "comboBoxLevel";
            this.comboBoxLevel.Size = new System.Drawing.Size(217, 27);
            this.comboBoxLevel.TabIndex = 16;
            // 
            // textId
            // 
            this.textId.BackColor = System.Drawing.Color.White;
            this.textId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textId.Location = new System.Drawing.Point(777, 60);
            this.textId.Name = "textId";
            this.textId.Size = new System.Drawing.Size(217, 26);
            this.textId.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(633, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 19);
            this.label4.TabIndex = 22;
            this.label4.Text = "Lecutrer Name :";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(657, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 19);
            this.label6.TabIndex = 24;
            this.label6.Text = "Lecutrer ID :";
            // 
            // btnSearchNameID
            // 
            this.btnSearchNameID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(104)))));
            this.btnSearchNameID.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSearchNameID.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchNameID.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchNameID.ForeColor = System.Drawing.Color.White;
            this.btnSearchNameID.Location = new System.Drawing.Point(777, 102);
            this.btnSearchNameID.Margin = new System.Windows.Forms.Padding(0);
            this.btnSearchNameID.Name = "btnSearchNameID";
            this.btnSearchNameID.Size = new System.Drawing.Size(217, 41);
            this.btnSearchNameID.TabIndex = 25;
            this.btnSearchNameID.Text = "Search";
            this.btnSearchNameID.UseVisualStyleBackColor = false;
            this.btnSearchNameID.Click += new System.EventHandler(this.btnSearchNameID_Click);
            // 
            // dataGridLecStatistic
            // 
            this.dataGridLecStatistic.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridLecStatistic.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridLecStatistic.Location = new System.Drawing.Point(125, 198);
            this.dataGridLecStatistic.Name = "dataGridLecStatistic";
            this.dataGridLecStatistic.Size = new System.Drawing.Size(869, 319);
            this.dataGridLecStatistic.TabIndex = 26;
            // 
            // btnLecStatSearch01
            // 
            this.btnLecStatSearch01.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(104)))));
            this.btnLecStatSearch01.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnLecStatSearch01.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLecStatSearch01.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLecStatSearch01.ForeColor = System.Drawing.Color.White;
            this.btnLecStatSearch01.Location = new System.Drawing.Point(125, 141);
            this.btnLecStatSearch01.Margin = new System.Windows.Forms.Padding(0);
            this.btnLecStatSearch01.Name = "btnLecStatSearch01";
            this.btnLecStatSearch01.Size = new System.Drawing.Size(217, 41);
            this.btnLecStatSearch01.TabIndex = 27;
            this.btnLecStatSearch01.Text = "Search";
            this.btnLecStatSearch01.UseVisualStyleBackColor = false;
            this.btnLecStatSearch01.Click += new System.EventHandler(this.btnLecStatSearch01_Click);
            // 
            // lblLecCount
            // 
            this.lblLecCount.AutoSize = true;
            this.lblLecCount.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLecCount.ForeColor = System.Drawing.Color.DimGray;
            this.lblLecCount.Location = new System.Drawing.Point(973, 176);
            this.lblLecCount.Name = "lblLecCount";
            this.lblLecCount.Size = new System.Drawing.Size(18, 19);
            this.lblLecCount.TabIndex = 49;
            this.lblLecCount.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(909, 176);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 19);
            this.label8.TabIndex = 48;
            this.label8.Text = "Count : ";
            // 
            // comboBoxLecName
            // 
            this.comboBoxLecName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxLecName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxLecName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxLecName.FormattingEnabled = true;
            this.comboBoxLecName.Items.AddRange(new object[] {
            "Faculty Of Computing",
            "Faculty Of Engineering",
            "Faculty Of Business",
            "Faculty Of Humanities & Science",
            "School Of Architecture",
            "Other"});
            this.comboBoxLecName.Location = new System.Drawing.Point(777, 22);
            this.comboBoxLecName.Name = "comboBoxLecName";
            this.comboBoxLecName.Size = new System.Drawing.Size(217, 27);
            this.comboBoxLecName.TabIndex = 50;
            // 
            // LecturerStatisticUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.comboBoxLecName);
            this.Controls.Add(this.lblLecCount);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnLecStatSearch01);
            this.Controls.Add(this.dataGridLecStatistic);
            this.Controls.Add(this.btnSearchNameID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textId);
            this.Controls.Add(this.comboBoxLevel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxCenter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxFaculty);
            this.Name = "LecturerStatisticUC";
            this.Size = new System.Drawing.Size(1021, 541);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridLecStatistic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxFaculty;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxCenter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxLevel;
        private System.Windows.Forms.TextBox textId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSearchNameID;
        private System.Windows.Forms.DataGridView dataGridLecStatistic;
        private System.Windows.Forms.Button btnLecStatSearch01;
        private System.Windows.Forms.Label lblLecCount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBoxLecName;
    }
}
