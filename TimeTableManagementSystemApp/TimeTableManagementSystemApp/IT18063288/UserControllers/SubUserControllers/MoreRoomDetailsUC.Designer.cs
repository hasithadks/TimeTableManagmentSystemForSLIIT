namespace TimeTableManagementSystemApp.IT18063288.UserControllers.SubUserControllers
{
    partial class MoreRoomDetailsUC
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
            this.button6 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRoomCapacity = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBoxLecture = new System.Windows.Forms.CheckBox();
            this.checkBoxLab = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(104)))));
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(642, 174);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(153, 31);
            this.button6.TabIndex = 39;
            this.button6.Text = "Save";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(302, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 23);
            this.label5.TabIndex = 37;
            this.label5.Text = "Room Type";
            // 
            // txtRoomCapacity
            // 
            this.txtRoomCapacity.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRoomCapacity.Location = new System.Drawing.Point(466, 29);
            this.txtRoomCapacity.Name = "txtRoomCapacity";
            this.txtRoomCapacity.Size = new System.Drawing.Size(329, 27);
            this.txtRoomCapacity.TabIndex = 36;
            this.txtRoomCapacity.Text = " Room Capacity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(214, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(202, 23);
            this.label4.TabIndex = 35;
            this.label4.Text = "Capacities of the Room";
            // 
            // checkBoxLecture
            // 
            this.checkBoxLecture.AutoSize = true;
            this.checkBoxLecture.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxLecture.Location = new System.Drawing.Point(466, 91);
            this.checkBoxLecture.Name = "checkBoxLecture";
            this.checkBoxLecture.Size = new System.Drawing.Size(111, 23);
            this.checkBoxLecture.TabIndex = 41;
            this.checkBoxLecture.Text = "Lecture Hall";
            this.checkBoxLecture.UseVisualStyleBackColor = true;
            // 
            // checkBoxLab
            // 
            this.checkBoxLab.AutoSize = true;
            this.checkBoxLab.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxLab.Location = new System.Drawing.Point(466, 120);
            this.checkBoxLab.Name = "checkBoxLab";
            this.checkBoxLab.Size = new System.Drawing.Size(53, 23);
            this.checkBoxLab.TabIndex = 42;
            this.checkBoxLab.Text = "Lab";
            this.checkBoxLab.UseVisualStyleBackColor = true;
            // 
            // MoreRoomDetailsUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.checkBoxLab);
            this.Controls.Add(this.checkBoxLecture);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtRoomCapacity);
            this.Controls.Add(this.label4);
            this.Name = "MoreRoomDetailsUC";
            this.Size = new System.Drawing.Size(1020, 365);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRoomCapacity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBoxLecture;
        private System.Windows.Forms.CheckBox checkBoxLab;
    }
}
