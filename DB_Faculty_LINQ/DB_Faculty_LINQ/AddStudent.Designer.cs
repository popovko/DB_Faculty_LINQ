namespace DB_Faculty_LINQ
{
    partial class AddStudent
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
            this.cbStGroup = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.tbStName = new System.Windows.Forms.TextBox();
            this.lblStdGroup = new System.Windows.Forms.Label();
            this.lblStndName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbStGroup
            // 
            this.cbStGroup.FormattingEnabled = true;
            this.cbStGroup.Location = new System.Drawing.Point(417, 204);
            this.cbStGroup.Name = "cbStGroup";
            this.cbStGroup.Size = new System.Drawing.Size(100, 21);
            this.cbStGroup.TabIndex = 14;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(442, 295);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(281, 295);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 11;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // tbStName
            // 
            this.tbStName.Location = new System.Drawing.Point(417, 151);
            this.tbStName.Name = "tbStName";
            this.tbStName.Size = new System.Drawing.Size(100, 20);
            this.tbStName.TabIndex = 10;
            // 
            // lblStdGroup
            // 
            this.lblStdGroup.AutoSize = true;
            this.lblStdGroup.Location = new System.Drawing.Point(278, 212);
            this.lblStdGroup.Name = "lblStdGroup";
            this.lblStdGroup.Size = new System.Drawing.Size(36, 13);
            this.lblStdGroup.TabIndex = 9;
            this.lblStdGroup.Text = "Група";
            // 
            // lblStndName
            // 
            this.lblStndName.AutoSize = true;
            this.lblStndName.Location = new System.Drawing.Point(278, 151);
            this.lblStndName.Name = "lblStndName";
            this.lblStndName.Size = new System.Drawing.Size(74, 13);
            this.lblStndName.TabIndex = 8;
            this.lblStndName.Text = "Ім\'я студента";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.Location = new System.Drawing.Point(253, 132);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(295, 121);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // AddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbStGroup);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.tbStName);
            this.Controls.Add(this.lblStdGroup);
            this.Controls.Add(this.lblStndName);
            this.Controls.Add(this.pictureBox1);
            this.Name = "AddStudent";
            this.Text = "AddStudent";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbStGroup;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.TextBox tbStName;
        private System.Windows.Forms.Label lblStdGroup;
        private System.Windows.Forms.Label lblStndName;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}