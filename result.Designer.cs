namespace CircusTrein
{
    partial class result
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
            this.total = new System.Windows.Forms.Label();
            this.totalC = new System.Windows.Forms.Label();
            this.containerBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // total
            // 
            this.total.AutoSize = true;
            this.total.Location = new System.Drawing.Point(13, 13);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(114, 17);
            this.total.TabIndex = 0;
            this.total.Text = "Total containers:";
            // 
            // totalC
            // 
            this.totalC.AutoSize = true;
            this.totalC.Location = new System.Drawing.Point(134, 13);
            this.totalC.Name = "totalC";
            this.totalC.Size = new System.Drawing.Size(16, 17);
            this.totalC.TabIndex = 1;
            this.totalC.Text = "0";
            // 
            // containerBox
            // 
            this.containerBox.FormattingEnabled = true;
            this.containerBox.ItemHeight = 16;
            this.containerBox.Location = new System.Drawing.Point(16, 44);
            this.containerBox.Name = "containerBox";
            this.containerBox.Size = new System.Drawing.Size(764, 388);
            this.containerBox.TabIndex = 4;
            // 
            // result
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.containerBox);
            this.Controls.Add(this.totalC);
            this.Controls.Add(this.total);
            this.Name = "result";
            this.Text = "result";
            this.Load += new System.EventHandler(this.result_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label total;
        private System.Windows.Forms.Label totalC;
        private System.Windows.Forms.ListBox containerBox;
    }
}