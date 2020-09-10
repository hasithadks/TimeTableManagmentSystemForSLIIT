namespace TimeTableManagementSystemApp.IT18063288.UserControls
{
    partial class ViewLocationUC
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
            this.label1 = new System.Windows.Forms.Label();
            this.buildingDataGrid = new System.Windows.Forms.DataGridView();
            this.roomDatagrid = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlEditRecords = new System.Windows.Forms.Panel();
            this.timetableManagementSystemDataSet = new TimeTableManagementSystemApp.TimetableManagementSystemDataSet();
            this.buildingsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buildingsTableAdapter = new TimeTableManagementSystemApp.TimetableManagementSystemDataSetTableAdapters.BuildingsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.buildingDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomDatagrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timetableManagementSystemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buildingsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(83, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buildings";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // buildingDataGrid
            // 
            this.buildingDataGrid.AllowUserToOrderColumns = true;
            this.buildingDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.buildingDataGrid.BackgroundColor = System.Drawing.Color.White;
            this.buildingDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.buildingDataGrid.Location = new System.Drawing.Point(86, 71);
            this.buildingDataGrid.Name = "buildingDataGrid";
            this.buildingDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.buildingDataGrid.Size = new System.Drawing.Size(376, 216);
            this.buildingDataGrid.TabIndex = 1;
            this.buildingDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.buildingDataGrid.DoubleClick += new System.EventHandler(this.buildingDataGrid_DoubleClick);
            // 
            // roomDatagrid
            // 
            this.roomDatagrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.roomDatagrid.BackgroundColor = System.Drawing.Color.White;
            this.roomDatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.roomDatagrid.Location = new System.Drawing.Point(543, 71);
            this.roomDatagrid.Name = "roomDatagrid";
            this.roomDatagrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.roomDatagrid.Size = new System.Drawing.Size(376, 216);
            this.roomDatagrid.TabIndex = 2;
            this.roomDatagrid.DoubleClick += new System.EventHandler(this.roomDatagrid_DoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(539, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Rooms";
            // 
            // pnlEditRecords
            // 
            this.pnlEditRecords.Location = new System.Drawing.Point(87, 357);
            this.pnlEditRecords.Name = "pnlEditRecords";
            this.pnlEditRecords.Size = new System.Drawing.Size(830, 315);
            this.pnlEditRecords.TabIndex = 4;
            // 
            // timetableManagementSystemDataSet
            // 
            this.timetableManagementSystemDataSet.DataSetName = "TimetableManagementSystemDataSet";
            this.timetableManagementSystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // buildingsBindingSource
            // 
            this.buildingsBindingSource.DataMember = "Buildings";
            this.buildingsBindingSource.DataSource = this.timetableManagementSystemDataSet;
            // 
            // buildingsTableAdapter
            // 
            this.buildingsTableAdapter.ClearBeforeFill = true;
            // 
            // ViewLocationUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnlEditRecords);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.roomDatagrid);
            this.Controls.Add(this.buildingDataGrid);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ViewLocationUC";
            this.Size = new System.Drawing.Size(1025, 700);
            ((System.ComponentModel.ISupportInitialize)(this.buildingDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomDatagrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timetableManagementSystemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buildingsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView buildingDataGrid;
        private System.Windows.Forms.DataGridView roomDatagrid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlEditRecords;
        private System.Windows.Forms.BindingSource buildingsBindingSource;
        private TimetableManagementSystemDataSet timetableManagementSystemDataSet;
        private TimetableManagementSystemDataSetTableAdapters.BuildingsTableAdapter buildingsTableAdapter;
    }
}
