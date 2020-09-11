namespace TimeTableManagementSystemApp.IT18058338.UserControllers
{
    partial class AddWorkingDaysUC
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.MWDMonday = new System.Windows.Forms.ComboBox();
            this.MWDTuesday = new System.Windows.Forms.ComboBox();
            this.MWDWednesday = new System.Windows.Forms.ComboBox();
            this.MWDThursday = new System.Windows.Forms.ComboBox();
            this.MWDFriday = new System.Windows.Forms.ComboBox();
            this.MWDSaturday = new System.Windows.Forms.ComboBox();
            this.MWDSunday = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.WorkingDaysPerWeek = new System.Windows.Forms.ComboBox();
            this.addWorkingDaysBtn = new System.Windows.Forms.Button();
            this.WorkingDayData = new System.Windows.Forms.DataGridView();
            this.updateWorkingDaysBtn = new System.Windows.Forms.Button();
            this.deleteWorkingDaysBtn = new System.Windows.Forms.Button();
            this.ResetWorkingDaysBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.WorkingTimePerDay = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.WorkingDayData)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(537, 5);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(316, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Manage Working Days and Hours";
            // 
            // MWDMonday
            // 
            this.MWDMonday.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.MWDMonday.FormattingEnabled = true;
            this.MWDMonday.Items.AddRange(new object[] {
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday"});
            this.MWDMonday.Location = new System.Drawing.Point(44, 276);
            this.MWDMonday.Margin = new System.Windows.Forms.Padding(4);
            this.MWDMonday.Name = "MWDMonday";
            this.MWDMonday.Size = new System.Drawing.Size(160, 31);
            this.MWDMonday.TabIndex = 4;
            this.MWDMonday.SelectedIndexChanged += new System.EventHandler(this.MWDMonday_SelectedIndexChanged);
            // 
            // MWDTuesday
            // 
            this.MWDTuesday.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.MWDTuesday.FormattingEnabled = true;
            this.MWDTuesday.Items.AddRange(new object[] {
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday"});
            this.MWDTuesday.Location = new System.Drawing.Point(245, 276);
            this.MWDTuesday.Margin = new System.Windows.Forms.Padding(4);
            this.MWDTuesday.Name = "MWDTuesday";
            this.MWDTuesday.Size = new System.Drawing.Size(160, 31);
            this.MWDTuesday.TabIndex = 5;
            // 
            // MWDWednesday
            // 
            this.MWDWednesday.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.MWDWednesday.FormattingEnabled = true;
            this.MWDWednesday.Items.AddRange(new object[] {
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday"});
            this.MWDWednesday.Location = new System.Drawing.Point(437, 276);
            this.MWDWednesday.Margin = new System.Windows.Forms.Padding(4);
            this.MWDWednesday.Name = "MWDWednesday";
            this.MWDWednesday.Size = new System.Drawing.Size(160, 31);
            this.MWDWednesday.TabIndex = 6;
            // 
            // MWDThursday
            // 
            this.MWDThursday.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.MWDThursday.FormattingEnabled = true;
            this.MWDThursday.Items.AddRange(new object[] {
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday"});
            this.MWDThursday.Location = new System.Drawing.Point(629, 276);
            this.MWDThursday.Margin = new System.Windows.Forms.Padding(4);
            this.MWDThursday.Name = "MWDThursday";
            this.MWDThursday.Size = new System.Drawing.Size(160, 31);
            this.MWDThursday.TabIndex = 7;
            // 
            // MWDFriday
            // 
            this.MWDFriday.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.MWDFriday.FormattingEnabled = true;
            this.MWDFriday.Items.AddRange(new object[] {
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday"});
            this.MWDFriday.Location = new System.Drawing.Point(819, 276);
            this.MWDFriday.Margin = new System.Windows.Forms.Padding(4);
            this.MWDFriday.Name = "MWDFriday";
            this.MWDFriday.Size = new System.Drawing.Size(160, 31);
            this.MWDFriday.TabIndex = 8;
            // 
            // MWDSaturday
            // 
            this.MWDSaturday.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.MWDSaturday.FormattingEnabled = true;
            this.MWDSaturday.Items.AddRange(new object[] {
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday",
            "Sunday"});
            this.MWDSaturday.Location = new System.Drawing.Point(1007, 276);
            this.MWDSaturday.Margin = new System.Windows.Forms.Padding(4);
            this.MWDSaturday.Name = "MWDSaturday";
            this.MWDSaturday.Size = new System.Drawing.Size(160, 31);
            this.MWDSaturday.TabIndex = 9;
            // 
            // MWDSunday
            // 
            this.MWDSunday.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.MWDSunday.FormattingEnabled = true;
            this.MWDSunday.Items.AddRange(new object[] {
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday",
            "Sunday"});
            this.MWDSunday.Location = new System.Drawing.Point(1195, 276);
            this.MWDSunday.Margin = new System.Windows.Forms.Padding(4);
            this.MWDSunday.Name = "MWDSunday";
            this.MWDSunday.Size = new System.Drawing.Size(160, 31);
            this.MWDSunday.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 81);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(411, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select Number of Working Days Per Week";
            // 
            // WorkingDaysPerWeek
            // 
            this.WorkingDaysPerWeek.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.WorkingDaysPerWeek.FormattingEnabled = true;
            this.WorkingDaysPerWeek.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.WorkingDaysPerWeek.Location = new System.Drawing.Point(509, 78);
            this.WorkingDaysPerWeek.Margin = new System.Windows.Forms.Padding(4);
            this.WorkingDaysPerWeek.Name = "WorkingDaysPerWeek";
            this.WorkingDaysPerWeek.Size = new System.Drawing.Size(160, 31);
            this.WorkingDaysPerWeek.TabIndex = 1;
            this.WorkingDaysPerWeek.SelectedIndexChanged += new System.EventHandler(this.NoOfDaysPerWeek_SelectedIndexChanged);
            // 
            // addWorkingDaysBtn
            // 
            this.addWorkingDaysBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(104)))));
            this.addWorkingDaysBtn.FlatAppearance.BorderSize = 0;
            this.addWorkingDaysBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addWorkingDaysBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addWorkingDaysBtn.ForeColor = System.Drawing.Color.White;
            this.addWorkingDaysBtn.Location = new System.Drawing.Point(697, 334);
            this.addWorkingDaysBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addWorkingDaysBtn.Name = "addWorkingDaysBtn";
            this.addWorkingDaysBtn.Size = new System.Drawing.Size(160, 36);
            this.addWorkingDaysBtn.TabIndex = 275;
            this.addWorkingDaysBtn.Text = "Insert";
            this.addWorkingDaysBtn.UseVisualStyleBackColor = false;
            this.addWorkingDaysBtn.Click += new System.EventHandler(this.addWorkingDaysBtn_Click);
            // 
            // WorkingDayData
            // 
            this.WorkingDayData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.WorkingDayData.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.WorkingDayData.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.WorkingDayData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.WorkingDayData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.WorkingDayData.DefaultCellStyle = dataGridViewCellStyle17;
            this.WorkingDayData.Location = new System.Drawing.Point(44, 400);
            this.WorkingDayData.Name = "WorkingDayData";
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.WorkingDayData.RowHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.WorkingDayData.RowHeadersWidth = 51;
            this.WorkingDayData.RowTemplate.Height = 24;
            this.WorkingDayData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.WorkingDayData.Size = new System.Drawing.Size(1311, 484);
            this.WorkingDayData.TabIndex = 276;
            this.WorkingDayData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.workingDayCellClick);
            // 
            // updateWorkingDaysBtn
            // 
            this.updateWorkingDaysBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(104)))));
            this.updateWorkingDaysBtn.FlatAppearance.BorderSize = 0;
            this.updateWorkingDaysBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateWorkingDaysBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateWorkingDaysBtn.ForeColor = System.Drawing.Color.White;
            this.updateWorkingDaysBtn.Location = new System.Drawing.Point(863, 334);
            this.updateWorkingDaysBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.updateWorkingDaysBtn.Name = "updateWorkingDaysBtn";
            this.updateWorkingDaysBtn.Size = new System.Drawing.Size(160, 36);
            this.updateWorkingDaysBtn.TabIndex = 277;
            this.updateWorkingDaysBtn.Text = "Update";
            this.updateWorkingDaysBtn.UseVisualStyleBackColor = false;
            this.updateWorkingDaysBtn.Click += new System.EventHandler(this.updateWorkingDaysBtn_Click);
            // 
            // deleteWorkingDaysBtn
            // 
            this.deleteWorkingDaysBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(104)))));
            this.deleteWorkingDaysBtn.FlatAppearance.BorderSize = 0;
            this.deleteWorkingDaysBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteWorkingDaysBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteWorkingDaysBtn.ForeColor = System.Drawing.Color.White;
            this.deleteWorkingDaysBtn.Location = new System.Drawing.Point(1029, 334);
            this.deleteWorkingDaysBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deleteWorkingDaysBtn.Name = "deleteWorkingDaysBtn";
            this.deleteWorkingDaysBtn.Size = new System.Drawing.Size(160, 36);
            this.deleteWorkingDaysBtn.TabIndex = 278;
            this.deleteWorkingDaysBtn.Text = "Delete";
            this.deleteWorkingDaysBtn.UseVisualStyleBackColor = false;
            this.deleteWorkingDaysBtn.Click += new System.EventHandler(this.deleteWorkingDaysBtn_Click);
            // 
            // ResetWorkingDaysBtn
            // 
            this.ResetWorkingDaysBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(104)))));
            this.ResetWorkingDaysBtn.FlatAppearance.BorderSize = 0;
            this.ResetWorkingDaysBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResetWorkingDaysBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetWorkingDaysBtn.ForeColor = System.Drawing.Color.White;
            this.ResetWorkingDaysBtn.Location = new System.Drawing.Point(1195, 334);
            this.ResetWorkingDaysBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ResetWorkingDaysBtn.Name = "ResetWorkingDaysBtn";
            this.ResetWorkingDaysBtn.Size = new System.Drawing.Size(160, 36);
            this.ResetWorkingDaysBtn.TabIndex = 279;
            this.ResetWorkingDaysBtn.Text = "Reset";
            this.ResetWorkingDaysBtn.UseVisualStyleBackColor = false;
            this.ResetWorkingDaysBtn.Click += new System.EventHandler(this.ResetWorkingDaysBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 147);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(271, 23);
            this.label3.TabIndex = 280;
            this.label3.Text = "Enter Working Time Per Day";
            // 
            // WorkingTimePerDay
            // 
            this.WorkingTimePerDay.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WorkingTimePerDay.Location = new System.Drawing.Point(509, 138);
            this.WorkingTimePerDay.Name = "WorkingTimePerDay";
            this.WorkingTimePerDay.Size = new System.Drawing.Size(160, 32);
            this.WorkingTimePerDay.TabIndex = 281;
            // 
            // AddWorkingDaysUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.WorkingTimePerDay);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ResetWorkingDaysBtn);
            this.Controls.Add(this.deleteWorkingDaysBtn);
            this.Controls.Add(this.updateWorkingDaysBtn);
            this.Controls.Add(this.WorkingDayData);
            this.Controls.Add(this.addWorkingDaysBtn);
            this.Controls.Add(this.MWDSunday);
            this.Controls.Add(this.MWDSaturday);
            this.Controls.Add(this.MWDFriday);
            this.Controls.Add(this.MWDThursday);
            this.Controls.Add(this.MWDWednesday);
            this.Controls.Add(this.MWDTuesday);
            this.Controls.Add(this.MWDMonday);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.WorkingDaysPerWeek);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddWorkingDaysUC";
            this.Size = new System.Drawing.Size(1387, 912);
            this.Load += new System.EventHandler(this.AddWorkingDaysUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.WorkingDayData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox MWDMonday;
        private System.Windows.Forms.ComboBox MWDTuesday;
        private System.Windows.Forms.ComboBox MWDWednesday;
        private System.Windows.Forms.ComboBox MWDThursday;
        private System.Windows.Forms.ComboBox MWDFriday;
        private System.Windows.Forms.ComboBox MWDSaturday;
        private System.Windows.Forms.ComboBox MWDSunday;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox WorkingDaysPerWeek;
        private System.Windows.Forms.Button addWorkingDaysBtn;
        private System.Windows.Forms.DataGridView WorkingDayData;
        private System.Windows.Forms.Button updateWorkingDaysBtn;
        private System.Windows.Forms.Button deleteWorkingDaysBtn;
        private System.Windows.Forms.Button ResetWorkingDaysBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox WorkingTimePerDay;
    }
}
