namespace TimeTableManagementSystemApp.IT18063288.UserControllers.SubUserControllers
{
    partial class EditLocationDataUC
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
            this.txtCapacity = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblBuilding = new System.Windows.Forms.Label();
            this.lblRoom = new System.Windows.Forms.Label();
            this.btnUpdateLocationUC = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnEditRecords = new System.Windows.Forms.Button();
            this.radioBtnLecture = new System.Windows.Forms.RadioButton();
            this.radioBtnLab = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(180, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Capacity of the room :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtCapacity
            // 
            this.txtCapacity.BackColor = System.Drawing.Color.White;
            this.txtCapacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCapacity.Location = new System.Drawing.Point(411, 114);
            this.txtCapacity.Name = "txtCapacity";
            this.txtCapacity.Size = new System.Drawing.Size(200, 26);
            this.txtCapacity.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(259, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Room Type :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(289, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Building :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(306, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "Room :";
            // 
            // lblBuilding
            // 
            this.lblBuilding.AutoSize = true;
            this.lblBuilding.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuilding.ForeColor = System.Drawing.Color.Gray;
            this.lblBuilding.Location = new System.Drawing.Point(407, 50);
            this.lblBuilding.Name = "lblBuilding";
            this.lblBuilding.Size = new System.Drawing.Size(120, 23);
            this.lblBuilding.TabIndex = 7;
            this.lblBuilding.Text = "New Building";
            // 
            // lblRoom
            // 
            this.lblRoom.AutoSize = true;
            this.lblRoom.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoom.ForeColor = System.Drawing.Color.Gray;
            this.lblRoom.Location = new System.Drawing.Point(407, 82);
            this.lblRoom.Name = "lblRoom";
            this.lblRoom.Size = new System.Drawing.Size(51, 23);
            this.lblRoom.TabIndex = 8;
            this.lblRoom.Text = "405B";
            // 
            // btnUpdateLocationUC
            // 
            this.btnUpdateLocationUC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(104)))));
            this.btnUpdateLocationUC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnUpdateLocationUC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateLocationUC.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateLocationUC.ForeColor = System.Drawing.Color.White;
            this.btnUpdateLocationUC.Location = new System.Drawing.Point(411, 223);
            this.btnUpdateLocationUC.Margin = new System.Windows.Forms.Padding(0);
            this.btnUpdateLocationUC.Name = "btnUpdateLocationUC";
            this.btnUpdateLocationUC.Size = new System.Drawing.Size(149, 44);
            this.btnUpdateLocationUC.TabIndex = 9;
            this.btnUpdateLocationUC.Text = "Update";
            this.btnUpdateLocationUC.UseVisualStyleBackColor = false;
            this.btnUpdateLocationUC.Click += new System.EventHandler(this.btnEditLocationUC_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(305, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(188, 25);
            this.label5.TabIndex = 45;
            this.label5.Text = "~Location Details~";
            // 
            // btnEditRecords
            // 
            this.btnEditRecords.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(104)))));
            this.btnEditRecords.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnEditRecords.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditRecords.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditRecords.ForeColor = System.Drawing.Color.White;
            this.btnEditRecords.Location = new System.Drawing.Point(228, 223);
            this.btnEditRecords.Margin = new System.Windows.Forms.Padding(0);
            this.btnEditRecords.Name = "btnEditRecords";
            this.btnEditRecords.Size = new System.Drawing.Size(149, 44);
            this.btnEditRecords.TabIndex = 46;
            this.btnEditRecords.Text = "Edit Records";
            this.btnEditRecords.UseVisualStyleBackColor = false;
            this.btnEditRecords.Click += new System.EventHandler(this.btnEditRecords_Click);
            // 
            // radioBtnLecture
            // 
            this.radioBtnLecture.AutoSize = true;
            this.radioBtnLecture.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtnLecture.Location = new System.Drawing.Point(411, 151);
            this.radioBtnLecture.Name = "radioBtnLecture";
            this.radioBtnLecture.Size = new System.Drawing.Size(110, 23);
            this.radioBtnLecture.TabIndex = 47;
            this.radioBtnLecture.TabStop = true;
            this.radioBtnLecture.Text = "Lecture Hall";
            this.radioBtnLecture.UseVisualStyleBackColor = true;
            // 
            // radioBtnLab
            // 
            this.radioBtnLab.AutoSize = true;
            this.radioBtnLab.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtnLab.Location = new System.Drawing.Point(411, 179);
            this.radioBtnLab.Name = "radioBtnLab";
            this.radioBtnLab.Size = new System.Drawing.Size(52, 23);
            this.radioBtnLab.TabIndex = 48;
            this.radioBtnLab.TabStop = true;
            this.radioBtnLab.Text = "Lab";
            this.radioBtnLab.UseVisualStyleBackColor = true;
            // 
            // EditLocationDataUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.radioBtnLab);
            this.Controls.Add(this.radioBtnLecture);
            this.Controls.Add(this.btnEditRecords);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnUpdateLocationUC);
            this.Controls.Add(this.lblRoom);
            this.Controls.Add(this.lblBuilding);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCapacity);
            this.Controls.Add(this.label1);
            this.Name = "EditLocationDataUC";
            this.Size = new System.Drawing.Size(830, 315);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCapacity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblBuilding;
        private System.Windows.Forms.Label lblRoom;
        private System.Windows.Forms.Button btnUpdateLocationUC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnEditRecords;
        private System.Windows.Forms.RadioButton radioBtnLecture;
        private System.Windows.Forms.RadioButton radioBtnLab;
    }
}
