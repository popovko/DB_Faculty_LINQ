namespace DB_Faculty_LINQ
{
    partial class AddGroup
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
            this.cbGrYear = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.tbGrName = new System.Windows.Forms.TextBox();
            this.lblGrYear = new System.Windows.Forms.Label();
            this.lblGrName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbCurator = new System.Windows.Forms.ComboBox();
            this.tbCurators = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbDp = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbGrYear
            // 
            this.cbGrYear.FormattingEnabled = true;
            this.cbGrYear.Location = new System.Drawing.Point(493, 89);
            this.cbGrYear.Name = "cbGrYear";
            this.cbGrYear.Size = new System.Drawing.Size(100, 21);
            this.cbGrYear.TabIndex = 40;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(454, 334);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 36;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(281, 334);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 35;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // tbGrName
            // 
            this.tbGrName.Location = new System.Drawing.Point(493, 45);
            this.tbGrName.Name = "tbGrName";
            this.tbGrName.Size = new System.Drawing.Size(100, 20);
            this.tbGrName.TabIndex = 34;
            // 
            // lblGrYear
            // 
            this.lblGrYear.AutoSize = true;
            this.lblGrYear.Location = new System.Drawing.Point(223, 92);
            this.lblGrYear.Name = "lblGrYear";
            this.lblGrYear.Size = new System.Drawing.Size(31, 13);
            this.lblGrYear.TabIndex = 33;
            this.lblGrYear.Text = "Курс";
            // 
            // lblGrName
            // 
            this.lblGrName.AutoSize = true;
            this.lblGrName.Location = new System.Drawing.Point(223, 52);
            this.lblGrName.Name = "lblGrName";
            this.lblGrName.Size = new System.Drawing.Size(70, 13);
            this.lblGrName.TabIndex = 32;
            this.lblGrName.Text = "Назва групи";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.Location = new System.Drawing.Point(186, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(447, 305);
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(223, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 41;
            this.label1.Text = "Куратор";
            // 
            // cbCurator
            // 
            this.cbCurator.FormattingEnabled = true;
            this.cbCurator.Location = new System.Drawing.Point(493, 195);
            this.cbCurator.Name = "cbCurator";
            this.cbCurator.Size = new System.Drawing.Size(100, 21);
            this.cbCurator.TabIndex = 42;
            this.cbCurator.SelectedIndexChanged += new System.EventHandler(this.cbCurator_SelectedIndexChanged);
            // 
            // tbCurators
            // 
            this.tbCurators.Enabled = false;
            this.tbCurators.Location = new System.Drawing.Point(226, 255);
            this.tbCurators.Name = "tbCurators";
            this.tbCurators.Size = new System.Drawing.Size(367, 20);
            this.tbCurators.TabIndex = 43;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(223, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 44;
            this.label2.Text = "Кафедра";
            // 
            // cbDp
            // 
            this.cbDp.FormattingEnabled = true;
            this.cbDp.Location = new System.Drawing.Point(493, 142);
            this.cbDp.Name = "cbDp";
            this.cbDp.Size = new System.Drawing.Size(100, 21);
            this.cbDp.TabIndex = 45;
            // 
            // AddGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbDp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbCurators);
            this.Controls.Add(this.cbCurator);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbGrYear);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.tbGrName);
            this.Controls.Add(this.lblGrYear);
            this.Controls.Add(this.lblGrName);
            this.Controls.Add(this.pictureBox1);
            this.Name = "AddGroup";
            this.Text = "AddGroup";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbGrYear;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.TextBox tbGrName;
        private System.Windows.Forms.Label lblGrYear;
        private System.Windows.Forms.Label lblGrName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbCurator;
        private System.Windows.Forms.TextBox tbCurators;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbDp;
    }
}