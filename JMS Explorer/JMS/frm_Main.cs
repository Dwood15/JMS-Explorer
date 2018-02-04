//using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Windows.Forms;
using Microsoft.DirectX;
using Microsoft.DirectX.Direct3D;
using _JMS;
//using SlimDX;
//using SlimDX.Windows;
//using SlimDX.Direct3D9;
using System.Drawing;

namespace JMS_Explorer
{  
    public partial class frm_Main : Form //: ToolSharp.IToolWindow
    {
        private static string verticeString = "Vertice";
        private static int verticeIndex = verticeString.LastIndexOf('e') + 1;
        
        #region JunkyStuff
       // private ToolSharp.IToolPlugin _base;
        D3DX matrix = new D3DX();

        /*
        public ToolSharp.IToolPlugin Base
        {
            get { return _base; }
            set { _base = value; }
        }
        */
        #region Symbols
        // Symbols to remember
        // 
        // % Two sided Property
        // # Transparent Property
        // ! Render Only Property
        // * Large Collideable Property
        // $ Fog Plane Property
        // ^ Ladder Property
        // - Breakable Property
        // & AI Deafening Property (not apply to multi-player)
        // @ Collision Only Property
        // . Exact Portal Property

        // Special Material Names
        //
        // +sky - applied to surfaces to render the skybox
        // +seamsealer - Commonly used to seal holes. SHOULD NOT BE USED IN FINAL BUILD. MAKE A WARNING
        // +portal - Applied to faces that are used to define general portals
        // +exactportal - Applied to faces that are used to define an exact volune or portal.
        // +weatherpoly - Applied to faces that are used to define a portal or portals to use a volume for setting weather effects
        // +sound - Applied to faces that are used to define volumes for sound
        // +unused - Can be used in conjunction with the special shader symbols to define its use and behavior. EX: Make a fog plane with a definite volume
        #endregion
        #region Button load click

        public void refresh_data() {
            tc_main.Enabled = false;

            lb_nodes.Items.Clear();
            lb_materials.Items.Clear();
            lb_markers.Items.Clear();
            lb_verts.Items.Clear();
            lb_faces.Items.Clear();
            lb_region.Items.Clear();

            foreach (Node item in _jms.Nodes)
            {
                lb_nodes.Items.Add(item.Name);
            }

            foreach (Materials item in _jms.MaterialList)
            {
                lb_materials.Items.Add(item.Name);
            }

            int _count = 1;

            foreach (Marker item in _jms.Markers)
            {
                lb_markers.Items.Add(string.Format("Marker {0}", _count));
                _count++;
            }

            _count = 1;

            foreach (Vertice item in _jms._vertices)
            {
                lb_verts.Items.Add(string.Format("Vertice {0}", _count));
                _count++;
            }

            _count = 1;

            foreach (Face item in _jms._faces)
            {
                lb_faces.Items.Add(string.Format("Face {0}", _count));
                _count++;
            }

            _count = 1;

            foreach (Region item in _jms._regions)
            {
                lb_region.Items.Add(string.Format("Region {0}", _count));
                _count ++;
            }

            tb_faces.Text = _jms._faces.Count.ToString();
            tb_markers.Text = _jms._markers.Count.ToString();
            tb_materials.Text = _jms._materials.Count.ToString();
            tb_nodes.Text = _jms._nodes.Count.ToString();
            tb_verts.Text = _jms._vertices.Count.ToString();
            tb_regions.Text = _jms._regions.Count.ToString();

            tc_main.Enabled = true;
        
        }

        private void btn_load_Click(System.Object sender, System.EventArgs e)
        {
            using (OpenFileDialog _OFD = new OpenFileDialog { Title = "JMS", Filter = "JMS File|*.jms" })
            {
                if (_OFD.ShowDialog().Equals(DialogResult.OK))
                {
                    _jms = new _JMS.JMS();
                    _jms.Load(_OFD.FileName);
                    refresh_data();
                }

            }

        }
        #endregion
        #region Selected Index Changes
        private void lb_materials_SelectedIndexChanged(System.Object sender, System.EventArgs e)
        {

            if (lb_materials.SelectedIndex > -1)
            {
                Materials _material = _jms.MaterialList[lb_materials.SelectedIndex];

                tb_materialName.Text = _material.Name;
                tb_materialPath.Text = _material.Path;

            }
            else
            {
                tb_materialName.Clear();
                tb_materialPath.Clear();

            }

        }


