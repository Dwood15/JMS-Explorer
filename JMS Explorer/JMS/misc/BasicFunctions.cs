using System.Windows.Forms;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using Microsoft.DirectX;
using Microsoft.DirectX.Direct3D;
using System;
using _JMS;
namespace JMS_Explorer
{
    static class misc
    {
        public static Matrix identityMatrix = Matrix.Identity;

        /// <summary>
        /// Creates an alertbox to tell user something went wrong
        /// </summary>
        /// <param name="message"></param>
        public static void alertbox(string message)
        {
            const string caption = "You did something I can't handle";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.OK,
                                         MessageBoxIcon.Error);
            return;
        }

        #region DX Conversions
        public static CustomVertex.PositionNormal vertexToCustomVertexPN(Vertice myVertex)
        {
            CustomVertex.PositionNormal cvpn_Vert = new CustomVertex.PositionNormal();
            return cvpn_Vert;
        }

        public static List<CustomVertex.PositionNormal> verticesToCustomVertex(List<Vertice> myVerts)
        {
            List<CustomVertex.PositionNormal> cust_Verts = new List<CustomVertex.PositionNormal>();
            CustomVertex.PositionNormal tempVertex = new CustomVertex.PositionNormal();
            Vector3 tempVector = new Vector3();
            for (int i = 0; i < myVerts.Count; i++)
            {
                tempVector.X = (float)myVerts[i].Normal.X;
                tempVector.Y = (float)myVerts[i].Normal.Y;
                tempVector.Z = (float)myVerts[i].Normal.Z;
                tempVertex.Normal = tempVector;
                tempVector.X = (float)myVerts[i].Position.X;
                tempVector.Y = (float)myVerts[i].Position.Y;
                tempVector.Z = (float)myVerts[i].Position.Z;
                tempVertex.Position = tempVector;
                cust_Verts.Add(tempVertex);
            }
            return cust_Verts;
        }

        // O is your object's position
        // P is the position of the object to face
        // U is the nominal "up" vector (typically Vector3.Y)
        // Note: this does not work when O is straight below or straight above P
        ///<summary>
        ///Returns a rotation Matrix, O = Object Position, P = position of object to face, U = "Up" direction
        ///</summary>
        ///<remarks>Don't Call unless objects are on the same level</remarks>
        public static Matrix RotateToFace(Vector3 O, Vector3 P, Vector3 U)
        {
            Vector3 D = (O - P);
            Vector3 Right = Vector3.Cross(U, D);
            Right = Vector3.Normalize(Right);
            Vector3 Backwards = Vector3.Cross(Right, U);
            Backwards = Vector3.Normalize(Backwards);
            Vector3 Up = Vector3.Cross(Backwards, Right);
            Matrix rot = new Matrix();
            rot.M11 = Right.X;
            rot.M12 = Right.Y;
            rot.M13 = Right.Z;
            rot.M14 = 0;
            rot.M21 = Up.X;
            rot.M22 = Up.Y;
            rot.M23 = Up.Z;
            rot.M24 = 0;
            rot.M31 = Backwards.X;
            rot.M32 = Backwards.Y;
            rot.M33 = Backwards.Z;
            rot.M34 = 0;
            rot.M41 = 0;
            rot.M42 = 0;
            rot.M43 = 0;
            rot.M44 = 1;





            return rot;
        }
        #endregion

        /// <summary>
        /// Merges two JMS files and moves them to fit each other based on material names and the locations of the faces to move to one another
        /// </summary>
        /// <param name="s_JMS">Source jms </param>
        /// <param name="d_JMS">Destination JMS (the one we're adding to, ie the algo moves s_JMS to this one)</param>
        /// <param name="goldenMatName"></param>
        /// <param name="expectFaces"></param>
        /// <param name="success"></param>
        /// <returns></returns>

