using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using BlamLib;
using BlamLib.Blam.Halo1;
using JMS_Explorer;
namespace _JMS
{
    /// <summary>
    /// A JMS file.
    /// </summary>
    /// <remarks></remarks>
    public class JMS
    {
        //Variables
        public string _version;
        public string _checksum;

        public List<Node> _nodes;
        public List<Materials> _materials;
        public List<Region> _regions;
        public List<Marker> _markers;
        public List<Vertice> _vertices;

        public List<Face> _faces;


        #region Properties (Read Only)

        public string Checksum
        {
            get { return _checksum; }
        }

        public string Version
        {
            get { return _version; }
        }

        public List<Node> Nodes
        {
            get { return _nodes; }
        }

        public List<Materials> MaterialList
        {
            get { return _materials; }
        }

        public List<Region> Regions
        {
            get { return _regions; }
        }

        public List<Marker> Markers
        {
            get { return _markers; }
        }

        public List<Vertice> Vertices
        {
            get { return _vertices; }
        }

        #endregion

        //Subroutines
        /// <summary>
        /// Creates a blank JMS class.
        /// </summary>
        /// <remarks></remarks>

        public JMS()
        {
            //Initialize variables
            _version = "8200";
            _checksum = "3251";
            _nodes = new List<Node>();
            _materials = new List<Materials>();
            _regions = new List<Region>();
            _markers = new List<Marker>();
            _vertices = new List<Vertice>();
            _faces = new List<Face>();
        }

