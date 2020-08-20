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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Tagsname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShortName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Action = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addedittagbut = new System.Windows.Forms.Button();
            this.editstdpagebut = new System.Windows.Forms.Button();
            this.deletestdbut = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(476, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 33);
            this.label1.TabIndex = 19;
            this.label1.Text = "Tags";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(174, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "Tag Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(262, 142);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(147, 20);
            this.textBox1.TabIndex = 21;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(415, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "Short Name";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(515, 142);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(147, 20);
            this.textBox2.TabIndex = 23;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Tagsname,
            this.ShortName,
            this.Action});
            this.dataGridView1.Location = new System.Drawing.Point(190, 229);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(643, 111);
            this.dataGridView1.TabIndex = 26;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Tagsname
            // 
            this.Tagsname.HeaderText = "Tags";
            this.Tagsname.Name = "Tagsname";
            this.Tagsname.ReadOnly = true;
            this.Tagsname.Width = 200;
            // 
            // ShortName
            // 
            this.ShortName.HeaderText = "Short Name";
            this.ShortName.Name = "ShortName";
            this.ShortName.ReadOnly = true;
            this.ShortName.Width = 200;
            // 
            // Action
            // 
            this.Action.HeaderText = "Action";
            this.Action.Name = "Action";
            this.Action.ReadOnly = true;
            this.Action.Width = 200;
            // 
            // addedittagbut
            // 
            this.addedittagbut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(104)))));
            this.addedittagbut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addedittagbut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addedittagbut.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addedittagbut.ForeColor = System.Drawing.Color.White;
            this.addedittagbut.Location = new System.Drawing.Point(701, 136);
            this.addedittagbut.Name = "addedittagbut";
            this.addedittagbut.Size = new System.Drawing.Size(123, 31);
            this.addedittagbut.TabIndex = 29;
            this.addedittagbut.Text = "Add / Edit";
            this.addedittagbut.UseVisualStyleBackColor = false;
            // 
            // editstdpagebut
            // 
            this.editstdpagebut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(104)))));
            this.editstdpagebut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editstdpagebut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editstdpagebut.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editstdpagebut.ForeColor = System.Drawing.Color.White;
            this.editstdpagebut.Location = new System.Drawing.Point(665, 250);
            this.editstdpagebut.Name = "editstdpagebut";
            this.editstdpagebut.Size = new System.Drawing.Size(55, 21);
            this.editstdpagebut.TabIndex = 30;
            this.editstdpagebut.Text = "Edit";
            this.editstdpagebut.UseVisualStyleBackColor = false;
            // 
            // deletestdbut
            // 
            this.deletestdbut.BackColor = System.Drawing.Color.Red;
            this.deletestdbut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deletestdbut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deletestdbut.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletestdbut.ForeColor = System.Drawing.Color.White;
            this.deletestdbut.Location = new System.Drawing.Point(758, 250);
            this.deletestdbut.Name = "deletestdbut";
            this.deletestdbut.Size = new System.Drawing.Size(55, 21);
            this.deletestdbut.TabIndex = 31;
            this.deletestdbut.Text = "Delete";
            this.deletestdbut.UseVisualStyleBackColor = false;
            // 
            // Tags
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.deletestdbut);
            this.Controls.Add(this.editstdpagebut);
            this.Controls.Add(this.addedittagbut);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tagsname;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShortName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Action;
        private System.Windows.Forms.Button addedittagbut;
        private System.Windows.Forms.Button editstdpagebut;
        private System.Windows.Forms.Button deletestdbut;
    }
}