        public static _JMS.JMS mergeJMS(_JMS.JMS s_JMS, _JMS.JMS d_JMS, string goldenMatName, int expectFaces, out bool success)
        {
            List<Vertice> tempVert = new List<Vertice>();
            List<Materials> tempMaterials = new List<Materials>();
            List<Face> tempFaces = new List<Face>();
            List<Face> truPrivFaces = new List<Face>();
            if ((isValidJMSForModularity(s_JMS, true) && isValidJMSForModularity(d_JMS)))
            {
                if (translateVertices(s_JMS._vertices, s_JMS._faces, d_JMS._vertices, d_JMS._faces, goldenMatName, s_JMS._materials, d_JMS._materials, expectFaces, out tempVert))
                {

                    s_JMS._materials = removeDupesAndMergeMats(s_JMS.MaterialList, d_JMS.MaterialList);
                    //nothin wrong with that function


                    //Now I need to shift the vertex index of the triangles of d_JMS to fit the vertices in s_JMS now.
                    {
                        List<Face> shoopDaWoop = new List<Face>();
                        for (int i = 0; i < d_JMS._faces.Count; i++)
                        {
                            Face pivaatFace = d_JMS._faces[i];
                            for (int j = 0; j < 3; j++)
                            {
                                pivaatFace.vertRefs[i] += (ushort)s_JMS._vertices.Count;
                            }

                            shoopDaWoop.Add(pivaatFace);
                        }
                        s_JMS._faces.AddRange(shoopDaWoop);
                    }

                    //What do i need to do?  
                    //I've removed duplicate materials, merged them together, and merged them into the s_jms._vertices
                    s_JMS._vertices.AddRange(tempVert); //Add our vertices to the end of the file




                    // int afterThought = getIndexOfMatByNameNoCheck(s_JMS._materials, goldenMatName);

                    alertbox("SUCCESS!");
                    success = true;
                    return s_JMS;
                }
                else
                {
                    success = false;
                    alertbox("FAILURE");
                    return new _JMS.JMS();
                }
            }
            success = false;
            return new _JMS.JMS();
        }



        public static bool facesContainVertice(List<Face> privFaces, int vertIndex)
        {
            for (int i = 0; i < privFaces.Count; i++)
            {
                if ((privFaces[i].vertRefs[0] == vertIndex) ||
                    (privFaces[i].vertRefs[1] == vertIndex) ||
                    (privFaces[i].vertRefs[2] == vertIndex)) 
                { return true; }
            }
            return false;
        }

        public static bool isValidJMSForModularity(_JMS.JMS myJMS, bool baseJMS)
        {
            if (myJMS.Markers.Count > 0) { alertbox("The Base JMS has markers. this is a no-no. Remove them, then export again"); return false; }
            if (myJMS.Nodes.Count > 1) { alertbox("The nodes count for the base jms is too many. Reduce the # of nodes and re-export"); return false; }
            if (myJMS.Regions.Count > 1) { alertbox("The region count for the base jms is too many. Reduce the # of regions and re-export"); return false; }
            if (!myJMS.Regions[0].Name.Equals("unnamed")) { alertbox(String.Format("The region name {0} for the base JMS is not \"unnamed\" please fix and re-export", myJMS.Regions[0].Name)); return false; }
            return true;
        }
        public static bool isValidJMSForModularity(_JMS.JMS myJMS)
        {
            if (myJMS.Markers.Count > 0) { alertbox("The Appending JMS has markers. this is a no-no. Remove them, then export again"); return false; }
            if (myJMS.Nodes.Count > 1) { alertbox("The nodes count for the appending jms is too many. Reduce the # of nodes and re-export"); return false; }
            if (myJMS.Regions.Count > 1) { alertbox("The region count for the appending jms is too many. Reduce the # of regions and re-export"); return false; }
            if (!myJMS.Regions[0].Name.Equals("unnamed")) { alertbox(String.Format("The region name {0} for the appending JMS is not \"unnamed\" please fix and re-export", myJMS.Regions[0].Name)); return false; }
            return true;
        }

        public static List<Face> butcherFaceMatIDs(List<Materials> s_Mats, List<Materials> d_Mats, List<Face> s_Faces, List<Face> d_Faces,
                                                   List<Vertice> cs_Vertices, List<Vertice> cd_Vertices)
        {
            Face tempFace = new Face();
            List<Face> privTempFaces = new List<Face>();
            int tempInt;
            for (int i = 0; i < d_Faces.Count; i++)
            {
                tempFace = d_Faces[i];
                if (getIndexOfMatByName(s_Mats, d_Mats[d_Faces[i].Face_Shader_Index].Name, out tempInt))
                {
                    tempFace.Face_Shader_Index = tempInt; //The past line is VERY VOLATILE. YOU BETTER BE SURE YOU PASS THE RIGHT 
                    tempFace = reAlignFaceVerts(tempFace, cd_Vertices, cs_Vertices);

                    privTempFaces.Add(tempFace);
                }
            }
            s_Faces.AddRange(privTempFaces); //those poor innocent little children
            return s_Faces;
        }

