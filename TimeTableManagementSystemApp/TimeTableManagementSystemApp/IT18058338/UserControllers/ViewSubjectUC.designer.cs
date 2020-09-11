namespace TimeTableManagementSystemApp.IT18058338.UserControllers
{
    partial class ViewSubjectUC
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
            this.viewsubjects = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.viewsubjects)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(430, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "View Subject";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // viewsubjects
            // 
            this.viewsubjects.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.viewsubjects.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.viewsubjects.BackgroundColor = System.Drawing.Color.White;
            this.viewsubjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewsubjects.GridColor = System.Drawing.Color.White;
            this.viewsubjects.Location = new System.Drawing.Point(50, 86);
            this.viewsubjects.Name = "viewsubjects";
            this.viewsubjects.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.viewsubjects.Size = new System.Drawing.Size(922, 559);
            this.viewsubjects.TabIndex = 4;
            this.viewsubjects.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SubjectCellClick);
            this.viewsubjects.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.viewsubjects_CellContentClick);
            // 
            // ViewSubjectUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.viewsubjects);
            this.Controls.Add(this.label1);
            this.Name = "ViewSubjectUC";
            this.Size = new System.Drawing.Size(1025, 700);
            this.Load += new System.EventHandler(this.ViewSubjectUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.viewsubjects)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView viewsubjects;
    }
}
