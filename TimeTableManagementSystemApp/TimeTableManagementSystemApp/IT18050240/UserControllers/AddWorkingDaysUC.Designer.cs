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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.MWDMonday = new System.Windows.Forms.ComboBox();
            this.MWDTuesday = new System.Windows.Forms.ComboBox();
            this.MWDWednesday = new System.Windows.Forms.ComboBox();
            this.MWDThursday = new System.Windows.Forms.ComboBox();
            this.MWDFriday = new System.Windows.Forms.ComboBox();
            this.MWDSaturday = new System.Windows.Forms.ComboBox();
            this.MWDSunday = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SelectYear = new System.Windows.Forms.ComboBox();
            this.SelectSem = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SelectGroup = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.NoOfDaysPerWeek = new System.Windows.Forms.ComboBox();
            this.addWorkingDaysBtn = new System.Windows.Forms.Button();
            this.WorkingDayData = new System.Windows.Forms.DataGridView();
            this.workingDayIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workingdayGroupDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workingdayYearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workingdaySemesterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workingday1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workingday2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workingday3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workingday4DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workingday5DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workingday6DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workingday7DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workingdayOneHourTimeSlotsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thirtyMinutesTimeSlotsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workingDaysBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.timetableManagementSystemDataSet1 = new TimeTableManagementSystemApp.TimetableManagementSystemDataSet1();
            this.workingDaysTableAdapter = new TimeTableManagementSystemApp.TimetableManagementSystemDataSet1TableAdapters.WorkingDaysTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.WorkingDayData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workingDaysBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timetableManagementSystemDataSet1)).BeginInit();
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
            this.MWDSaturday.Text = "Saturday";
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
            this.MWDSunday.Text = "Sunday";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.checkBox1.Location = new System.Drawing.Point(1101, 85);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(218, 27);
            this.checkBox1.TabIndex = 13;
            this.checkBox1.Text = "One hour time slots";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.checkBox2.Location = new System.Drawing.Point(1101, 126);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(254, 27);
            this.checkBox2.TabIndex = 14;
            this.checkBox2.Text = "Thirty minutes time slots";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 161);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 23);
            this.label3.TabIndex = 15;
            this.label3.Text = "Select Year";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(40, 201);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 23);
            this.label4.TabIndex = 16;
            this.label4.Text = "Select Semester";
            // 
            // SelectYear
            // 
            this.SelectYear.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.SelectYear.FormattingEnabled = true;
            this.SelectYear.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.SelectYear.Location = new System.Drawing.Point(396, 161);
            this.SelectYear.Margin = new System.Windows.Forms.Padding(4);
            this.SelectYear.Name = "SelectYear";
            this.SelectYear.Size = new System.Drawing.Size(160, 31);
            this.SelectYear.TabIndex = 17;
            // 
            // SelectSem
            // 
            this.SelectSem.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.SelectSem.FormattingEnabled = true;
            this.SelectSem.Items.AddRange(new object[] {
            "1",
            "2"});
            this.SelectSem.Location = new System.Drawing.Point(396, 201);
            this.SelectSem.Margin = new System.Windows.Forms.Padding(4);
            this.SelectSem.Name = "SelectSem";
            this.SelectSem.Size = new System.Drawing.Size(160, 31);
            this.SelectSem.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(40, 122);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 23);
            this.label5.TabIndex = 19;
            this.label5.Text = "Select Group";
            // 
            // SelectGroup
            // 
            this.SelectGroup.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.SelectGroup.FormattingEnabled = true;
            this.SelectGroup.Items.AddRange(new object[] {
            "Y1.S1.SE.09.2",
            "Y2.S2.IT.06.05"});
            this.SelectGroup.Location = new System.Drawing.Point(396, 122);
            this.SelectGroup.Margin = new System.Windows.Forms.Padding(4);
            this.SelectGroup.Name = "SelectGroup";
            this.SelectGroup.Size = new System.Drawing.Size(160, 31);
            this.SelectGroup.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 81);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(331, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select Number of Days Per Week";
            // 
            // NoOfDaysPerWeek
            // 
            this.NoOfDaysPerWeek.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.NoOfDaysPerWeek.FormattingEnabled = true;
            this.NoOfDaysPerWeek.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "Weekend"});
            this.NoOfDaysPerWeek.Location = new System.Drawing.Point(396, 81);
            this.NoOfDaysPerWeek.Margin = new System.Windows.Forms.Padding(4);
            this.NoOfDaysPerWeek.Name = "NoOfDaysPerWeek";
            this.NoOfDaysPerWeek.Size = new System.Drawing.Size(160, 31);
            this.NoOfDaysPerWeek.TabIndex = 1;
            this.NoOfDaysPerWeek.SelectedIndexChanged += new System.EventHandler(this.NoOfDaysPerWeek_SelectedIndexChanged);
            // 
            // addWorkingDaysBtn
            // 
            this.addWorkingDaysBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(104)))));
            this.addWorkingDaysBtn.FlatAppearance.BorderSize = 0;
            this.addWorkingDaysBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addWorkingDaysBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addWorkingDaysBtn.ForeColor = System.Drawing.Color.White;
            this.addWorkingDaysBtn.Location = new System.Drawing.Point(1195, 834);
            this.addWorkingDaysBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addWorkingDaysBtn.Name = "addWorkingDaysBtn";
            this.addWorkingDaysBtn.Size = new System.Drawing.Size(160, 36);
            this.addWorkingDaysBtn.TabIndex = 275;
            this.addWorkingDaysBtn.Text = "Done";
            this.addWorkingDaysBtn.UseVisualStyleBackColor = false;
            this.addWorkingDaysBtn.Click += new System.EventHandler(this.addWorkingDaysBtn_Click);
            // 
            // WorkingDayData
            // 
            this.WorkingDayData.AutoGenerateColumns = false;
            this.WorkingDayData.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.WorkingDayData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.WorkingDayData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.WorkingDayData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.workingDayIDDataGridViewTextBoxColumn,
            this.workingdayGroupDataGridViewTextBoxColumn,
            this.workingdayYearDataGridViewTextBoxColumn,
            this.workingdaySemesterDataGridViewTextBoxColumn,
            this.workingday1DataGridViewTextBoxColumn,
            this.workingday2DataGridViewTextBoxColumn,
            this.workingday3DataGridViewTextBoxColumn,
            this.workingday4DataGridViewTextBoxColumn,
            this.workingday5DataGridViewTextBoxColumn,
            this.workingday6DataGridViewTextBoxColumn,
            this.workingday7DataGridViewTextBoxColumn,
            this.workingdayOneHourTimeSlotsDataGridViewTextBoxColumn,
            this.thirtyMinutesTimeSlotsDataGridViewTextBoxColumn});
            this.WorkingDayData.DataSource = this.workingDaysBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.WorkingDayData.DefaultCellStyle = dataGridViewCellStyle2;
            this.WorkingDayData.Location = new System.Drawing.Point(44, 408);
            this.WorkingDayData.Name = "WorkingDayData";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.WorkingDayData.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.WorkingDayData.RowHeadersWidth = 51;
            this.WorkingDayData.RowTemplate.Height = 24;
            this.WorkingDayData.Size = new System.Drawing.Size(1311, 150);
            this.WorkingDayData.TabIndex = 276;
            // 
            // workingDayIDDataGridViewTextBoxColumn
            // 
            this.workingDayIDDataGridViewTextBoxColumn.DataPropertyName = "WorkingDayID";
            this.workingDayIDDataGridViewTextBoxColumn.HeaderText = "WorkingDayID";
            this.workingDayIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.workingDayIDDataGridViewTextBoxColumn.Name = "workingDayIDDataGridViewTextBoxColumn";
            this.workingDayIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.workingDayIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // workingdayGroupDataGridViewTextBoxColumn
            // 
            this.workingdayGroupDataGridViewTextBoxColumn.DataPropertyName = "workingdayGroup";
            this.workingdayGroupDataGridViewTextBoxColumn.HeaderText = "workingdayGroup";
            this.workingdayGroupDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.workingdayGroupDataGridViewTextBoxColumn.Name = "workingdayGroupDataGridViewTextBoxColumn";
            this.workingdayGroupDataGridViewTextBoxColumn.Width = 125;
            // 
            // workingdayYearDataGridViewTextBoxColumn
            // 
            this.workingdayYearDataGridViewTextBoxColumn.DataPropertyName = "workingdayYear";
            this.workingdayYearDataGridViewTextBoxColumn.HeaderText = "workingdayYear";
            this.workingdayYearDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.workingdayYearDataGridViewTextBoxColumn.Name = "workingdayYearDataGridViewTextBoxColumn";
            this.workingdayYearDataGridViewTextBoxColumn.Width = 125;
            // 
            // workingdaySemesterDataGridViewTextBoxColumn
            // 
            this.workingdaySemesterDataGridViewTextBoxColumn.DataPropertyName = "workingdaySemester";
            this.workingdaySemesterDataGridViewTextBoxColumn.HeaderText = "workingdaySemester";
            this.workingdaySemesterDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.workingdaySemesterDataGridViewTextBoxColumn.Name = "workingdaySemesterDataGridViewTextBoxColumn";
            this.workingdaySemesterDataGridViewTextBoxColumn.Width = 125;
            // 
            // workingday1DataGridViewTextBoxColumn
            // 
            this.workingday1DataGridViewTextBoxColumn.DataPropertyName = "workingday1";
            this.workingday1DataGridViewTextBoxColumn.HeaderText = "workingday1";
            this.workingday1DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.workingday1DataGridViewTextBoxColumn.Name = "workingday1DataGridViewTextBoxColumn";
            this.workingday1DataGridViewTextBoxColumn.Width = 125;
            // 
            // workingday2DataGridViewTextBoxColumn
            // 
            this.workingday2DataGridViewTextBoxColumn.DataPropertyName = "workingday2";
            this.workingday2DataGridViewTextBoxColumn.HeaderText = "workingday2";
            this.workingday2DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.workingday2DataGridViewTextBoxColumn.Name = "workingday2DataGridViewTextBoxColumn";
            this.workingday2DataGridViewTextBoxColumn.Width = 125;
            // 
            // workingday3DataGridViewTextBoxColumn
            // 
            this.workingday3DataGridViewTextBoxColumn.DataPropertyName = "workingday3";
            this.workingday3DataGridViewTextBoxColumn.HeaderText = "workingday3";
            this.workingday3DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.workingday3DataGridViewTextBoxColumn.Name = "workingday3DataGridViewTextBoxColumn";
            this.workingday3DataGridViewTextBoxColumn.Width = 125;
            // 
            // workingday4DataGridViewTextBoxColumn
            // 
            this.workingday4DataGridViewTextBoxColumn.DataPropertyName = "workingday4";
            this.workingday4DataGridViewTextBoxColumn.HeaderText = "workingday4";
            this.workingday4DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.workingday4DataGridViewTextBoxColumn.Name = "workingday4DataGridViewTextBoxColumn";
            this.workingday4DataGridViewTextBoxColumn.Width = 125;
            // 
            // workingday5DataGridViewTextBoxColumn
            // 
            this.workingday5DataGridViewTextBoxColumn.DataPropertyName = "workingday5";
            this.workingday5DataGridViewTextBoxColumn.HeaderText = "workingday5";
            this.workingday5DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.workingday5DataGridViewTextBoxColumn.Name = "workingday5DataGridViewTextBoxColumn";
            this.workingday5DataGridViewTextBoxColumn.Width = 125;
            // 
            // workingday6DataGridViewTextBoxColumn
            // 
            this.workingday6DataGridViewTextBoxColumn.DataPropertyName = "workingday6";
            this.workingday6DataGridViewTextBoxColumn.HeaderText = "workingday6";
            this.workingday6DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.workingday6DataGridViewTextBoxColumn.Name = "workingday6DataGridViewTextBoxColumn";
            this.workingday6DataGridViewTextBoxColumn.Width = 125;
            // 
            // workingday7DataGridViewTextBoxColumn
            // 
            this.workingday7DataGridViewTextBoxColumn.DataPropertyName = "workingday7";
            this.workingday7DataGridViewTextBoxColumn.HeaderText = "workingday7";
            this.workingday7DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.workingday7DataGridViewTextBoxColumn.Name = "workingday7DataGridViewTextBoxColumn";
            this.workingday7DataGridViewTextBoxColumn.Width = 125;
            // 
            // workingdayOneHourTimeSlotsDataGridViewTextBoxColumn
            // 
            this.workingdayOneHourTimeSlotsDataGridViewTextBoxColumn.DataPropertyName = "workingdayOneHourTimeSlots";
            this.workingdayOneHourTimeSlotsDataGridViewTextBoxColumn.HeaderText = "workingdayOneHourTimeSlots";
            this.workingdayOneHourTimeSlotsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.workingdayOneHourTimeSlotsDataGridViewTextBoxColumn.Name = "workingdayOneHourTimeSlotsDataGridViewTextBoxColumn";
            this.workingdayOneHourTimeSlotsDataGridViewTextBoxColumn.Width = 125;
            // 
            // thirtyMinutesTimeSlotsDataGridViewTextBoxColumn
            // 
            this.thirtyMinutesTimeSlotsDataGridViewTextBoxColumn.DataPropertyName = "ThirtyMinutesTimeSlots";
            this.thirtyMinutesTimeSlotsDataGridViewTextBoxColumn.HeaderText = "ThirtyMinutesTimeSlots";
            this.thirtyMinutesTimeSlotsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.thirtyMinutesTimeSlotsDataGridViewTextBoxColumn.Name = "thirtyMinutesTimeSlotsDataGridViewTextBoxColumn";
            this.thirtyMinutesTimeSlotsDataGridViewTextBoxColumn.Width = 125;
            // 
            // workingDaysBindingSource
            // 
            this.workingDaysBindingSource.DataMember = "WorkingDays";
            this.workingDaysBindingSource.DataSource = this.timetableManagementSystemDataSet1;
            // 
            // timetableManagementSystemDataSet1
            // 
            this.timetableManagementSystemDataSet1.DataSetName = "TimetableManagementSystemDataSet1";
            this.timetableManagementSystemDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // workingDaysTableAdapter
            // 
            this.workingDaysTableAdapter.ClearBeforeFill = true;
            // 
            // AddWorkingDaysUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.WorkingDayData);
            this.Controls.Add(this.addWorkingDaysBtn);
            this.Controls.Add(this.SelectGroup);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.SelectSem);
            this.Controls.Add(this.SelectYear);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.MWDSunday);
            this.Controls.Add(this.MWDSaturday);
            this.Controls.Add(this.MWDFriday);
            this.Controls.Add(this.MWDThursday);
            this.Controls.Add(this.MWDWednesday);
            this.Controls.Add(this.MWDTuesday);
            this.Controls.Add(this.MWDMonday);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NoOfDaysPerWeek);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddWorkingDaysUC";
            this.Size = new System.Drawing.Size(1387, 912);
            this.Load += new System.EventHandler(this.AddWorkingDaysUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.WorkingDayData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workingDaysBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timetableManagementSystemDataSet1)).EndInit();
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
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox SelectYear;
        private System.Windows.Forms.ComboBox SelectSem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox SelectGroup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox NoOfDaysPerWeek;
        private System.Windows.Forms.Button addWorkingDaysBtn;
        private System.Windows.Forms.DataGridView WorkingDayData;
        private System.Windows.Forms.DataGridViewTextBoxColumn workingDayIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn workingdayGroupDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn workingdayYearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn workingdaySemesterDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn workingday1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn workingday2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn workingday3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn workingday4DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn workingday5DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn workingday6DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn workingday7DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn workingdayOneHourTimeSlotsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn thirtyMinutesTimeSlotsDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource workingDaysBindingSource;
        private TimetableManagementSystemDataSet1 timetableManagementSystemDataSet1;
        private TimetableManagementSystemDataSet1TableAdapters.WorkingDaysTableAdapter workingDaysTableAdapter;
    }
}