        //Volatile function, bad coding style, 
        //In the future need to set functions to bools and use OUT parameters
        public static Face reAlignFaceVerts(Face privFaces, List<Vertice> d_Verts, List<Vertice> s_Verts)
        {
            Vertice tempVert = new Vertice();
            List<Vertice> mergeVertLists = s_Verts; //those poor little innocent children
            mergeVertLists.AddRange(d_Verts);
            //It's 3 pm and my Roomie is still asleep
            tempVert = d_Verts[privFaces.vertRefs[0]]; //if it has 1 vert, it has the other 2 right after it.
            if (mergeVertLists.Contains(tempVert))
            {
                Face tempFace = new Face();
                tempFace.vertRefs[0] = Convert.ToUInt16(mergeVertLists.IndexOf(tempVert));
                tempFace.vertRefs[1] = Convert.ToUInt16(mergeVertLists.IndexOf(d_Verts[privFaces.vertRefs[1]]));
                tempFace.vertRefs[2] = Convert.ToUInt16(mergeVertLists.IndexOf(d_Verts[privFaces.vertRefs[2]]));

                //repeat for vert two and three then reassign to the idnex number.
                privFaces = tempFace;
            }

            return privFaces;
        }

        public static int getIndexOfMatByNameNoCheck(List<Materials> mats, string name)
        {
            for (int i = 0; i < mats.Count; i++)
            {
                if (name.Equals(mats[i].Name)) { return i; }
            }
            return -1;


        }

        public static bool getIndexOfMatByName(List<Materials> mats, string name, out int index)
        {
            for (int i = 0; i < mats.Count; i++)
            {
                if (name.Equals(mats[i].Name)) { index = i; return true; }
            }
            index = 0;
            return false;
        }

        public static List<Materials> removeDupesAndMergeMats(List<Materials> s_Mats, List<Materials> d_Mats)
        {
            bool nestedFound = false;
            for (int i = 0; i < d_Mats.Count; i++)
            {
                if (!s_Mats.Contains(d_Mats[i]))
                {
                    for (int j = 0; j < s_Mats.Count; j++)
                    {
                        if (s_Mats[j].Name.Equals(d_Mats[i].Name)) { nestedFound = true; }
                    }
                    if (!nestedFound) { s_Mats.Add(d_Mats[i]); } else { nestedFound = false; }
                }
            }
            return s_Mats;
        }