        private void lb_region_SelectedIndexChanged(System.Object sender, System.EventArgs e)
        {

            if (lb_region.SelectedIndex > -1)
            {
                Region _region = _jms._regions[lb_region.SelectedIndex];

                tb_RegionName.Text = _region.Name;


            }
            else
            {
                tb_RegionName.Clear();

            }

        }


        private void lb_nodes_SelectedIndexChanged(System.Object sender, System.EventArgs e)
        {

            if (lb_nodes.SelectedIndex > -1)
            {
                Node _node = _jms._nodes[lb_nodes.SelectedIndex];

                var _with1 = _node;

                tb_nodeName.Text = _with1.Name;
                tb_node_childIndex.Text = _with1.child_index.ToString();
                tb_node_sibling_index.Text = _with1.next_sibling_index.ToString();

                tb_node_rotation_w.Text = _with1.Rotation.W.ToString();
                tb_node_rotation_x.Text = _with1.Rotation.X.ToString();
                tb_node_rotation_y.Text = _with1.Rotation.Y.ToString();
                tb_node_rotation_z.Text = _with1.Rotation.Z.ToString();

                tb_node_translation_x.Text = _with1.Translation.X.ToString();
                tb_node_translation_y.Text = _with1.Translation.Y.ToString();
                tb_node_translation_z.Text = _with1.Translation.Z.ToString();



            }
            else
            {
                tb_nodeName.Clear();
                tb_node_childIndex.Clear();
                tb_node_sibling_index.Clear();

                tb_node_rotation_w.Clear();
                tb_node_rotation_x.Clear();
                tb_node_rotation_y.Clear();
                tb_node_rotation_z.Clear();

                tb_node_translation_x.Clear();
                tb_node_translation_y.Clear();
                tb_node_translation_z.Clear();

            }

        }


        private void lb_markers_SelectedIndexChanged(System.Object sender, System.EventArgs e)
        {

            if (lb_markers.SelectedIndex > -1)
            {
                Marker _marker = _jms.Markers[lb_markers.SelectedIndex];

                var _with2 = _marker;

                tb_marker_name.Text = _with2.Name;
                tb_markers_parent_index.Text = _with2.parent_index.ToString();

                tb_markers_rotation_w.Text = _with2.Rotation.W.ToString();
                tb_markers_rotation_x.Text = _with2.Rotation.X.ToString();
                tb_markers_rotation_y.Text = _with2.Rotation.Y.ToString();
                tb_markers_rotation_z.Text = _with2.Rotation.Z.ToString();

                tb_markers_translation_x.Text = _with2.Translation.X.ToString();
                tb_markers_translation_y.Text = _with2.Translation.Y.ToString();
                tb_markers_translation_z.Text = _with2.Translation.Z.ToString();



            }
            else
            {
                tb_marker_name.Clear();
                tb_markers_parent_index.Clear();

                tb_markers_rotation_w.Clear();
                tb_markers_rotation_x.Clear();
                tb_markers_rotation_y.Clear();
                tb_markers_rotation_z.Clear();

                tb_markers_translation_x.Clear();
                tb_markers_translation_y.Clear();
                tb_markers_translation_z.Clear();

            }

        }


        private void lb_verts_SelectedIndexChanged(System.Object sender, System.EventArgs e)
        {

            if (lb_verts.SelectedIndex > -1)
            {
                Vertice _vert = _jms.Vertices[lb_verts.SelectedIndex];

                var _with3 = _vert;

                tb_verts_zero_index.Text = _with3.node_zero_index.ToString();
                tb_verts_one_index.Text = _with3.node_one_index.ToString();
                tb_verts_one_weight.Text = _with3.node_one_weight.ToString();

                tb_vert_position_x.Text = _with3.Position.X.ToString();
                tb_vert_position_y.Text = _with3.Position.Y.ToString();
                tb_vert_position_z.Text = _with3.Position.Z.ToString();

                tb_vert_normal_x.Text = _with3.Normal.X.ToString();
                tb_vert_normal_y.Text = _with3.Normal.Y.ToString();
                tb_vert_normal_z.Text = _with3.Normal.Z.ToString();

                tb_vert_tx.Text = _with3.tvert_PositionX.ToString();
                tb_vert_ty.Text = _with3.tvert_PositionY.ToString();



            }
            else
            {
                tb_verts_zero_index.Clear();
                tb_verts_one_index.Clear();
                tb_verts_one_weight.Clear();

                tb_vert_position_x.Clear();
                tb_vert_position_y.Clear();
                tb_vert_position_z.Clear();

                tb_vert_normal_x.Clear();
                tb_vert_normal_y.Clear();
                tb_vert_normal_z.Clear();

                tb_vert_tx.Clear();
                tb_vert_ty.Clear();

            }

        }


