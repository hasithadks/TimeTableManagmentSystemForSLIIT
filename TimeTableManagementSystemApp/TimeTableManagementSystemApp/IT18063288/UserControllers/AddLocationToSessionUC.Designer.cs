namespace TimeTableManagementSystemApp.IT18063288.UserControllers
{
    partial class AddLocationToSessionUC
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
            this.buttonSearchView = new System.Windows.Forms.Button();
            this.comboBoxGroup = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.comboBoxSubject = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.comboBoxLecturer = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.CountLabel = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DataGridSessions = new System.Windows.Forms.DataGridView();
            this.buttonNotAdded = new System.Windows.Forms.Button();
            this.PanelBtnHorizontal = new System.Windows.Forms.Panel();
            this.buttonAdded = new System.Windows.Forms.Button();
            this.labelSessID = new System.Windows.Forms.Label();
            this.labelTag = new System.Windows.Forms.Label();
            this.labelSubject = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxRoom = new System.Windows.Forms.ComboBox();
            this.buttonUpdateSession = new System.Windows.Forms.Button();
            this.grouptxt = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.subGroupTxt = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridSessions)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSearchView
            // 
            this.buttonSearchView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(104)))));
            this.buttonSearchView.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonSearchView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSearchView.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearchView.ForeColor = System.Drawing.Color.White;
            this.buttonSearchView.Location = new System.Drawing.Point(746, 343);
            this.buttonSearchView.Margin = new System.Windows.Forms.Padding(0);
            this.buttonSearchView.Name = "buttonSearchView";
            this.buttonSearchView.Size = new System.Drawing.Size(131, 30);
            this.buttonSearchView.TabIndex = 89;
            this.buttonSearchView.Text = "Search";
            this.buttonSearchView.UseVisualStyleBackColor = false;
            this.buttonSearchView.Click += new System.EventHandler(this.buttonSearchView_Click);
            // 
            // comboBoxGroup
            // 
            this.comboBoxGroup.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxGroup.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxGroup.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxGroup.FormattingEnabled = true;
            this.comboBoxGroup.Location = new System.Drawing.Point(563, 343);
            this.comboBoxGroup.Name = "comboBoxGroup";
            this.comboBoxGroup.Size = new System.Drawing.Size(162, 27);
            this.comboBoxGroup.TabIndex = 88;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label14.Location = new System.Drawing.Point(502, 346);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(69, 19);
            this.label14.TabIndex = 87;
            this.label14.Text = "Group : ";
            // 
            // comboBoxSubject
            // 
            this.comboBoxSubject.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxSubject.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxSubject.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSubject.FormattingEnabled = true;
            this.comboBoxSubject.Location = new System.Drawing.Point(334, 343);
            this.comboBoxSubject.Name = "comboBoxSubject";
            this.comboBoxSubject.Size = new System.Drawing.Size(162, 27);
            this.comboBoxSubject.TabIndex = 86;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label12.Location = new System.Drawing.Point(264, 346);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 19);
            this.label12.TabIndex = 85;
            this.label12.Text = "Subject : ";
            // 
            // comboBoxLecturer
            // 
            this.comboBoxLecturer.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxLecturer.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxLecturer.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxLecturer.FormattingEnabled = true;
            this.comboBoxLecturer.Location = new System.Drawing.Point(96, 343);
            this.comboBoxLecturer.Name = "comboBoxLecturer";
            this.comboBoxLecturer.Size = new System.Drawing.Size(162, 27);
            this.comboBoxLecturer.TabIndex = 84;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label13.Location = new System.Drawing.Point(19, 346);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(82, 19);
            this.label13.TabIndex = 83;
            this.label13.Text = "Lecturer : ";
            // 
            // CountLabel
            // 
            this.CountLabel.AutoSize = true;
            this.CountLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CountLabel.ForeColor = System.Drawing.Color.Black;
            this.CountLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CountLabel.Location = new System.Drawing.Point(976, 90);
            this.CountLabel.Name = "CountLabel";
            this.CountLabel.Size = new System.Drawing.Size(0, 19);
            this.CountLabel.TabIndex = 82;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.Black;
            this.label20.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label20.Location = new System.Drawing.Point(898, 90);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(72, 19);
            this.label20.TabIndex = 81;
            this.label20.Text = "Count  : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(447, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 19);
            this.label1.TabIndex = 80;
            this.label1.Text = "Set Session Locations";
            // 
            // DataGridSessions
            // 
            this.DataGridSessions.AllowUserToOrderColumns = true;
            this.DataGridSessions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridSessions.BackgroundColor = System.Drawing.Color.White;
            this.DataGridSessions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridSessions.Location = new System.Drawing.Point(18, 112);
            this.DataGridSessions.Name = "DataGridSessions";
            this.DataGridSessions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridSessions.Size = new System.Drawing.Size(1008, 225);
            this.DataGridSessions.TabIndex = 79;
            this.DataGridSessions.DoubleClick += new System.EventHandler(this.DataGridSessions_DoubleClick);
            // 
            // buttonNotAdded
            // 
            this.buttonNotAdded.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(104)))));
            this.buttonNotAdded.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonNotAdded.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonNotAdded.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNotAdded.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNotAdded.ForeColor = System.Drawing.Color.White;
            this.buttonNotAdded.Location = new System.Drawing.Point(18, 49);
            this.buttonNotAdded.Margin = new System.Windows.Forms.Padding(0);
            this.buttonNotAdded.Name = "buttonNotAdded";
            this.buttonNotAdded.Size = new System.Drawing.Size(166, 41);
            this.buttonNotAdded.TabIndex = 90;
            this.buttonNotAdded.Text = "Not Added List";
            this.buttonNotAdded.UseVisualStyleBackColor = false;
            this.buttonNotAdded.Click += new System.EventHandler(this.buttonNotAdded_Click);
            // 
            // PanelBtnHorizontal
            // 
            this.PanelBtnHorizontal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(104)))));
            this.PanelBtnHorizontal.Location = new System.Drawing.Point(18, 93);
            this.PanelBtnHorizontal.Name = "PanelBtnHorizontal";
            this.PanelBtnHorizontal.Size = new System.Drawing.Size(166, 16);
            this.PanelBtnHorizontal.TabIndex = 91;
            // 
            // buttonAdded
            // 
            this.buttonAdded.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(104)))));
            this.buttonAdded.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonAdded.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAdded.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdded.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdded.ForeColor = System.Drawing.Color.White;
            this.buttonAdded.Location = new System.Drawing.Point(184, 49);
            this.buttonAdded.Margin = new System.Windows.Forms.Padding(0);
            this.buttonAdded.Name = "buttonAdded";
            this.buttonAdded.Size = new System.Drawing.Size(166, 41);
            this.buttonAdded.TabIndex = 92;
            this.buttonAdded.Text = "Added List";
            this.buttonAdded.UseVisualStyleBackColor = false;
            this.buttonAdded.Click += new System.EventHandler(this.buttonAdded_Click);
            // 
            // labelSessID
            // 
            this.labelSessID.AutoSize = true;
            this.labelSessID.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSessID.ForeColor = System.Drawing.Color.Black;
            this.labelSessID.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelSessID.Location = new System.Drawing.Point(530, 486);
            this.labelSessID.Name = "labelSessID";
            this.labelSessID.Size = new System.Drawing.Size(35, 19);
            this.labelSessID.TabIndex = 101;
            this.labelSessID.Text = "text";
            // 
            // labelTag
            // 
            this.labelTag.AutoSize = true;
            this.labelTag.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTag.ForeColor = System.Drawing.Color.Black;
            this.labelTag.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelTag.Location = new System.Drawing.Point(530, 543);
            this.labelTag.Name = "labelTag";
            this.labelTag.Size = new System.Drawing.Size(35, 19);
            this.labelTag.TabIndex = 100;
            this.labelTag.Text = "text";
            // 
            // labelSubject
            // 
            this.labelSubject.AutoSize = true;
            this.labelSubject.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSubject.ForeColor = System.Drawing.Color.Black;
            this.labelSubject.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelSubject.Location = new System.Drawing.Point(530, 514);
            this.labelSubject.Name = "labelSubject";
            this.labelSubject.Size = new System.Drawing.Size(35, 19);
            this.labelSubject.TabIndex = 98;
            this.labelSubject.Text = "text";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label10.Location = new System.Drawing.Point(419, 486);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(105, 19);
            this.label10.TabIndex = 97;
            this.label10.Text = "Session ID  : ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label8.Location = new System.Drawing.Point(467, 543);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 19);
            this.label8.TabIndex = 96;
            this.label8.Text = "Tag  : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label6.Location = new System.Drawing.Point(411, 572);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 19);
            this.label6.TabIndex = 95;
            this.label6.Text = "Select Room : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label4.Location = new System.Drawing.Point(442, 514);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 19);
            this.label4.TabIndex = 94;
            this.label4.Text = "Subject  : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(401, 406);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 19);
            this.label2.TabIndex = 93;
            this.label2.Text = "Add Location to Sessions ";
            // 
            // comboBoxRoom
            // 
            this.comboBoxRoom.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxRoom.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxRoom.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxRoom.FormattingEnabled = true;
            this.comboBoxRoom.Location = new System.Drawing.Point(530, 569);
            this.comboBoxRoom.Name = "comboBoxRoom";
            this.comboBoxRoom.Size = new System.Drawing.Size(162, 27);
            this.comboBoxRoom.TabIndex = 102;
            // 
            // buttonUpdateSession
            // 
            this.buttonUpdateSession.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(104)))));
            this.buttonUpdateSession.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonUpdateSession.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonUpdateSession.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdateSession.ForeColor = System.Drawing.Color.White;
            this.buttonUpdateSession.Location = new System.Drawing.Point(394, 619);
            this.buttonUpdateSession.Margin = new System.Windows.Forms.Padding(0);
            this.buttonUpdateSession.Name = "buttonUpdateSession";
            this.buttonUpdateSession.Size = new System.Drawing.Size(246, 41);
            this.buttonUpdateSession.TabIndex = 103;
            this.buttonUpdateSession.Text = "Update SessionDetails";
            this.buttonUpdateSession.UseVisualStyleBackColor = false;
            this.buttonUpdateSession.Click += new System.EventHandler(this.buttonUpdateSession_Click);
            // 
            // grouptxt
            // 
            this.grouptxt.AutoSize = true;
            this.grouptxt.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grouptxt.ForeColor = System.Drawing.Color.Black;
            this.grouptxt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.grouptxt.Location = new System.Drawing.Point(530, 435);
            this.grouptxt.Name = "grouptxt";
            this.grouptxt.Size = new System.Drawing.Size(35, 19);
            this.grouptxt.TabIndex = 105;
            this.grouptxt.Text = "text";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label5.Location = new System.Drawing.Point(450, 435);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 19);
            this.label5.TabIndex = 104;
            this.label5.Text = "Group  : ";
            // 
            // subGroupTxt
            // 
            this.subGroupTxt.AutoSize = true;
            this.subGroupTxt.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subGroupTxt.ForeColor = System.Drawing.Color.Black;
            this.subGroupTxt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.subGroupTxt.Location = new System.Drawing.Point(530, 462);
            this.subGroupTxt.Name = "subGroupTxt";
            this.subGroupTxt.Size = new System.Drawing.Size(35, 19);
            this.subGroupTxt.TabIndex = 107;
            this.subGroupTxt.Text = "text";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label7.Location = new System.Drawing.Point(419, 462);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 19);
            this.label7.TabIndex = 106;
            this.label7.Text = "Sub Group  : ";
            // 
            // AddLocationToSessionUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.subGroupTxt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.grouptxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonUpdateSession);
            this.Controls.Add(this.comboBoxRoom);
            this.Controls.Add(this.labelSessID);
            this.Controls.Add(this.labelTag);
            this.Controls.Add(this.labelSubject);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonAdded);
            this.Controls.Add(this.PanelBtnHorizontal);
            this.Controls.Add(this.buttonNotAdded);
            this.Controls.Add(this.buttonSearchView);
            this.Controls.Add(this.comboBoxGroup);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.comboBoxSubject);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.comboBoxLecturer);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.CountLabel);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DataGridSessions);
            this.Name = "AddLocationToSessionUC";
            this.Size = new System.Drawing.Size(1040, 720);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridSessions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSearchView;
        private System.Windows.Forms.ComboBox comboBoxGroup;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox comboBoxSubject;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox comboBoxLecturer;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label CountLabel;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DataGridSessions;
        private System.Windows.Forms.Button buttonNotAdded;
        private System.Windows.Forms.Panel PanelBtnHorizontal;
        private System.Windows.Forms.Button buttonAdded;
        private System.Windows.Forms.Label labelSessID;
        private System.Windows.Forms.Label labelTag;
        private System.Windows.Forms.Label labelSubject;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxRoom;
        private System.Windows.Forms.Button buttonUpdateSession;
        private System.Windows.Forms.Label grouptxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label subGroupTxt;
        private System.Windows.Forms.Label label7;
    }
}