        /// <summary>
        /// Takes the Vertices of the static verts to be appended to
        /// Moves them by the amount necessary to get the specified faces (by Material name)
        /// to match</summary>
        /// <param name="staticVertices">The vertices of the object to be appended to</param>
        /// <param name="staticFaces">The Faces of the object to be appended to</param>
        /// <param name="dynamicVertices">The Vertices of the object that is being appended from</param>
        /// <param name="dynamicFaces">The Faces of the object that is being appended from</param>
        /// <param name="matName">The name of the material we are using to find the quad to append</param>
        /// <param name="s_materials">The list of Materials of the object to be appended to</param>
        /// <param name="d_materials">The list of Materials of the object we are appending from</param>
        /// <param name="expectedFaces">The number of faces we are expecting. If _both_ don't have the same number of verts it will fail</param>
        /// <param name="listOut">Where we want to put the translated vertices, EMPTY if operation FAILED</param>
        /// <returns>true if operation failed, false otherwise. if false, accompanied by an alertbox describing the problem</returns>
        public static bool translateVertices(List<Vertice> staticVertices, List<Face> staticFaces,
                                                        List<Vertice> dynamicVertices, List<Face> dynamicFaces, string matName,
                                                        List<Materials> s_materials, List<Materials> d_materials, int expectedFaces,
                                                                   out List<Vertice> listOut)
        {
            TranslationXYZ s_centerPoint = new TranslationXYZ();
            TranslationXYZ d_centerPoint = new TranslationXYZ();
            List<Vertice> translatedVerts = new List<Vertice>();
            List<Face> s_tempFaces = new List<Face>();
            List<Face> d_tempFaces = new List<Face>();

            if (!getFacesByMaterialName(staticFaces, s_materials, matName, out s_tempFaces)) { alertbox("The object you're adding to has no faces that fit!"); listOut = new List<Vertice>(); return false; }
            if (!getFacesByMaterialName(dynamicFaces, d_materials, matName, out d_tempFaces)) { alertbox("The object being added didn't have any faces that fit!"); listOut = new List<Vertice>(); return false; }

            if (s_tempFaces.Count > expectedFaces)
            { alertbox(String.Format("The static face count is more than {0}, the num we were expecting - there were {1} faces!", expectedFaces, s_tempFaces.Count)); listOut = new List<Vertice>(); return false; }
            if (d_tempFaces.Count > expectedFaces)
            { alertbox(String.Format("The dynamic face count is more than {0}, the number of faces we were expecting - there were {1} faces!", expectedFaces, d_tempFaces.Count)); listOut = new List<Vertice>(); return false; }
            d_centerPoint = getCenterPoint(d_tempFaces[0], d_tempFaces[1], dynamicVertices);
            s_centerPoint = getCenterPoint(s_tempFaces[0], s_tempFaces[1], staticVertices);

            TranslationXYZ translation = subTranslations(d_centerPoint, s_centerPoint);
            //translation = d_centerPoint.Add(translation);

            List<Vertice> floop = dynamicVertices;
            for (int i = 0; i < floop.Count; i++)
            {
                Vertice superTFace = new Vertice();
                superTFace = floop[i];
                superTFace.Position = addTranslations(translation, superTFace.Position);
                floop[i] = superTFace;
            }

            listOut = floop;
            return true;
        }

        public static TranslationXYZ addTranslations(TranslationXYZ toAdd, TranslationXYZ addTo)
        {
            addTo.X += toAdd.X;
            addTo.Y += toAdd.Y;
            addTo.Z += toAdd.Z;
            return addTo;
        }

        public static TranslationXYZ subTranslations(TranslationXYZ toSub, TranslationXYZ subFrom)
        {
            subFrom.X -= toSub.X;
            subFrom.Y -= toSub.Y;
            subFrom.Z -= toSub.Z;
            return subFrom;
        }

        public static bool getFacesByMaterialName(List<Face> myFaces, List<Materials> myMaterials, string matName, out List<Face> outFaces)
        {
            List<Face> tempFaces = new List<Face>();
            for (int i = 0; i < myFaces.Count; i++)
            {
                if (myMaterials[myFaces[i].Face_Shader_Index].Name.Equals(matName)) { tempFaces.Add(myFaces[i]); }
            }

            outFaces = tempFaces;
            return true;
        }

        /// <summary>
        /// Pass the faces and the verts that need to be moved to fit one with another. 
        /// </summary>
        /// <param name="f_staticJMS"></param>
        /// <param name="v_staticJMS"></param>
        /// <param name="v_dynamicJMS"></param>
        /// <param name="f_dynamicJMS"></param>
        /// <returns></returns>
        public static TranslationXYZ getVertsToMatchByPlanes(List<Face> f_staticJMS, List<Face> f_dynamicJMS, List<Vertice> v_staticJMS, List<Vertice> v_dynamicJMS)
        {
            if (v_staticJMS.Count < 6) { alertbox("Did not pass enough verts to move!(6) staticJMS"); TranslationXYZ x = new TranslationXYZ(); return x; }
            if (v_dynamicJMS.Count < 6) { alertbox("Did not pass enough verts to move!(6) dynamicJMS"); TranslationXYZ x = new TranslationXYZ(); return x; }
            if (f_dynamicJMS.Count < 2) { alertbox("Did not pass enough faces to move!(2) f_dynamicJMS"); TranslationXYZ x = new TranslationXYZ(); return x; }
            if (f_staticJMS.Count < 2) { alertbox("Did not pass enough faces to move!(2) f_staticJMS"); TranslationXYZ x = new TranslationXYZ(); return x; }

            TranslationXYZ centerPointStatic = getCenterPoint(f_staticJMS[0], f_staticJMS[1], v_staticJMS);
            TranslationXYZ centerPointDynamic = getCenterPoint(f_dynamicJMS[0], f_dynamicJMS[1], v_dynamicJMS);

            // translation = centerPointDynamic.Add(translation);
            return centerPointStatic.Subtract(centerPointDynamic);
        }

