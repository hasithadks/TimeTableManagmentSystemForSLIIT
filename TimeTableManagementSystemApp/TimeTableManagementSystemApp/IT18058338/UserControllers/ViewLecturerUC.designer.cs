namespace TimeTableManagementSystemApp.IT18058338.UserControllers
{
    partial class ViewLecturerUC
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
            this.viewlecturers = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.viewlecturers)).BeginInit();
            this.SuspendLayout();
            // 
            // viewlecturers
            // 
            this.viewlecturers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.viewlecturers.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.viewlecturers.BackgroundColor = System.Drawing.Color.White;
            this.viewlecturers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewlecturers.GridColor = System.Drawing.Color.White;
            this.viewlecturers.Location = new System.Drawing.Point(44, 89);
            this.viewlecturers.Name = "viewlecturers";
            this.viewlecturers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.viewlecturers.Size = new System.Drawing.Size(922, 586);
            this.viewlecturers.TabIndex = 0;
            this.viewlecturers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.lecturerCellClick);
            this.viewlecturers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(410, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "View Lecturers";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ViewLecturerUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.viewlecturers);
            this.Name = "ViewLecturerUC";
            this.Size = new System.Drawing.Size(1025, 700);
            this.Load += new System.EventHandler(this.ViewLecturerUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.viewlecturers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView viewlecturers;
        private System.Windows.Forms.Label label1;
    }
}
