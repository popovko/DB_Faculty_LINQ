namespace DB_Faculty_LINQ
{
    partial class AddLesson
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.lblSb = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cbSb = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbDOW = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbLsNum = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbGr = new System.Windows.Forms.ComboBox();
            this.tbGr = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbTc = new System.Windows.Forms.ComboBox();
            this.tbTcAud = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnGrClean = new System.Windows.Forms.Button();
            this.btnTcAudClean = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(442, 451);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 19;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(281, 451);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 18;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // lblSb
            // 
            this.lblSb.AutoSize = true;
            this.lblSb.Location = new System.Drawing.Point(278, 34);
            this.lblSb.Name = "lblSb";
            this.lblSb.Size = new System.Drawing.Size(52, 13);
            this.lblSb.TabIndex = 15;
            this.lblSb.Text = "Предмет";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.Location = new System.Drawing.Point(253, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(295, 433);
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // cbSb
            // 
            this.cbSb.FormattingEnabled = true;
            this.cbSb.Location = new System.Drawing.Point(417, 31);
            this.cbSb.Name = "cbSb";
            this.cbSb.Size = new System.Drawing.Size(100, 21);
            this.cbSb.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(278, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "День тижня";
            // 
            // cbDOW
            // 
            this.cbDOW.FormattingEnabled = true;
            this.cbDOW.Location = new System.Drawing.Point(417, 72);
            this.cbDOW.Name = "cbDOW";
            this.cbDOW.Size = new System.Drawing.Size(100, 21);
            this.cbDOW.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(278, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Номер пари";
            // 
            // cbLsNum
            // 
            this.cbLsNum.FormattingEnabled = true;
            this.cbLsNum.Location = new System.Drawing.Point(417, 115);
            this.cbLsNum.Name = "cbLsNum";
            this.cbLsNum.Size = new System.Drawing.Size(100, 21);
            this.cbLsNum.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(278, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Група";
            // 
            // cbGr
            // 
            this.cbGr.FormattingEnabled = true;
            this.cbGr.Location = new System.Drawing.Point(417, 160);
            this.cbGr.Name = "cbGr";
            this.cbGr.Size = new System.Drawing.Size(100, 21);
            this.cbGr.TabIndex = 28;
            this.cbGr.SelectedIndexChanged += new System.EventHandler(this.cbGr_SelectedIndexChanged);
            // 
            // tbGr
            // 
            this.tbGr.Enabled = false;
            this.tbGr.Location = new System.Drawing.Point(281, 248);
            this.tbGr.Name = "tbGr";
            this.tbGr.Size = new System.Drawing.Size(236, 20);
            this.tbGr.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(278, 295);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Викладач + аудиторія";
            // 
            // cbTc
            // 
            this.cbTc.FormattingEnabled = true;
            this.cbTc.Location = new System.Drawing.Point(417, 292);
            this.cbTc.Name = "cbTc";
            this.cbTc.Size = new System.Drawing.Size(100, 21);
            this.cbTc.TabIndex = 31;
            this.cbTc.SelectedIndexChanged += new System.EventHandler(this.cbTc_SelectedIndexChanged);
            // 
            // tbTcAud
            // 
            this.tbTcAud.Location = new System.Drawing.Point(281, 408);
            this.tbTcAud.Name = "tbTcAud";
            this.tbTcAud.Size = new System.Drawing.Size(236, 20);
            this.tbTcAud.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(305, 337);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(186, 13);
            this.label5.TabIndex = 33;
            this.label5.Text = "Аудиторія вводиться вручну після +";
            // 
            // btnGrClean
            // 
            this.btnGrClean.Location = new System.Drawing.Point(281, 208);
            this.btnGrClean.Name = "btnGrClean";
            this.btnGrClean.Size = new System.Drawing.Size(75, 23);
            this.btnGrClean.TabIndex = 34;
            this.btnGrClean.Text = "Очистити";
            this.btnGrClean.UseVisualStyleBackColor = true;
            this.btnGrClean.Click += new System.EventHandler(this.btnGrClean_Click);
            // 
            // btnTcAudClean
            // 
            this.btnTcAudClean.Location = new System.Drawing.Point(281, 369);
            this.btnTcAudClean.Name = "btnTcAudClean";
            this.btnTcAudClean.Size = new System.Drawing.Size(75, 23);
            this.btnTcAudClean.TabIndex = 35;
            this.btnTcAudClean.Text = "Очистити";
            this.btnTcAudClean.UseVisualStyleBackColor = true;
            this.btnTcAudClean.Click += new System.EventHandler(this.btnTcAudClean_Click);
            // 
            // AddLesson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 486);
            this.Controls.Add(this.btnTcAudClean);
            this.Controls.Add(this.btnGrClean);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbTcAud);
            this.Controls.Add(this.cbTc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbGr);
            this.Controls.Add(this.cbGr);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbLsNum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbDOW);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbSb);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.lblSb);
            this.Controls.Add(this.pictureBox1);
            this.Name = "AddLesson";
            this.Text = "AddLesson";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label lblSb;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cbSb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbDOW;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbLsNum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbGr;
        private System.Windows.Forms.TextBox tbGr;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbTc;
        private System.Windows.Forms.TextBox tbTcAud;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnGrClean;
        private System.Windows.Forms.Button btnTcAudClean;
    }
}