        /// <summary>
        /// Pass the vertices that you need to move
        /// </summary>
        /// <param name="staticVert">The static Vertex</param>
        /// <param name="vertMove">The vertex to move</param>
        /// <returns>Returns the amount of translation to move one vert to another.</returns>
        public static TranslationXYZ getTranslationNeeded(Vertice staticVert, Vertice vertMove)
        {
            TranslationXYZ translation = new TranslationXYZ();
            translation.X = staticVert.Position.X - vertMove.Position.X;
            translation.Y = staticVert.Position.Y - vertMove.Position.Y;
            translation.Z = staticVert.Position.Z - vertMove.Position.Z;
            return translation;
        }

        public static bool uniqueVertByPosition(List<Vertice> myVerts, Vertice myVert)
        {
            int count = 0;
            for (int j = 0; j < myVerts.Count; j++)
            {
                if ((myVert.Position.Compare(myVerts[j].Position)) && (myVert.Normal.Compare(myVerts[j].Normal)))
                    count++;
            }
            if (count > 2)
                return false;
            else if (count == 1)
                return true;
            return false;
        }
        /// <summary>
        /// Gets a list of vertices from the given faces
        /// </summary>
        /// <param name="myFaces">The list of faces</param>
        /// <param name="myVerts">The list of vertices</param>
        /// <remarks>Faces and myVerts need to be from the same _jms or it may exception</remarks>
        public static List<Vertice> getVerticesFromFaceList(List<Face> myFaces, List<Vertice> myVerts)
        {
            List<Vertice> vertices = new List<Vertice>();

            for (int i = 0; i < myFaces.Count; i++)
            {
                for (int j = 0; j < myFaces[i].vertRefs.Count; j++)
                {
                    vertices.Add(myVerts[myFaces[i].vertRefs[j]]);
                }
            }
            return vertices;

        }

        /// <summary>
        /// Gets the center point of a 2-face Quadrilateral.
        /// </summary>
        /// <param name="firstFace"> Needs to be first face in order in the list of faces</param>
        /// <param name="secondFace">Needs to be the second face in order of the list of faces</param>
        /// <returns>Returns a vector3 indicating the position of the center point of the faces passed</returns>
        /// <remarks>Don't call unless the two faces make up a rectangle.</remarks>
        public static TranslationXYZ getCenterPoint(Face firstFace, Face secondFace, List<Vertice> myVerts)
        {
            List<Vertice> vertices = new List<Vertice>();
            for (int i = 0; i < 3; i++)
            {
                vertices.Add(myVerts[firstFace.vertRefs[i]]);
            }

            for (int i = 0; i < 3; i++)
            {
                vertices.Add(myVerts[secondFace.vertRefs[i]]);
            }
            return getHighLoMiddle(vertices).Position;
        }

        /// <summary>
        /// Gets the middle VERTEX
        /// </summary>
        /// <remarks>Technically it *should* work with > 2 vertices in the list, but not meant for that.</remarks>
        /// <returns>Returns a Vertex that contains the center points- keeps the same properties as the first vertice in the list</returns>
        public static Vertice getHighLoMiddle(List<Vertice> vertices)
        {
            //they should all be on the same axis, nothing in between
            float highestXValue = getHighestXPosition(vertices);
            float highestYValue = getHighestYPosition(vertices);
            float highestZValue = getHighestZPosition(vertices);
            float lowestXValue = getLowestXPosition(vertices); //returns zero no matter what
            float lowestYValue = getLowestYPosition(vertices);
            float lowestZValue = getLowestZPosition(vertices);
            TranslationXYZ txyz = new TranslationXYZ();

            Vertice myVertice = new Vertice(); // Not assigned
            txyz.X = highestXValue - lowestXValue;
            txyz.Y = highestYValue - lowestYValue;
            txyz.Z = highestZValue - lowestZValue;
            myVertice.Position = txyz;

            txyz.X = lowestXValue + (myVertice.Position.X / 2);
            txyz.Y = lowestYValue + (myVertice.Position.Y / 2);
            txyz.Z = lowestZValue + (myVertice.Position.Z / 2);
            myVertice.Position = txyz;
            myVertice.Normal = vertices[0].Normal;
            myVertice.node_one_index = vertices[0].node_one_index;
            myVertice.node_one_weight = vertices[0].node_one_weight;
            myVertice.node_zero_index = vertices[0].node_zero_index;
            //   myVert.tvert_PositionX = vertices[0].tvert_PositionX;
            //   myVert.tvert_PositionY = vertices[0].tvert_PositionY;
            return myVertice;
            // Matrix myMatrix = new Matrix();
        }

