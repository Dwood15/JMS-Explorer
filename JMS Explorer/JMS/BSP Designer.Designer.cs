namespace JMS_Explorer
{
    partial class testBasicForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.lb_ConnectBy = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_AppendWith = new System.Windows.Forms.ComboBox();
            this.lb_AppendBy = new System.Windows.Forms.ListBox();
            this.tb_ModelBaseName = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Base Model";
            // 
            // lb_ConnectBy
            // 
            this.lb_ConnectBy.FormattingEnabled = true;
            this.lb_ConnectBy.Location = new System.Drawing.Point(132, 6);
            this.lb_ConnectBy.Name = "lb_ConnectBy";
            this.lb_ConnectBy.Size = new System.Drawing.Size(102, 108);
            this.lb_ConnectBy.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Model to append with";
            // 
            // cb_AppendWith
            // 
            this.cb_AppendWith.FormattingEnabled = true;
            this.cb_AppendWith.Location = new System.Drawing.Point(6, 102);
            this.cb_AppendWith.Name = "cb_AppendWith";
            this.cb_AppendWith.Size = new System.Drawing.Size(120, 21);
            this.cb_AppendWith.TabIndex = 4;
            this.cb_AppendWith.Text = "Select Item";
            // 
            // lb_AppendBy
            // 
            this.lb_AppendBy.FormattingEnabled = true;
            this.lb_AppendBy.Location = new System.Drawing.Point(6, 132);
            this.lb_AppendBy.Name = "lb_AppendBy";
            this.lb_AppendBy.Size = new System.Drawing.Size(114, 108);
            this.lb_AppendBy.TabIndex = 5;
            // 
            // tb_ModelBaseName
            // 
            this.tb_ModelBaseName.Enabled = false;
            this.tb_ModelBaseName.Location = new System.Drawing.Point(6, 36);
            this.tb_ModelBaseName.Name = "tb_ModelBaseName";
            this.tb_ModelBaseName.Size = new System.Drawing.Size(120, 20);
            this.tb_ModelBaseName.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(132, 120);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 24);
            this.button1.TabIndex = 8;
            this.button1.Text = "Load Collection";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(258, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(216, 240);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // testBasicForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 250);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tb_ModelBaseName);
            this.Controls.Add(this.lb_AppendBy);
            this.Controls.Add(this.cb_AppendWith);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lb_ConnectBy);
            this.Controls.Add(this.label1);
            this.Name = "testBasicForm";
            this.Text = "testBasicForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lb_ConnectBy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_AppendWith;
        private System.Windows.Forms.ListBox lb_AppendBy;
        private System.Windows.Forms.TextBox tb_ModelBaseName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;




    }
}