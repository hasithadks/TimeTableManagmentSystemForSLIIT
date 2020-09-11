namespace TimeTableManagementSystemApp.IT18049114.UserControllers
{
    partial class Tags
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
            this.label2 = new System.Windows.Forms.Label();
            this.tagname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.shName = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.addedittagbut = new System.Windows.Forms.Button();
            this.tagDeleteBut = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(477, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 21);
            this.label1.TabIndex = 19;
            this.label1.Text = "Tags";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(177, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 21);
            this.label2.TabIndex = 20;
            this.label2.Text = "Tag Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // tagname
            // 
            this.tagname.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tagname.Location = new System.Drawing.Point(274, 146);
            this.tagname.Name = "tagname";
            this.tagname.Size = new System.Drawing.Size(147, 27);
            this.tagname.TabIndex = 21;
            this.tagname.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(437, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 21);
            this.label3.TabIndex = 22;
            this.label3.Text = "Short Name";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // shName
            // 
            this.shName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shName.Location = new System.Drawing.Point(542, 146);
            this.shName.Name = "shName";
            this.shName.Size = new System.Drawing.Size(147, 27);
            this.shName.TabIndex = 23;
            this.shName.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(178, 229);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(643, 300);
            this.dataGridView1.TabIndex = 26;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // addedittagbut
            // 
            this.addedittagbut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(104)))));
            this.addedittagbut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addedittagbut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addedittagbut.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addedittagbut.ForeColor = System.Drawing.Color.White;
            this.addedittagbut.Location = new System.Drawing.Point(698, 143);
            this.addedittagbut.Name = "addedittagbut";
            this.addedittagbut.Size = new System.Drawing.Size(123, 31);
            this.addedittagbut.TabIndex = 29;
            this.addedittagbut.Text = "Add / Edit";
            this.addedittagbut.UseVisualStyleBackColor = false;
            this.addedittagbut.Click += new System.EventHandler(this.addedittagbut_Click);
            // 
            // tagDeleteBut
            // 
            this.tagDeleteBut.BackColor = System.Drawing.Color.Red;
            this.tagDeleteBut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tagDeleteBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tagDeleteBut.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tagDeleteBut.ForeColor = System.Drawing.Color.White;
            this.tagDeleteBut.Location = new System.Drawing.Point(698, 546);
            this.tagDeleteBut.Name = "tagDeleteBut";
            this.tagDeleteBut.Size = new System.Drawing.Size(123, 31);
            this.tagDeleteBut.TabIndex = 30;
            this.tagDeleteBut.Text = "Delete";
            this.tagDeleteBut.UseVisualStyleBackColor = false;
            this.tagDeleteBut.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Tags
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tagDeleteBut);
            this.Controls.Add(this.addedittagbut);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.shName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tagname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Tags";
            this.Size = new System.Drawing.Size(1025, 700);
            this.Load += new System.EventHandler(this.Tags_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tagname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox shName;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button addedittagbut;
        private System.Windows.Forms.Button tagDeleteBut;
    }
}
