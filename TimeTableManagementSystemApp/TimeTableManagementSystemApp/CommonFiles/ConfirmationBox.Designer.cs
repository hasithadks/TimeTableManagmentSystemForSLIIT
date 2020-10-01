namespace TimeTableManagementSystemApp.CommonFiles
{
    partial class ConfirmationBox
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cancelBtn2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.closeBtn = new System.Windows.Forms.PictureBox();
            this.maxBtn = new System.Windows.Forms.PictureBox();
            this.miniBtn = new System.Windows.Forms.PictureBox();
            this.TitleSuccessMsg = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SuccessMsg = new System.Windows.Forms.Label();
            this.buttonOk = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.miniBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cancelBtn2
            // 
            this.cancelBtn2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(104)))));
            this.cancelBtn2.FlatAppearance.BorderSize = 0;
            this.cancelBtn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelBtn2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBtn2.ForeColor = System.Drawing.Color.White;
            this.cancelBtn2.Location = new System.Drawing.Point(440, 204);
            this.cancelBtn2.Margin = new System.Windows.Forms.Padding(2);
            this.cancelBtn2.Name = "cancelBtn2";
            this.cancelBtn2.Size = new System.Drawing.Size(111, 29);
            this.cancelBtn2.TabIndex = 279;
            this.cancelBtn2.Text = "Cancel";
            this.cancelBtn2.UseVisualStyleBackColor = false;
            this.cancelBtn2.Click += new System.EventHandler(this.cancelBtn2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(104)))));
            this.panel1.Controls.Add(this.closeBtn);
            this.panel1.Controls.Add(this.maxBtn);
            this.panel1.Controls.Add(this.miniBtn);
            this.panel1.Controls.Add(this.TitleSuccessMsg);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(566, 48);
            this.panel1.TabIndex = 278;
            // 
            // closeBtn
            // 
            this.closeBtn.Image = global::TimeTableManagementSystemApp.Properties.Resources.closebtn;
            this.closeBtn.Location = new System.Drawing.Point(518, 10);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(38, 28);
            this.closeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.closeBtn.TabIndex = 7;
            this.closeBtn.TabStop = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // maxBtn
            // 
            this.maxBtn.Image = global::TimeTableManagementSystemApp.Properties.Resources.Maxibtn;
            this.maxBtn.Location = new System.Drawing.Point(973, 7);
            this.maxBtn.Name = "maxBtn";
            this.maxBtn.Size = new System.Drawing.Size(35, 25);
            this.maxBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.maxBtn.TabIndex = 5;
            this.maxBtn.TabStop = false;
            // 
            // miniBtn
            // 
            this.miniBtn.Image = global::TimeTableManagementSystemApp.Properties.Resources.minibtn;
            this.miniBtn.Location = new System.Drawing.Point(932, 6);
            this.miniBtn.Name = "miniBtn";
            this.miniBtn.Size = new System.Drawing.Size(35, 25);
            this.miniBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.miniBtn.TabIndex = 4;
            this.miniBtn.TabStop = false;
            // 
            // TitleSuccessMsg
            // 
            this.TitleSuccessMsg.AutoSize = true;
            this.TitleSuccessMsg.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleSuccessMsg.ForeColor = System.Drawing.Color.White;
            this.TitleSuccessMsg.Location = new System.Drawing.Point(10, 11);
            this.TitleSuccessMsg.Name = "TitleSuccessMsg";
            this.TitleSuccessMsg.Size = new System.Drawing.Size(46, 23);
            this.TitleSuccessMsg.TabIndex = 3;
            this.TitleSuccessMsg.Text = "Title";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TimeTableManagementSystemApp.Properties.Resources.closebtn;
            this.pictureBox1.Location = new System.Drawing.Point(1014, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // SuccessMsg
            // 
            this.SuccessMsg.AutoSize = true;
            this.SuccessMsg.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SuccessMsg.Location = new System.Drawing.Point(12, 103);
            this.SuccessMsg.Name = "SuccessMsg";
            this.SuccessMsg.Size = new System.Drawing.Size(79, 21);
            this.SuccessMsg.TabIndex = 277;
            this.SuccessMsg.Text = "Message";
            this.SuccessMsg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonOk
            // 
            this.buttonOk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(104)))));
            this.buttonOk.FlatAppearance.BorderSize = 0;
            this.buttonOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOk.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOk.ForeColor = System.Drawing.Color.White;
            this.buttonOk.Location = new System.Drawing.Point(325, 204);
            this.buttonOk.Margin = new System.Windows.Forms.Padding(2);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(111, 29);
            this.buttonOk.TabIndex = 280;
            this.buttonOk.Text = "Ok";
            this.buttonOk.UseVisualStyleBackColor = false;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // ConfirmationBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(562, 244);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.cancelBtn2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.SuccessMsg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConfirmationBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConfirmationBox";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.miniBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelBtn2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox closeBtn;
        private System.Windows.Forms.PictureBox maxBtn;
        private System.Windows.Forms.PictureBox miniBtn;
        private System.Windows.Forms.Label TitleSuccessMsg;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label SuccessMsg;
        private System.Windows.Forms.Button buttonOk;
    }
}