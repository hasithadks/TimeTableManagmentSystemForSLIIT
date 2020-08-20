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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlEditRecords = new System.Windows.Forms.Panel();
            this.btnEditRecordLocationUC = new System.Windows.Forms.Button();
            this.timetableManagementSystemDataSet = new TimeTableManagementSystemApp.TimetableManagementSystemDataSet();
            this.buildingsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buildingsTableAdapter = new TimeTableManagementSystemApp.TimetableManagementSystemDataSetTableAdapters.BuildingsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
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
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(86, 71);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(376, 216);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(543, 71);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(376, 216);
            this.dataGridView2.TabIndex = 2;
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
            // btnEditRecordLocationUC
            // 
            this.btnEditRecordLocationUC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(104)))));
            this.btnEditRecordLocationUC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnEditRecordLocationUC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditRecordLocationUC.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditRecordLocationUC.ForeColor = System.Drawing.Color.White;
            this.btnEditRecordLocationUC.Location = new System.Drawing.Point(754, 302);
            this.btnEditRecordLocationUC.Margin = new System.Windows.Forms.Padding(0);
            this.btnEditRecordLocationUC.Name = "btnEditRecordLocationUC";
            this.btnEditRecordLocationUC.Size = new System.Drawing.Size(163, 42);
            this.btnEditRecordLocationUC.TabIndex = 10;
            this.btnEditRecordLocationUC.Text = "Edit Records";
            this.btnEditRecordLocationUC.UseVisualStyleBackColor = false;
            this.btnEditRecordLocationUC.Click += new System.EventHandler(this.btnEditRecordLocationUC_Click);
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
            this.Controls.Add(this.btnEditRecordLocationUC);
            this.Controls.Add(this.pnlEditRecords);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ViewLocationUC";
            this.Size = new System.Drawing.Size(1025, 700);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timetableManagementSystemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buildingsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlEditRecords;
        private System.Windows.Forms.Button btnEditRecordLocationUC;
        private System.Windows.Forms.BindingSource buildingsBindingSource;
        private TimetableManagementSystemDataSet timetableManagementSystemDataSet;
        private TimetableManagementSystemDataSetTableAdapters.BuildingsTableAdapter buildingsTableAdapter;
    }
}
