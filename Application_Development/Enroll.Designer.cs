namespace Application_Development
{
    partial class Enroll
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
            this.dataGridReport = new System.Windows.Forms.DataGridView();
            this.dateReport = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridReport)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridReport
            // 
            this.dataGridReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridReport.Location = new System.Drawing.Point(246, 83);
            this.dataGridReport.Name = "dataGridReport";
            this.dataGridReport.Size = new System.Drawing.Size(327, 182);
            this.dataGridReport.TabIndex = 0;
            // 
            // dateReport
            // 
            this.dateReport.Location = new System.Drawing.Point(176, 24);
            this.dateReport.Name = "dateReport";
            this.dateReport.Size = new System.Drawing.Size(200, 20);
            this.dateReport.TabIndex = 1;
            // 
            // Enroll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dateReport);
            this.Controls.Add(this.dataGridReport);
            this.Name = "Enroll";
            this.Text = "Enroll";
            this.Load += new System.EventHandler(this.Enroll_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridReport)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridReport;
        private System.Windows.Forms.DateTimePicker dateReport;
    }
}