        /// <summary>
        /// Creates a JMS class and loads a file into it.
        /// </summary>
        /// <param name="file">The JMS file to load in.</param>
        /// <remarks></remarks>
        public void Load(string file)
        {
            if (System.IO.File.Exists(file))
            {
                System.IO.StreamReader _sr = new System.IO.StreamReader(file);
                _version = _sr.ReadLine();
                _checksum = _sr.ReadLine();

                #region LoadNodes
                _nodes.Capacity = Convert.ToInt32(_sr.ReadLine());

                for (int i = 1; i <= _nodes.Capacity; i++)
                {
                    Node _node = new Node();
                    _node.Name = _sr.ReadLine();
                    _node.child_index = Convert.ToInt32(_sr.ReadLine());
                    _node.next_sibling_index = Convert.ToInt32(_sr.ReadLine());

                    List<string> _rotation = new List<string>(_sr.ReadLine().Split('\t'));
                    _node.Rotation = new RotatationXYZW
                    {
                        X = Convert.ToSingle(_rotation[0]),
                        Y = Convert.ToSingle(_rotation[1]),
                        Z = Convert.ToSingle(_rotation[2]),
                        W = Convert.ToSingle(_rotation[3])
                    };

                    //Translation
                    List<string> _translation = new List<string>(_sr.ReadLine().Split('\t'));
                    _node.Translation = new TranslationXYZ
                    {
                        X = Convert.ToSingle(_translation[0]),
                        Y = Convert.ToSingle(_translation[1]),
                        Z = Convert.ToSingle(_translation[2])
                    };

                    this._nodes.Add(_node);

                }
                #endregion
                #region LoadMats
                _materials.Capacity = Convert.ToInt32(_sr.ReadLine());

                for (int i = 1; i <= _materials.Capacity; i++)
                {
                    Materials _materialStructure = new Materials();
                    _materialStructure.Name = _sr.ReadLine();
                    _materialStructure.Path = _sr.ReadLine();
                    _materials.Add(_materialStructure);
                }
                #endregion
                #region LoadMarkers
                _markers.Capacity = Convert.ToInt32(_sr.ReadLine());
                if (_markers.Capacity > 0)
                {
                    for (int i = 1; i <= _markers.Capacity; i++)
                    {
                        Marker _marker = new Marker();
                        _marker.Name = _sr.ReadLine();
                        _marker.Unknown_Value_One = Convert.ToInt32(_sr.ReadLine());
                        _marker.parent_index = Convert.ToInt32(_sr.ReadLine());
                        List<string> _rotationList = new List<string>(_sr.ReadLine().Split('\t'));
                        _marker.Rotation = new RotatationXYZW
                        {
                            X = Convert.ToSingle(_rotationList[0]),
                            Y = Convert.ToSingle(_rotationList[1]),
                            Z = Convert.ToSingle(_rotationList[2]),
                            W = Convert.ToSingle(_rotationList[3])
                        };

                        List<string> _translationList = new List<string>(_sr.ReadLine().Split('\t'));
                        _marker.Translation = new TranslationXYZ
                        {
                            X = Convert.ToSingle(_translationList[0]),
                            Y = Convert.ToSingle(_translationList[1]),
                            Z = Convert.ToSingle(_translationList[2])
                        };

                        _marker.Unknown_Value_Two = Convert.ToSingle(_sr.ReadLine());

                        //Add to the main list
                        _markers.Add(_marker);

                    }

                }
                #endregion

                #region LoadRegions
                _regions.Capacity = Convert.ToInt32(_sr.ReadLine());
                for (int i = 1; i <= _regions.Capacity; i++)
                {
                    _regions.Add(new Region { Name = _sr.ReadLine() });
                }
                #endregion

                #region LoadVertices
                _vertices.Capacity = Convert.ToInt32(_sr.ReadLine());
                for (int i = 1; i <= _vertices.Capacity; i++)
                {
                    Vertice _vert = new Vertice();
                    _vert.node_zero_index = Convert.ToInt32(_sr.ReadLine());
                    List<string> _postitionList = new List<string>(_sr.ReadLine().Split('\t'));
                    _vert.Position = new TranslationXYZ
                    {
                        X = Convert.ToSingle(_postitionList[0]),
                        Y = Convert.ToSingle(_postitionList[1]),
                        Z = Convert.ToSingle(_postitionList[2])
                    };
                    List<string> _normalList = new List<string>(_sr.ReadLine().Split('\t'));
                    _vert.Normal = new TranslationXYZ
                    {
                        X = Convert.ToSingle(_normalList[0]),
                        Y = Convert.ToSingle(_normalList[1]),
                        Z = Convert.ToSingle(_normalList[2])
                    };
                    _vert.node_one_index = Convert.ToInt32(_sr.ReadLine());
                    _vert.node_one_weight = Convert.ToInt32(_sr.ReadLine());
                    
                    _vert.tvert_PositionX = Convert.ToSingle(_sr.ReadLine());
                    _vert.tvert_PositionY = Convert.ToSingle(_sr.ReadLine());
                    _sr.ReadLine();
                    _vertices.Add(_vert);
                }
                #endregion
                #region LoadFaces
                _faces.Capacity = Convert.ToInt32(_sr.ReadLine());
                for (int i = 0; i < _faces.Capacity; i++)
                {
                    Face _face = new Face();
                    _face.Face_Region_Index = Convert.ToInt32(_sr.ReadLine());
                    _face.Face_Shader_Index = Convert.ToInt32(_sr.ReadLine());
                    List<string> _verts = new List<string>(_sr.ReadLine().Split('\t'));
                    for (int j = 0; j < 3; j++)
                    {
                        _face.vertRefs.Add(Convert.ToUInt16(_verts[j]));
                    }
                    _faces.Add(_face);
                }
                #endregion
                _sr.Close();

            }
        }
        
