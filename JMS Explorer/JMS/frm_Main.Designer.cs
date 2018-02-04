//using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Windows.Forms;
using _JMS;

namespace JMS_Explorer
{
//    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class frm_Main : Form //: ToolSharp.FadeGradientForm
    {
        _JMS.JMS _jms = new _JMS.JMS();
       

        private System.ComponentModel.IContainer components;
        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing && (components != null))
        //    {
        //        components.Dispose();
              
        //    }
        //    base.Dispose(disposing);
        //}

        

        
        //NOTE: The following procedure is required by the Windows Form Designer
        //It can be modified using the Windows Form Designer.  
        //Do not modify it using the code editor.
       // [System.Diagnostics.DebuggerStepThrough()]
        public bool viewer = false;
        private void InitializeComponent()
        {
            this.lb_materials = new System.Windows.Forms.ListBox();
            this.lb_nodes = new System.Windows.Forms.ListBox();
            this.btn_load = new System.Windows.Forms.Button();
            this.lb_markers = new System.Windows.Forms.ListBox();
            this.lb_verts = new System.Windows.Forms.ListBox();
            this.lb_faces = new System.Windows.Forms.ListBox();
            this.tb_markers = new System.Windows.Forms.TextBox();
            this.tb_verts = new System.Windows.Forms.TextBox();
            this.tb_faces = new System.Windows.Forms.TextBox();
            this.lb_region = new System.Windows.Forms.ListBox();
            this.tb_regions = new System.Windows.Forms.TextBox();
            this.tc_main = new System.Windows.Forms.TabControl();
            this.tp_materials = new System.Windows.Forms.TabPage();
            this.tb_materials = new System.Windows.Forms.TextBox();
            this.label54 = new System.Windows.Forms.Label();
            this.label53 = new System.Windows.Forms.Label();
            this.btn_mattAdd = new System.Windows.Forms.Button();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.tb_materialPath = new System.Windows.Forms.TextBox();
            this.Label9 = new System.Windows.Forms.Label();
            this.tb_materialName = new System.Windows.Forms.TextBox();
            this.Label8 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.tp_regions = new System.Windows.Forms.TabPage();
            this.Label11 = new System.Windows.Forms.Label();
            this.tb_RegionName = new System.Windows.Forms.TextBox();
            this.Label10 = new System.Windows.Forms.Label();
            this.tp_nodes = new System.Windows.Forms.TabPage();
            this.tb_nodes = new System.Windows.Forms.TextBox();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.GroupBox4 = new System.Windows.Forms.GroupBox();
            this.tb_node_translation_z = new System.Windows.Forms.TextBox();
            this.Label19 = new System.Windows.Forms.Label();
            this.tb_node_translation_y = new System.Windows.Forms.TextBox();
            this.Label20 = new System.Windows.Forms.Label();
            this.tb_node_translation_x = new System.Windows.Forms.TextBox();
            this.Label21 = new System.Windows.Forms.Label();
            this.GroupBox3 = new System.Windows.Forms.GroupBox();
            this.tb_node_rotation_w = new System.Windows.Forms.TextBox();
            this.Label17 = new System.Windows.Forms.Label();
            this.tb_node_rotation_z = new System.Windows.Forms.TextBox();
            this.Label16 = new System.Windows.Forms.Label();
            this.tb_node_rotation_y = new System.Windows.Forms.TextBox();
            this.Label15 = new System.Windows.Forms.Label();
            this.tb_node_rotation_x = new System.Windows.Forms.TextBox();
            this.Label14 = new System.Windows.Forms.Label();
            this.tb_node_sibling_index = new System.Windows.Forms.TextBox();
            this.Label13 = new System.Windows.Forms.Label();
            this.tb_node_childIndex = new System.Windows.Forms.TextBox();
            this.Label12 = new System.Windows.Forms.Label();
            this.tb_nodeName = new System.Windows.Forms.TextBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.tp_markers = new System.Windows.Forms.TabPage();
            this.GroupBox5 = new System.Windows.Forms.GroupBox();
            this.GroupBox6 = new System.Windows.Forms.GroupBox();
            this.tb_markers_translation_z = new System.Windows.Forms.TextBox();
            this.Label23 = new System.Windows.Forms.Label();
            this.tb_markers_translation_y = new System.Windows.Forms.TextBox();
            this.Label24 = new System.Windows.Forms.Label();
            this.tb_markers_translation_x = new System.Windows.Forms.TextBox();
            this.Label25 = new System.Windows.Forms.Label();
            this.GroupBox7 = new System.Windows.Forms.GroupBox();
            this.tb_markers_rotation_w = new System.Windows.Forms.TextBox();
            this.Label26 = new System.Windows.Forms.Label();
            this.tb_markers_rotation_z = new System.Windows.Forms.TextBox();
            this.Label27 = new System.Windows.Forms.Label();
            this.tb_markers_rotation_y = new System.Windows.Forms.TextBox();
            this.Label28 = new System.Windows.Forms.Label();
            this.tb_markers_rotation_x = new System.Windows.Forms.TextBox();
            this.Label29 = new System.Windows.Forms.Label();
            this.tb_markers_parent_index = new System.Windows.Forms.TextBox();
            this.Label22 = new System.Windows.Forms.Label();
            this.Label18 = new System.Windows.Forms.Label();
            this.tb_marker_name = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.tp_vertice = new System.Windows.Forms.TabPage();
            this.tb_selVertbyInd = new System.Windows.Forms.TextBox();
            this.label52 = new System.Windows.Forms.Label();
            this.selectVertButton = new System.Windows.Forms.Button();
            this.GroupBox8 = new System.Windows.Forms.GroupBox();
            this.tb_verts_one_weight = new System.Windows.Forms.TextBox();
            this.tb_vert_ty = new System.Windows.Forms.TextBox();
            this.Label39 = new System.Windows.Forms.Label();
            this.tb_vert_tx = new System.Windows.Forms.TextBox();
            this.Label38 = new System.Windows.Forms.Label();
            this.Label37 = new System.Windows.Forms.Label();
            this.tb_verts_one_index = new System.Windows.Forms.TextBox();
            this.Label36 = new System.Windows.Forms.Label();
            this.GroupBox10 = new System.Windows.Forms.GroupBox();
            this.tb_vert_normal_z = new System.Windows.Forms.TextBox();
            this.Label33 = new System.Windows.Forms.Label();
            this.tb_vert_normal_y = new System.Windows.Forms.TextBox();
            this.Label34 = new System.Windows.Forms.Label();
            this.tb_vert_normal_x = new System.Windows.Forms.TextBox();
            this.Label35 = new System.Windows.Forms.Label();
            this.GroupBox9 = new System.Windows.Forms.GroupBox();
            this.tb_vert_position_z = new System.Windows.Forms.TextBox();
            this.Label30 = new System.Windows.Forms.Label();
            this.tb_vert_position_y = new System.Windows.Forms.TextBox();
            this.Label31 = new System.Windows.Forms.Label();
            this.tb_vert_position_x = new System.Windows.Forms.TextBox();
            this.Label32 = new System.Windows.Forms.Label();
            this.tb_verts_zero_index = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.cb_RecurseVerts = new System.Windows.Forms.CheckBox();
            this.groupBox15 = new System.Windows.Forms.GroupBox();
            this.label49 = new System.Windows.Forms.Label();
            this.label50 = new System.Windows.Forms.Label();
            this.label51 = new System.Windows.Forms.Label();
            this.tb_normResZ = new System.Windows.Forms.TextBox();
            this.tb_normResY = new System.Windows.Forms.TextBox();
            this.tb_normResX = new System.Windows.Forms.TextBox();
            this.groupBox14 = new System.Windows.Forms.GroupBox();
            this.label48 = new System.Windows.Forms.Label();
            this.label47 = new System.Windows.Forms.Label();
            this.label46 = new System.Windows.Forms.Label();
            this.tb_resultZ = new System.Windows.Forms.TextBox();
            this.tb_resultY = new System.Windows.Forms.TextBox();
            this.tb_resultX = new System.Windows.Forms.TextBox();
            this.lb_vertResults = new System.Windows.Forms.ListBox();
            this.searchVerts_b = new System.Windows.Forms.Button();
            this.cb_vertAxis = new System.Windows.Forms.ComboBox();
            this.stb_verts = new System.Windows.Forms.TextBox();
            this.tp_face = new System.Windows.Forms.TabPage();
            this.b_TestOptimize = new System.Windows.Forms.Button();
            this.GroupBox11 = new System.Windows.Forms.GroupBox();
            this.groupBox16 = new System.Windows.Forms.GroupBox();
            this.cb_sfacesRecurse = new System.Windows.Forms.CheckBox();
            this.cb_sfaces = new System.Windows.Forms.ComboBox();
            this.tb_sfaces = new System.Windows.Forms.TextBox();
            this.b_sfaces = new System.Windows.Forms.Button();
            this.lb_sfaces = new System.Windows.Forms.ListBox();
            this.GroupBox12 = new System.Windows.Forms.GroupBox();
            this.tb_face_vert_z = new System.Windows.Forms.TextBox();
            this.Label45 = new System.Windows.Forms.Label();
            this.tb_face_vert_y = new System.Windows.Forms.TextBox();
            this.Label44 = new System.Windows.Forms.Label();
            this.tb_face_vert_x = new System.Windows.Forms.TextBox();
            this.Label43 = new System.Windows.Forms.Label();
            this.lb_faces_verts = new System.Windows.Forms.ListBox();
            this.Label42 = new System.Windows.Forms.Label();
            this.tb_face_shader = new System.Windows.Forms.TextBox();
            this.Label41 = new System.Windows.Forms.Label();
            this.tb_face_region = new System.Windows.Forms.TextBox();
            this.Label40 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.saveJMS = new System.Windows.Forms.Button();
            this.tc_main.SuspendLayout();
            this.tp_materials.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            this.tp_regions.SuspendLayout();
            this.tp_nodes.SuspendLayout();
            this.GroupBox2.SuspendLayout();
            this.GroupBox4.SuspendLayout();
            this.GroupBox3.SuspendLayout();
            this.tp_markers.SuspendLayout();
            this.GroupBox5.SuspendLayout();
            this.GroupBox6.SuspendLayout();
            this.GroupBox7.SuspendLayout();
            this.tp_vertice.SuspendLayout();
            this.GroupBox8.SuspendLayout();
            this.GroupBox10.SuspendLayout();
            this.GroupBox9.SuspendLayout();
            this.groupBox13.SuspendLayout();
            this.groupBox15.SuspendLayout();
            this.groupBox14.SuspendLayout();
            this.tp_face.SuspendLayout();
            this.GroupBox11.SuspendLayout();
            this.groupBox16.SuspendLayout();
            this.GroupBox12.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_materials
            // 
            this.lb_materials.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.lb_materials.FormattingEnabled = true;
            this.lb_materials.Location = new System.Drawing.Point(3, 3);
            this.lb_materials.Name = "lb_materials";
            this.lb_materials.Size = new System.Drawing.Size(120, 212);
            this.lb_materials.TabIndex = 1;
            this.lb_materials.SelectedIndexChanged += new System.EventHandler(this.lb_materials_SelectedIndexChanged);
            // 
            // lb_nodes
            // 
            this.lb_nodes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.lb_nodes.FormattingEnabled = true;
            this.lb_nodes.Location = new System.Drawing.Point(3, 3);
            this.lb_nodes.Name = "lb_nodes";
            this.lb_nodes.Size = new System.Drawing.Size(120, 303);
            this.lb_nodes.TabIndex = 1;
            this.lb_nodes.SelectedIndexChanged += new System.EventHandler(this.lb_nodes_SelectedIndexChanged);
            // 
            // btn_load
            // 
            this.btn_load.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_load.Location = new System.Drawing.Point(585, 4);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(75, 23);
            this.btn_load.TabIndex = 2;
            this.btn_load.Text = "Load";
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // lb_markers
            // 
            this.lb_markers.Location = new System.Drawing.Point(0, 0);
            this.lb_markers.Name = "lb_markers";
            this.lb_markers.Size = new System.Drawing.Size(120, 186);
            this.lb_markers.TabIndex = 6;
            this.lb_markers.SelectedIndexChanged += new System.EventHandler(this.lb_markers_SelectedIndexChanged);
            // 
            // lb_verts
            // 
            this.lb_verts.Location = new System.Drawing.Point(6, 6);
            this.lb_verts.Name = "lb_verts";
            this.lb_verts.Size = new System.Drawing.Size(120, 290);
            this.lb_verts.TabIndex = 12;
            this.lb_verts.SelectedIndexChanged += new System.EventHandler(this.lb_verts_SelectedIndexChanged);
            // 
            // lb_faces
            // 
            this.lb_faces.Location = new System.Drawing.Point(6, 6);
            this.lb_faces.Name = "lb_faces";
            this.lb_faces.Size = new System.Drawing.Size(108, 212);
            this.lb_faces.TabIndex = 6;
            this.lb_faces.SelectedIndexChanged += new System.EventHandler(this.lb_faces_SelectedIndexChanged);
            // 
            // tb_markers
            // 
            this.tb_markers.Location = new System.Drawing.Point(210, 11);
            this.tb_markers.Name = "tb_markers";
            this.tb_markers.Size = new System.Drawing.Size(120, 22);
            this.tb_markers.TabIndex = 3;
            // 
            // tb_verts
            // 
            this.tb_verts.Location = new System.Drawing.Point(230, 9);
            this.tb_verts.Name = "tb_verts";
            this.tb_verts.Size = new System.Drawing.Size(120, 22);
            this.tb_verts.TabIndex = 3;
            // 
            // tb_faces
            // 
            this.tb_faces.Location = new System.Drawing.Point(201, 14);
            this.tb_faces.Name = "tb_faces";
            this.tb_faces.Size = new System.Drawing.Size(120, 22);
            this.tb_faces.TabIndex = 3;
            // 
            // lb_region
            // 
            this.lb_region.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.lb_region.FormattingEnabled = true;
            this.lb_region.Location = new System.Drawing.Point(3, 3);
            this.lb_region.Name = "lb_region";
            this.lb_region.Size = new System.Drawing.Size(120, 290);
            this.lb_region.TabIndex = 1;
            this.lb_region.SelectedIndexChanged += new System.EventHandler(this.lb_region_SelectedIndexChanged);
            // 
            // tb_regions
            // 
            this.tb_regions.Location = new System.Drawing.Point(211, 10);
            this.tb_regions.Name = "tb_regions";
            this.tb_regions.Size = new System.Drawing.Size(120, 22);
            this.tb_regions.TabIndex = 3;
            // 
            // tc_main
            // 
            this.tc_main.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tc_main.Controls.Add(this.tp_materials);
            this.tc_main.Controls.Add(this.tp_regions);
            this.tc_main.Controls.Add(this.tp_nodes);
            this.tc_main.Controls.Add(this.tp_markers);
            this.tc_main.Controls.Add(this.tp_vertice);
            this.tc_main.Controls.Add(this.tp_face);
            this.tc_main.Enabled = false;
            this.tc_main.Location = new System.Drawing.Point(0, 12);
            this.tc_main.Name = "tc_main";
            this.tc_main.SelectedIndex = 0;
            this.tc_main.Size = new System.Drawing.Size(672, 346);
            this.tc_main.TabIndex = 4;
            // 
            // tp_materials
            // 
            this.tp_materials.Controls.Add(this.tb_materials);
            this.tp_materials.Controls.Add(this.label54);
            this.tp_materials.Controls.Add(this.label53);
            this.tp_materials.Controls.Add(this.btn_mattAdd);
            this.tp_materials.Controls.Add(this.GroupBox1);
            this.tp_materials.Controls.Add(this.Label7);
            this.tp_materials.Controls.Add(this.lb_materials);
            this.tp_materials.Location = new System.Drawing.Point(4, 22);
            this.tp_materials.Name = "tp_materials";
            this.tp_materials.Size = new System.Drawing.Size(664, 320);
            this.tp_materials.TabIndex = 0;
            this.tp_materials.Text = "MaterialList";
            this.tp_materials.UseVisualStyleBackColor = true;
            // 
            // tb_materials
            // 
            this.tb_materials.Location = new System.Drawing.Point(216, 6);
            this.tb_materials.Name = "tb_materials";
            this.tb_materials.Size = new System.Drawing.Size(114, 22);
            this.tb_materials.TabIndex = 10;
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Location = new System.Drawing.Point(246, 132);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(362, 13);
            this.label54.TabIndex = 8;
            this.label54.Text = "Name is the name of the shader, with any symbols you wish to attach";
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Location = new System.Drawing.Point(240, 114);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(358, 13);
            this.label53.TabIndex = 7;
            this.label53.Text = "Note: you don\'t need to specify a path, set it as <none> in that case";
            // 
            // btn_mattAdd
            // 
            this.btn_mattAdd.Location = new System.Drawing.Point(132, 114);
            this.btn_mattAdd.Name = "btn_mattAdd";
            this.btn_mattAdd.Size = new System.Drawing.Size(102, 30);
            this.btn_mattAdd.TabIndex = 6;
            this.btn_mattAdd.Text = "Add Material";
            this.btn_mattAdd.UseVisualStyleBackColor = true;
            this.btn_mattAdd.Click += new System.EventHandler(this.btn_mattAdd_Click);
            // 
            // GroupBox1
            // 
            this.GroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupBox1.Controls.Add(this.tb_materialPath);
            this.GroupBox1.Controls.Add(this.Label9);
            this.GroupBox1.Controls.Add(this.tb_materialName);
            this.GroupBox1.Controls.Add(this.Label8);
            this.GroupBox1.Location = new System.Drawing.Point(129, 34);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(502, 75);
            this.GroupBox1.TabIndex = 5;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Material Properties";
            // 
            // tb_materialPath
            // 
            this.tb_materialPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_materialPath.Location = new System.Drawing.Point(50, 45);
            this.tb_materialPath.Name = "tb_materialPath";
            this.tb_materialPath.Size = new System.Drawing.Size(446, 22);
            this.tb_materialPath.TabIndex = 8;
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Location = new System.Drawing.Point(10, 48);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(33, 13);
            this.Label9.TabIndex = 7;
            this.Label9.Text = "Path:";
            // 
            // tb_materialName
            // 
            this.tb_materialName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_materialName.Location = new System.Drawing.Point(50, 19);
            this.tb_materialName.Name = "tb_materialName";
            this.tb_materialName.Size = new System.Drawing.Size(446, 22);
            this.tb_materialName.TabIndex = 6;
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Location = new System.Drawing.Point(6, 22);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(39, 13);
            this.Label8.TabIndex = 0;
            this.Label8.Text = "Name:";
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Location = new System.Drawing.Point(129, 11);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(85, 13);
            this.Label7.TabIndex = 4;
            this.Label7.Text = "Total Materials:";
            // 
            // tp_regions
            // 
            this.tp_regions.Controls.Add(this.Label11);
            this.tp_regions.Controls.Add(this.tb_RegionName);
            this.tp_regions.Controls.Add(this.Label10);
            this.tp_regions.Controls.Add(this.lb_region);
            this.tp_regions.Controls.Add(this.tb_regions);
            this.tp_regions.Location = new System.Drawing.Point(4, 22);
            this.tp_regions.Name = "tp_regions";
            this.tp_regions.Size = new System.Drawing.Size(664, 320);
            this.tp_regions.TabIndex = 1;
            this.tp_regions.Text = "Regions";
            this.tp_regions.UseVisualStyleBackColor = true;
            // 
            // Label11
            // 
            this.Label11.AutoSize = true;
            this.Label11.Location = new System.Drawing.Point(129, 39);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(79, 13);
            this.Label11.TabIndex = 6;
            this.Label11.Text = "Region Name:";
            // 
            // tb_RegionName
            // 
            this.tb_RegionName.Location = new System.Drawing.Point(211, 36);
            this.tb_RegionName.Name = "tb_RegionName";
            this.tb_RegionName.Size = new System.Drawing.Size(120, 22);
            this.tb_RegionName.TabIndex = 5;
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Location = new System.Drawing.Point(129, 13);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(80, 13);
            this.Label10.TabIndex = 4;
            this.Label10.Text = "Total Regions:";
            // 
            // tp_nodes
            // 
            this.tp_nodes.Controls.Add(this.tb_nodes);
            this.tp_nodes.Controls.Add(this.GroupBox2);
            this.tp_nodes.Controls.Add(this.Label1);
            this.tp_nodes.Controls.Add(this.lb_nodes);
            this.tp_nodes.Location = new System.Drawing.Point(4, 22);
            this.tp_nodes.Name = "tp_nodes";
            this.tp_nodes.Size = new System.Drawing.Size(664, 320);
            this.tp_nodes.TabIndex = 2;
            this.tp_nodes.Text = "Nodes";
            this.tp_nodes.UseVisualStyleBackColor = true;
            // 
            // tb_nodes
            // 
            this.tb_nodes.Location = new System.Drawing.Point(204, 12);
            this.tb_nodes.Name = "tb_nodes";
            this.tb_nodes.Size = new System.Drawing.Size(108, 22);
            this.tb_nodes.TabIndex = 6;
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.GroupBox4);
            this.GroupBox2.Controls.Add(this.GroupBox3);
            this.GroupBox2.Controls.Add(this.tb_node_sibling_index);
            this.GroupBox2.Controls.Add(this.Label13);
            this.GroupBox2.Controls.Add(this.tb_node_childIndex);
            this.GroupBox2.Controls.Add(this.Label12);
            this.GroupBox2.Controls.Add(this.tb_nodeName);
            this.GroupBox2.Controls.Add(this.Label6);
            this.GroupBox2.Location = new System.Drawing.Point(129, 38);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(499, 177);
            this.GroupBox2.TabIndex = 5;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "Node Properties";
            // 
            // GroupBox4
            // 
            this.GroupBox4.Controls.Add(this.tb_node_translation_z);
            this.GroupBox4.Controls.Add(this.Label19);
            this.GroupBox4.Controls.Add(this.tb_node_translation_y);
            this.GroupBox4.Controls.Add(this.Label20);
            this.GroupBox4.Controls.Add(this.tb_node_translation_x);
            this.GroupBox4.Controls.Add(this.Label21);
            this.GroupBox4.Location = new System.Drawing.Point(351, 10);
            this.GroupBox4.Name = "GroupBox4";
            this.GroupBox4.Size = new System.Drawing.Size(140, 126);
            this.GroupBox4.TabIndex = 6;
            this.GroupBox4.TabStop = false;
            this.GroupBox4.Text = "Translation";
            // 
            // tb_node_translation_z
            // 
            this.tb_node_translation_z.Location = new System.Drawing.Point(29, 71);
            this.tb_node_translation_z.Name = "tb_node_translation_z";
            this.tb_node_translation_z.Size = new System.Drawing.Size(100, 22);
            this.tb_node_translation_z.TabIndex = 1;
            // 
            // Label19
            // 
            this.Label19.AutoSize = true;
            this.Label19.Location = new System.Drawing.Point(6, 74);
            this.Label19.Name = "Label19";
            this.Label19.Size = new System.Drawing.Size(16, 13);
            this.Label19.TabIndex = 0;
            this.Label19.Text = "Z:";
            // 
            // tb_node_translation_y
            // 
            this.tb_node_translation_y.Location = new System.Drawing.Point(29, 45);
            this.tb_node_translation_y.Name = "tb_node_translation_y";
            this.tb_node_translation_y.Size = new System.Drawing.Size(100, 22);
            this.tb_node_translation_y.TabIndex = 1;
            // 
            // Label20
            // 
            this.Label20.AutoSize = true;
            this.Label20.Location = new System.Drawing.Point(6, 48);
            this.Label20.Name = "Label20";
            this.Label20.Size = new System.Drawing.Size(15, 13);
            this.Label20.TabIndex = 0;
            this.Label20.Text = "Y:";
            // 
            // tb_node_translation_x
            // 
            this.tb_node_translation_x.Location = new System.Drawing.Point(29, 19);
            this.tb_node_translation_x.Name = "tb_node_translation_x";
            this.tb_node_translation_x.Size = new System.Drawing.Size(100, 22);
            this.tb_node_translation_x.TabIndex = 1;
            // 
            // Label21
            // 
            this.Label21.AutoSize = true;
            this.Label21.Location = new System.Drawing.Point(6, 22);
            this.Label21.Name = "Label21";
            this.Label21.Size = new System.Drawing.Size(16, 13);
            this.Label21.TabIndex = 0;
            this.Label21.Text = "X:";
            // 
            // GroupBox3
            // 
            this.GroupBox3.Controls.Add(this.tb_node_rotation_w);
            this.GroupBox3.Controls.Add(this.Label17);
            this.GroupBox3.Controls.Add(this.tb_node_rotation_z);
            this.GroupBox3.Controls.Add(this.Label16);
            this.GroupBox3.Controls.Add(this.tb_node_rotation_y);
            this.GroupBox3.Controls.Add(this.Label15);
            this.GroupBox3.Controls.Add(this.tb_node_rotation_x);
            this.GroupBox3.Controls.Add(this.Label14);
            this.GroupBox3.Location = new System.Drawing.Point(205, 10);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Size = new System.Drawing.Size(140, 126);
            this.GroupBox3.TabIndex = 6;
            this.GroupBox3.TabStop = false;
            this.GroupBox3.Text = "Rotation";
            // 
            // tb_node_rotation_w
            // 
            this.tb_node_rotation_w.Location = new System.Drawing.Point(29, 97);
            this.tb_node_rotation_w.Name = "tb_node_rotation_w";
            this.tb_node_rotation_w.Size = new System.Drawing.Size(100, 22);
            this.tb_node_rotation_w.TabIndex = 1;
            // 
            // Label17
            // 
            this.Label17.AutoSize = true;
            this.Label17.Location = new System.Drawing.Point(6, 100);
            this.Label17.Name = "Label17";
            this.Label17.Size = new System.Drawing.Size(21, 13);
            this.Label17.TabIndex = 0;
            this.Label17.Text = "W:";
            // 
            // tb_node_rotation_z
            // 
            this.tb_node_rotation_z.Location = new System.Drawing.Point(29, 71);
            this.tb_node_rotation_z.Name = "tb_node_rotation_z";
            this.tb_node_rotation_z.Size = new System.Drawing.Size(100, 22);
            this.tb_node_rotation_z.TabIndex = 1;
            // 
            // Label16
            // 
            this.Label16.AutoSize = true;
            this.Label16.Location = new System.Drawing.Point(6, 74);
            this.Label16.Name = "Label16";
            this.Label16.Size = new System.Drawing.Size(16, 13);
            this.Label16.TabIndex = 0;
            this.Label16.Text = "Z:";
            // 
            // tb_node_rotation_y
            // 
            this.tb_node_rotation_y.Location = new System.Drawing.Point(29, 45);
            this.tb_node_rotation_y.Name = "tb_node_rotation_y";
            this.tb_node_rotation_y.Size = new System.Drawing.Size(100, 22);
            this.tb_node_rotation_y.TabIndex = 1;
            // 
            // Label15
            // 
            this.Label15.AutoSize = true;
            this.Label15.Location = new System.Drawing.Point(6, 48);
            this.Label15.Name = "Label15";
            this.Label15.Size = new System.Drawing.Size(15, 13);
            this.Label15.TabIndex = 0;
            this.Label15.Text = "Y:";
            // 
            // tb_node_rotation_x
            // 
            this.tb_node_rotation_x.Location = new System.Drawing.Point(29, 19);
            this.tb_node_rotation_x.Name = "tb_node_rotation_x";
            this.tb_node_rotation_x.Size = new System.Drawing.Size(100, 22);
            this.tb_node_rotation_x.TabIndex = 1;
            // 
            // Label14
            // 
            this.Label14.AutoSize = true;
            this.Label14.Location = new System.Drawing.Point(6, 22);
            this.Label14.Name = "Label14";
            this.Label14.Size = new System.Drawing.Size(16, 13);
            this.Label14.TabIndex = 0;
            this.Label14.Text = "X:";
            // 
            // tb_node_sibling_index
            // 
            this.tb_node_sibling_index.Location = new System.Drawing.Point(112, 71);
            this.tb_node_sibling_index.Name = "tb_node_sibling_index";
            this.tb_node_sibling_index.Size = new System.Drawing.Size(82, 22);
            this.tb_node_sibling_index.TabIndex = 5;
            // 
            // Label13
            // 
            this.Label13.AutoSize = true;
            this.Label13.Location = new System.Drawing.Point(11, 74);
            this.Label13.Name = "Label13";
            this.Label13.Size = new System.Drawing.Size(103, 13);
            this.Label13.TabIndex = 4;
            this.Label13.Text = "Next Sibling Index:";
            // 
            // tb_node_childIndex
            // 
            this.tb_node_childIndex.Location = new System.Drawing.Point(79, 45);
            this.tb_node_childIndex.Name = "tb_node_childIndex";
            this.tb_node_childIndex.Size = new System.Drawing.Size(115, 22);
            this.tb_node_childIndex.TabIndex = 3;
            // 
            // Label12
            // 
            this.Label12.AutoSize = true;
            this.Label12.Location = new System.Drawing.Point(11, 48);
            this.Label12.Name = "Label12";
            this.Label12.Size = new System.Drawing.Size(68, 13);
            this.Label12.TabIndex = 2;
            this.Label12.Text = "Child Index:";
            // 
            // tb_nodeName
            // 
            this.tb_nodeName.Location = new System.Drawing.Point(79, 19);
            this.tb_nodeName.Name = "tb_nodeName";
            this.tb_nodeName.Size = new System.Drawing.Size(115, 22);
            this.tb_nodeName.TabIndex = 1;
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(6, 22);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(70, 13);
            this.Label6.TabIndex = 0;
            this.Label6.Text = "Node Name:";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(129, 15);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(71, 13);
            this.Label1.TabIndex = 4;
            this.Label1.Text = "Total Nodes:";
            // 
            // tp_markers
            // 
            this.tp_markers.Controls.Add(this.GroupBox5);
            this.tp_markers.Controls.Add(this.Label2);
            this.tp_markers.Controls.Add(this.lb_markers);
            this.tp_markers.Controls.Add(this.tb_markers);
            this.tp_markers.Location = new System.Drawing.Point(4, 22);
            this.tp_markers.Name = "tp_markers";
            this.tp_markers.Size = new System.Drawing.Size(664, 320);
            this.tp_markers.TabIndex = 3;
            this.tp_markers.Text = "Markers";
            this.tp_markers.UseVisualStyleBackColor = true;
            // 
            // GroupBox5
            // 
            this.GroupBox5.Controls.Add(this.GroupBox6);
            this.GroupBox5.Controls.Add(this.GroupBox7);
            this.GroupBox5.Controls.Add(this.tb_markers_parent_index);
            this.GroupBox5.Controls.Add(this.Label22);
            this.GroupBox5.Controls.Add(this.Label18);
            this.GroupBox5.Controls.Add(this.tb_marker_name);
            this.GroupBox5.Location = new System.Drawing.Point(129, 37);
            this.GroupBox5.Name = "GroupBox5";
            this.GroupBox5.Size = new System.Drawing.Size(498, 146);
            this.GroupBox5.TabIndex = 5;
            this.GroupBox5.TabStop = false;
            this.GroupBox5.Text = "Marker Properties";
            // 
            // GroupBox6
            // 
            this.GroupBox6.Controls.Add(this.tb_markers_translation_z);
            this.GroupBox6.Controls.Add(this.Label23);
            this.GroupBox6.Controls.Add(this.tb_markers_translation_y);
            this.GroupBox6.Controls.Add(this.Label24);
            this.GroupBox6.Controls.Add(this.tb_markers_translation_x);
            this.GroupBox6.Controls.Add(this.Label25);
            this.GroupBox6.Location = new System.Drawing.Point(350, 10);
            this.GroupBox6.Name = "GroupBox6";
            this.GroupBox6.Size = new System.Drawing.Size(140, 126);
            this.GroupBox6.TabIndex = 8;
            this.GroupBox6.TabStop = false;
            this.GroupBox6.Text = "Translation";
            // 
            // tb_markers_translation_z
            // 
            this.tb_markers_translation_z.Location = new System.Drawing.Point(29, 71);
            this.tb_markers_translation_z.Name = "tb_markers_translation_z";
            this.tb_markers_translation_z.Size = new System.Drawing.Size(100, 22);
            this.tb_markers_translation_z.TabIndex = 1;
            // 
            // Label23
            // 
            this.Label23.AutoSize = true;
            this.Label23.Location = new System.Drawing.Point(6, 74);
            this.Label23.Name = "Label23";
            this.Label23.Size = new System.Drawing.Size(16, 13);
            this.Label23.TabIndex = 0;
            this.Label23.Text = "Z:";
            // 
            // tb_markers_translation_y
            // 
            this.tb_markers_translation_y.Location = new System.Drawing.Point(29, 45);
            this.tb_markers_translation_y.Name = "tb_markers_translation_y";
            this.tb_markers_translation_y.Size = new System.Drawing.Size(100, 22);
            this.tb_markers_translation_y.TabIndex = 1;
            // 
            // Label24
            // 
            this.Label24.AutoSize = true;
            this.Label24.Location = new System.Drawing.Point(6, 48);
            this.Label24.Name = "Label24";
            this.Label24.Size = new System.Drawing.Size(15, 13);
            this.Label24.TabIndex = 0;
            this.Label24.Text = "Y:";
            // 
            // tb_markers_translation_x
            // 
            this.tb_markers_translation_x.Location = new System.Drawing.Point(29, 19);
            this.tb_markers_translation_x.Name = "tb_markers_translation_x";
            this.tb_markers_translation_x.Size = new System.Drawing.Size(100, 22);
            this.tb_markers_translation_x.TabIndex = 1;
            // 
            // Label25
            // 
            this.Label25.AutoSize = true;
            this.Label25.Location = new System.Drawing.Point(6, 22);
            this.Label25.Name = "Label25";
            this.Label25.Size = new System.Drawing.Size(16, 13);
            this.Label25.TabIndex = 0;
            this.Label25.Text = "X:";
            // 
            // GroupBox7
            // 
            this.GroupBox7.Controls.Add(this.tb_markers_rotation_w);
            this.GroupBox7.Controls.Add(this.Label26);
            this.GroupBox7.Controls.Add(this.tb_markers_rotation_z);
            this.GroupBox7.Controls.Add(this.Label27);
            this.GroupBox7.Controls.Add(this.tb_markers_rotation_y);
            this.GroupBox7.Controls.Add(this.Label28);
            this.GroupBox7.Controls.Add(this.tb_markers_rotation_x);
            this.GroupBox7.Controls.Add(this.Label29);
            this.GroupBox7.Location = new System.Drawing.Point(204, 10);
            this.GroupBox7.Name = "GroupBox7";
            this.GroupBox7.Size = new System.Drawing.Size(140, 126);
            this.GroupBox7.TabIndex = 7;
            this.GroupBox7.TabStop = false;
            this.GroupBox7.Text = "Rotation";
            // 
            // tb_markers_rotation_w
            // 
            this.tb_markers_rotation_w.Location = new System.Drawing.Point(29, 97);
            this.tb_markers_rotation_w.Name = "tb_markers_rotation_w";
            this.tb_markers_rotation_w.Size = new System.Drawing.Size(100, 22);
            this.tb_markers_rotation_w.TabIndex = 1;
            // 
            // Label26
            // 
            this.Label26.AutoSize = true;
            this.Label26.Location = new System.Drawing.Point(6, 100);
            this.Label26.Name = "Label26";
            this.Label26.Size = new System.Drawing.Size(21, 13);
            this.Label26.TabIndex = 0;
            this.Label26.Text = "W:";
            // 
            // tb_markers_rotation_z
            // 
            this.tb_markers_rotation_z.Location = new System.Drawing.Point(29, 71);
            this.tb_markers_rotation_z.Name = "tb_markers_rotation_z";
            this.tb_markers_rotation_z.Size = new System.Drawing.Size(100, 22);
            this.tb_markers_rotation_z.TabIndex = 1;
            // 
            // Label27
            // 
            this.Label27.AutoSize = true;
            this.Label27.Location = new System.Drawing.Point(6, 74);
            this.Label27.Name = "Label27";
            this.Label27.Size = new System.Drawing.Size(16, 13);
            this.Label27.TabIndex = 0;
            this.Label27.Text = "Z:";
            // 
            // tb_markers_rotation_y
            // 
            this.tb_markers_rotation_y.Location = new System.Drawing.Point(29, 45);
            this.tb_markers_rotation_y.Name = "tb_markers_rotation_y";
            this.tb_markers_rotation_y.Size = new System.Drawing.Size(100, 22);
            this.tb_markers_rotation_y.TabIndex = 1;
            // 
            // Label28
            // 
            this.Label28.AutoSize = true;
            this.Label28.Location = new System.Drawing.Point(6, 48);
            this.Label28.Name = "Label28";
            this.Label28.Size = new System.Drawing.Size(15, 13);
            this.Label28.TabIndex = 0;
            this.Label28.Text = "Y:";
            // 
            // tb_markers_rotation_x
            // 
            this.tb_markers_rotation_x.Location = new System.Drawing.Point(29, 19);
            this.tb_markers_rotation_x.Name = "tb_markers_rotation_x";
            this.tb_markers_rotation_x.Size = new System.Drawing.Size(100, 22);
            this.tb_markers_rotation_x.TabIndex = 1;
            // 
            // Label29
            // 
            this.Label29.AutoSize = true;
            this.Label29.Location = new System.Drawing.Point(6, 22);
            this.Label29.Name = "Label29";
            this.Label29.Size = new System.Drawing.Size(16, 13);
            this.Label29.TabIndex = 0;
            this.Label29.Text = "X:";
            // 
            // tb_markers_parent_index
            // 
            this.tb_markers_parent_index.Location = new System.Drawing.Point(87, 45);
            this.tb_markers_parent_index.Name = "tb_markers_parent_index";
            this.tb_markers_parent_index.Size = new System.Drawing.Size(111, 22);
            this.tb_markers_parent_index.TabIndex = 3;
            // 
            // Label22
            // 
            this.Label22.AutoSize = true;
            this.Label22.Location = new System.Drawing.Point(11, 48);
            this.Label22.Name = "Label22";
            this.Label22.Size = new System.Drawing.Size(74, 13);
            this.Label22.TabIndex = 2;
            this.Label22.Text = "Parent Index:";
            // 
            // Label18
            // 
            this.Label18.AutoSize = true;
            this.Label18.Location = new System.Drawing.Point(7, 22);
            this.Label18.Name = "Label18";
            this.Label18.Size = new System.Drawing.Size(78, 13);
            this.Label18.TabIndex = 1;
            this.Label18.Text = "Marker Name:";
            // 
            // tb_marker_name
            // 
            this.tb_marker_name.Location = new System.Drawing.Point(87, 19);
            this.tb_marker_name.Name = "tb_marker_name";
            this.tb_marker_name.Size = new System.Drawing.Size(111, 22);
            this.tb_marker_name.TabIndex = 0;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(129, 14);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(79, 13);
            this.Label2.TabIndex = 4;
            this.Label2.Text = "Total Markers:";
            // 
            // tp_vertice
            // 
            this.tp_vertice.Controls.Add(this.tb_selVertbyInd);
            this.tp_vertice.Controls.Add(this.label52);
            this.tp_vertice.Controls.Add(this.selectVertButton);
            this.tp_vertice.Controls.Add(this.GroupBox8);
            this.tp_vertice.Controls.Add(this.Label3);
            this.tp_vertice.Controls.Add(this.lb_verts);
            this.tp_vertice.Controls.Add(this.tb_verts);
            this.tp_vertice.Controls.Add(this.groupBox13);
            this.tp_vertice.Location = new System.Drawing.Point(4, 22);
            this.tp_vertice.Name = "tp_vertice";
            this.tp_vertice.Size = new System.Drawing.Size(664, 320);
            this.tp_vertice.TabIndex = 4;
            this.tp_vertice.Text = "Vertices";
            this.tp_vertice.UseVisualStyleBackColor = true;
            // 
            // tb_selVertbyInd
            // 
            this.tb_selVertbyInd.Location = new System.Drawing.Point(475, 9);
            this.tb_selVertbyInd.Name = "tb_selVertbyInd";
            this.tb_selVertbyInd.Size = new System.Drawing.Size(75, 22);
            this.tb_selVertbyInd.TabIndex = 11;
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Location = new System.Drawing.Point(356, 9);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(108, 13);
            this.label52.TabIndex = 10;
            this.label52.Text = "Select vert by index:";
            // 
            // selectVertButton
            // 
            this.selectVertButton.Location = new System.Drawing.Point(561, 8);
            this.selectVertButton.Name = "selectVertButton";
            this.selectVertButton.Size = new System.Drawing.Size(75, 23);
            this.selectVertButton.TabIndex = 9;
            this.selectVertButton.Text = "Select";
            this.selectVertButton.UseVisualStyleBackColor = true;
            this.selectVertButton.Click += new System.EventHandler(this.selectVertButton_Click);
            // 
            // GroupBox8
            // 
            this.GroupBox8.Controls.Add(this.tb_verts_one_weight);
            this.GroupBox8.Controls.Add(this.tb_vert_ty);
            this.GroupBox8.Controls.Add(this.Label39);
            this.GroupBox8.Controls.Add(this.tb_vert_tx);
            this.GroupBox8.Controls.Add(this.Label38);
            this.GroupBox8.Controls.Add(this.Label37);
            this.GroupBox8.Controls.Add(this.tb_verts_one_index);
            this.GroupBox8.Controls.Add(this.Label36);
            this.GroupBox8.Controls.Add(this.GroupBox10);
            this.GroupBox8.Controls.Add(this.GroupBox9);
            this.GroupBox8.Controls.Add(this.tb_verts_zero_index);
            this.GroupBox8.Controls.Add(this.Label5);
            this.GroupBox8.Location = new System.Drawing.Point(130, 38);
            this.GroupBox8.Name = "GroupBox8";
            this.GroupBox8.Size = new System.Drawing.Size(501, 158);
            this.GroupBox8.TabIndex = 6;
            this.GroupBox8.TabStop = false;
            this.GroupBox8.Text = "Vertice Properties";
            // 
            // tb_verts_one_weight
            // 
            this.tb_verts_one_weight.Location = new System.Drawing.Point(395, 45);
            this.tb_verts_one_weight.Name = "tb_verts_one_weight";
            this.tb_verts_one_weight.Size = new System.Drawing.Size(100, 22);
            this.tb_verts_one_weight.TabIndex = 12;
            // 
            // tb_vert_ty
            // 
            this.tb_vert_ty.Location = new System.Drawing.Point(395, 116);
            this.tb_vert_ty.Name = "tb_vert_ty";
            this.tb_vert_ty.Size = new System.Drawing.Size(100, 22);
            this.tb_vert_ty.TabIndex = 15;
            // 
            // Label39
            // 
            this.Label39.AutoSize = true;
            this.Label39.Location = new System.Drawing.Point(340, 119);
            this.Label39.Name = "Label39";
            this.Label39.Size = new System.Drawing.Size(48, 13);
            this.Label39.TabIndex = 14;
            this.Label39.Text = "T-Vert Y:";
            // 
            // tb_vert_tx
            // 
            this.tb_vert_tx.Location = new System.Drawing.Point(395, 90);
            this.tb_vert_tx.Name = "tb_vert_tx";
            this.tb_vert_tx.Size = new System.Drawing.Size(100, 22);
            this.tb_vert_tx.TabIndex = 15;
            // 
            // Label38
            // 
            this.Label38.AutoSize = true;
            this.Label38.Location = new System.Drawing.Point(340, 93);
            this.Label38.Name = "Label38";
            this.Label38.Size = new System.Drawing.Size(49, 13);
            this.Label38.TabIndex = 14;
            this.Label38.Text = "T-Vert X:";
            // 
            // Label37
            // 
            this.Label37.AutoSize = true;
            this.Label37.Location = new System.Drawing.Point(293, 48);
            this.Label37.Name = "Label37";
            this.Label37.Size = new System.Drawing.Size(104, 13);
            this.Label37.TabIndex = 13;
            this.Label37.Text = "Node One Weight:";
            // 
            // tb_verts_one_index
            // 
            this.tb_verts_one_index.Location = new System.Drawing.Point(395, 19);
            this.tb_verts_one_index.Name = "tb_verts_one_index";
            this.tb_verts_one_index.Size = new System.Drawing.Size(100, 22);
            this.tb_verts_one_index.TabIndex = 11;
            // 
            // Label36
            // 
            this.Label36.AutoSize = true;
            this.Label36.Location = new System.Drawing.Point(301, 22);
            this.Label36.Name = "Label36";
            this.Label36.Size = new System.Drawing.Size(94, 13);
            this.Label36.TabIndex = 10;
            this.Label36.Text = "Node One Index:";
            // 
            // GroupBox10
            // 
            this.GroupBox10.Controls.Add(this.tb_vert_normal_z);
            this.GroupBox10.Controls.Add(this.Label33);
            this.GroupBox10.Controls.Add(this.tb_vert_normal_y);
            this.GroupBox10.Controls.Add(this.Label34);
            this.GroupBox10.Controls.Add(this.tb_vert_normal_x);
            this.GroupBox10.Controls.Add(this.Label35);
            this.GroupBox10.Location = new System.Drawing.Point(153, 45);
            this.GroupBox10.Name = "GroupBox10";
            this.GroupBox10.Size = new System.Drawing.Size(140, 103);
            this.GroupBox10.TabIndex = 9;
            this.GroupBox10.TabStop = false;
            this.GroupBox10.Text = "Normal";
            // 
            // tb_vert_normal_z
            // 
            this.tb_vert_normal_z.Location = new System.Drawing.Point(29, 71);
            this.tb_vert_normal_z.Name = "tb_vert_normal_z";
            this.tb_vert_normal_z.Size = new System.Drawing.Size(100, 22);
            this.tb_vert_normal_z.TabIndex = 1;
            // 
            // Label33
            // 
            this.Label33.AutoSize = true;
            this.Label33.Location = new System.Drawing.Point(6, 74);
            this.Label33.Name = "Label33";
            this.Label33.Size = new System.Drawing.Size(16, 13);
            this.Label33.TabIndex = 0;
            this.Label33.Text = "Z:";
            // 
            // tb_vert_normal_y
            // 
            this.tb_vert_normal_y.Location = new System.Drawing.Point(29, 45);
            this.tb_vert_normal_y.Name = "tb_vert_normal_y";
            this.tb_vert_normal_y.Size = new System.Drawing.Size(100, 22);
            this.tb_vert_normal_y.TabIndex = 1;
            // 
            // Label34
            // 
            this.Label34.AutoSize = true;
            this.Label34.Location = new System.Drawing.Point(6, 48);
            this.Label34.Name = "Label34";
            this.Label34.Size = new System.Drawing.Size(15, 13);
            this.Label34.TabIndex = 0;
            this.Label34.Text = "Y:";
            // 
            // tb_vert_normal_x
            // 
            this.tb_vert_normal_x.Location = new System.Drawing.Point(29, 19);
            this.tb_vert_normal_x.Name = "tb_vert_normal_x";
            this.tb_vert_normal_x.Size = new System.Drawing.Size(100, 22);
            this.tb_vert_normal_x.TabIndex = 1;
            // 
            // Label35
            // 
            this.Label35.AutoSize = true;
            this.Label35.Location = new System.Drawing.Point(6, 22);
            this.Label35.Name = "Label35";
            this.Label35.Size = new System.Drawing.Size(16, 13);
            this.Label35.TabIndex = 0;
            this.Label35.Text = "X:";
            // 
            // GroupBox9
            // 
            this.GroupBox9.Controls.Add(this.tb_vert_position_z);
            this.GroupBox9.Controls.Add(this.Label30);
            this.GroupBox9.Controls.Add(this.tb_vert_position_y);
            this.GroupBox9.Controls.Add(this.Label31);
            this.GroupBox9.Controls.Add(this.tb_vert_position_x);
            this.GroupBox9.Controls.Add(this.Label32);
            this.GroupBox9.Location = new System.Drawing.Point(7, 45);
            this.GroupBox9.Name = "GroupBox9";
            this.GroupBox9.Size = new System.Drawing.Size(140, 103);
            this.GroupBox9.TabIndex = 9;
            this.GroupBox9.TabStop = false;
            this.GroupBox9.Text = "Position";
            // 
            // tb_vert_position_z
            // 
            this.tb_vert_position_z.Location = new System.Drawing.Point(29, 71);
            this.tb_vert_position_z.Name = "tb_vert_position_z";
            this.tb_vert_position_z.Size = new System.Drawing.Size(100, 22);
            this.tb_vert_position_z.TabIndex = 1;
            // 
            // Label30
            // 
            this.Label30.AutoSize = true;
            this.Label30.Location = new System.Drawing.Point(6, 74);
            this.Label30.Name = "Label30";
            this.Label30.Size = new System.Drawing.Size(16, 13);
            this.Label30.TabIndex = 0;
            this.Label30.Text = "Z:";
            // 
            // tb_vert_position_y
            // 
            this.tb_vert_position_y.Location = new System.Drawing.Point(29, 45);
            this.tb_vert_position_y.Name = "tb_vert_position_y";
            this.tb_vert_position_y.Size = new System.Drawing.Size(100, 22);
            this.tb_vert_position_y.TabIndex = 1;
            // 
            // Label31
            // 
            this.Label31.AutoSize = true;
            this.Label31.Location = new System.Drawing.Point(6, 48);
            this.Label31.Name = "Label31";
            this.Label31.Size = new System.Drawing.Size(15, 13);
            this.Label31.TabIndex = 0;
            this.Label31.Text = "Y:";
            // 
            // tb_vert_position_x
            // 
            this.tb_vert_position_x.Location = new System.Drawing.Point(29, 19);
            this.tb_vert_position_x.Name = "tb_vert_position_x";
            this.tb_vert_position_x.Size = new System.Drawing.Size(100, 22);
            this.tb_vert_position_x.TabIndex = 1;
            // 
            // Label32
            // 
            this.Label32.AutoSize = true;
            this.Label32.Location = new System.Drawing.Point(6, 22);
            this.Label32.Name = "Label32";
            this.Label32.Size = new System.Drawing.Size(16, 13);
            this.Label32.TabIndex = 0;
            this.Label32.Text = "X:";
            // 
            // tb_verts_zero_index
            // 
            this.tb_verts_zero_index.Location = new System.Drawing.Point(100, 19);
            this.tb_verts_zero_index.Name = "tb_verts_zero_index";
            this.tb_verts_zero_index.Size = new System.Drawing.Size(120, 22);
            this.tb_verts_zero_index.TabIndex = 6;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(4, 22);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(95, 13);
            this.Label5.TabIndex = 5;
            this.Label5.Text = "Node Zero Index:";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(149, 12);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(78, 13);
            this.Label3.TabIndex = 4;
            this.Label3.Text = "Total Vertices:";
            // 
            // groupBox13
            // 
            this.groupBox13.Controls.Add(this.cb_RecurseVerts);
            this.groupBox13.Controls.Add(this.groupBox15);
            this.groupBox13.Controls.Add(this.groupBox14);
            this.groupBox13.Controls.Add(this.lb_vertResults);
            this.groupBox13.Controls.Add(this.searchVerts_b);
            this.groupBox13.Controls.Add(this.cb_vertAxis);
            this.groupBox13.Controls.Add(this.stb_verts);
            this.groupBox13.Location = new System.Drawing.Point(133, 198);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Size = new System.Drawing.Size(498, 216);
            this.groupBox13.TabIndex = 8;
            this.groupBox13.TabStop = false;
            this.groupBox13.Text = "Search Verts";
            // 
            // cb_RecurseVerts
            // 
            this.cb_RecurseVerts.AutoSize = true;
            this.cb_RecurseVerts.Location = new System.Drawing.Point(410, 46);
            this.cb_RecurseVerts.Name = "cb_RecurseVerts";
            this.cb_RecurseVerts.Size = new System.Drawing.Size(71, 17);
            this.cb_RecurseVerts.TabIndex = 15;
            this.cb_RecurseVerts.Text = "Recurse?";
            this.cb_RecurseVerts.UseVisualStyleBackColor = true;
            // 
            // groupBox15
            // 
            this.groupBox15.Controls.Add(this.label49);
            this.groupBox15.Controls.Add(this.label50);
            this.groupBox15.Controls.Add(this.label51);
            this.groupBox15.Controls.Add(this.tb_normResZ);
            this.groupBox15.Controls.Add(this.tb_normResY);
            this.groupBox15.Controls.Add(this.tb_normResX);
            this.groupBox15.Location = new System.Drawing.Point(265, 45);
            this.groupBox15.Name = "groupBox15";
            this.groupBox15.Size = new System.Drawing.Size(138, 102);
            this.groupBox15.TabIndex = 14;
            this.groupBox15.TabStop = false;
            this.groupBox15.Text = "Normals";
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Location = new System.Drawing.Point(7, 82);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(13, 13);
            this.label49.TabIndex = 13;
            this.label49.Text = "Z";
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Location = new System.Drawing.Point(7, 54);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(15, 13);
            this.label50.TabIndex = 12;
            this.label50.Text = "Y:";
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Location = new System.Drawing.Point(7, 26);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(16, 13);
            this.label51.TabIndex = 11;
            this.label51.Text = "X:";
            // 
            // tb_normResZ
            // 
            this.tb_normResZ.Location = new System.Drawing.Point(29, 73);
            this.tb_normResZ.Name = "tb_normResZ";
            this.tb_normResZ.Size = new System.Drawing.Size(100, 22);
            this.tb_normResZ.TabIndex = 10;
            // 
            // tb_normResY
            // 
            this.tb_normResY.Location = new System.Drawing.Point(29, 45);
            this.tb_normResY.Name = "tb_normResY";
            this.tb_normResY.Size = new System.Drawing.Size(100, 22);
            this.tb_normResY.TabIndex = 10;
            // 
            // tb_normResX
            // 
            this.tb_normResX.Location = new System.Drawing.Point(29, 17);
            this.tb_normResX.Name = "tb_normResX";
            this.tb_normResX.Size = new System.Drawing.Size(100, 22);
            this.tb_normResX.TabIndex = 10;
            // 
            // groupBox14
            // 
            this.groupBox14.Controls.Add(this.label48);
            this.groupBox14.Controls.Add(this.label47);
            this.groupBox14.Controls.Add(this.label46);
            this.groupBox14.Controls.Add(this.tb_resultZ);
            this.groupBox14.Controls.Add(this.tb_resultY);
            this.groupBox14.Controls.Add(this.tb_resultX);
            this.groupBox14.Location = new System.Drawing.Point(121, 45);
            this.groupBox14.Name = "groupBox14";
            this.groupBox14.Size = new System.Drawing.Size(138, 101);
            this.groupBox14.TabIndex = 14;
            this.groupBox14.TabStop = false;
            this.groupBox14.Text = "Position";
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Location = new System.Drawing.Point(7, 82);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(13, 13);
            this.label48.TabIndex = 13;
            this.label48.Text = "Z";
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Location = new System.Drawing.Point(7, 54);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(15, 13);
            this.label47.TabIndex = 12;
            this.label47.Text = "Y:";
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Location = new System.Drawing.Point(7, 26);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(16, 13);
            this.label46.TabIndex = 11;
            this.label46.Text = "X:";
            // 
            // tb_resultZ
            // 
            this.tb_resultZ.Location = new System.Drawing.Point(29, 73);
            this.tb_resultZ.Name = "tb_resultZ";
            this.tb_resultZ.Size = new System.Drawing.Size(100, 22);
            this.tb_resultZ.TabIndex = 10;
            // 
            // tb_resultY
            // 
            this.tb_resultY.Location = new System.Drawing.Point(29, 45);
            this.tb_resultY.Name = "tb_resultY";
            this.tb_resultY.Size = new System.Drawing.Size(100, 22);
            this.tb_resultY.TabIndex = 10;
            // 
            // tb_resultX
            // 
            this.tb_resultX.Location = new System.Drawing.Point(29, 17);
            this.tb_resultX.Name = "tb_resultX";
            this.tb_resultX.Size = new System.Drawing.Size(100, 22);
            this.tb_resultX.TabIndex = 10;
            // 
            // lb_vertResults
            // 
            this.lb_vertResults.FormattingEnabled = true;
            this.lb_vertResults.Location = new System.Drawing.Point(6, 21);
            this.lb_vertResults.MinimumSize = new System.Drawing.Size(105, 120);
            this.lb_vertResults.Name = "lb_vertResults";
            this.lb_vertResults.Size = new System.Drawing.Size(105, 186);
            this.lb_vertResults.TabIndex = 9;
            this.lb_vertResults.SelectedIndexChanged += new System.EventHandler(this.lb_vertResults_SelectedIndexChanged);
            // 
            // searchVerts_b
            // 
            this.searchVerts_b.Location = new System.Drawing.Point(159, 18);
            this.searchVerts_b.Name = "searchVerts_b";
            this.searchVerts_b.Size = new System.Drawing.Size(62, 21);
            this.searchVerts_b.TabIndex = 8;
            this.searchVerts_b.Text = "Search";
            this.searchVerts_b.UseVisualStyleBackColor = true;
            this.searchVerts_b.Click += new System.EventHandler(this.searchVerts_b_Click);
            // 
            // cb_vertAxis
            // 
            this.cb_vertAxis.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cb_vertAxis.FormattingEnabled = true;
            this.cb_vertAxis.Items.AddRange(new object[] {
            "X Axis",
            "Y Axis",
            "Z Axis"});
            this.cb_vertAxis.Location = new System.Drawing.Point(355, 18);
            this.cb_vertAxis.Name = "cb_vertAxis";
            this.cb_vertAxis.Size = new System.Drawing.Size(137, 21);
            this.cb_vertAxis.TabIndex = 0;
            this.cb_vertAxis.Text = "Select Axis";
            // 
            // stb_verts
            // 
            this.stb_verts.Location = new System.Drawing.Point(227, 17);
            this.stb_verts.Name = "stb_verts";
            this.stb_verts.Size = new System.Drawing.Size(122, 22);
            this.stb_verts.TabIndex = 7;
            // 
            // tp_face
            // 
            this.tp_face.Controls.Add(this.b_TestOptimize);
            this.tp_face.Controls.Add(this.GroupBox11);
            this.tp_face.Controls.Add(this.Label4);
            this.tp_face.Controls.Add(this.lb_faces);
            this.tp_face.Controls.Add(this.tb_faces);
            this.tp_face.Location = new System.Drawing.Point(4, 22);
            this.tp_face.Name = "tp_face";
            this.tp_face.Size = new System.Drawing.Size(664, 320);
            this.tp_face.TabIndex = 5;
            this.tp_face.Text = "Faces";
            this.tp_face.UseVisualStyleBackColor = true;
            // 
            // b_TestOptimize
            // 
            this.b_TestOptimize.Location = new System.Drawing.Point(558, 6);
            this.b_TestOptimize.Name = "b_TestOptimize";
            this.b_TestOptimize.Size = new System.Drawing.Size(72, 24);
            this.b_TestOptimize.TabIndex = 7;
            this.b_TestOptimize.Text = "Optimize";
            this.b_TestOptimize.UseVisualStyleBackColor = true;
            this.b_TestOptimize.Click += new System.EventHandler(this.b_TestOptimize_Click);
            // 
            // GroupBox11
            // 
            this.GroupBox11.Controls.Add(this.groupBox16);
            this.GroupBox11.Controls.Add(this.GroupBox12);
            this.GroupBox11.Controls.Add(this.lb_faces_verts);
            this.GroupBox11.Controls.Add(this.Label42);
            this.GroupBox11.Controls.Add(this.tb_face_shader);
            this.GroupBox11.Controls.Add(this.Label41);
            this.GroupBox11.Controls.Add(this.tb_face_region);
            this.GroupBox11.Controls.Add(this.Label40);
            this.GroupBox11.Location = new System.Drawing.Point(129, 40);
            this.GroupBox11.Name = "GroupBox11";
            this.GroupBox11.Size = new System.Drawing.Size(507, 272);
            this.GroupBox11.TabIndex = 5;
            this.GroupBox11.TabStop = false;
            this.GroupBox11.Text = "Face Properties";
            // 
            // groupBox16
            // 
            this.groupBox16.Controls.Add(this.cb_sfacesRecurse);
            this.groupBox16.Controls.Add(this.cb_sfaces);
            this.groupBox16.Controls.Add(this.tb_sfaces);
            this.groupBox16.Controls.Add(this.b_sfaces);
            this.groupBox16.Controls.Add(this.lb_sfaces);
            this.groupBox16.Location = new System.Drawing.Point(7, 68);
            this.groupBox16.Name = "groupBox16";
            this.groupBox16.Size = new System.Drawing.Size(185, 192);
            this.groupBox16.TabIndex = 8;
            this.groupBox16.TabStop = false;
            this.groupBox16.Text = "Search Tris";
            // 
            // cb_sfacesRecurse
            // 
            this.cb_sfacesRecurse.AutoSize = true;
            this.cb_sfacesRecurse.Location = new System.Drawing.Point(91, 96);
            this.cb_sfacesRecurse.Name = "cb_sfacesRecurse";
            this.cb_sfacesRecurse.Size = new System.Drawing.Size(71, 17);
            this.cb_sfacesRecurse.TabIndex = 4;
            this.cb_sfacesRecurse.Text = "Recurse?";
            this.cb_sfacesRecurse.UseVisualStyleBackColor = true;
            // 
            // cb_sfaces
            // 
            this.cb_sfaces.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cb_sfaces.FormattingEnabled = true;
            this.cb_sfaces.Items.AddRange(new object[] {
            "Region",
            "Shaders",
            "Vertice"});
            this.cb_sfaces.Location = new System.Drawing.Point(89, 67);
            this.cb_sfaces.Name = "cb_sfaces";
            this.cb_sfaces.Size = new System.Drawing.Size(85, 21);
            this.cb_sfaces.TabIndex = 3;
            this.cb_sfaces.Text = "Search By";
            // 
            // tb_sfaces
            // 
            this.tb_sfaces.Location = new System.Drawing.Point(89, 41);
            this.tb_sfaces.Name = "tb_sfaces";
            this.tb_sfaces.Size = new System.Drawing.Size(86, 22);
            this.tb_sfaces.TabIndex = 2;
            this.tb_sfaces.Text = "Enter Value";
            // 
            // b_sfaces
            // 
            this.b_sfaces.Location = new System.Drawing.Point(89, 13);
            this.b_sfaces.Name = "b_sfaces";
            this.b_sfaces.Size = new System.Drawing.Size(72, 22);
            this.b_sfaces.TabIndex = 1;
            this.b_sfaces.Text = "Search";
            this.b_sfaces.UseVisualStyleBackColor = true;
            this.b_sfaces.Click += new System.EventHandler(this.b_sfaces_Click);
            // 
            // lb_sfaces
            // 
            this.lb_sfaces.FormattingEnabled = true;
            this.lb_sfaces.Location = new System.Drawing.Point(6, 13);
            this.lb_sfaces.Name = "lb_sfaces";
            this.lb_sfaces.Size = new System.Drawing.Size(74, 160);
            this.lb_sfaces.TabIndex = 0;
            // 
            // GroupBox12
            // 
            this.GroupBox12.Controls.Add(this.tb_face_vert_z);
            this.GroupBox12.Controls.Add(this.Label45);
            this.GroupBox12.Controls.Add(this.tb_face_vert_y);
            this.GroupBox12.Controls.Add(this.Label44);
            this.GroupBox12.Controls.Add(this.tb_face_vert_x);
            this.GroupBox12.Controls.Add(this.Label43);
            this.GroupBox12.Location = new System.Drawing.Point(318, 18);
            this.GroupBox12.Name = "GroupBox12";
            this.GroupBox12.Size = new System.Drawing.Size(137, 103);
            this.GroupBox12.TabIndex = 6;
            this.GroupBox12.TabStop = false;
            this.GroupBox12.Text = "Vertice Position";
            // 
            // tb_face_vert_z
            // 
            this.tb_face_vert_z.Location = new System.Drawing.Point(28, 71);
            this.tb_face_vert_z.Name = "tb_face_vert_z";
            this.tb_face_vert_z.Size = new System.Drawing.Size(100, 22);
            this.tb_face_vert_z.TabIndex = 1;
            // 
            // Label45
            // 
            this.Label45.AutoSize = true;
            this.Label45.Location = new System.Drawing.Point(6, 74);
            this.Label45.Name = "Label45";
            this.Label45.Size = new System.Drawing.Size(16, 13);
            this.Label45.TabIndex = 0;
            this.Label45.Text = "Z:";
            // 
            // tb_face_vert_y
            // 
            this.tb_face_vert_y.Location = new System.Drawing.Point(28, 43);
            this.tb_face_vert_y.Name = "tb_face_vert_y";
            this.tb_face_vert_y.Size = new System.Drawing.Size(100, 22);
            this.tb_face_vert_y.TabIndex = 1;
            // 
            // Label44
            // 
            this.Label44.AutoSize = true;
            this.Label44.Location = new System.Drawing.Point(6, 46);
            this.Label44.Name = "Label44";
            this.Label44.Size = new System.Drawing.Size(15, 13);
            this.Label44.TabIndex = 0;
            this.Label44.Text = "Y:";
            // 
            // tb_face_vert_x
            // 
            this.tb_face_vert_x.Location = new System.Drawing.Point(28, 15);
            this.tb_face_vert_x.Name = "tb_face_vert_x";
            this.tb_face_vert_x.Size = new System.Drawing.Size(100, 22);
            this.tb_face_vert_x.TabIndex = 1;
            // 
            // Label43
            // 
            this.Label43.AutoSize = true;
            this.Label43.Location = new System.Drawing.Point(6, 18);
            this.Label43.Name = "Label43";
            this.Label43.Size = new System.Drawing.Size(16, 13);
            this.Label43.TabIndex = 0;
            this.Label43.Text = "X:";
            // 
            // lb_faces_verts
            // 
            this.lb_faces_verts.FormattingEnabled = true;
            this.lb_faces_verts.Location = new System.Drawing.Point(210, 36);
            this.lb_faces_verts.Name = "lb_faces_verts";
            this.lb_faces_verts.Size = new System.Drawing.Size(90, 56);
            this.lb_faces_verts.TabIndex = 5;
            this.lb_faces_verts.SelectedIndexChanged += new System.EventHandler(this.lb_faces_verts_SelectedIndexChanged);
            // 
            // Label42
            // 
            this.Label42.AutoSize = true;
            this.Label42.Location = new System.Drawing.Point(204, 18);
            this.Label42.Name = "Label42";
            this.Label42.Size = new System.Drawing.Size(102, 13);
            this.Label42.TabIndex = 4;
            this.Label42.Text = "Attached Verticies:";
            // 
            // tb_face_shader
            // 
            this.tb_face_shader.Location = new System.Drawing.Point(56, 42);
            this.tb_face_shader.Name = "tb_face_shader";
            this.tb_face_shader.Size = new System.Drawing.Size(120, 22);
            this.tb_face_shader.TabIndex = 3;
            // 
            // Label41
            // 
            this.Label41.AutoSize = true;
            this.Label41.Location = new System.Drawing.Point(6, 45);
            this.Label41.Name = "Label41";
            this.Label41.Size = new System.Drawing.Size(46, 13);
            this.Label41.TabIndex = 2;
            this.Label41.Text = "Shader:";
            // 
            // tb_face_region
            // 
            this.tb_face_region.Location = new System.Drawing.Point(56, 16);
            this.tb_face_region.Name = "tb_face_region";
            this.tb_face_region.Size = new System.Drawing.Size(120, 22);
            this.tb_face_region.TabIndex = 1;
            // 
            // Label40
            // 
            this.Label40.AutoSize = true;
            this.Label40.Location = new System.Drawing.Point(6, 19);
            this.Label40.Name = "Label40";
            this.Label40.Size = new System.Drawing.Size(47, 13);
            this.Label40.TabIndex = 0;
            this.Label40.Text = "Region:";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(129, 17);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(66, 13);
            this.Label4.TabIndex = 4;
            this.Label4.Text = "Total Faces:";
            // 
            // saveJMS
            // 
            this.saveJMS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.saveJMS.Location = new System.Drawing.Point(500, 4);
            this.saveJMS.Name = "saveJMS";
            this.saveJMS.Size = new System.Drawing.Size(75, 23);
            this.saveJMS.TabIndex = 5;
            this.saveJMS.Text = "Save";
            this.saveJMS.UseVisualStyleBackColor = true;
            this.saveJMS.Click += new System.EventHandler(this.saveJMS_Click);
            // 
            // frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 361);
            this.Controls.Add(this.saveJMS);
            this.Controls.Add(this.btn_load);
            this.Controls.Add(this.tc_main);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimumSize = new System.Drawing.Size(673, 311);
            this.Name = "frm_Main";
            this.Text = "JMS Explorer";
            this.Load += new System.EventHandler(this.frm_Main_Load_1);
            this.tc_main.ResumeLayout(false);
            this.tp_materials.ResumeLayout(false);
            this.tp_materials.PerformLayout();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.tp_regions.ResumeLayout(false);
            this.tp_regions.PerformLayout();
            this.tp_nodes.ResumeLayout(false);
            this.tp_nodes.PerformLayout();
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            this.GroupBox4.ResumeLayout(false);
            this.GroupBox4.PerformLayout();
            this.GroupBox3.ResumeLayout(false);
            this.GroupBox3.PerformLayout();
            this.tp_markers.ResumeLayout(false);
            this.tp_markers.PerformLayout();
            this.GroupBox5.ResumeLayout(false);
            this.GroupBox5.PerformLayout();
            this.GroupBox6.ResumeLayout(false);
            this.GroupBox6.PerformLayout();
            this.GroupBox7.ResumeLayout(false);
            this.GroupBox7.PerformLayout();
            this.tp_vertice.ResumeLayout(false);
            this.tp_vertice.PerformLayout();
            this.GroupBox8.ResumeLayout(false);
            this.GroupBox8.PerformLayout();
            this.GroupBox10.ResumeLayout(false);
            this.GroupBox10.PerformLayout();
            this.GroupBox9.ResumeLayout(false);
            this.GroupBox9.PerformLayout();
            this.groupBox13.ResumeLayout(false);
            this.groupBox13.PerformLayout();
            this.groupBox15.ResumeLayout(false);
            this.groupBox15.PerformLayout();
            this.groupBox14.ResumeLayout(false);
            this.groupBox14.PerformLayout();
            this.tp_face.ResumeLayout(false);
            this.tp_face.PerformLayout();
            this.GroupBox11.ResumeLayout(false);
            this.GroupBox11.PerformLayout();
            this.groupBox16.ResumeLayout(false);
            this.groupBox16.PerformLayout();
            this.GroupBox12.ResumeLayout(false);
            this.GroupBox12.PerformLayout();
            this.ResumeLayout(false);

        }
        internal System.Windows.Forms.ListBox lb_materials;
        internal System.Windows.Forms.ListBox lb_nodes;
        internal System.Windows.Forms.Button btn_load;
        internal System.Windows.Forms.ListBox lb_markers;
        internal System.Windows.Forms.ListBox lb_verts;
        internal System.Windows.Forms.ListBox lb_faces;

        internal System.Windows.Forms.TextBox tb_markers;
        internal System.Windows.Forms.TextBox tb_verts;
        internal System.Windows.Forms.TextBox tb_faces;
        internal System.Windows.Forms.ListBox lb_region;
        internal System.Windows.Forms.TextBox tb_regions;
        internal System.Windows.Forms.TabControl tc_main;
        internal System.Windows.Forms.TabPage tp_materials;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.TabPage tp_regions;
        internal System.Windows.Forms.TabPage tp_nodes;
        internal System.Windows.Forms.TabPage tp_markers;
        internal System.Windows.Forms.TabPage tp_vertice;
        internal System.Windows.Forms.TabPage tp_face;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.TextBox tb_materialName;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.TextBox tb_materialPath;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.Label Label11;
        internal System.Windows.Forms.TextBox tb_RegionName;
        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.TextBox tb_nodeName;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label Label12;
        internal System.Windows.Forms.GroupBox GroupBox4;
        internal System.Windows.Forms.TextBox tb_node_translation_z;
        internal System.Windows.Forms.Label Label19;
        internal System.Windows.Forms.TextBox tb_node_translation_y;
        internal System.Windows.Forms.Label Label20;
        internal System.Windows.Forms.TextBox tb_node_translation_x;
        internal System.Windows.Forms.Label Label21;
        internal System.Windows.Forms.GroupBox GroupBox3;
        internal System.Windows.Forms.TextBox tb_node_rotation_w;
        internal System.Windows.Forms.Label Label17;
        internal System.Windows.Forms.TextBox tb_node_rotation_z;
        internal System.Windows.Forms.Label Label16;
        internal System.Windows.Forms.TextBox tb_node_rotation_y;
        internal System.Windows.Forms.Label Label15;
        internal System.Windows.Forms.TextBox tb_node_rotation_x;
        internal System.Windows.Forms.Label Label14;
        internal System.Windows.Forms.TextBox tb_node_sibling_index;
        internal System.Windows.Forms.Label Label13;
        internal System.Windows.Forms.TextBox tb_node_childIndex;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.GroupBox GroupBox5;
        internal System.Windows.Forms.TextBox tb_markers_parent_index;
        internal System.Windows.Forms.Label Label22;
        internal System.Windows.Forms.Label Label18;
        internal System.Windows.Forms.TextBox tb_marker_name;
        internal System.Windows.Forms.GroupBox GroupBox6;
        internal System.Windows.Forms.TextBox tb_markers_translation_z;
        internal System.Windows.Forms.Label Label23;
        internal System.Windows.Forms.TextBox tb_markers_translation_y;
        internal System.Windows.Forms.Label Label24;
        internal System.Windows.Forms.TextBox tb_markers_translation_x;
        internal System.Windows.Forms.Label Label25;
        internal System.Windows.Forms.GroupBox GroupBox7;
        internal System.Windows.Forms.TextBox tb_markers_rotation_w;
        internal System.Windows.Forms.Label Label26;
        internal System.Windows.Forms.TextBox tb_markers_rotation_z;
        internal System.Windows.Forms.Label Label27;
        internal System.Windows.Forms.TextBox tb_markers_rotation_y;
        internal System.Windows.Forms.Label Label28;
        internal System.Windows.Forms.TextBox tb_markers_rotation_x;
        internal System.Windows.Forms.Label Label29;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.GroupBox GroupBox8;
        internal System.Windows.Forms.TextBox tb_verts_zero_index;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.TextBox tb_verts_one_index;
        internal System.Windows.Forms.Label Label36;
        internal System.Windows.Forms.GroupBox GroupBox10;
        internal System.Windows.Forms.TextBox tb_vert_normal_z;
        internal System.Windows.Forms.Label Label33;
        internal System.Windows.Forms.TextBox tb_vert_normal_y;
        internal System.Windows.Forms.Label Label34;
        internal System.Windows.Forms.TextBox tb_vert_normal_x;
        internal System.Windows.Forms.Label Label35;
        internal System.Windows.Forms.GroupBox GroupBox9;
        internal System.Windows.Forms.TextBox tb_vert_position_z;
        internal System.Windows.Forms.Label Label30;
        internal System.Windows.Forms.TextBox tb_vert_position_y;
        internal System.Windows.Forms.Label Label31;
        internal System.Windows.Forms.TextBox tb_vert_position_x;
        internal System.Windows.Forms.Label Label32;
        internal System.Windows.Forms.Label Label37;
        internal System.Windows.Forms.TextBox tb_verts_one_weight;
        internal System.Windows.Forms.TextBox tb_vert_ty;
        internal System.Windows.Forms.Label Label39;
        internal System.Windows.Forms.TextBox tb_vert_tx;
        internal System.Windows.Forms.Label Label38;
        internal System.Windows.Forms.GroupBox GroupBox11;
        internal System.Windows.Forms.TextBox tb_face_shader;
        internal System.Windows.Forms.Label Label41;
        internal System.Windows.Forms.TextBox tb_face_region;
        internal System.Windows.Forms.Label Label40;
        internal System.Windows.Forms.ListBox lb_faces_verts;
        internal System.Windows.Forms.Label Label42;
        internal System.Windows.Forms.GroupBox GroupBox12;
        internal System.Windows.Forms.TextBox tb_face_vert_z;
        internal System.Windows.Forms.Label Label45;
        internal System.Windows.Forms.TextBox tb_face_vert_y;
        internal System.Windows.Forms.Label Label44;
        internal System.Windows.Forms.TextBox tb_face_vert_x;
        internal System.Windows.Forms.Label Label43;

        private System.Windows.Forms.TextBox stb_verts;
        private System.Windows.Forms.GroupBox groupBox13;
        private System.Windows.Forms.ComboBox cb_vertAxis;
        private System.Windows.Forms.Button searchVerts_b;
        private System.Windows.Forms.ListBox lb_vertResults;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.TextBox tb_resultZ;
        private System.Windows.Forms.TextBox tb_resultY;
        private System.Windows.Forms.TextBox tb_resultX;
        private System.Windows.Forms.GroupBox groupBox15;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.TextBox tb_normResZ;
        private System.Windows.Forms.TextBox tb_normResY;
        private System.Windows.Forms.TextBox tb_normResX;
        private System.Windows.Forms.GroupBox groupBox14;
        private System.Windows.Forms.TextBox tb_selVertbyInd;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.Button selectVertButton;
        private System.Windows.Forms.CheckBox cb_RecurseVerts;
        private System.Windows.Forms.GroupBox groupBox16;
        private System.Windows.Forms.ListBox lb_sfaces;
        private System.Windows.Forms.Button b_sfaces;
        private System.Windows.Forms.CheckBox cb_sfacesRecurse;
        private System.Windows.Forms.ComboBox cb_sfaces;
        private System.Windows.Forms.TextBox tb_sfaces;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.Label label53;
        private System.Windows.Forms.Button btn_mattAdd;
        private System.Windows.Forms.TextBox tb_materials;
        private System.Windows.Forms.TextBox tb_nodes;
        private System.Windows.Forms.Button b_TestOptimize;
        private Button saveJMS;
    }

}