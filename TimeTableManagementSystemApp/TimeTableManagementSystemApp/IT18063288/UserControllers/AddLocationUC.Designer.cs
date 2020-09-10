namespace TimeTableManagementSystemApp.IT18063288.UserControllers
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddLocationUC));
            this.btnBuildingSave = new System.Windows.Forms.Button();
            this.txtNewBuilding = new System.Windows.Forms.TextBox();
            this.comboBoxBuilding = new System.Windows.Forms.ComboBox();
            this.buildingsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.timetableManagementSystemDataSet = new TimeTableManagementSystemApp.TimetableManagementSystemDataSet();
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
            this.labelRoom = new System.Windows.Forms.Label();
            this.panelRoomDetails = new System.Windows.Forms.Panel();
            this.buildingsTableAdapter = new TimeTableManagementSystemApp.TimetableManagementSystemDataSetTableAdapters.BuildingsTableAdapter();
            this.fillByToolStrip = new System.Windows.Forms.ToolStrip();
            this.fillByToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.fillToolStrip = new System.Windows.Forms.ToolStrip();
            this.fillToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.btnViewRoomDetails = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.buildingsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timetableManagementSystemDataSet)).BeginInit();
            this.fillByToolStrip.SuspendLayout();
            this.fillToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBuildingSave
            // 
            this.btnBuildingSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(104)))));
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
            this.btnBuildingSave.Click += new System.EventHandler(this.btnBuildingSave_Click);
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
            this.comboBoxBuilding.Location = new System.Drawing.Point(282, 65);
            this.comboBoxBuilding.Name = "comboBoxBuilding";
            this.comboBoxBuilding.Size = new System.Drawing.Size(329, 27);
            this.comboBoxBuilding.TabIndex = 10;
            this.comboBoxBuilding.SelectedIndexChanged += new System.EventHandler(this.comboBoxBuilding_SelectedIndexChanged);
            // 
            // buildingsBindingSource
            // 
            this.buildingsBindingSource.DataMember = "Buildings";
            this.buildingsBindingSource.DataSource = this.timetableManagementSystemDataSet;
            // 
            // timetableManagementSystemDataSet
            // 
            this.timetableManagementSystemDataSet.DataSetName = "TimetableManagementSystemDataSet";
            this.timetableManagementSystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(99, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 23);
            this.label1.TabIndex = 9;
            this.label1.Text = "Select Building";
            // 
            // btnBuildingUpdate
            // 
            this.btnBuildingUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(104)))));
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
            this.btnBuildingUpdate.Click += new System.EventHandler(this.btnBuildingUpdate_Click);
            // 
            // btnChangeBuildingName
            // 
            this.btnChangeBuildingName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(104)))));
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
            this.btnDeleteBuilding.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(104)))));
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
            this.btnDeleteBuilding.Click += new System.EventHandler(this.btnDeleteBuilding_Click);
            // 
            // btnAddNewBuilding
            // 
            this.btnAddNewBuilding.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(104)))));
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
            this.btnAddNewRoom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(104)))));
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
            this.btnDeleteRoom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(104)))));
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
            this.btnDeleteRoom.Click += new System.EventHandler(this.btnDeleteRoom_Click);
            // 
            // btnChangeRoomName
            // 
            this.btnChangeRoomName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(104)))));
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
            this.btnRoomUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(104)))));
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
            this.btnRoomUpdate.Click += new System.EventHandler(this.btnRoomUpdate_Click);
            // 
            // btnRoomSave
            // 
            this.btnRoomSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(104)))));
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
            this.btnRoomSave.Click += new System.EventHandler(this.btnRoomSave_Click);
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
            this.comboBoxRoom.Location = new System.Drawing.Point(282, 183);
            this.comboBoxRoom.Name = "comboBoxRoom";
            this.comboBoxRoom.Size = new System.Drawing.Size(329, 27);
            this.comboBoxRoom.TabIndex = 21;
            this.comboBoxRoom.SelectedIndexChanged += new System.EventHandler(this.comboBoxRoom_SelectedIndexChanged);
            // 
            // labelRoom
            // 
            this.labelRoom.AutoSize = true;
            this.labelRoom.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRoom.ForeColor = System.Drawing.Color.Black;
            this.labelRoom.Location = new System.Drawing.Point(109, 179);
            this.labelRoom.Name = "labelRoom";
            this.labelRoom.Size = new System.Drawing.Size(114, 23);
            this.labelRoom.TabIndex = 20;
            this.labelRoom.Text = "Select Room";
            // 
            // panelRoomDetails
            // 
            this.panelRoomDetails.Location = new System.Drawing.Point(3, 303);
            this.panelRoomDetails.Name = "panelRoomDetails";
            this.panelRoomDetails.Size = new System.Drawing.Size(1020, 365);
            this.panelRoomDetails.TabIndex = 35;
            // 
            // buildingsTableAdapter
            // 
            this.buildingsTableAdapter.ClearBeforeFill = true;
            // 
            // fillByToolStrip
            // 
            this.fillByToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.fillByToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillByToolStripButton});
            this.fillByToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillByToolStrip.Name = "fillByToolStrip";
            this.fillByToolStrip.Size = new System.Drawing.Size(1042, 25);
            this.fillByToolStrip.TabIndex = 36;
            this.fillByToolStrip.Text = "fillByToolStrip";
            this.fillByToolStrip.Visible = false;
            // 
            // fillByToolStripButton
            // 
            this.fillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByToolStripButton.Name = "fillByToolStripButton";
            this.fillByToolStripButton.Size = new System.Drawing.Size(39, 22);
            this.fillByToolStripButton.Text = "FillBy";
            this.fillByToolStripButton.Click += new System.EventHandler(this.fillByToolStripButton_Click);
            // 
            // fillToolStrip
            // 
            this.fillToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.fillToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.fillToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillToolStripButton,
            this.toolStripButton1});
            this.fillToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillToolStrip.Name = "fillToolStrip";
            this.fillToolStrip.Size = new System.Drawing.Size(1042, 25);
            this.fillToolStrip.TabIndex = 37;
            this.fillToolStrip.Text = "fillToolStrip";
            this.fillToolStrip.Visible = false;
            // 
            // fillToolStripButton
            // 
            this.fillToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillToolStripButton.Name = "fillToolStripButton";
            this.fillToolStripButton.Size = new System.Drawing.Size(26, 22);
            this.fillToolStripButton.Text = "Fill";
            this.fillToolStripButton.Click += new System.EventHandler(this.fillToolStripButton_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(24, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // btnViewRoomDetails
            // 
            this.btnViewRoomDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(104)))));
            this.btnViewRoomDetails.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewRoomDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewRoomDetails.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewRoomDetails.ForeColor = System.Drawing.Color.White;
            this.btnViewRoomDetails.Location = new System.Drawing.Point(282, 269);
            this.btnViewRoomDetails.Name = "btnViewRoomDetails";
            this.btnViewRoomDetails.Size = new System.Drawing.Size(329, 31);
            this.btnViewRoomDetails.TabIndex = 38;
            this.btnViewRoomDetails.Text = "View Room Details";
            this.btnViewRoomDetails.UseVisualStyleBackColor = false;
            this.btnViewRoomDetails.Click += new System.EventHandler(this.btnViewRoomDetails_Click);
            // 
            // AddLocationUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnViewRoomDetails);
            this.Controls.Add(this.fillToolStrip);
            this.Controls.Add(this.fillByToolStrip);
            this.Controls.Add(this.btnAddNewRoom);
            this.Controls.Add(this.btnDeleteRoom);
            this.Controls.Add(this.btnChangeRoomName);
            this.Controls.Add(this.btnRoomUpdate);
            this.Controls.Add(this.btnRoomSave);
            this.Controls.Add(this.txtNewRoom);
            this.Controls.Add(this.comboBoxRoom);
            this.Controls.Add(this.labelRoom);
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
            this.Size = new System.Drawing.Size(1042, 671);
            ((System.ComponentModel.ISupportInitialize)(this.buildingsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timetableManagementSystemDataSet)).EndInit();
            this.fillByToolStrip.ResumeLayout(false);
            this.fillByToolStrip.PerformLayout();
            this.fillToolStrip.ResumeLayout(false);
            this.fillToolStrip.PerformLayout();
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
        private System.Windows.Forms.Label labelRoom;
        private System.Windows.Forms.Panel panelRoomDetails;
        private System.Windows.Forms.BindingSource buildingsBindingSource;
        private TimetableManagementSystemDataSet timetableManagementSystemDataSet;
        private TimetableManagementSystemDataSetTableAdapters.BuildingsTableAdapter buildingsTableAdapter;
        private System.Windows.Forms.ToolStrip fillByToolStrip;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton;
        private System.Windows.Forms.ToolStrip fillToolStrip;
        private System.Windows.Forms.ToolStripButton fillToolStripButton;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.Button btnViewRoomDetails;
    }
}
