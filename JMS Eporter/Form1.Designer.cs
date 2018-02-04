namespace JMS_Eporter
{
    partial class Exporter
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
            this.tc_main = new System.Windows.Forms.TabControl();
            this.tp_Materials = new System.Windows.Forms.TabPage();
            this.tp_Regions = new System.Windows.Forms.TabPage();
            this.tp_Nodes = new System.Windows.Forms.TabPage();
            this.tp_Markers = new System.Windows.Forms.TabPage();
            this.tp_Vertices = new System.Windows.Forms.TabPage();
            this.tp_Faces = new System.Windows.Forms.TabPage();
            this.lb_materials = new System.Windows.Forms.ListBox();
            this.tc_main.SuspendLayout();
            this.tp_Materials.SuspendLayout();
            this.SuspendLayout();
            // 
            // tc_main
            // 
            this.tc_main.Controls.Add(this.tp_Materials);
            this.tc_main.Controls.Add(this.tp_Regions);
            this.tc_main.Controls.Add(this.tp_Nodes);
            this.tc_main.Controls.Add(this.tp_Markers);
            this.tc_main.Controls.Add(this.tp_Vertices);
            this.tc_main.Controls.Add(this.tp_Faces);
            this.tc_main.Location = new System.Drawing.Point(0, 0);
            this.tc_main.Name = "tc_main";
            this.tc_main.SelectedIndex = 0;
            this.tc_main.Size = new System.Drawing.Size(570, 360);
            this.tc_main.TabIndex = 0;
            // 
            // tp_Materials
            // 
            this.tp_Materials.Controls.Add(this.lb_materials);
            this.tp_Materials.Location = new System.Drawing.Point(4, 22);
            this.tp_Materials.Name = "tp_Materials";
            this.tp_Materials.Padding = new System.Windows.Forms.Padding(3);
            this.tp_Materials.Size = new System.Drawing.Size(562, 334);
            this.tp_Materials.TabIndex = 0;
            this.tp_Materials.Text = "Materials";
            this.tp_Materials.UseVisualStyleBackColor = true;
            // 
            // tp_Regions
            // 
            this.tp_Regions.Location = new System.Drawing.Point(4, 22);
            this.tp_Regions.Name = "tp_Regions";
            this.tp_Regions.Padding = new System.Windows.Forms.Padding(3);
            this.tp_Regions.Size = new System.Drawing.Size(562, 334);
            this.tp_Regions.TabIndex = 1;
            this.tp_Regions.Text = "Regions";
            this.tp_Regions.UseVisualStyleBackColor = true;
            // 
            // tp_Nodes
            // 
            this.tp_Nodes.Location = new System.Drawing.Point(4, 22);
            this.tp_Nodes.Name = "tp_Nodes";
            this.tp_Nodes.Size = new System.Drawing.Size(562, 334);
            this.tp_Nodes.TabIndex = 2;
            this.tp_Nodes.Text = "Nodes";
            this.tp_Nodes.UseVisualStyleBackColor = true;
            // 
            // tp_Markers
            // 
            this.tp_Markers.Location = new System.Drawing.Point(4, 22);
            this.tp_Markers.Name = "tp_Markers";
            this.tp_Markers.Size = new System.Drawing.Size(562, 334);
            this.tp_Markers.TabIndex = 3;
            this.tp_Markers.Text = "Markers";
            this.tp_Markers.UseVisualStyleBackColor = true;
            // 
            // tp_Vertices
            // 
            this.tp_Vertices.Location = new System.Drawing.Point(4, 22);
            this.tp_Vertices.Name = "tp_Vertices";
            this.tp_Vertices.Size = new System.Drawing.Size(562, 334);
            this.tp_Vertices.TabIndex = 4;
            this.tp_Vertices.Text = "Vertices";
            this.tp_Vertices.UseVisualStyleBackColor = true;
            // 
            // tp_Faces
            // 
            this.tp_Faces.Location = new System.Drawing.Point(4, 22);
            this.tp_Faces.Name = "tp_Faces";
            this.tp_Faces.Size = new System.Drawing.Size(562, 334);
            this.tp_Faces.TabIndex = 5;
            this.tp_Faces.Text = "Faces";
            this.tp_Faces.UseVisualStyleBackColor = true;
            // 
            // lb_materials
            // 
            this.lb_materials.FormattingEnabled = true;
            this.lb_materials.Location = new System.Drawing.Point(6, 6);
            this.lb_materials.Name = "lb_materials";
            this.lb_materials.Size = new System.Drawing.Size(96, 316);
            this.lb_materials.TabIndex = 0;
            // 
            // Exporter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 360);
            this.Controls.Add(this.tc_main);
            this.Name = "Exporter";
            this.Text = "JMS Exporter By Dwood";
            this.tc_main.ResumeLayout(false);
            this.tp_Materials.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tc_main;
        private System.Windows.Forms.TabPage tp_Materials;
        private System.Windows.Forms.TabPage tp_Regions;
        private System.Windows.Forms.ListBox lb_materials;
        private System.Windows.Forms.TabPage tp_Nodes;
        private System.Windows.Forms.TabPage tp_Markers;
        private System.Windows.Forms.TabPage tp_Vertices;
        private System.Windows.Forms.TabPage tp_Faces;
    }
}