        private void lb_faces_SelectedIndexChanged(System.Object sender, System.EventArgs e)
        {

            if (lb_faces.SelectedIndex > -1)
            {
                Face _face = _jms._faces[lb_faces.SelectedIndex];


                tb_face_region.Text = _jms.Regions[_face.Face_Region_Index].Name;
                tb_face_shader.Text = _jms.MaterialList[_face.Face_Shader_Index].Name;

                lb_faces_verts.Items.Clear();

                for (int i = 0; i < _face.vertRefs.Count; i++ )
                {
                    lb_faces_verts.Items.Add(_face.vertRefs[i]);
                }

            }
            else
            {
                tb_face_region.Clear();
                tb_face_shader.Clear();

                lb_faces_verts.Items.Clear();
            }
        }


        private void lb_faces_verts_SelectedIndexChanged(System.Object sender, System.EventArgs e)
        {
            if (lb_faces_verts.SelectedIndex > -1)
            {
                Vertice _vert = _jms.Vertices[Convert.ToInt32(lb_faces_verts.SelectedItem)];
                var _with5 = _vert;
                tb_face_vert_x.Text = _with5.Position.X.ToString();
                tb_face_vert_y.Text = _with5.Position.Y.ToString();
                tb_face_vert_z.Text = _with5.Position.Z.ToString();
            }
            else
            {
                tb_face_vert_x.Clear();
                tb_face_vert_y.Clear();
                tb_face_vert_z.Clear();
            }
        }
        #endregion
        #region Junk
        private void frm_Main_Load(object sender, System.EventArgs e)
        { }


        private void Button1_Click(System.Object sender, System.EventArgs e)
        {
            // Dim _frmRender As New frm_Render
            //_frmRender.MdiParent = Me.MdiParent
            // _frmRender.Show()

        }

        private void btn_load_Click_1(object sender, EventArgs e)
        { btn_load_Click(sender, e); }
        #endregion
        #endregion

        #region Search for verts
        private void searchVerts_b_Click(object sender, EventArgs e)
        {
            searchVerts_b.Enabled = false;
            int selection = -1;
            if (this.cb_vertAxis.Text.Equals("X Axis")) { selection = 0; }
            else if (this.cb_vertAxis.Text.Equals("Y Axis")) { selection = 1; }
            else if (this.cb_vertAxis.Text.Equals("Z Axis")) { selection = 2; }
            else { misc.alertbox("Your Entry is invalid. Please use the drop down box to select what axis you're searching for"); searchVerts_b.Enabled = true; return; }
            searchForVertByAxisGet(selection);
        }

        public void searchForVertByAxisGet(int selection)
        {
            //switch (selection) {
            //    case 0:                    
            //        break;
            //    case 1: break;
            //    case 2: break;
            //}
            float myText = 0;
            string myRealTXT = this.stb_verts.Text;
            bool recurse = false;
            switch (selection)
            {
                case 0: if (float.TryParse(myRealTXT, out myText)) searchForVertByAxisX(myText, recurse);
                    else { misc.alertbox("We could not parse your number! Make sure It really is a number!"); }
                    break;

                case 1: if (float.TryParse(myRealTXT, out myText)) searchForVertByAxisY(myText, recurse);
                    else { misc.alertbox("We could not parse your number! Make sure It really is a number!"); }
                    break;
                case 2: if (float.TryParse(myRealTXT, out myText)) searchForVertByAxisZ(myText, recurse);
                    else { misc.alertbox("We could not parse your number! Make sure It really is a number!"); }
                    break;
            }
            searchVerts_b.Enabled = true;

        }
        #region Search for Verts by Axis#
        public void searchForVertByAxisX(float searchValue, bool recurse)
        {
            lb_vertResults.Update();
            if (!recurse)
                lb_vertResults.Items.Clear();
            int _count = 1;
            for (int i = 0; i < _jms._vertices.Count; i++)
            {
                if (_jms._vertices[i].Position.X == searchValue)
                {
                    lb_vertResults.Items.Add(string.Format("Vertice {0}", _count));
                }
                _count++;
            }
            lb_vertResults.EndUpdate();
            searchVerts_b.Enabled = true;
        }