        #region Get Extremes
        public static float getHighestXPosition(List<Vertice> vertices)
        {
            float lgValue = vertices[0].Position.X;
            for (int i = 0; i < vertices.Count; i++)
            {
                if (lgValue < vertices[i].Position.X)
                    lgValue = vertices[i].Position.X;
            }
            return lgValue;
        }
        public static float getHighestYPosition(List<Vertice> vertices)
        {
            float lgValue = vertices[0].Position.Y;
            for (int i = 0; i < vertices.Count; i++)
            {
                if (lgValue < vertices[i].Position.Y)
                    lgValue = vertices[i].Position.Y;
            }
            return lgValue;
        }
        public static float getHighestZPosition(List<Vertice> vertices)
        {
            float lgValue = vertices[0].Position.Z;
            for (int i = 0; i < vertices.Count; i++)
            {
                if (lgValue < vertices[i].Position.Z)
                    lgValue = vertices[i].Position.Z;
            }
            return lgValue;
        }
        public static float getLowestXPosition(List<Vertice> vertices)
        {
            float loValue = vertices[0].Position.X;
            for (int i = 0; i < vertices.Count; i++)
            {
                if (loValue > vertices[i].Position.X)
                    loValue = vertices[i].Position.X;
            }
            return loValue;
        }
        public static float getLowestYPosition(List<Vertice> vertices)
        {
            float loValue = vertices[0].Position.Y;
            for (int i = 0; i < vertices.Count; i++)
            {
                if (loValue > vertices[i].Position.Y)
                    loValue = vertices[i].Position.Y;
            }
            return loValue;
        }
        public static float getLowestZPosition(List<Vertice> vertices)
        {
            float loValue = vertices[0].Position.Z;
            for (int i = 0; i < vertices.Count; i++)
            {
                if (loValue > vertices[i].Position.Z)
                    loValue = vertices[i].Position.Z;
            }

            return loValue;
        }



        /// <summary>
        /// Gets the extreme X, Y, Z values and puts them into a vert for lo and one for high
        /// </summary>
        /// <remarks></remarks>
        public static List<Vertice> getExtremeVertValues(List<Vertice> vertices)
        {
            //Get the Verts that have the highest Z position- there should be 8, minimum.
            float hiX = getHighestXPosition(vertices);
            float hiY = getHighestYPosition(vertices);
            float hiZ = getHighestZPosition(vertices);

            Vertice hiVert = new Vertice();
            TranslationXYZ hiXYZ = new TranslationXYZ();
            hiXYZ.X = hiX;
            hiXYZ.Y = hiY;
            hiXYZ.Z = hiZ;
            hiVert.Position = hiXYZ;

            float loX = getLowestXPosition(vertices);
            float loY = getLowestYPosition(vertices);
            float loZ = getLowestZPosition(vertices);

            Vertice loVert = new Vertice();
            TranslationXYZ loXYZ = new TranslationXYZ();
            loXYZ.X = loX;
            loXYZ.Y = loY;
            loXYZ.Z = loZ;
            loVert.Position = loXYZ;

            vertices.Clear();
            vertices.Add(hiVert);
            vertices.Add(loVert);
            return vertices;
        }
        #endregion

