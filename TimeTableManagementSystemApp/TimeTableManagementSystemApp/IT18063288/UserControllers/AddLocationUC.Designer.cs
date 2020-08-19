﻿namespace TimeTableManagementSystemApp.IT18063288.UserControllers
{
    partial class AddLocationUC
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
            this.btnBuildingSave = new System.Windows.Forms.Button();
            this.txtNewBuilding = new System.Windows.Forms.TextBox();
            this.comboBoxBuilding = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuildingUpdate = new System.Windows.Forms.Button();
            this.btnChangeBuildingName = new System.Windows.Forms.Button();
            this.btnDeleteBuilding = new System.Windows.Forms.Button();
            this.btnAddNewBuilding = new System.Windows.Forms.Button();
            this.btnAddNewRoom = new System.Windows.Forms.Button();
            this.btnDeleteRoom = new System.Windows.Forms.Button();
            this.btnChangeRoomName = new System.Windows.Forms.Button();
            this.btnRoomUpdate = new System.Windows.Forms.Button();
            this.btnRoomSave = new System.Windows.Forms.Button();
            this.txtNewRoom = new System.Windows.Forms.TextBox();
            this.comboBoxRoom = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblRoomDetails = new System.Windows.Forms.Label();
            this.panelRoomDetails = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnBuildingSave
            // 
            this.btnBuildingSave.BackColor = System.Drawing.Color.DimGray;
            this.btnBuildingSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuildingSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuildingSave.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuildingSave.ForeColor = System.Drawing.Color.White;
            this.btnBuildingSave.Location = new System.Drawing.Point(641, 102);
            this.btnBuildingSave.Name = "btnBuildingSave";
            this.btnBuildingSave.Size = new System.Drawing.Size(102, 31);
            this.btnBuildingSave.TabIndex = 15;
            this.btnBuildingSave.Text = "Save";
            this.btnBuildingSave.UseVisualStyleBackColor = false;
            // 
            // txtNewBuilding
            // 
            this.txtNewBuilding.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewBuilding.Location = new System.Drawing.Point(282, 105);
            this.txtNewBuilding.Name = "txtNewBuilding";
            this.txtNewBuilding.Size = new System.Drawing.Size(329, 27);
            this.txtNewBuilding.TabIndex = 14;
            this.txtNewBuilding.Text = "Enter New Building name";
            this.txtNewBuilding.TextChanged += new System.EventHandler(this.txtNewBuilding_TextChanged);
            // 
            // comboBoxBuilding
            // 
            this.comboBoxBuilding.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxBuilding.FormattingEnabled = true;
            this.comboBoxBuilding.Items.AddRange(new object[] {
            "Main Building",
            "New Building",
            "Engineering Building"});
            this.comboBoxBuilding.Location = new System.Drawing.Point(282, 65);
            this.comboBoxBuilding.Name = "comboBoxBuilding";
            this.comboBoxBuilding.Size = new System.Drawing.Size(329, 27);
            this.comboBoxBuilding.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(99, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 23);
            this.label1.TabIndex = 9;
            this.label1.Text = "Select Building";
            // 
            // btnBuildingUpdate
            // 
            this.btnBuildingUpdate.BackColor = System.Drawing.Color.DimGray;
            this.btnBuildingUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuildingUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuildingUpdate.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuildingUpdate.ForeColor = System.Drawing.Color.White;
            this.btnBuildingUpdate.Location = new System.Drawing.Point(847, 102);
            this.btnBuildingUpdate.Name = "btnBuildingUpdate";
            this.btnBuildingUpdate.Size = new System.Drawing.Size(94, 31);
            this.btnBuildingUpdate.TabIndex = 16;
            this.btnBuildingUpdate.Text = "Update";
            this.btnBuildingUpdate.UseVisualStyleBackColor = false;
            // 
            // btnChangeBuildingName
            // 
            this.btnChangeBuildingName.BackColor = System.Drawing.Color.DimGray;
            this.btnChangeBuildingName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChangeBuildingName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangeBuildingName.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeBuildingName.ForeColor = System.Drawing.Color.White;
            this.btnChangeBuildingName.Location = new System.Drawing.Point(749, 61);
            this.btnChangeBuildingName.Name = "btnChangeBuildingName";
            this.btnChangeBuildingName.Size = new System.Drawing.Size(192, 31);
            this.btnChangeBuildingName.TabIndex = 17;
            this.btnChangeBuildingName.Text = "Change Building Name";
            this.btnChangeBuildingName.UseVisualStyleBackColor = false;
            this.btnChangeBuildingName.Click += new System.EventHandler(this.btnChangeBuildingName_Click);
            // 
            // btnDeleteBuilding
            // 
            this.btnDeleteBuilding.BackColor = System.Drawing.Color.DimGray;
            this.btnDeleteBuilding.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteBuilding.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteBuilding.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteBuilding.ForeColor = System.Drawing.Color.White;
            this.btnDeleteBuilding.Location = new System.Drawing.Point(749, 102);
            this.btnDeleteBuilding.Name = "btnDeleteBuilding";
            this.btnDeleteBuilding.Size = new System.Drawing.Size(92, 31);
            this.btnDeleteBuilding.TabIndex = 18;
            this.btnDeleteBuilding.Text = "Delete";
            this.btnDeleteBuilding.UseVisualStyleBackColor = false;
            // 
            // btnAddNewBuilding
            // 
            this.btnAddNewBuilding.BackColor = System.Drawing.Color.DimGray;
            this.btnAddNewBuilding.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddNewBuilding.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewBuilding.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewBuilding.ForeColor = System.Drawing.Color.White;
            this.btnAddNewBuilding.Location = new System.Drawing.Point(641, 61);
            this.btnAddNewBuilding.Name = "btnAddNewBuilding";
            this.btnAddNewBuilding.Size = new System.Drawing.Size(102, 31);
            this.btnAddNewBuilding.TabIndex = 19;
            this.btnAddNewBuilding.Text = "Add New";
            this.btnAddNewBuilding.UseVisualStyleBackColor = false;
            this.btnAddNewBuilding.Click += new System.EventHandler(this.btnAddNewBuilding_Click);
            // 
            // btnAddNewRoom
            // 
            this.btnAddNewRoom.BackColor = System.Drawing.Color.DimGray;
            this.btnAddNewRoom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddNewRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewRoom.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewRoom.ForeColor = System.Drawing.Color.White;
            this.btnAddNewRoom.Location = new System.Drawing.Point(641, 179);
            this.btnAddNewRoom.Name = "btnAddNewRoom";
            this.btnAddNewRoom.Size = new System.Drawing.Size(102, 31);
            this.btnAddNewRoom.TabIndex = 27;
            this.btnAddNewRoom.Text = "Add New";
            this.btnAddNewRoom.UseVisualStyleBackColor = false;
            this.btnAddNewRoom.Click += new System.EventHandler(this.btnAddNewRoom_Click);
            // 
            // btnDeleteRoom
            // 
            this.btnDeleteRoom.BackColor = System.Drawing.Color.DimGray;
            this.btnDeleteRoom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteRoom.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteRoom.ForeColor = System.Drawing.Color.White;
            this.btnDeleteRoom.Location = new System.Drawing.Point(749, 220);
            this.btnDeleteRoom.Name = "btnDeleteRoom";
            this.btnDeleteRoom.Size = new System.Drawing.Size(92, 31);
            this.btnDeleteRoom.TabIndex = 26;
            this.btnDeleteRoom.Text = "Delete";
            this.btnDeleteRoom.UseVisualStyleBackColor = false;
            // 
            // btnChangeRoomName
            // 
            this.btnChangeRoomName.BackColor = System.Drawing.Color.DimGray;
            this.btnChangeRoomName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChangeRoomName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangeRoomName.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeRoomName.ForeColor = System.Drawing.Color.White;
            this.btnChangeRoomName.Location = new System.Drawing.Point(749, 179);
            this.btnChangeRoomName.Name = "btnChangeRoomName";
            this.btnChangeRoomName.Size = new System.Drawing.Size(192, 31);
            this.btnChangeRoomName.TabIndex = 25;
            this.btnChangeRoomName.Text = "Change Room Name";
            this.btnChangeRoomName.UseVisualStyleBackColor = false;
            this.btnChangeRoomName.Click += new System.EventHandler(this.btnChangeRoomName_Click);
            // 
            // btnRoomUpdate
            // 
            this.btnRoomUpdate.BackColor = System.Drawing.Color.DimGray;
            this.btnRoomUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRoomUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRoomUpdate.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoomUpdate.ForeColor = System.Drawing.Color.White;
            this.btnRoomUpdate.Location = new System.Drawing.Point(847, 220);
            this.btnRoomUpdate.Name = "btnRoomUpdate";
            this.btnRoomUpdate.Size = new System.Drawing.Size(94, 31);
            this.btnRoomUpdate.TabIndex = 24;
            this.btnRoomUpdate.Text = "Update";
            this.btnRoomUpdate.UseVisualStyleBackColor = false;
            // 
            // btnRoomSave
            // 
            this.btnRoomSave.BackColor = System.Drawing.Color.DimGray;
            this.btnRoomSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRoomSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRoomSave.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoomSave.ForeColor = System.Drawing.Color.White;
            this.btnRoomSave.Location = new System.Drawing.Point(641, 220);
            this.btnRoomSave.Name = "btnRoomSave";
            this.btnRoomSave.Size = new System.Drawing.Size(102, 31);
            this.btnRoomSave.TabIndex = 23;
            this.btnRoomSave.Text = "Save";
            this.btnRoomSave.UseVisualStyleBackColor = false;
            // 
            // txtNewRoom
            // 
            this.txtNewRoom.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewRoom.Location = new System.Drawing.Point(282, 223);
            this.txtNewRoom.Name = "txtNewRoom";
            this.txtNewRoom.Size = new System.Drawing.Size(329, 27);
            this.txtNewRoom.TabIndex = 22;
            this.txtNewRoom.Text = "Enter New Room name";
            // 
            // comboBoxRoom
            // 
            this.comboBoxRoom.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxRoom.FormattingEnabled = true;
            this.comboBoxRoom.Items.AddRange(new object[] {
            "Main Building",
            "New Building",
            "Engineering Building"});
            this.comboBoxRoom.Location = new System.Drawing.Point(282, 183);
            this.comboBoxRoom.Name = "comboBoxRoom";
            this.comboBoxRoom.Size = new System.Drawing.Size(329, 27);
            this.comboBoxRoom.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(109, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 23);
            this.label2.TabIndex = 20;
            this.label2.Text = "Select Room";
            // 
            // lblRoomDetails
            // 
            this.lblRoomDetails.AutoSize = true;
            this.lblRoomDetails.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblRoomDetails.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomDetails.ForeColor = System.Drawing.Color.White;
            this.lblRoomDetails.Location = new System.Drawing.Point(362, 299);
            this.lblRoomDetails.Name = "lblRoomDetails";
            this.lblRoomDetails.Size = new System.Drawing.Size(153, 23);
            this.lblRoomDetails.TabIndex = 28;
            this.lblRoomDetails.Text = "Room Details >>";
            this.lblRoomDetails.Click += new System.EventHandler(this.lblRoomDetails_Click);
            // 
            // panelRoomDetails
            // 
            this.panelRoomDetails.Location = new System.Drawing.Point(3, 335);
            this.panelRoomDetails.Name = "panelRoomDetails";
            this.panelRoomDetails.Size = new System.Drawing.Size(1020, 365);
            this.panelRoomDetails.TabIndex = 35;
            // 
            // AddLocationUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.Controls.Add(this.lblRoomDetails);
            this.Controls.Add(this.btnAddNewRoom);
            this.Controls.Add(this.btnDeleteRoom);
            this.Controls.Add(this.btnChangeRoomName);
            this.Controls.Add(this.btnRoomUpdate);
            this.Controls.Add(this.btnRoomSave);
            this.Controls.Add(this.txtNewRoom);
            this.Controls.Add(this.comboBoxRoom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAddNewBuilding);
            this.Controls.Add(this.btnDeleteBuilding);
            this.Controls.Add(this.btnChangeBuildingName);
            this.Controls.Add(this.btnBuildingUpdate);
            this.Controls.Add(this.btnBuildingSave);
            this.Controls.Add(this.txtNewBuilding);
            this.Controls.Add(this.comboBoxBuilding);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelRoomDetails);
            this.Name = "AddLocationUC";
            this.Size = new System.Drawing.Size(1025, 700);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnBuildingSave;
        private System.Windows.Forms.TextBox txtNewBuilding;
        private System.Windows.Forms.ComboBox comboBoxBuilding;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuildingUpdate;
        private System.Windows.Forms.Button btnChangeBuildingName;
        private System.Windows.Forms.Button btnDeleteBuilding;
        private System.Windows.Forms.Button btnAddNewBuilding;
        private System.Windows.Forms.Button btnAddNewRoom;
        private System.Windows.Forms.Button btnDeleteRoom;
        private System.Windows.Forms.Button btnChangeRoomName;
        private System.Windows.Forms.Button btnRoomUpdate;
        private System.Windows.Forms.Button btnRoomSave;
        private System.Windows.Forms.TextBox txtNewRoom;
        private System.Windows.Forms.ComboBox comboBoxRoom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblRoomDetails;
        private System.Windows.Forms.Panel panelRoomDetails;
    }
}