        public void searchForVertByAxisY(float searchValue, bool recurse)
        {
            lb_vertResults.Update();
            if (!recurse)
                lb_vertResults.Items.Clear();
            int _count = 1;
            for (int i = 0; i < _jms._vertices.Count; i++)
            {
                if (_jms._vertices[i].Position.Y == searchValue)
                {
                    //misc.alertbox(string.Format("pass # {0}", i));
                    lb_vertResults.Items.Add(string.Format("Vertice {0}", _count));
                }
                _count++;
            }
            lb_vertResults.EndUpdate();
            searchVerts_b.Enabled = true;
        }

        public void searchForVertByAxisZ(float searchValue, bool recurse)
        {
            lb_vertResults.Update();
            if (!recurse)
                lb_vertResults.Items.Clear();
            int _count = 1;
            for (int i = 0; i < _jms._vertices.Count; i++)
            {
                if (_jms._vertices[i].Position.Z == searchValue)
                {
                    //misc.alertbox(string.Format("pass # {0}", i));
                    lb_vertResults.Items.Add(string.Format("Vertice {0}", _count));
                }
                _count++;
            }
            lb_vertResults.EndUpdate();
            searchVerts_b.Enabled = true;
        }
        #endregion

        private void lb_vertResults_SelectedIndexChanged(object sender, EventArgs e)
        {
            int parseIndex;
            string vertString;
            bool testParse = false;
            parseIndex = lb_vertResults.SelectedIndex;
            vertString = lb_vertResults.Items[parseIndex].ToString();
            testParse = int.TryParse((vertString.Substring(verticeIndex)), out parseIndex);
            tb_resultX.Text = _jms.Vertices[parseIndex - 1].Position.X.ToString();
            tb_resultY.Text = _jms.Vertices[parseIndex - 1].Position.Y.ToString();
            tb_resultZ.Text = _jms.Vertices[parseIndex - 1].Position.Z.ToString();
            tb_normResX.Text = _jms.Vertices[parseIndex - 1].Normal.X.ToString();
            tb_normResY.Text = _jms.Vertices[parseIndex - 1].Normal.Y.ToString();
            tb_normResZ.Text = _jms.Vertices[parseIndex - 1].Normal.Z.ToString();
        }
        private void selectVertButton_Click(object sender, EventArgs e)
        {
            selectVertButton.Enabled = false;
            int selectIndex = 0;
            if (int.TryParse(tb_selVertbyInd.Text, out selectIndex))
                lb_verts.SetSelected((selectIndex - 1), true);
            else misc.alertbox("You did not enter an integer");

            selectVertButton.Enabled = true;
        }
        #endregion

        #region Search for Faces

        private void b_sfaces_Click(object sender, EventArgs e)
        {
            b_sfaces.Enabled = false;
            int selection = -1;
            if (this.cb_sfaces.Text.Equals("Region")) { selection = 0; }
            else if (this.cb_sfaces.Text.Equals("Shaders")) { selection = 1; }
            else if (this.cb_sfaces.Text.Equals("Vertice")) { selection = 2; }
            else { misc.alertbox("Your Entry is invalid, please use the drop down box to select what you want to search for"); b_sfaces.Enabled = true; return; }
            searchForFaceByItemGet(selection);
        }

