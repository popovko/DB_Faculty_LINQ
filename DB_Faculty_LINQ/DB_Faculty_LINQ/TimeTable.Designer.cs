namespace DB_Faculty_LINQ
{
    partial class TimeTable
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
            this.dgvtt = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtt)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvtt
            // 
            this.dgvtt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvtt.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvtt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvtt.Location = new System.Drawing.Point(12, 13);
            this.dgvtt.Name = "dgvtt";
            this.dgvtt.ReadOnly = true;
            this.dgvtt.RowHeadersWidth = 100;
            this.dgvtt.RowTemplate.Height = 50;
            this.dgvtt.RowTemplate.ReadOnly = true;
            this.dgvtt.Size = new System.Drawing.Size(776, 425);
            this.dgvtt.TabIndex = 0;
            // 
            // TimeTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvtt);
            this.Name = "TimeTable";
            this.Text = "Розклад";
            ((System.ComponentModel.ISupportInitialize)(this.dgvtt)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvtt;
    }
}