        /// <summary>
        /// Takes a list of vertices and calculates the area as though it were a rectangle
        /// </summary>
        /// <remarks>returns total area</remarks>
        public static float getTotalArea(List<Vertice> vertices)
        {
            vertices = getExtremeVertValues(vertices);
            //Should never have more than 2. If it does then someone modified getExtremeVertValues
            float width = vertices[0].Position.X - vertices[1].Position.X;
            float depth = vertices[0].Position.Y - vertices[1].Position.Y;
            float height = vertices[0].Position.Z - vertices[1].Position.Z;
            float totalArea = width * depth * height;
            return totalArea;
        }
    }

    #region Structures
    //Structure
    /// <summary>
    /// The XYZW Rotation Orientation.
    /// </summary>
    /// <remarks></remarks>
    public struct RotatationXYZW
    {
        public float X { get; set; }
        public float Y { get; set; }
        public float Z { get; set; }
        public float W { get; set; }
    }

    /// <summary>
    /// The XYZ Location Structure.
    /// </summary>
    /// <remarks></remarks>
    public struct TranslationXYZ
    {
        public float X { get; set; }
        public float Y { get; set; }
        public float Z { get; set; }
        /// <summary>
        /// Converts to the DX form Vector3
        /// </summary>
        /// <returns>Returns the TXYZ as a Vector3</returns>
        /// <remarks>Casts x, y, z as float. Possible data loss</remarks>
        public Vector3 toVector3()
        {
            Vector3 myVect3 = new Vector3();
            myVect3.X = (float)this.X;
            myVect3.Y = (float)this.Y;
            myVect3.Z = (float)this.Z;
            return myVect3;
        }

        public void addToThis(TranslationXYZ toAdd)
        {
            this.X += toAdd.X;
            this.Y += toAdd.Y;
            this.Z += toAdd.Z;
        }

        /// <summary>
        /// Adds this TXYZ by toAdd
        /// </summary>
        /// <param name="toAdd">The TXYZ to add this to</param>
        /// <returns>Returns these two added together</returns>
        public TranslationXYZ Add(TranslationXYZ toAdd)
        {
            TranslationXYZ tempXYZ = new TranslationXYZ();
            tempXYZ.X = this.X + toAdd.X;
            tempXYZ.Y = this.Y + toAdd.Y;
            tempXYZ.Z = this.Z + toAdd.Z;
            return tempXYZ;
        }

        /// <summary>
        /// Subtracts this TXYZ by toSubtract
        /// </summary>
        /// <param name="toSubtract">The TXYZ to subtract this by</param>
        /// <returns>Returns this minus toSubtract</returns>
        public TranslationXYZ Subtract(TranslationXYZ toSubtract)
        {
            TranslationXYZ tempXYZ = new TranslationXYZ();
            tempXYZ.X = this.X - toSubtract.X;
            tempXYZ.Y = this.Y - toSubtract.Y;
            tempXYZ.Z = this.X - toSubtract.Z;
            return tempXYZ;

        }

        /// <summary>
        /// Returns true if the two TranslationXYZ are the same
        /// </summary>
        /// <param name="compareTo"></param>
        /// <returns></returns>
        public bool Compare(TranslationXYZ compareTo)
        {
            if ((this.X == compareTo.X) && (this.Y == compareTo.Y) && (this.Z == compareTo.Z))
            {
                return true;
            }
            else
                return false;
        }
        /// <summary>
        /// Inverts the properties of the this TranslationXYZ
        /// </summary>
        /// <returns>Returns the inverted properties</returns>
        public TranslationXYZ invertProperties()
        {
            TranslationXYZ myInversion = new TranslationXYZ();
            myInversion.X = this.X * -1;
            myInversion.Y = this.Y * -1;
            myInversion.Z = this.Z * -1;
            return myInversion;
        }
    }

    /// <summary>
    /// The XYZ Rotation Orientation.
    /// </summary>
    /// <remarks></remarks>
    public struct RotationXYZ
    {
        public float X { get; set; }
        public float Y { get; set; }
        public float Z { get; set; }
        public Vector3 toVector3()
        {
            Vector3 myVect3 = new Vector3();
            myVect3.X = (float)this.X;
            myVect3.Y = (float)this.Y;
            myVect3.Z = (float)this.Z;
            return myVect3;
        }
    }

    /// <summary>
    /// The Region Structure
    /// </summary>
    /// <remarks></remarks>
    public struct Region
    {
        public string Name { get; set; }
    }

    /// <summary>
    /// Used explicitly to make the optimized vert structure
    ///     Where vertRef is the first encounter of the vert
    ///     and the List is any other vert that occurs after that one.
    /// </summary>
    public class optiVerts
    {
        public int vertRef { get; set; }
        public List<UInt16> verts { get; set; }

        public optiVerts()
        {
            this.vertRef = new int();
            this.verts = new List<UInt16>();
        }

        public optiVerts(int vRef, List<UInt16> vs)
        {
            this.vertRef = vRef;
            this.verts = vs;
        }
    }

    /// <summary>
    /// Vertice Struture
    /// </summary>
    /// <remarks></remarks>
    public struct Vertice
    {
        public int node_zero_index { get; set; }
        public TranslationXYZ Position { get; set; }
        public TranslationXYZ Normal { get; set; }
        public int node_one_index { get; set; }
        public int node_one_weight { get; set; }
        public float tvert_PositionX { get; set; }
        public float tvert_PositionY { get; set; }

        /// <summary>
        /// Returns the Vertex in CustomVertex.PositionNormal form
        /// </summary>
        /// <remarks>Casts decimals as floats, doesn't keep node or tvert data</remarks>
        public CustomVertex.PositionNormal vertToCVertPN()
        {
            CustomVertex.PositionNormal myCVPN = new CustomVertex.PositionNormal();
            myCVPN.Position = this.Position.toVector3();
            myCVPN.Normal = this.Normal.toVector3();
            return myCVPN;
        }

        public bool Equals(Vertice vv) {
            if (this.node_one_index == vv.node_one_index) {
                if (this.node_one_weight == vv.node_one_weight) {
                    if (this.node_zero_index == vv.node_zero_index) {
                        if (this.Normal.Compare(vv.Normal)) {
                            if (this.Position.Compare(vv.Position)) {
                                if (this.tvert_PositionX == vv.tvert_PositionX) {
                                    if (this.tvert_PositionY == vv.tvert_PositionY) {
                                        return true;
                                    }
                                }
                            }
                        }
                    }
                }
            }
            return false;
        }

        public static Int32 FindIndex(List<Vertice> vL, Vertice v) 
        {
            for (Int32 i = 0; i < vL.Count; i++)
            {
                if (v.Equals(vL[i]))
                {
                    return i;
                }
            }
            return -1;
        }
    }

    /// <summary>
    /// Marker Structure
    /// </summary>
    /// <remarks></remarks>
    public struct Marker
    {
        public string Name { get; set; }
        public int Unknown_Value_One { get; set; }
        public int parent_index { get; set; }
        public RotatationXYZW Rotation { get; set; }
        public TranslationXYZ Translation { get; set; }
        public float Unknown_Value_Two { get; set; }
    }

    /// <summary>
    /// Face Structure
    /// </summary>
    /// <remarks></remarks>
    public class Face
    {
        public int Face_Region_Index { get; set; }
        public int Face_Shader_Index { get; set; }
        public List<UInt16> vertRefs { get; set; }

        public Face() { 
            this.Face_Region_Index = new int();
            this.Face_Shader_Index = new int();
            this.vertRefs = new List<UInt16>(3);
        }

        public Face(int fr, int fs, List<UInt16> lu)
        {
            this.Face_Region_Index = fr;
            this.Face_Shader_Index = fs;
            this.vertRefs = lu;  // look at your arguments.
            this.vertRefs.Capacity = 3;
        }

        public static List<UInt16> getStraightVertIndexList (List<Face> f) {
            List<UInt16> vertIndices = new List<UInt16>(f.Count * 3);
            for (int i = 0; i < f.Count; i++)
            {
                vertIndices.AddRange(f[i].vertRefs);
            }
            return vertIndices;
        }
    }

    /// <summary>
    /// Stores the specific node data.
    /// </summary>
    /// <remarks></remarks>
    public struct Node
    {
        public string Name { get; set; }
        public int child_index { get; set; }
        public int next_sibling_index { get; set; }
        public RotatationXYZW Rotation { get; set; }
        public TranslationXYZ Translation { get; set; }
    }
    /// <summary>
    /// Stores the specified material information.
    /// </summary>
    /// <remarks></remarks>
    public struct Materials
    {
        public string Name { get; set; }
        public string Path { get; set; }
    }
    #endregion



}