        public void searchForFaceByItemGet(int selection)
        {
            float myText = 0;
            int searchForThisVert = 0;
            string myRealTXT = this.tb_sfaces.Text;
            bool recurse = false;
            switch (selection)
            {
                case 0: if (searchForFaceByRegion(findRegionExists(myRealTXT), recurse)) { }
                    else { misc.alertbox("Check to be sure that your entry is valid with the list of regions!"); }
                    break;

                case 1: if (searchForFaceByShader(findShaderExists(myRealTXT), recurse)){ }
                    else { misc.alertbox("Your entry is not valid!"); }
                    break;

                case 2: if (int.TryParse(myRealTXT, out searchForThisVert)) searchForFaceByVertex(searchForThisVert, recurse);
                    else if (float.TryParse(myRealTXT, out myText))
                        misc.alertbox("The number you entered was not an integer.");
                    else misc.alertbox("You did not enter a number!");
                    break;
            }
            searchVerts_b.Enabled = true;
        }
        public void searchForFaceByVertex(int searchValue, bool recurse)
        {
            lb_sfaces.Update();
            if (!recurse)
                lb_sfaces.Items.Clear();
            int _count = 1;
            for (int i = 0; i < _jms._faces.Count; i++)
            {
                for (int j = 0; j < _jms._faces[i].vertRefs.Count; j++)
			    {
                    if (_jms._faces[i].vertRefs[i] == searchValue) 
                    {
                        lb_sfaces.Items.Add(string.Format("Face {0}", _count));
                    }
			    }
                _count++;
            }
            lb_sfaces.EndUpdate();
          b_sfaces.Enabled = true;
        }
        private bool searchForFaceByRegion(int regionIndex, bool recurse) {
            if (regionIndex == -2) { misc.alertbox("There is only one region, so we'd be giving you every single face..."); return true; }
            else if (regionIndex == -1) return false;
            else if (regionIndex == -3) { misc.alertbox("This program has encountered an error with the search"); return true; }
            
            lb_sfaces.Update(); 
            if (!recurse) 
                lb_sfaces.Items.Clear();
            int _count = 1; //This was an issue, I don't want it to be one again
            for (int i = 0; i < _jms._faces.Count; i++) //FacCount your face
            {
                if (_jms._faces[i].Face_Region_Index ==  regionIndex) //region index????????
                {
                    lb_sfaces.Items.Add(string.Format("Face {0}", _count));
                }
                _count++;
            }
            lb_sfaces.EndUpdate();
            b_sfaces.Enabled = true;
            return true;
        }
        private int findRegionExists(string region)
        {
            if (_jms._regions.Count > 1) {  //if there are more than 1 specified region
                for (int i = 0; i < _jms._regions.Count; i++) { //go through all the regions
                    if (_jms._regions[i].Name.Equals(region)) //and check to see if we can find our name
                        return i; //Ooohohhh ohhh it's maaaagic!
                }
                return -1; //you didn't enter an existing region
           }
            else if (region.Equals(_jms._regions[0].Name))
                return -2; //if there's only 1 region and our name == it, then no point in searching
            else return -3; //i hate you
        }
        private bool searchForFaceByShader(int shaderIndex, bool recurse)
        {
            if (shaderIndex == -2) { misc.alertbox("There is only one shader, so we'd be giving you every single face..."); return true; }
            else if (shaderIndex == -1) return false;

            lb_sfaces.Update(); //Who let the dogs out? woof wof oough!
            if (!recurse) //silly, this isn't ready yet so it shouldn't be select-able!
                lb_sfaces.Items.Clear(); //out with the old in with the new!
            int _count = 1; //This was an issue, I don't want it to be one again
            for (int i = 0; i < _jms._faces.Count; i++) //FacCount your face
            {
                if (_jms._faces[i].Face_Shader_Index == shaderIndex) //region index????????
                {
                    lb_sfaces.Items.Add(string.Format("Face {0}", _count));
                }
                _count++;
            }
            lb_sfaces.EndUpdate();
            b_sfaces.Enabled = true;
            return true;
        }
        private int findShaderExists(string shader)
        {
            if (_jms._materials.Count > 1)
            {
                for (int i = 0; i < _jms._materials.Count; i++)
                {
                    if (_jms._materials[i].Name.Equals(shader))
                        return i; //Ooohohhh ohhh it's maaaagic!
                }
                return -1; //you didn't enter an existing shader
            }
            else if (shader.Equals(_jms._materials[0].Name))
                return -2; //if there's only 1 shader and our name = it, then no point in searching
            else return -1; //i hate you
        }
        #endregion

