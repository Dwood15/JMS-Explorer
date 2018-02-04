namespace JMS_Explorer
{
    partial class JMSMergeTesting
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
            this.b_LBaseJMS = new System.Windows.Forms.Button();
            this.b_LAppendingJMS = new System.Windows.Forms.Button();
            this.b_MergeJMS = new System.Windows.Forms.Button();
            this.tb_MatName = new System.Windows.Forms.TextBox();
            this.nUD_Merge = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_Merge)).BeginInit();
            this.SuspendLayout();
            // 
            // b_LBaseJMS
            // 
            this.b_LBaseJMS.Location = new System.Drawing.Point(30, 6);
            this.b_LBaseJMS.Name = "b_LBaseJMS";
            this.b_LBaseJMS.Size = new System.Drawing.Size(150, 36);
            this.b_LBaseJMS.TabIndex = 0;
            this.b_LBaseJMS.Text = "LoadBaseJMS";
            this.b_LBaseJMS.UseVisualStyleBackColor = true;
            this.b_LBaseJMS.Click += new System.EventHandler(this.b_LBaseJMS_Click);
            // 
            // b_LAppendingJMS
            // 
            this.b_LAppendingJMS.Location = new System.Drawing.Point(30, 48);
            this.b_LAppendingJMS.Name = "b_LAppendingJMS";
            this.b_LAppendingJMS.Size = new System.Drawing.Size(150, 36);
            this.b_LAppendingJMS.TabIndex = 0;
            this.b_LAppendingJMS.Text = "Load Appending JMS";
            this.b_LAppendingJMS.UseVisualStyleBackColor = true;
            this.b_LAppendingJMS.Click += new System.EventHandler(this.b_LAppendingJMS_Click);
            // 
            // b_MergeJMS
            // 
            this.b_MergeJMS.Location = new System.Drawing.Point(30, 90);
            this.b_MergeJMS.Name = "b_MergeJMS";
            this.b_MergeJMS.Size = new System.Drawing.Size(150, 36);
            this.b_MergeJMS.TabIndex = 0;
            this.b_MergeJMS.Text = "Merge JMS files";
            this.b_MergeJMS.UseVisualStyleBackColor = true;
            this.b_MergeJMS.Click += new System.EventHandler(this.b_MergeJMS_Click);
            // 
            // tb_MatName
            // 
            this.tb_MatName.Location = new System.Drawing.Point(36, 132);
            this.tb_MatName.Name = "tb_MatName";
            this.tb_MatName.Size = new System.Drawing.Size(138, 20);
            this.tb_MatName.TabIndex = 1;
            // 
            // nUD_Merge
            // 
            this.nUD_Merge.Location = new System.Drawing.Point(192, 12);
            this.nUD_Merge.Name = "nUD_Merge";
            this.nUD_Merge.Size = new System.Drawing.Size(36, 20);
            this.nUD_Merge.TabIndex = 2;
            // 
            // JMSMergeTesting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(245, 174);
            this.Controls.Add(this.nUD_Merge);
            this.Controls.Add(this.tb_MatName);
            this.Controls.Add(this.b_MergeJMS);
            this.Controls.Add(this.b_LAppendingJMS);
            this.Controls.Add(this.b_LBaseJMS);
            this.Name = "JMSMergeTesting";
            this.Text = "JMSMergeTesting";
            ((System.ComponentModel.ISupportInitialize)(this.nUD_Merge)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button b_LBaseJMS;
        private System.Windows.Forms.Button b_LAppendingJMS;
        private System.Windows.Forms.Button b_MergeJMS;
        private System.Windows.Forms.TextBox tb_MatName;
        private System.Windows.Forms.NumericUpDown nUD_Merge;
    }
}