        public JMS(string file)
            : this()
        {
            /*
            //Initialize
            if (System.IO.File.Exists(file))
            {

                System.IO.StreamReader _sr = new System.IO.StreamReader(file);
                _version = _sr.ReadLine();
                _checksum = _sr.ReadLine();

                #region LoadNodes
                _nodes.Capacity = Convert.ToInt32(_sr.ReadLine());

                for (int i = 0; i < _nodes.Capacity; i++)
                {
                    Node _node = new Node();
                    _node.Name = _sr.ReadLine();
                    _node.child_index = Convert.ToInt32(_sr.ReadLine());
                    _node.next_sibling_index = Convert.ToInt32(_sr.ReadLine());

                    List<string> _rotation = new List<string>(_sr.ReadLine().Split('\t'));
                    _node.Rotation = new RotatationXYZW
                    {
                        X = Convert.ToDecimal(_rotation[0]),
                        Y = Convert.ToDecimal(_rotation[1]),
                        Z = Convert.ToDecimal(_rotation[2]),
                        W = Convert.ToDecimal(_rotation[3])
                    };

                    //Translation
                    List<string> _translation = new List<string>(_sr.ReadLine().Split('\t'));
                    _node.Translation = new TranslationXYZ
                    {
                        X = Convert.ToDecimal(_translation[0]),
                        Y = Convert.ToDecimal(_translation[1]),
                        Z = Convert.ToDecimal(_translation[2])
                    };

                    this._nodes.Add(_node);

                }
                #endregion
                #region LoadMats
                _materials.Capacity = Convert.ToInt32(_sr.ReadLine());

                for (int i = 0; i < _materials.Capacity; i++)
                {
                    Materials _materialStructure = new Materials();
                    _materialStructure.Name = _sr.ReadLine();
                    _materialStructure.Path = _sr.ReadLine();
                    _materials.Add(_materialStructure);
                }
                #endregion
                #region LoadMarkers
                _markers.Capacity = Convert.ToInt32(_sr.ReadLine());
                if (_markers.Capacity > 0)
                {
                    for (int i = 0; i < _markers.Capacity; i++)
                    {
                        Marker _marker = new Marker();
                        _marker.Name = _sr.ReadLine();
                        _marker.Unknown_Value_One = Convert.ToInt32(_sr.ReadLine());
                        _marker.parent_index = Convert.ToInt32(_sr.ReadLine());
                        List<string> _rotationList = new List<string>(_sr.ReadLine().Split('\t'));
                        _marker.Rotation = new RotatationXYZW
                        {
                            X = Convert.ToDecimal(_rotationList[0]),
                            Y = Convert.ToDecimal(_rotationList[1]),
                            Z = Convert.ToDecimal(_rotationList[2]),
                            W = Convert.ToDecimal(_rotationList[3])
                        };

                        List<string> _translationList = new List<string>(_sr.ReadLine().Split('\t'));
                        _marker.Translation = new TranslationXYZ
                        {
                            X = Convert.ToDecimal(_translationList[0]),
                            Y = Convert.ToDecimal(_translationList[1]),
                            Z = Convert.ToDecimal(_translationList[2])
                        };

                        _marker.Unknown_Value_Two = Convert.ToDecimal(_sr.ReadLine());

                        //Add to the main list
                        _markers.Add(_marker);
                    }
                }
                #endregion

                #region LoadRegions
                _regions.Capacity = Convert.ToInt32(_sr.ReadLine());
                for (int i = 0; i < _regions.Capacity; i++)
                {
                    _regions.Add(new Region { Name = _sr.ReadLine() });
                }
                #endregion

                #region LoadVertices
                _vertices.Capacity = Convert.ToInt32(_sr.ReadLine());
                for (int i = 0;
                    i < _vertices.Capacity;
                    i++)
                {
                    Vertice _vert = new Vertice();
                    _vert.node_zero_index = Convert.ToInt32(_sr.ReadLine());
                    List<string> _postitionList = new List<string>(_sr.ReadLine().Split('\t'));
                    _vert.Position = new TranslationXYZ
                    {
                        X = Convert.ToDecimal(_postitionList[0]),
                        Y = Convert.ToDecimal(_postitionList[1]),
                        Z = Convert.ToDecimal(_postitionList[2])
                    };
                    List<string> _normalList = new List<string>(_sr.ReadLine().Split('\t'));
                    _vert.Normal = new TranslationXYZ
                    {
                        X = Convert.ToDecimal(_normalList[0]),
                        Y = Convert.ToDecimal(_normalList[1]),
                        Z = Convert.ToDecimal(_normalList[2])
                    };
                    _vert.node_one_index = Convert.ToInt32(_sr.ReadLine());
                    _vert.node_one_weight = Convert.ToInt32(_sr.ReadLine());
                    _vert.tvert_PositionX = Convert.ToDecimal(_sr.ReadLine());
                    _vert.tvert_PositionY = Convert.ToDecimal(_sr.ReadLine());
                    _sr.ReadLine();
                    _vertices.Add(_vert);
                }
                #endregion
                #region LoadFaces
                _faces.Capacity = Convert.ToInt32(_sr.ReadLine());
                for (int i = 0; i < _faces.Capacity; i++)
                {
                    Face _face = new Face();
                    _face.Face_Region_Index = Convert.ToInt32(_sr.ReadLine());
                    _face.Face_Shader_Index = Convert.ToInt32(_sr.ReadLine());
                    List<string> _verts = new List<string>(_sr.ReadLine().Split('\t'));
                    for (int j = 0; j < 3; j++)
                        _face.vertRefs.Add(Convert.ToUInt16(_verts[j]));
                    _faces.Add(_face);
                }
                #endregion
                _sr.Close();

                //Load the file.
            }
             * */
    //      this = Load(file);
        }
              
