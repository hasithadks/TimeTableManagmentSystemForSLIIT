namespace TimeTableManagementSystemApp.IT18049114.UserControllers
{
    partial class ViewStudent
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.StudentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YearAndSemester = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Programme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubGroupID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Action = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editstdpagebut = new System.Windows.Forms.Button();
            this.deletestdbut = new System.Windows.Forms.Button();
            this.testlabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(451, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 21);
            this.label1.TabIndex = 18;
            this.label1.Text = "Students";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StudentID,
            this.StudentName,
            this.YearAndSemester,
            this.Programme,
            this.SubGroupID,
            this.Action});
            this.dataGridView1.Location = new System.Drawing.Point(69, 107);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(873, 141);
            this.dataGridView1.TabIndex = 20;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // StudentID
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentID.DefaultCellStyle = dataGridViewCellStyle1;
            this.StudentID.HeaderText = "Student ID";
            this.StudentID.Name = "StudentID";
            this.StudentID.ReadOnly = true;
            // 
            // StudentName
            // 
            this.StudentName.HeaderText = "Student Name";
            this.StudentName.Name = "StudentName";
            this.StudentName.ReadOnly = true;
            this.StudentName.Width = 200;
            // 
            // YearAndSemester
            // 
            this.YearAndSemester.HeaderText = "Year and Semester";
            this.YearAndSemester.Name = "YearAndSemester";
            this.YearAndSemester.ReadOnly = true;
            // 
            // Programme
            // 
            this.Programme.HeaderText = "Programme";
            this.Programme.Name = "Programme";
            this.Programme.ReadOnly = true;
            // 
            // SubGroupID
            // 
            this.SubGroupID.HeaderText = "Sub-Group ID";
            this.SubGroupID.Name = "SubGroupID";
            this.SubGroupID.ReadOnly = true;
            this.SubGroupID.Width = 150;
            // 
            // Action
            // 
            this.Action.HeaderText = "Action";
            this.Action.Name = "Action";
            this.Action.ReadOnly = true;
            this.Action.Width = 180;
            // 
            // editstdpagebut
            // 
            this.editstdpagebut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(104)))));
            this.editstdpagebut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editstdpagebut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editstdpagebut.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editstdpagebut.ForeColor = System.Drawing.Color.White;
            this.editstdpagebut.Location = new System.Drawing.Point(790, 142);
            this.editstdpagebut.Name = "editstdpagebut";
            this.editstdpagebut.Size = new System.Drawing.Size(55, 21);
            this.editstdpagebut.TabIndex = 23;
            this.editstdpagebut.Text = "Edit";
            this.editstdpagebut.UseVisualStyleBackColor = false;
            this.editstdpagebut.Click += new System.EventHandler(this.editstdpagebut_Click);
            // 
            // deletestdbut
            // 
            this.deletestdbut.BackColor = System.Drawing.Color.Red;
            this.deletestdbut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deletestdbut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deletestdbut.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletestdbut.ForeColor = System.Drawing.Color.White;
            this.deletestdbut.Location = new System.Drawing.Point(871, 142);
            this.deletestdbut.Name = "deletestdbut";
            this.deletestdbut.Size = new System.Drawing.Size(54, 21);
            this.deletestdbut.TabIndex = 24;
            this.deletestdbut.Text = "Delete";
            this.deletestdbut.UseVisualStyleBackColor = false;
            // 
            // testlabel
            // 
            this.testlabel.AutoSize = true;
            this.testlabel.Location = new System.Drawing.Point(125, 148);
            this.testlabel.Name = "testlabel";
            this.testlabel.Size = new System.Drawing.Size(65, 13);
            this.testlabel.TabIndex = 25;
            this.testlabel.Text = "IT18049114";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(230, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Hansaka H. M. P.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(441, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Y3.S2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(547, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "SE";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(646, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Y3.S2.SE.09.2";
            // 
            // ViewStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.testlabel);
            this.Controls.Add(this.deletestdbut);
            this.Controls.Add(this.editstdpagebut);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "ViewStudent";
            this.Size = new System.Drawing.Size(1025, 700);
            this.Load += new System.EventHandler(this.ViewStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn YearAndSemester;
        private System.Windows.Forms.DataGridViewTextBoxColumn Programme;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubGroupID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Action;
        private System.Windows.Forms.Button editstdpagebut;
        private System.Windows.Forms.Button deletestdbut;
        private System.Windows.Forms.Label testlabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}