        public frm_Main(bool viewer)
        {
            InitializeComponent();
            enableAndShowAll(viewer);
        }
        private void enableAndShowAll(bool viewer)
        {
            
            tb_face_region.ReadOnly = viewer;
            tb_face_shader.ReadOnly = viewer;
            tb_face_vert_x.ReadOnly = viewer;
            tb_face_vert_y.ReadOnly = viewer;
            tb_face_vert_z.ReadOnly = viewer;
            tb_faces.ReadOnly = viewer;
            tb_marker_name.ReadOnly = viewer;
            tb_markers.ReadOnly = viewer;
            tb_markers_parent_index.ReadOnly = viewer;
            tb_markers_rotation_w.ReadOnly = viewer;
            tb_markers_rotation_x.ReadOnly = viewer;
            tb_markers_rotation_y.ReadOnly = viewer;
            tb_markers_rotation_z.ReadOnly = viewer;
            tb_markers_translation_x.ReadOnly = viewer;
            tb_markers_translation_y.ReadOnly = viewer;
            tb_markers_translation_z.ReadOnly = viewer;
            tb_materialName.ReadOnly = viewer;
            tb_materialPath.ReadOnly = viewer;

            tb_resultX.ReadOnly = true;
            tb_resultY.ReadOnly = true;
            tb_resultZ.ReadOnly = true;

            tb_normResX.ReadOnly = true;
            tb_normResY.ReadOnly = true;
            tb_normResZ.ReadOnly = true;

            tb_materials.ReadOnly = true;
            tb_faces.ReadOnly = true;
            tb_regions.ReadOnly = true;
            tb_nodes.ReadOnly = true;
            tb_markers.ReadOnly = true;
            tb_verts.ReadOnly = true;

            tb_node_childIndex.ReadOnly = viewer;
            tb_node_rotation_w.ReadOnly = viewer;
            tb_node_rotation_x.ReadOnly = viewer;
            tb_node_rotation_y.ReadOnly = viewer;
            tb_node_rotation_z.ReadOnly = viewer;
            tb_node_sibling_index.ReadOnly = viewer;
            tb_node_translation_x.ReadOnly = viewer;
            tb_node_translation_y.ReadOnly = viewer;
            tb_node_translation_z.ReadOnly = viewer;
            tb_nodeName.ReadOnly = viewer;
            tb_nodes.ReadOnly = viewer;
            tb_RegionName.ReadOnly = viewer;
            tb_regions.ReadOnly = viewer;
            tb_selVertbyInd.ReadOnly = viewer;
            tb_sfaces.ReadOnly = viewer;
            tb_vert_normal_x.ReadOnly = viewer;
            tb_vert_normal_y.ReadOnly = viewer;
            tb_vert_normal_z.ReadOnly = viewer;
            tb_vert_position_x.ReadOnly = viewer;
            tb_vert_position_y.ReadOnly = viewer;
            tb_vert_position_z.ReadOnly = viewer;
            tb_vert_tx.ReadOnly = viewer;
            tb_vert_ty.ReadOnly = viewer;
            tb_verts.ReadOnly = viewer;
            tb_verts_one_index.ReadOnly = viewer;
            tb_verts_one_weight.ReadOnly = viewer;
            tb_verts_zero_index.ReadOnly = viewer;
            btn_load.Enabled = viewer;

        }

        //returns true if that Material was valid
        private bool searchMaterialsByName(string text, string path) {
            bool validName = true;
            bool mmmmm = true;
            if ((_jms._materials.Count > 0) && (string.Empty != text))
            {
                if ((!text.Equals(_jms._materials[0].Name)))
                {
                    for (int i = 0; i < _jms._materials.Count; i++)
                    {
                        if (text.Equals(_jms._materials[0].Name))
                        {
                            misc.alertbox("The name you entered already exists!");
                            mmmmm = false;
                        }
                    }
                    validName = mmmmm;
                }
                else { misc.alertbox("the text you entered was the exact same as the first item"); }
            }
            else if (text.Equals(string.Empty)){
                misc.alertbox("The name you entered was empty!");
                validName = false;
                }

            if (!path.ToLower().Equals("<none>")) {
                misc.alertbox("We detected that the path does not equal \"<none>\". Be careful.");
                    }
            return validName;
        }

        private void btn_mattAdd_Click(object sender, EventArgs e)
        {
            //if name isn't the exact same as the name of another material type.
            if (searchMaterialsByName(tb_materialName.Text, tb_materialPath.Text) == false) {
                return;
            }
            
            Materials myMat = new Materials();
            myMat.Name = tb_materialName.Text;
            myMat.Path = tb_materialPath.Text;
            
            _jms._materials.Add(myMat);
            lb_materials.Items.Add(myMat.Name);
            //_jms.Vertices[]
        }

        private void frm_Main_Load_1(object sender, EventArgs e)
        {

        }

        private void b_TestOptimize_Click(object sender, EventArgs e)
        {
            this._jms.OptimizeJMS();
            refresh_data();
        }

        private void saveJMS_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog _SFD = new SaveFileDialog { Title = "JMS", Filter = "JMS File|*.jms" })
            {
                if (_SFD.ShowDialog().Equals(DialogResult.OK))
                {
                    this._jms.Save(_SFD.FileName);
                    refresh_data();
                }

            }
        }


    }
}