        public void Save(string file)
        {
            System.IO.StreamWriter _sw = new StreamWriter(file);
            _sw.WriteLine(_version);
            _sw.WriteLine(_checksum);

            #region saveNodes
            _sw.WriteLine(_nodes.Count);
            for (int i = 0; i < _nodes.Count; i++)
            {
                _sw.WriteLine(_nodes[i].Name);
                _sw.WriteLine(_nodes[i].child_index);
                _sw.WriteLine(_nodes[i].next_sibling_index);
                _sw.WriteLine(String.Format("{0}\t{1}\t{2}\t{3}", _nodes[i].Rotation.X, _nodes[i].Rotation.Y,
                                                _nodes[i].Rotation.Z, _nodes[i].Rotation.W));
                _sw.WriteLine(String.Format("{0}\t{1}\t{2}", _nodes[i].Translation.X, _nodes[i].Translation.Y,
                                               _nodes[i].Translation.Z));
            }
            #endregion

            #region saveMaterials
            _sw.WriteLine(_materials.Count);

            for (int i = 0; i < _materials.Count; i++)
            {
                _sw.WriteLine(_materials[i].Name);
                _sw.WriteLine(_materials[i].Path);
            }
            #endregion

            #region saveMarkers
            _sw.WriteLine(_markers.Count);
            if (_markers.Count > 0)
            {
                for (int i = 0; i < _markers.Count; i++)
                {
                    _sw.WriteLine(_markers[i].Name);
                    _sw.WriteLine(_markers[i].Unknown_Value_One);
                    _sw.WriteLine(_markers[i].parent_index);
                    _sw.WriteLine(String.Format("{0}\t{1}\t{2}\t{3}", _markers[i].Rotation.X, _markers[i].Rotation.Y,
                                    _markers[i].Rotation.Z, _markers[i].Rotation.W));
                    _sw.WriteLine(String.Format("{0}\t{1}\t{2}", _markers[i].Translation.X, _markers[i].Translation.Y,
                                   _markers[i].Translation.Z));
                    _sw.WriteLine(_markers[i].Unknown_Value_Two);
                }
            }
            #endregion

            #region saveRegions
            _sw.WriteLine(_regions.Count);
            for (int i = 0; i < _regions.Count; i++)
            {
                _sw.WriteLine(_regions[i].Name);
            }
            #endregion

            #region saveVertices
            _sw.WriteLine(_vertices.Count);
            for (int i = 0; i < _vertices.Count; i++)
            {
                _sw.WriteLine(_vertices[i].node_zero_index);
                _sw.WriteLine(String.Format("{0}\t{1}\t{2}", _vertices[i].Position.X, _vertices[i].Position.Y,
                      _vertices[i].Position.Z));
                _sw.WriteLine(String.Format("{0}\t{1}\t{2}", _vertices[i].Normal.X, _vertices[i].Normal.Y,
                      _vertices[i].Normal.Z));
                _sw.WriteLine(_vertices[i].node_one_index);
                _sw.WriteLine(_vertices[i].node_one_weight);
                _sw.WriteLine(_vertices[i].tvert_PositionX);
                _sw.WriteLine(_vertices[i].tvert_PositionY);
                _sw.WriteLine(0);
            }
            #endregion

            #region saveFaces
            _sw.WriteLine(_faces.Count);
            for (int i = 0; i < _faces.Count; i++)
            {
                _sw.WriteLine(_faces[i].Face_Region_Index);
                _sw.WriteLine(_faces[i].Face_Shader_Index);
                for (int j = 0; j < 3; j++)
                {
                    if (j == 0)
                        _sw.WriteLine(String.Format("{0}", _faces[i].vertRefs[j]));
                    else _sw.Write(String.Format("\t{0}", _faces[i].vertRefs[j]));
                }
                
            }
            #endregion

            _sw.Close();
        }
        /// <summary>
        /// Load the JMS File into the class.
        /// </summary>
        /// <param name="file">The path to the file.</param>
        /// <remarks></remarks>
        /// 
        /*
        public void Load(string file)
        {
            if (System.IO.File.Exists(file))
            {

                System.IO.StreamReader _sr = new System.IO.StreamReader(file);
                _version = _sr.ReadLine();
                _checksum = _sr.ReadLine();

                #region LoadNodes
                _nodes.Capacity = Convert.ToInt32(_sr.ReadLine());

                for (int i = 0; i < _nodes.Capacity; i++)
                {
                    Node _node = new Node();
                    _node.Name = _sr.ReadLine();
                    _node.child_index = Convert.ToInt32(_sr.ReadLine());
                    _node.next_sibling_index = Convert.ToInt32(_sr.ReadLine());

                    List<string> _rotation = new List<string>(_sr.ReadLine().Split('\t'));


                    //Translation
                    List<string> _translation = new List<string>(_sr.ReadLine().Split('\t'));
                    _node.Translation = new TranslationXYZ
                    {
                        X = Convert.ToDecimal(_translation[0]),
                        Y = Convert.ToDecimal(_translation[1]),
                        Z = Convert.ToDecimal(_translation[2])
                    };

                    this._nodes.Add(_node);

                }
                #endregion
                #region LoadMats
                _materials.Capacity = Convert.ToInt32(_sr.ReadLine());

                for (int i = 0; i < _materials.Capacity; i++)
                {
                    Materials _materialStructure = new Materials();
                    _materialStructure.Name = _sr.ReadLine();
                    _materialStructure.Path = _sr.ReadLine();
                    _materials.Add(_materialStructure);
                }
                #endregion
                #region LoadMarkers
                _markers.Capacity = Convert.ToInt32(_sr.ReadLine());
                if (_markers.Capacity > 0)
                {
                    for (int i = 0; i < _markers.Capacity; i++)
                    {
                        Marker _marker = new Marker();
                        _marker.Name = _sr.ReadLine();
                        _marker.Unknown_Value_One = Convert.ToInt32(_sr.ReadLine());
                        _marker.parent_index = Convert.ToInt32(_sr.ReadLine());
                        List<string> _rotationList = new List<string>(_sr.ReadLine().Split('\t'));
                        _marker.Rotation = new RotatationXYZW
                        {
                            X = Convert.ToDecimal(_rotationList[0]),
                            Y = Convert.ToDecimal(_rotationList[1]),
                            Z = Convert.ToDecimal(_rotationList[2]),
                            W = Convert.ToDecimal(_rotationList[3])
                        };

                        List<string> _translationList = new List<string>(_sr.ReadLine().Split('\t'));
                        _marker.Translation = new TranslationXYZ
                        {
                            X = Convert.ToDecimal(_translationList[0]),
                            Y = Convert.ToDecimal(_translationList[1]),
                            Z = Convert.ToDecimal(_translationList[2])
                        };

                        _marker.Unknown_Value_Two = Convert.ToDecimal(_sr.ReadLine());

                        //Add to the main list
                        _markers.Add(_marker);
                    }
                }
                #endregion

                #region LoadRegions
                _regions.Capacity = Convert.ToInt32(_sr.ReadLine());
                for (int i = 0; i < _regions.Capacity; i++)
                {
                    _regions.Add(new Region { Name = _sr.ReadLine() });
                }
                #endregion

                #region LoadVertices
                _vertices.Capacity = Convert.ToInt32(_sr.ReadLine());
                for (int i = 0; 
                    i < _vertices.Capacity; 
                    i++)
                {
                    Vertice _vert = new Vertice();
                    _vert.node_zero_index = Convert.ToInt32(_sr.ReadLine());
                    List<string> _postitionList = new List<string>(_sr.ReadLine().Split('\t'));
                    _vert.Position = new TranslationXYZ
                    {
                        X = Convert.ToDecimal(_postitionList[0]),
                        Y = Convert.ToDecimal(_postitionList[1]),
                        Z = Convert.ToDecimal(_postitionList[2])
                    };
                    List<string> _normalList = new List<string>(_sr.ReadLine().Split('\t'));
                    _vert.Normal = new TranslationXYZ
                    {
                        X = Convert.ToDecimal(_normalList[0]),
                        Y = Convert.ToDecimal(_normalList[1]),
                        Z = Convert.ToDecimal(_normalList[2])
                    };
                    _vert.node_one_index = Convert.ToInt32(_sr.ReadLine());
                    _vert.node_one_weight = Convert.ToInt32(_sr.ReadLine());
                    _vert.tvert_PositionX = Convert.ToDecimal(_sr.ReadLine());
                    _vert.tvert_PositionY = Convert.ToDecimal(_sr.ReadLine());
                    _sr.ReadLine();
                    _vertices.Add(_vert);
                }
                #endregion
                #region LoadFaces
                _faces.Capacity = Convert.ToInt32(_sr.ReadLine());
                for (int i = 0; i < _faces.Capacity; i++)
                {
                    Face _face = new Face();
                    _face.Face_Region_Index = Convert.ToInt32(_sr.ReadLine());
                    _face.Face_Shader_Index = Convert.ToInt32(_sr.ReadLine());
                    List<string> _verts = new List<string>(_sr.ReadLine().Split('\t'));
                    for (int j = 0; j < 3; j++)
                        _face.vertRefs.Add(Convert.ToUInt16(_verts[j])); 
                    _faces.Add(_face);
                }
                #endregion
                _sr.Close();

            }
        }
        */
        public BlamLib.Blam.Halo1.Tags.scenario_structure_bsps_block compileIntoBSP()
        {


           //  supBSP = new BlamLib.Blam.Halo1.Tags.scenario_structure_bsps_block();
            return new BlamLib.Blam.Halo1.Tags.scenario_structure_bsps_block();

        }
        public void OptimizeJMS()
        {
            _version = "8231";
            _checksum = "3251";
            if ((this._faces.Count == 0) || (this._vertices.Count == 0))
            {
                System.Windows.Forms.MessageBox.Show("Can't optimize a model without any faces or verts!");
                return;
            }
            List<optiVerts> lopti = new List<optiVerts>(_vertices.Count);
            List<Vertice> verts = _vertices;

                //List<Vertice> matchingVerts = new List<Vertice>(); //I have a thing called optiVerts where it stores the original vert index #
                //// and has a list of uints for general purpose but i was going to use them
                ////to store the indices to other verts that are the exact same.
                ////i'm old school.

                //// Let's get our verticies
                //for (int i = 2; i < verts.Count - 1; i += 3)
                //{

                //    // Get our first pair of verts
                //    Vertice _v1 = verts[i];
                //    Vertice _v2 = verts[i + 1]; //only the 3rd and 4th verts will match. Look at my start index and the count. o

                //    // These two verts -should- match in their position
                //    if (_v1.Position.Equals(_v2.Position))
                //    {
                //        // We need to store these in a secondary list
                //        matchingVerts.Add(_v1);
                //        matchingVerts.Add(_v2);
                //    }


                //}

            // Now we have our matching verts, get a list of faces for the second vert
            // No lol, this makes a copy of the verts.
            List<UInt16>  idk = Face.getStraightVertIndexList(_faces);
            List<Vertice> temV = new List<Vertice>(_vertices.ToArray());
            List<Vertice> puree = new List<Vertice>(temV.Count / 3);
            for (int i = 0; i < temV.Count; i++)
            {
                puree.Add(temV[i]);
                //temV.RemoveAll(temV[i]);
            }

            for (int i = 0; i < idk.Count; i++)
            {
                Int32 f = Vertice.FindIndex(puree, _vertices[idk[i]]);
                if (f >= 0)
                {
                    idk[i] = (ushort)f;
                }
                else
                {
                    Console.WriteLine(String.Format("puree does not contain vertex: {0}", idk[i]));
                }

            }
                
        }
    }
}

